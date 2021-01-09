Imports MySql.Data.MySqlClient

Public Class frmEmployee_View

#Region "Functions"

#Region "Load List"

    Public Sub LoadData()
        FillEmployee("SELECT * FROM tblEmployee")
    End Sub

#End Region

#Region "Fill List"

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Me.lstvwEmployee.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwEmployee.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Employee_Name".ToString)) '1
                    .SubItems.Add(dr("Position".ToString)) '2
                    .SubItems.Add(dr("Department".ToString)) '3
                    .SubItems.Add(dr("ListingCode".ToString)) '4
                End With
            Next
        End If
    End Sub

#End Region

#End Region

    Private Sub frmEmployee_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        LoadData()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete employee " & Me.lstvwEmployee.SelectedItems(0).SubItems(1).Text & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblEmployee WHERE ID= '" & Me.lstvwEmployee.SelectedItems(0).SubItems(0).Text & "'"

            CheckConnection(cn)

            Dim cmd As New MySqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwEmployee.SelectedItems(0).SubItems(1).Text & " employee has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

            Me.LoadData()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmEmployee_Entry
            .btnEntry.Text = "&Save"
            .cmbxListingCode.Text = "<select>"
            .LoadDepartment()
            .txtEmployeeName.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub CMSEmployee_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSEmployee.Opening
        If Me.lstvwEmployee.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmEmployee_Entry
            .btnEntry.Text = "&Update"
            .ID = Me.lstvwEmployee.SelectedItems(0).Text
            .LoadDepartment()
            .txtEmployeeName.Text = Me.lstvwEmployee.SelectedItems(0).SubItems(1).Text
            .txtPosition.Text = Me.lstvwEmployee.SelectedItems(0).SubItems(2).Text
            .cmbxDepartment.Text = Me.lstvwEmployee.SelectedItems(0).SubItems(3).Text
            .cmbxListingCode.Text = Me.lstvwEmployee.SelectedItems(0).SubItems(4).Text
            .txtEmployeeName.Focus()
            .ShowDialog()
        End With
    End Sub

End Class