Imports MySql.Data.MySqlClient

Public Class frmComplaint_View

#Region "Functions"

    Private Function GetPicID() As Boolean

        'CheckConnection(cn)
        'Dim cmd As New MySqlCommand(Sql, cn)
        'Dim r As MySqlDataReader = cmd.ExecuteReader

        'r.Read()
        'If r.HasRows = True Then
        '    printComplaintEntry(r("Department_ID"),
        '                    r("ID"),
        '                    r("Priority"),
        '                    r("NatureOfComplaint"),
        '                    r("Type"),
        '                    r("Name"),
        '                    r("Address"),
        '                    r("ContactNo"),
        '                    r("EmailAddress"),
        '                    r("AccountNo"),
        '                     r("AccountName"),
        '                    r("MeterNo"),
        '                    r("ActionDesired"),
        '                    frmMain.lblEmployeeName.Text,
        '                    EmployeePos, CDate(r("DateReceipt").ToString), strFU, strFUDate)
        'End If

    End Function

    Private Function GetFollowUpDate(ByVal SR As String) As String

        CheckConnection(cn)
        Dim cmd As New MySqlCommand("SELECT * FROM tblFollowUp WHERE SRNo='" & SR & "' ORDER BY FUDate DESC LIMIT 1", cn)
        Dim r As MySqlDataReader = cmd.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            GetFollowUpDate = r("FUDate")
        Else
            GetFollowUpDate = ""
        End If

        r.Close()

        Return GetFollowUpDate

    End Function

    Private Function GetNoOfUpdates(ByVal SR As String) As String

        ds.Clear()

        da.SelectCommand = New MySqlCommand("SELECT * FROM tblFollowUp WHERE SRNo='" & SR & "'", cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            GetNoOfUpdates = CInt(ds.Tables(0).Rows.Count)
        Else
            GetNoOfUpdates = 0
        End If

        Return GetNoOfUpdates

    End Function

    Private Sub PrintComplaint(ByVal ID As String)
        Dim strFU As String
        Dim strFUDate As String

        strFU = GetNoOfUpdates(Me.lstvwComplaints.SelectedItems(0).Text)
        strFUDate = GetFollowUpDate(Me.lstvwComplaints.SelectedItems(0).Text)

        Dim EmployeePos As String

        EmployeePos = getEmployeePos(frmMain.lblEmployeeName.Text)

        Dim SQL As String
        SQL = "SELECT * FROM tblComplaints WHERE ID='" & ID & "'"

        frmComplaint_Entry.LoadDepartment()
        frmComplaint_Entry.LoadNatureOfComplaint()

        CheckConnection(cn)
        Dim cmd As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmd.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            printComplaintEntry(r("Department_ID"),
                            r("ID"),
                            r("Priority"),
                            r("NatureOfComplaint"),
                            r("Type"),
                            r("Name"),
                            r("Address"),
                            r("ContactNo"),
                            r("EmailAddress"),
                            r("AccountNo"),
                             r("AccountName"),
                            r("MeterNo"),
                            r("ActionDesired"),
                            frmMain.lblEmployeeName.Text,
                            EmployeePos, CDate(r("DateReceipt").ToString), strFU, strFUDate)
        End If

        r.Close()

    End Sub

    Private Sub LoadComplaintInfo(ByVal ID As Integer)

        Dim SQL As String
        SQL = "SELECT * FROM tblComplaints WHERE ID='" & ID & "'"

        frmComplaint_Entry.LoadDepartment()
        frmComplaint_Entry.LoadNatureOfComplaint()
        frmComplaint_Entry.LoadComplaintType()
        frmComplaint_Entry.LoadActionDesired()

        CheckConnection(cn)
        Dim cmd As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmd.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            With frmComplaint_Entry

                .dtpReceipt.Value = CDate(r("DateReceipt").ToString)
                .dtpTime.Value = CDate(r("DateReceipt").ToString) '.ToString("HH:mm:ss")
                .txtAccount.Text = r("AccountNo")
                .txtAccountName.Text = r("AccountName")
                .txtMeter.Text = r("MeterNo")
                .txtServiceNo.Text = r("ID")
                .txtName.Text = r("Name")
                .txtAddress.Text = r("Address")
                .cmbxSendTo.Text = r("Department_ID")
                .txtContactNo.Text = r("ContactNo")
                .cmbxPriority.Text = r("Priority")
                .cmbxNatureOfComplaint.Text = r("NatureOfComplaint")
                .txtEmail.Text = r("EmailAddress")
                .cmbxAction_Desired.Text = r("ActionDesired")
                .cmbxComplaintType.Text = r("Type")

            End With
        End If

        r.Close()

    End Sub

#Region "Load List"

    Public Sub LoadDataGrid()

        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")

        If Trim(Me.txtSearch.Text.Length) > 0 Then
            FillComplaints("SELECT * FROM tblComplaints WHERE " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        End If

    End Sub

#End Region

#Region "Fill List"

    Private Sub FillComplaints(ByVal Sqlstring As String)

        Dim tmpDateTime As Date
        Me.lstvwComplaints.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwComplaints.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Priority".ToString)) '1
                    .SubItems.Add(dr("Department_ID".ToString)) '2
                    .SubItems.Add(dr("Name".ToString)) '3
                    .SubItems.Add(dr("Address".ToString)) '4
                    .SubItems.Add(dr("ContactNo".ToString)) '5
                    .SubItems.Add(dr("NatureOfComplaint".ToString)) '6
                    tmpDateTime = CDate(dr("DateReceipt").ToString)
                    .SubItems.Add(tmpDateTime.ToString("yyyy-MM-dd HH:mm:ss")) '7
                    .SubItems.Add(dr("ReceivedBy".ToString)) '8
                    .SubItems.Add(dr("Type".ToString)) '9
                    '.SubItems.Add(dr("FollowUp".ToString)) '10
                End With
            Next
            Me.lblTotalRecords.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
            Call listvwColorChange(Me.lstvwComplaints)
        End If
    End Sub

#End Region

#End Region

    Private Sub frmComplaint_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        Me.cmbxFilter.Text = "SR#"
        LoadDataGrid()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmComplaint_Entry
            .grpbxFollowUp.Enabled = False
            .Text = "Add New Entry"
            .btnEntry.Text = "Save"
            .LoadDepartment()
            .LoadNatureOfComplaint()
            .LoadComplaintType()
            .LoadActionDesired()
            .cmbxPriority.Text = "<select>"
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmComplaint_Entry
            .ID = Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text
            .Text = "Edit Entry"
            .btnEntry.Text = "Update"
            LoadComplaintInfo(Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text)
            .ShowDialog()
        End With
    End Sub

    Private Sub CMSComplaint_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSComplaint.Opening
        If Me.lstvwComplaints.SelectedItems.Count > 0 Then
            Me.LocationToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
            Me.EditToolStripMenuItem.Enabled = True
            Me.PrintToolStripMenuItem.Enabled = True
            Me.FollowUpToolStripMenuItem.Enabled = True
        Else
            Me.LocationToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
            Me.EditToolStripMenuItem.Enabled = False
            Me.PrintToolStripMenuItem.Enabled = False
            Me.FollowUpToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If CInt(frmMain.lblUserLevel.Text) <> 1 Then
            MessageBox.Show("Only Administrator can delete a complain entry, please contact the Administrator.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("Are you sure you want to delete service #" & Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                StrSelect = "DELETE FROM tblComplaints WHERE ID= '" & Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text & "'"

                CheckConnection(cn)

                Dim cmd As New MySqlCommand(StrSelect, cn)

                cmd.ExecuteNonQuery()
                MsgBox(Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text & " has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

                Me.LoadDataGrid()

            End If
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadDataGrid()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadDataGrid()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Call PrintComplaint(Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text)
    End Sub

    Private Sub FollowUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FollowUpToolStripMenuItem.Click
           With frmFollowUp_Entry
            .btnEntry.Text = "&Save"
            .lblSR.Text = Me.lstvwComplaints.SelectedItems(0).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub ViewLocationDrawingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewLocationDrawingToolStripMenuItem.Click

        Dim SQL As String
        SQL = "SELECT * FROM tblComplaints WHERE ID='" & Me.lstvwComplaints.SelectedItems(0).Text & "'"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim objReader As MySqlDataReader = cmdSearch.ExecuteReader

        objReader.Read()
        If objReader.HasRows = True Then
            'Load image
            If IsDBNull(objReader("Pic")) = False Then
                Dim arrayImage() As Byte = CType(objReader("Pic"), Byte())
                Dim ms As New IO.MemoryStream(arrayImage)
                'On Error Resume Next
                frmShowDrawing.picCanvas.Image = Image.FromStream(ms)
                frmShowDrawing.Text = "(" & objReader("ID") & ")-" & objReader("Name")
                frmShowDrawing.ShowDialog()
            Else
                MsgBox("No available image.", MsgBoxStyle.Information, "Site drawing")
            End If
        End If

        'close the reader
        objReader.Close()

    End Sub

    Private Sub AddLocationDrawingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLocationDrawingToolStripMenuItem.Click

        With frmDrawing
            .ID = Me.lstvwComplaints.SelectedItems(0).Text
            .ShowDialog()
        End With
    End Sub

End Class