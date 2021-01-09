Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPrevByNOC

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

        Dim repDoc = New crptERCByNatureOfComplaint

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

        frmvwComplaintByNature.crptvwByNOC.ReportSource = repDoc
        If Me.cmbxNOC.Text = "All" Then
            'frmvwComplaintListERC.crptvwComplaintListERC.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# AND {tblComplaints1.ActionTaken}<>'" & "'"
            'frmvwComplaintByNature.crptvwByNOC.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# AND {tblComplaints1.ActionTaken}<>'' AND " & "{tblComplaints1.NatureOfComplaint})='" & Me.cmbxNOC.Text & "'"
            frmvwComplaintByNature.crptvwByNOC.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "#"
        Else
            frmvwComplaintByNature.crptvwByNOC.SelectionFormula = "{tblComplaints1.NatureOfComplaint}='" & Me.cmbxNOC.Text & "' AND Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "#"
        End If

        frmvwComplaintByNature.ShowDialog()

    End Sub

#End Region

#Region "Filling Function"

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

    Private Sub FillNOC(ByVal Sqlstring As String)

        Me.cmbxNOC.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxNOC.Items.Add("<select>")
        Me.cmbxNOC.Items.Add("All")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxNOC.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxNOC.Text = "<select>"
    End Sub

#End Region

#Region "Loading Function"

    Private Sub LoadEmployee()
        FillEmployee("SELECT * FROM tblEmployee WHERE ListingCode=1")
    End Sub

    Private Sub LoadNOC()
        FillNOC("SELECT * FROM tblNatureOfComplaint")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxNOC.Text = "<select>" Then
            MessageBox.Show("Please select an NOC.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxNOC.Focus()
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

    Private Sub frmPrintPrevByNOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        LoadEmployee()
        LoadNOC()
    End Sub

End Class