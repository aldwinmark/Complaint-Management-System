Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPrevWeeklyReport

#Region "User Functions"

    Private Function getActed() As Integer
        Dim StartDate As String = Me.dtpDateStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpDateEnd.Value.ToString("yyyy-MM-dd 24:00:00")
        Dim SQL As String
        SQL = "SELECT COUNT(*) AS TotalCount FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' AND DateActionTaken IS NOT NULL AND ActionTaken<>'' AND ActionTakenBy<>'' ORDER BY DateReceipt ASC"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            getActed = r("TotalCount").ToString
        Else
            getActed = 0
        End If
        r.Close()

        Return getActed

    End Function

    Private Function getUnActed() As Integer
        Dim StartDate As String = Me.dtpDateStart.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpDateEnd.Value.ToString("yyyy-MM-dd 24:00:00")
        Dim SQL As String
        SQL = "SELECT COUNT(*) AS TotalCount FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "' AND ActionTaken='' ORDER BY DateReceipt ASC"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            getUnActed = r("TotalCount").ToString
        Else
            getUnActed = 0
        End If
        r.Close()

        Return getUnActed
    End Function

    Private Sub LoadRouteReport()

        Dim Acted As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim UnActed As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Total As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim FormNo As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim txtPreparedby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtReviewedby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtMonitoredby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtNotedby As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim txtPreparedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtReviewedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtMonitoredbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtNotedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim txtTitle As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim repDoc

        repDoc = New crptWeeklyReport

        Acted = repDoc.ReportDefinition.ReportObjects.Item("txtActed")
        UnActed = repDoc.ReportDefinition.ReportObjects.Item("txtUnActed")
        Total = repDoc.ReportDefinition.ReportObjects.Item("txtTotal")

        FormNo = repDoc.ReportDefinition.ReportObjects.Item("txtFormNo")

        txtPreparedby = repDoc.ReportDefinition.ReportObjects.Item("txtPreparedby")
        txtReviewedby = repDoc.ReportDefinition.ReportObjects.Item("txtReviewedby")
        txtMonitoredby = repDoc.ReportDefinition.ReportObjects.Item("txtMonitoredby")
        txtNotedby = repDoc.ReportDefinition.ReportObjects.Item("txtNotedBy")

        txtTitle = repDoc.ReportDefinition.ReportObjects.Item("txtTitle")

        txtPreparedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtPreparedbyPos")
        txtReviewedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtReviewedbyPos")
        txtMonitoredbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtMonitoredbyPos")
        txtNotedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtNotedbyPos")

        Acted.Text = getActed()
        UnActed.Text = getUnActed()

        Total.Text = getActed() + getUnActed()

        FormNo.Text = "001-" & Me.cmbxDepartment.Text & "-FO; Revision 0; 01-Aug-July-2014"

        txtPreparedby.Text = Me.cmbxPreparedBy.Text
        txtReviewedby.Text = Me.cmbxReviewedBy.Text
        txtMonitoredby.Text = Me.cmbxMonitoredBy.Text
        txtNotedby.Text = Me.cmbxNotedBy.Text

        txtTitle.Text = GetDepartment(Me.cmbxDepartment.Text)

        txtPreparedbyPos.Text = Me.lblPreparedBy.Text
        txtReviewedbyPos.Text = Me.lblReviewedBy.Text
        txtMonitoredbyPos.Text = Me.lblMonitoredBy.Text
        txtNotedbyPos.Text = Me.lblNotedby.Text

        'For Each myTable In repDoc.Database.Tables
        '    myLogin = myTable.LogOnInfo
        '    myLogin.ConnectionInfo.ServerName = ServerName
        '    myLogin.ConnectionInfo.DatabaseName = DatabaseName
        '    myLogin.ConnectionInfo.UserID = UserID
        '    'myLogin.ConnectionInfo.Password = Password

        '    myTable.ApplyLogOnInfo(myLogin)
        'Next

        crSections = repDoc.ReportDefinition.Sections
        'loop through all the sections to find all the report objects
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
        Next
        frmvwWeeklyReport.crptvwWeeklyReport.ReportSource = repDoc

        'If Me.cmbxDepartment.Text = "All" Then
        frmvwWeeklyReport.crptvwWeeklyReport.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# " & ""
        'Else
        'frmvwWeeklyReport.crptvwWeeklyReport.SelectionFormula = "{tblComplaints1.Department_ID}='" & Me.cmbxDepartment.Text & "' AND Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# " & ""
        'End If

        'frmvwWeeklyReport.crptvwWeeklyReport.SelectionFormula = "{tblComplaints1.RoutedNo}='" & RoutingSlip & "'"
        frmvwWeeklyReport.Show()

    End Sub

    Private Function GetDepartment(ByVal str As String) As String

        Dim SQL As String
        SQL = "SELECT * FROM tblDepartments WHERE Department_ID='" & str & "'"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            GetDepartment = r("Title").ToString
        Else
            GetDepartment = ""
        End If
        r.Close()

        Return GetDepartment

    End Function

    Private Function getEmployeePos(ByVal Name As String) As String

        Dim SQL As String
        SQL = "SELECT * FROM tblEmployee WHERE Employee_Name='" & Name & "'"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            getEmployeePos = r("Position")
        Else
            getEmployeePos = ""
        End If
        r.Close()

        Return getEmployeePos

    End Function

