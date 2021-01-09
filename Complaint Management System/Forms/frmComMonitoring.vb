Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class frmComMonitoring

#Region "User Functions"

    Private Sub DelComMonitoring()
        Dim StrSelect As String
        StrSelect = "DELETE FROM printcommonitoring"
        CheckConnection(cn)
        Dim cmd As New MySqlCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub AddComMonitoring()
        Dim oc As String
        Dim account As String
        Dim name As String
        Dim address As String
        Dim contact As String
        Dim noc As String
        Dim dtr As DateTime
        Dim strdtr As String
        Dim at As String
        Dim mr As String
        Dim agency As String
        Dim dta As Date
        Dim strdta As String
        Dim SRNo As String

        Dim x As Integer

        Dim sqlString As String
        'delete the items before adding a record
        DelComMonitoring()
        'save the data entry
        CheckConnection(cn)
        For x = 0 To Me.lstvwComplaints.Items.Count - 1
            With Me.lstvwComplaints
                oc = .Items(x).SubItems(4).Text
                account = .Items(x).SubItems(9).Text
                name = .Items(x).SubItems(1).Text
                address = .Items(x).SubItems(10).Text
                contact = .Items(x).SubItems(11).Text
                noc = .Items(x).SubItems(2).Text

                dtr = CDate(.Items(x).SubItems(3).Text)
                strdtr = dtr.ToString("yyyy-MM-dd") '& " " & dtr.ToString("HH:mm:ss")

                at = .Items(x).SubItems(6).Text
                mr = .Items(x).SubItems(12).Text
                agency = .Items(x).SubItems(13).Text
                If Trim(.Items(x).SubItems(14).Text) = "" Then
                    strdta = "0000-00-00 00:00:00"
                Else
                    dta = CDate(.Items(x).SubItems(14).Text)
                    strdta = dta.ToString("yyyy-MM-dd") & " " & dta.ToString("HH:mm:ss")
                End If
                SRNo = .Items(x).SubItems(0).Text
            End With
            sqlString = "INSERT INTO printcommonitoring (oc," & _
                                                                "account," & _
                                                                "name," & _
                                                                "address," & _
                                                                "contact," & _
                                                                "noc," & _
                                                                "dtr," & _
                                                                "at," & _
                                                                "mr," & _
                                                                "dta," & _
                                                                "SRNo," & _
                                                                "agency) VALUES ('" & oc & "', " & _
                                                                "'" & account & "'," & _
                                                                "'" & name & "'," & _
                                                                "'" & address & "'," & _
                                                                "'" & contact & "'," & _
                                                                "'" & noc & "'," & _
                                                                "'" & strdtr & "'," & _
                                                                "'" & at & "'," & _
                                                                "'" & mr & "'," & _
                                                                "'" & strdta & "'," & _
                                                                "'" & SRNo & "'," & _
                                                                "'" & agency & "')"
            Dim cmd As New MySqlCommand(sqlString, cn)
            cmd.ExecuteNonQuery()
        Next
    End Sub

    Private Function GetRoute(ByVal Account As String) As String
        Dim SQL As String
        SQL = "SELECT * FROM billing WHERE account='" & Account & "'"

        CheckConnection(cnPsion)
        Dim cmdSearch As New MySqlCommand(SQL, cnPsion)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            GetRoute = r("route").ToString
        Else
            GetRoute = "none"
        End If
        r.Close()

        Return GetRoute
    End Function

    Private Function GetMR(ByVal route As String) As String

        Dim SQL As String
        SQL = "SELECT * FROM schedules WHERE route='" & route & "'"

        CheckConnection(cnPsion)
        Dim cmdSearch As New MySqlCommand(SQL, cnPsion)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            GetMR = r("MR").ToString
        Else
            GetMR = "none"
        End If
        r.Close()

        Return GetMR
    End Function

    Private Function GetAgency(ByVal MR As String) As String
        Dim dbfcnMTRR As OleDbConnection
        'dbfconnection
        dbfcnMTRR = New OleDb.OleDbConnection("Provider=vfpoledb.1;Data Source=" & Application.StartupPath & "\HCMTRR.dbf;Collating Sequence=machine")
        dbfcnMTRR.Open()

        Dim cmd As New OleDbCommand("SELECT * FROM HCMTRR WHERE MTRRCODE='" & MR & "'", dbfcnMTRR)
        Dim objReader As OleDbDataReader = cmd.ExecuteReader
        objReader.Read()
        If objReader.HasRows Then
            GetAgency = objReader("CON_CODE").ToString
        Else
            GetAgency = ""
        End If
        'close the reader 
        objReader.Close()

        Return GetAgency
    End Function

#End Region

