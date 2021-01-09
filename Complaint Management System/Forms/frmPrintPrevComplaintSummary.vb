Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPrevComplaintSummary

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

    Private Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxDepartment.Text = "<select>" Then
            MessageBox.Show("Please select a department.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        Else
            Dim DateFrom As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim DateTo As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim crSections As Sections
            Dim crSection As Section
            Dim crReportObjects As ReportObjects

            Dim repDoc = New crptComplaintSummary

            DateFrom = repDoc.ReportDefinition.ReportObjects.Item("txtDateFrom")
            DateTo = repDoc.ReportDefinition.ReportObjects.Item("txtDateTo")

            DateFrom.Text = Me.dtpDateStart.Value.ToShortDateString
            DateTo.Text = Me.dtpDateEnd.Value.ToShortDateString

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


            frmvwComplaintSummary.crptvwComplaintSummary.ReportSource = repDoc
            If Me.cmbxDepartment.Text = "All" Then
                frmvwComplaintSummary.crptvwComplaintSummary.SelectionFormula = "Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# " & ""
            Else
                frmvwComplaintSummary.crptvwComplaintSummary.SelectionFormula = "{tblComplaints1.Department_ID}='" & Me.cmbxDepartment.Text & "' AND Date({tblComplaints1.DateReceipt})>= #" & Me.dtpDateStart.Value.ToShortDateString & "# And Date({tblComplaints1.DateReceipt})<= #" & Me.dtpDateEnd.Value.ToShortDateString & "# " & ""
            End If

            frmvwComplaintSummary.Show()
        End If

    End Sub

    Private Sub frmPrintPrevComplaintSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        LoadDepartment()
    End Sub

End Class