#End Region

#Region "Filling Functions"

    Private Sub FillEmployee(ByVal Sqlstring As String)
        Me.cmbxPreparedBy.Items.Clear()
        Me.cmbxReviewedBy.Items.Clear()
        Me.cmbxMonitoredBy.Items.Clear()
        Me.cmbxNotedBy.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxPreparedBy.Items.Add("<select>")
        Me.cmbxReviewedBy.Items.Add("<select>")
        Me.cmbxMonitoredBy.Items.Add("<select>")
        Me.cmbxNotedBy.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxPreparedBy.Items.Add(dr("Employee_Name"))
                Me.cmbxReviewedBy.Items.Add(dr("Employee_Name"))
                Me.cmbxMonitoredBy.Items.Add(dr("Employee_Name"))
                Me.cmbxNotedBy.Items.Add(dr("Employee_Name"))
            Next
        End If
        Me.cmbxPreparedBy.Text = "<select>"
        Me.cmbxReviewedBy.Text = "<select>"
        Me.cmbxMonitoredBy.Text = "<select>"
        Me.cmbxNotedBy.Text = "<select>"
    End Sub

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        ds.Clear()
        da.Fill(ds)
        Me.cmbxDepartment.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxDepartment.Items.Add(dr("Department_ID"))
            Next
        End If
        Me.cmbxDepartment.Text = "<select>"
    End Sub

#End Region

#Region "Load Functions"

    Private Sub LoadEmployee()
        FillEmployee("SELECT * FROM tblEmployee WHERE ListingCode='1'")
    End Sub

    Private Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmPrintPrevWeeklyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        LoadEmployee()
        LoadDepartment()
    End Sub

    Private Sub cmbxPreparedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxPreparedBy.SelectedIndexChanged
        If Not Me.cmbxPreparedBy.Text = "<select>" Then
            Me.lblPreparedBy.Text = getEmployeePos(Me.cmbxPreparedBy.Text)
        End If
    End Sub

    Private Sub cmbxReviewedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxReviewedBy.SelectedIndexChanged
        If Not Me.cmbxReviewedBy.Text = "<select>" Then
            Me.lblReviewedBy.Text = getEmployeePos(Me.cmbxReviewedBy.Text)
        End If
    End Sub

    Private Sub cmbxMonitoredBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxMonitoredBy.SelectedIndexChanged
        If Not Me.cmbxMonitoredBy.Text = "<select>" Then
            Me.lblMonitoredBy.Text = getEmployeePos(Me.cmbxMonitoredBy.Text)
        End If
    End Sub

    Private Sub cmbxNotedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxNotedBy.SelectedIndexChanged
        If Not Me.cmbxNotedBy.Text = "<select>" Then
            Me.lblNotedBy.Text = getEmployeePos(Me.cmbxNotedBy.Text)
        End If
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxPreparedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for prepared by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxPreparedBy.Focus()
        ElseIf Me.cmbxReviewedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for reviewed by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxReviewedBy.Focus()
        ElseIf Me.cmbxMonitoredBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for monitored by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxMonitoredBy.Focus()
        ElseIf Me.cmbxNotedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for noted by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxNotedBy.Focus()
        ElseIf Me.cmbxDepartment.Text = "<select>" Then
            MessageBox.Show("Please select department", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        Else
            LoadRouteReport()
        End If
    End Sub

End Class