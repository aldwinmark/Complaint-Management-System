Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPrevToERC

#Region "User Functions"

    Private Sub LoadERCReport()

        Dim DateStart As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateEnd As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim Preparedby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Reviewedby As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Notedby As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim PreparedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim ReviewedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim NotedbyPos As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim repDoc = New crptERCReport

        DateStart = repDoc.ReportDefinition.ReportObjects.Item("txtDateStart")
        DateEnd = repDoc.ReportDefinition.ReportObjects.Item("txtDateEnd")

        Preparedby = repDoc.ReportDefinition.ReportObjects.Item("txtPreparedby")
        Reviewedby = repDoc.ReportDefinition.ReportObjects.Item("txtReviewedby")
        Notedby = repDoc.ReportDefinition.ReportObjects.Item("txtNotedby")

        PreparedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtPreparedbyPos")
        ReviewedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtReviewedbyPos")
        NotedbyPos = repDoc.ReportDefinition.ReportObjects.Item("txtNotedbyPos")

        DateStart.Text = Me.dtpDateStart.Value.ToShortDateString
        DateEnd.Text = Me.dtpDateEnd.Value.ToShortDateString

        Preparedby.Text = Me.cmbxPreparedBy.Text
        Reviewedby.Text = Me.cmbxReviewedBy.Text
        Notedby.Text = Me.cmbxNotedBy.Text

        PreparedbyPos.Text = Me.lblPreparedby.Text
        ReviewedbyPos.Text = Me.lblReviewedby.Text
        NotedbyPos.Text = Me.lblNotedby.Text

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

        frmvwComplaintListERC.crptvwComplaintListERC.ReportSource = repDoc
        If Me.cmbxDepartment.Text = "All" Then
            'frmvwComplaintListERC.crptvwComplaintListERC.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# AND {tblComplaints1.ActionTaken}<>'" & "'"
            'frmvwComplaintListERC.crptvwComplaintListERC.report()
            frmvwComplaintListERC.crptvwComplaintListERC.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# AND {tblComplaints1.ActionTaken}<>''" & ""
        Else
            frmvwComplaintListERC.crptvwComplaintListERC.SelectionFormula = "{tblComplaints1.Department_ID}='" & Me.cmbxDepartment.Text & "' AND Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# AND {tblComplaints1.ActionTaken}<>''"
        End If

        frmvwComplaintListERC.ShowDialog()

    End Sub

#End Region

#Region "Filling Function"

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxDepartment.Items.Add("<select>")
        Me.cmbxDepartment.Items.Add("All")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxDepartment.Items.Add(dr("Department_ID"))
            Next
        End If
        Me.cmbxDepartment.Text = "<select>"

    End Sub

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Me.cmbxReviewedBy.Items.Clear()
        Me.cmbxNotedBy.Items.Clear()
        Me.cmbxPreparedBy.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxReviewedBy.Items.Add("<select>")
        Me.cmbxNotedBy.Items.Add("<select>")
        Me.cmbxPreparedBy.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxReviewedBy.Items.Add(dr("Employee_Name"))
                Me.cmbxNotedBy.Items.Add(dr("Employee_Name"))
                Me.cmbxPreparedBy.Items.Add(dr("Employee_Name"))
            Next
        End If
        Me.cmbxReviewedBy.Text = "<select>"
        Me.cmbxNotedBy.Text = "<select>"
        Me.cmbxPreparedBy.Text = "<select>"
    End Sub

#End Region

#Region "Loading Function"

    Private Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

    Private Sub LoadEmployee()
        FillEmployee("SELECT * FROM tblEmployee WHERE ListingCode=1")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmPrintPrevToERC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        LoadDepartment()
        LoadEmployee()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click

        If Me.cmbxDepartment.Text = "<select>" Then
            MessageBox.Show("Please select an Area/Office/Department.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        ElseIf Me.cmbxPreparedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for the (Prepared by:).", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxPreparedBy.Focus()
        ElseIf Me.cmbxReviewedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for the (Reviewed by:).", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxReviewedBy.Focus()
        ElseIf Me.cmbxNotedBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee for the (Noted by:).", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxNotedBy.Focus()
        Else
            LoadERCReport()
        End If

    End Sub

    Private Sub cmbxPreparedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxPreparedBy.SelectedIndexChanged
        If Not Me.cmbxPreparedBy.Text = "<select>" Then
            Me.lblPreparedby.Text = getEmployeePos(Me.cmbxPreparedBy.Text)
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