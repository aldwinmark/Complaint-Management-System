Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPrevComMonitoring

    Friend DateStart As String
    Friend DateEnd As String
    Friend DateCount As String

#Region "Functions"

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

    Private Sub ProcessComMonitoring()



    End Sub

#Region "Load Functions"

    Private Sub LoadEmployee()
        FillEmployee("SELECT * FROM tblEmployee WHERE ListingCode='1'")
    End Sub

    Friend Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Me.cmbxPreparedBy.Items.Clear()
        Me.cmbxReviewedBy.Items.Clear()
        Me.cmbxNotedBy.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxPreparedBy.Items.Add("<select>")
        Me.cmbxReviewedBy.Items.Add("<select>")
        Me.cmbxNotedBy.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxPreparedBy.Items.Add(dr("Employee_Name"))
                Me.cmbxReviewedBy.Items.Add(dr("Employee_Name"))
                Me.cmbxNotedBy.Items.Add(dr("Employee_Name"))
            Next
        End If
        Me.cmbxPreparedBy.Text = "<select>"
        Me.cmbxReviewedBy.Text = "<select>"
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

#Region "Reports"

    Private Sub LoadReport()

        Dim txtDateStart As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtDateEnd As CrystalDecisions.CrystalReports.Engine.TextObject
        'Dim txtDateCount As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim txtPreparedby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtReviewedby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtNotedby As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim txtPreparedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtReviewedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtNotedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim txtTitle As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim repDoc

        repDoc = New crptComplaintMon

        txtDateStart = repDoc.ReportDefinition.ReportObjects.Item("txtDateStart")
        txtDateEnd = repDoc.ReportDefinition.ReportObjects.Item("txtDateEnd")
        'txtDateCount = repDoc.ReportDefinition.ReportObjects.Item("txtDateCount")

        txtPreparedby = repDoc.ReportDefinition.ReportObjects.Item("txtPreparedby")
        txtReviewedby = repDoc.ReportDefinition.ReportObjects.Item("txtReviewedby")
        txtNotedby = repDoc.ReportDefinition.ReportObjects.Item("txtNotedBy")

        txtTitle = repDoc.ReportDefinition.ReportObjects.Item("txtTitle")

        txtPreparedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtPreparedbyPos")
        txtReviewedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtReviewedbyPos")
        txtNotedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtNotedbyPos")

        txtDateStart.Text = DateStart
        txtDateEnd.Text = DateEnd
        'txtDateCount.text = DateCount

        txtPreparedby.Text = Me.cmbxPreparedBy.Text
        txtReviewedby.Text = Me.cmbxReviewedBy.Text
        txtNotedby.Text = Me.cmbxNotedBy.Text

        txtTitle.Text = GetDepartment(Me.cmbxDepartment.Text)

        txtPreparedbyPos.Text = Me.lblPreparedBy.Text
        txtReviewedbyPos.Text = Me.lblReviewedby.Text
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
        frmvwComMonitoring.crptvwComMonitoring.ReportSource = repDoc
        'frmvwComMonitoring.crptvwComMonitoring.SelectionFormula = "{tblComplaints1.RoutedNo}='" & RoutingSlip & "'"
        frmvwComMonitoring.Show()

    End Sub

#End Region

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxPreparedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for prepared by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxPreparedBy.Focus()
        ElseIf Me.cmbxReviewedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for reviewed by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxReviewedBy.Focus()
        ElseIf Me.cmbxNotedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for noted by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxNotedBy.Focus()
        ElseIf Me.cmbxDepartment.Text = "<select>" Then
            MessageBox.Show("Please select an employee for noted by:", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        Else
            LoadReport()
        End If
    End Sub

    Private Sub frmPrintPrevComMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        LoadEmployee()
    End Sub

    Private Sub cmbxPreparedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxPreparedBy.SelectedIndexChanged
        If Not Me.cmbxPreparedBy.Text = "<select>" Then
            Me.lblPreparedBy.Text = getEmployeePos(Me.cmbxPreparedBy.Text)
        End If
    End Sub

    Private Sub cmbxReviewedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxReviewedBy.SelectedIndexChanged
        If Not Me.cmbxReviewedBy.Text = "<select>" Then
            Me.lblReviewedby.Text = getEmployeePos(Me.cmbxReviewedBy.Text)
        End If
    End Sub

    Private Sub cmbxNotedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxNotedBy.SelectedIndexChanged
        If Not Me.cmbxNotedBy.Text = "<select>" Then
            Me.lblNotedby.Text = getEmployeePos(Me.cmbxNotedBy.Text)
        End If
    End Sub
End Class