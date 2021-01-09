Imports MySql.Data.MySqlClient

Public Class frmUserAccounts_View

#Region "Functions"

#Region "Load List"

    Public Sub LoadData()
        FillUserAccount("SELECT * FROM tblUserAccount")
    End Sub

#End Region

#Region "Fill List"

    Private Sub FillUserAccount(ByVal Sqlstring As String)

        Me.lstvwUserAccount.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwUserAccount.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Username".ToString)) '1
                    .SubItems.Add(dr("Name".ToString)) '2
                    .SubItems.Add(dr("Designation".ToString)) '3
                    .SubItems.Add(dr("UserLevel".ToString)) '4
                    .SubItems.Add(dr("Password".ToString)) '5
                End With
            Next
        End If
    End Sub

#End Region

#End Region

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmUserAccounts_Entry
            .Text = "Add New Entry "
            .btnEntry.Text = "&Save"
            .LoadDesignation()
            .LoadEmployee()
            .cmbxLevel.Text = "3"
            .ShowDialog()
            .txtUsername.Focus()
        End With
    End Sub

    Private Sub CMSUserAccount_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSUserAccount.Opening
        If Me.lstvwUserAccount.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
            Me.EditToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
            Me.EditToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete User " & Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblUserAccount WHERE ID= '" & Me.lstvwUserAccount.SelectedItems(0).SubItems(0).Text & "'"

            CheckConnection(cn)

            Dim cmd As New MySqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

            Me.LoadData()
        End If
    End Sub

    Private Sub frmUserAccounts_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        Call LoadData()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmUserAccounts_Entry
            .LoadDesignation()
            .LoadEmployee()
            .ID = Me.lstvwUserAccount.SelectedItems(0).Text
            .Text = "Edit Entry "
            .btnEntry.Text = "&Update"
            .txtUsername.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text
            .txtPassword.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(5).Text
            .txtRetypePassword.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(5).Text
            .cmbxEmployeeName.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(2).Text
            .cmbxDesignation.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(3).Text
            .cmbxLevel.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(4).Text
            .ShowDialog()
            .txtUsername.Focus()
        End With
    End Sub

End Class