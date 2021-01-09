Imports MySql.Data.MySqlClient

Public Class frmComplaintAction

    Friend Area As String

#Region "Functions"

    Private Sub LoadComplaintInfo(ByVal ID As Integer)

        Dim SQL As String
        SQL = "SELECT * FROM tblComplaints WHERE ID='" & ID & "'"

        frmComplaint_Entry.LoadDepartment()
        frmComplaint_Entry.LoadNatureOfComplaint()

        CheckConnection(cn)
        Dim cmd As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmd.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            With frmComplaintAction_Entry
                '.dtpReceipt.Value = CDate(r("DateReceipt").ToString)
                '.txtTime.Text = CDate(r("DateReceipt").ToString).ToString("HH:mm:ss")
                '.txtAccount.Text = r("AccountNo")
                '.txtMeter.Text = r("MeterNo")
                '.txtServiceNo.Text = r("ID")
                '.txtName.Text = r("Name")
                '.txtAddress.Text = r("Address")
                '.cmbxSendTo.Text = r("Department_ID")
                '.txtContactNo.Text = r("ContactNo")
                '.cmbxPriority.Text = r("Priority")
                '.cmbxNatureOfComplaint.Text = r("NatureOfComplaint")
                ''.dtpReceipt.Value = CDate(strData)
                '.txtAction_Desired.Text = r("ActionDesired")
            End With
        End If

        r.Close()

    End Sub

#Region "Load List"

    Public Sub LoadData()

        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")

        'If Me.cmbxEmployee.Text = "<select>" Then
        'FillComplaints("SELECT * FROM tblComplaints WHERE ID LIKE '" & Me.txtSearch.Text & "%' OR Priority LIKE '" & Me.txtSearch.Text & "%' OR Name LIKE '" & Me.txtSearch.Text & "%' OR NatureOfComplaint LIKE '" & Me.txtSearch.Text & "%' OR ReceivedBy LIKe '" & Me.txtSearch.Text & "%' OR Type LIKE '" & Me.txtSearch.Text & "%' AND ActionTakenBy<>'' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        'Else
        'FillComplaints("SELECT * FROM tblComplaints WHERE ID LIKE '" & Me.txtSearch.Text & "%' AND Department_ID='" & Area & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        FillComplaints("SELECT * FROM tblComplaints WHERE ID LIKE '" & Me.txtSearch.Text & "%' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        'End If

    End Sub

#End Region

#Region "Fill List"

    Private Sub FillComplaints(ByVal Sqlstring As String)
        Dim ActionTakenBy As String
        Dim ActionTaken As String
        Dim tmpDateTime As Date
        Dim DateActionTaken As String
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
                    .SubItems.Add(dr("ActionTakenBy".ToString)) '1
                    .SubItems.Add(dr("Priority".ToString)) '2
                    .SubItems.Add(dr("Department_ID".ToString)) '3
                    .SubItems.Add(dr("Name".ToString)) '4
                    .SubItems.Add(dr("NatureOfComplaint".ToString)) '5
                    tmpDateTime = CDate(dr("DateReceipt").ToString)
                    .SubItems.Add(tmpDateTime.ToString("yyyy-MM-dd HH:mm:ss")) '6
                    .SubItems.Add(dr("ReceivedBy".ToString)) '7
                    .SubItems.Add(dr("Type".ToString)) '8
                    ActionTakenBy = dr("ActionTakenBy".ToString)
                    ActionTaken = dr("ActionTaken".ToString)
                    If Trim(ActionTakenBy).Length = 0 And Trim(ActionTaken).Length = 0 Then
                        .SubItems.Add("") '9
                        .BackColor = Color.LightYellow
                    ElseIf Trim(ActionTakenBy).Length <> 0 AndAlso (Trim(ActionTaken).Length = 0 Or ActionTaken = "<select>") Then
                        If ActionTaken = "<select>" Then
                            .SubItems.Add("<select>") '9
                        Else
                            .SubItems.Add("") '9
                        End If
                        .BackColor = Color.LightBlue
                    Else
                        .SubItems.Add(dr("ActionTaken".ToString)) '11
                        .BackColor = Color.OrangeRed
                    End If
                    If IsDBNull(dr("DateActionTaken".ToString)) = False Then
                        DateActionTaken = dr("DateActionTaken").ToString
                        .SubItems.Add(DateActionTaken) '10
                    Else
                        .SubItems.Add("----") '10
                    End If

                End With
            Next
        End If
    End Sub

#End Region

#End Region

    Private Sub frmCompliantAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        Area = frmMain.lblArea.Text
        LoadData()
    End Sub

    Private Sub ActionTakenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTakenToolStripMenuItem.Click
        With frmComplaintAction_Entry
            .LoadDispatchTo()
            .LoadActionTaken()
            .txtSRNo.Text = Me.lstvwComplaints.SelectedItems(0).SubItems(0).Text
            .lblName.Text = Me.lstvwComplaints.SelectedItems(0).SubItems(4).Text
            .lblNatureOfComplaint.Text = Me.lstvwComplaints.SelectedItems(0).SubItems(5).Text
            .lblDatetimeReceipt.Text = Me.lstvwComplaints.SelectedItems(0).SubItems(6).Text
            .cmbxActionTaken.Text = Me.lstvwComplaints.SelectedItems(0).SubItems(9).Text
            .cmbxEmployee.Text = Me.lstvwComplaints.SelectedItems(0).SubItems(1).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub CMSComplaint_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSComplaint.Opening
        If Me.lstvwComplaints.SelectedItems.Count > 0 Then
            Me.ActionTakenToolStripMenuItem.Enabled = True
        Else
            Me.ActionTakenToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub cmbxEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

End Class