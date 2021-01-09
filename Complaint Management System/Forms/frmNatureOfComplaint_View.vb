Imports MySql.Data.MySqlClient

Public Class frmNatureOfComplaint_View

#Region "Functions"

#Region "Load List"

    Public Sub LoadData()
        FillNOC("SELECT * FROM tblNatureOfComplaint")
    End Sub

#End Region

#Region "Fill List"

    Private Sub FillNOC(ByVal Sqlstring As String)

        Me.lstvwNOC.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwNOC.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Title".ToString)) '1
                End With
            Next
        End If
    End Sub

#End Region

#End Region

    Private Sub frmNatureOfComplaint_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        LoadData()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to delete NOC " & Me.lstvwNOC.SelectedItems(0).SubItems(1).Text & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblNatureOfComplaint WHERE ID= '" & Me.lstvwNOC.SelectedItems(0).SubItems(0).Text & "'"

            CheckConnection(cn)

            Dim cmd As New MySqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwNOC.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

            Me.LoadData()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.LoadData()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmNatureOfComplaint_Entry
            .Text = "Add New Nature of Complaint"
            .btnEntry.Text = "Save"
            .ShowDialog()
            .txtTitle.Focus()
        End With
    End Sub

    Private Sub CMSNOC_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSNOC.Opening
        If Me.lstvwNOC.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

End Class