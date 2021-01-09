Imports MySql.Data.MySqlClient

Public Class frmSubCompDesk

#Region "Functions"

    Private Sub PrintComplaint(ByVal ID As String)

        Dim SQL As String
        SQL = "SELECT * FROM tblComplaints WHERE ID='" & ID & "'"

        CheckConnection(cn)
        Dim cmd As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmd.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            Dim ActionTaken As String
            Dim DateActionTaken As String
            Dim ActionTAkenBy As String
            If IsDBNull(r("ActionTaken")) = True Then
                ActionTaken = ""
            Else
                ActionTaken = r("ActionTaken")
            End If
            If IsDBNull(r("DateActionTaken")) = True Then
                DateActionTaken = ""
            Else
                DateActionTaken = r("DateActionTaken")
            End If
            If IsDBNull(r("ActionTakenBy")) = True Then
                ActionTAkenBy = ""
            Else
                ActionTAkenBy = r("ActionTakenBy")
            End If
            printComplaintReceipt(ID,
                                  r("Name"),
                                  r("Address"),
                                  r("DateReceipt").ToString,
                                  r("NatureOfComplaint"),
                                  ActionTaken,
                                  DateActionTaken,
                                  ActionTAkenBy)
        End If

        r.Close()

    End Sub

#Region "Load List"

    Private Sub LoadAll()
        If Me.tbctrlMain.SelectedIndex = 0 Then
            LoadData_Emergency()
        ElseIf Me.tbctrlMain.SelectedIndex = 1 Then
            LoadData_Survey()
        Else
            LoadData_Request()
        End If
    End Sub

    Public Sub LoadData_Emergency()
        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")

        'FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Area & "' AND Priority='1' ORDER BY DateReceipt", Me.lstvwEmergency)
        'FillComplaints("SELECT * FROM tblComplaints WHERE Priority='1' ORDER BY DateReceipt", Me.lstvwEmergency)
        If Trim(Me.txtSearch.Text.Length) > 0 Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Me.lblArea.Text & "' AND " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'", Me.lstvwEmergency)
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Me.lblArea.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'", Me.lstvwEmergency)
        End If

    End Sub

    Public Sub LoadData_Survey()

        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")

        If Trim(Me.txtSearch.Text.Length) > 0 Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Priority='2' AND Department_ID='" & Me.lblArea.Text & "' AND " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'", Me.lstvwSurvey)
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE Priority='2' AND Department_ID='" & Me.lblArea.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'", Me.lstvwSurvey)
        End If
    End Sub

    Public Sub LoadData_Request()

        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")

        If Trim(Me.txtSearch.Text.Length) > 0 Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Priority='3' AND Department_ID='" & Me.lblArea.Text & "' AND " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'", Me.lstvwRequest)
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE Priority='3' AND Department_ID='" & Me.lblArea.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'", Me.lstvwRequest)
        End If

    End Sub

#End Region

#Region "Fill List"

    Private Sub FillComplaints(ByVal Sqlstring As String, ByVal lstvw As ListView)

        lstvw.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = lstvw.Items.Add(dr("ActionTakenBy"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("ID".ToString)) '1
                    .SubItems.Add(dr("Priority".ToString)) '2
                    .SubItems.Add(dr("Department_ID".ToString)) '3
                    .SubItems.Add(dr("Name".ToString)) '4
                    .SubItems.Add(dr("Address".ToString)) '5
                    .SubItems.Add(dr("ContactNo".ToString)) '6
                    .SubItems.Add(dr("NatureOfComplaint".ToString)) '7
                    .SubItems.Add(dr("DateReceipt".ToString)) '8
                    .SubItems.Add(dr("ReceivedBy".ToString)) '9
                    .SubItems.Add(dr("Type".ToString)) '10
                End With
            Next
            listvwColorChange(Me.lstvwEmergency)
        End If
    End Sub

#End Region

#End Region

    Private Sub tbctrlMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbctrlMain.SelectedIndexChanged
        LoadAll()
    End Sub

    Private Sub frmSubCompDesk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        Me.lblArea.Text = frmMain.lblArea.Text
        Me.cmbxFilter.Text = "SR#"
        LoadAll()
    End Sub

    Private Sub CMSComplaint_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSComplaint.Opening
        Me.DispatchToolStripMenuItem.Enabled = False
        If Me.tbctrlMain.SelectedIndex = 0 Then
            Me.DispatchToolStripMenuItem.Enabled = True
            Me.ActionComplaintReceiptToolStripMenuItem.Enabled = True
        End If

        If Me.lstvwEmergency.SelectedItems.Count > 0 Then
            Me.DispatchToolStripMenuItem.Enabled = True
            Me.ActionComplaintReceiptToolStripMenuItem.Enabled = True
        Else
            Me.DispatchToolStripMenuItem.Enabled = False
            Me.ActionComplaintReceiptToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub DispatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchToolStripMenuItem.Click

        Dim lstvw As ListView

        lstvw = Me.lstvwEmergency

        With frmDispatch
            .lblSRNo.Text = lstvw.SelectedItems(0).SubItems(1).Text
            .lblPriority.Text = lstvw.SelectedItems(0).SubItems(2).Text
            .lblNOC.Text = lstvw.SelectedItems(0).SubItems(7).Text
            .lblNameOfComplainant.Text = lstvw.SelectedItems(0).SubItems(4).Text
            .cmbxActionTakenBy.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadAll()
    End Sub

    Private Sub ActionComplaintReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionComplaintReceiptToolStripMenuItem.Click
        Call PrintComplaint(Me.lstvwEmergency.SelectedItems(0).SubItems(1).Text)
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyValue = Keys.Enter Then
            Call LoadData_Emergency()
        End If
    End Sub

End Class