#Region "Loading Functions"

    Public Sub loadUnAttendentComp(ByVal status As Integer)
        Dim complStatus As String
        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")

        'Unattended = 0, Attended = 1
        If status = 0 Then
            complStatus = "DateActionTaken IS NULL AND ActionTaken='' AND ActionTakenBy=''"
        Else
            complStatus = "DateActionTaken IS NOT NULL AND ActionTaken<>'' AND ActionTakenBy<>''"
        End If

        'if the the department is selected as "All" and received by as "All"
        If Me.cmbxDepartment.Text <> "All" And Me.cmbxRecievedBy.Text <> "All" Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Me.cmbxDepartment.Text & "' AND ReceivedBy='" & Me.cmbxRecievedBy.Text & "' AND " & complStatus & " AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
            'if the department selected as "All" and received by equals to someone
        ElseIf Me.cmbxDepartment.Text = "All" And Me.cmbxRecievedBy.Text <> "All" Then
            FillComplaints("SELECT * FROM tblComplaints WHERE ReceivedBy='" & Me.cmbxRecievedBy.Text & "' AND " & complStatus & " AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
            'if the department selected to a department and received by is selected as "All"
        ElseIf Me.cmbxDepartment.Text <> "All" And Me.cmbxRecievedBy.Text = "All" Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Me.cmbxDepartment.Text & "' AND " & complStatus & " AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE " & complStatus & " AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
        End If
    End Sub

    Public Sub LoadData()
        Dim StartDate As String = Me.dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpEnd.Value.ToString("yyyy-MM-dd 24:00:00")
        'if the the department is selected as "All" and received by as "All"
        If Me.cmbxDepartment.Text <> "All" And Me.cmbxRecievedBy.Text <> "All" Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Me.cmbxDepartment.Text & "' AND ReceivedBy='" & Me.cmbxRecievedBy.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
            'if the department selected as "All" and received by equals to someone
        ElseIf Me.cmbxDepartment.Text = "All" And Me.cmbxRecievedBy.Text <> "All" Then
            FillComplaints("SELECT * FROM tblComplaints WHERE ReceivedBy='" & Me.cmbxRecievedBy.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
            'if the department selected to a department and received by is selected as "All"
        ElseIf Me.cmbxDepartment.Text <> "All" And Me.cmbxRecievedBy.Text = "All" Then
            FillComplaints("SELECT * FROM tblComplaints WHERE Department_ID='" & Me.cmbxDepartment.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' ORDER BY DateReceipt ASC")
        End If
        'ActionTaken
    End Sub

    Public Sub LoadReceivedBy()
        FillReceivedBy("SELECT * FROM tblUserAccount")
    End Sub

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxDepartment.Items.Add("All")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxDepartment.Items.Add(dr("Department_ID"))
            Next
        End If
        Me.cmbxDepartment.Text = "All"

    End Sub

    Private Sub FillReceivedBy(ByVal Sqlstring As String)

        Me.cmbxRecievedBy.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxRecievedBy.Items.Add("All")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxRecievedBy.Items.Add(dr("Username").ToString)
            Next
        End If
        Me.cmbxRecievedBy.Text = "All"

    End Sub

    Private Sub FillComplaints(ByVal Sqlstring As String)
        Dim Account As String
        Dim Route As String
        Dim MR As String
        Dim Agency As String
        Dim DateR As Date
        Dim DateAT As Date
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
                    DateR = CDate(dr("DateReceipt").ToString)
                    .SubItems.Add(dr("Name".ToString)) '1
                    .SubItems.Add(dr("NatureOfComplaint".ToString)) '2
                    .SubItems.Add(DateR.ToString("MM/dd/yyyy")) '3
                    .SubItems.Add(dr("ReceivedBy".ToString)) '4
                    .SubItems.Add(dr("Type".ToString)) '5
                    If IsDBNull(dr("ActionTaken".ToString)) = False AndAlso Trim(dr("ActionTaken".ToString)).Length > 0 Then
                        .SubItems.Add(dr("ActionTaken".ToString)) '6
                    Else
                        .SubItems.Add("--------------") '6
                    End If
                    If IsDBNull(dr("DateActionTaken".ToString)) = False Then
                        DateAT = CDate(dr("DateActionTaken").ToString)
                        '.SubItems.Add(DateAT.ToString("MM/dd/yyyy")) '7
                        .SubItems.Add(dr("DateActionTaken").ToString) '7
                    Else
                        .SubItems.Add("--------------") '7
                    End If
                    If IsDBNull(dr("ActionTakenBy".ToString)) = False AndAlso Trim(dr("ActionTakenBy".ToString)).Length > 0 Then
                        .SubItems.Add(dr("ActionTakenBy".ToString)) '8
                    Else
                        .SubItems.Add("--------------") '8
                    End If
                    .SubItems.Add(dr("AccountNo".ToString)) '9
                    .SubItems.Add(dr("Address".ToString)) '10
                    .SubItems.Add(dr("ContactNo".ToString)) '11
                    Account = dr("AccountNo".ToString)
                    Route = GetRoute("01" & Account)
                    MR = GetMR(Route)
                    Agency = GetAgency(MR)
                    .SubItems.Add(MR) '12
                    .SubItems.Add(Trim(Agency)) '13
                    .SubItems.Add(dr("DateActionTaken").ToString) '14
                End With
            Next
            Me.lblTotalRecords.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
            Call listvwColorChange(Me.lstvwComplaints)
        End If
    End Sub

#End Region

    Private Sub frmMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        LoadData()
        LoadDepartment()
        LoadReceivedBy()
        Me.cmbxDepartment.Text = frmMain.lblArea.Text
        Me.cmbxRecievedBy.Text = "All"
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Call LoadData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub ComplaintMonitoringReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintMonitoringReportToolStripMenuItem.Click
        Dim Count As TimeSpan
        AddComMonitoring()
        With frmPrintPrevComMonitoring
            .LoadDepartment()
            .cmbxDepartment.Text = Me.cmbxDepartment.Text
            .DateStart = Me.dtpStart.Value
            .DateEnd = Me.dtpEnd.Value
            Count = Me.dtpEnd.Value - Me.dtpStart.Value
            .DateCount = Count.Days
            .ShowDialog()
        End With
    End Sub

    Private Sub UnAttToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnAttToolStripMenuItem.Click
        loadUnAttendentComp(0)
    End Sub

    Private Sub AttToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttToolStripMenuItem.Click
        loadUnAttendentComp(1)
    End Sub

End Class