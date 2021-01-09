Imports MySql.Data.MySqlClient

Public Class frmDepartment_View

#Region "Functions"

#Region "Load List"

    Public Sub LoadData()
        FillDeprtment("SELECT * FROM tblDepartments")
    End Sub

#End Region

#Region "Fill List"

    Private Sub FillDeprtment(ByVal Sqlstring As String)

        Me.lstvwDepartments.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwDepartments.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Department_ID".ToString)) '1
                    .SubItems.Add(dr("Title".ToString)) '2
                End With
            Next
        End If
    End Sub

#End Region

#End Region

    Private Sub CMSDepartments_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSDepartments.Opening
        If Me.lstvwDepartments.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub frmDepartments_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        LoadData()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmDepartment_Entry
            .Text = "Add New Entry "
            .btnEntry.Text = "Save"
            .ShowDialog()
            .txtDepartment_ID.Focus()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to delete department " & Me.lstvwDepartments.SelectedItems(0).SubItems(1).Text & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblDepartments WHERE ID= '" & Me.lstvwDepartments.SelectedItems(0).SubItems(0).Text & "'"

            CheckConnection(cn)

            Dim cmd As New MySqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwDepartments.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

            Me.LoadData()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmDepartment_Entry
            .Text = "Edit Entry "
            .btnEntry.Text = "Edit"
            .ID = Me.lstvwDepartments.SelectedItems(0).Text
            .GetDepartment(Me.lstvwDepartments.SelectedItems(0).Text)
            .ShowDialog()
            .txtDepartment_ID.Focus()
        End With
    End Sub

End Class