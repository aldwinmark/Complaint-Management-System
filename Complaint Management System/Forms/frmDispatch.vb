Imports MySql.Data.MySqlClient

Public Class frmDispatch

    Friend ComplaintID As Integer

#Region "Functions"

    Private Sub updateComplaint(ByVal ID As Integer, ByVal EmployeeName As String)

        'update the data entry
        CheckConnection(cn)

        Dim sqlString As String = "UPDATE tblComplaints SET ActionTakenBy='" & EmployeeName & "' WHERE ID='" & ID & "'"
        Dim cmd As New MySqlCommand(sqlString, cn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("SR# " & ID & " has been successfully dispatch to " & EmployeeName, "Dispatch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmSubCompDesk.LoadData_Emergency()

    End Sub

    Public Sub LoadActionTakenBy()
        FillActionTakenBy("SELECT * FROM tblEmployee WHERE ListingCode='2' OR ListingCode='3' AND ListingCode='4'")
    End Sub

    Private Sub FillActionTakenBy(ByVal Sqlstring As String)

        Me.cmbxActionTakenBy.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxActionTakenBy.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxActionTakenBy.Items.Add(dr("Employee_Name"))
            Next
        End If
        Me.cmbxActionTakenBy.Text = "<select>"
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmDispatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        LoadActionTakenBy()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxActionTakenBy.Text = "<select>" Then
            MessageBox.Show("Please select an employee to dispatch the complaint", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxActionTakenBy.Focus()
        Else
            Call updateComplaint(CInt(Me.lblSRNo.Text), Me.cmbxActionTakenBy.Text)
            Me.btnCancel_Click(sender, e)
        End If

    End Sub

End Class