Imports MySql.Data.MySqlClient

Public Class frmComplaintAction_Entry

#Region "Functions"

#Region "Filling Functions"

    Private Sub FillDispatchTo(ByVal Sqlstring As String)

        Me.cmbxEmployee.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxEmployee.Items.Add("<select>")
        Me.cmbxEmployee.Items.Add("")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxEmployee.Items.Add(dr("Employee_Name"))
            Next
        End If
        Me.cmbxEmployee.Text = "<select>"
    End Sub

    Private Sub FillActionTaken(ByVal Sqlstring As String)

        Me.cmbxActionTaken.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxActionTaken.Items.Add("<select>")
        Me.cmbxActionTaken.Items.Add("")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxActionTaken.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxActionTaken.Text = "<select>"
    End Sub

#End Region

#Region "Load Functions"

    Friend Sub LoadDispatchTo()
        FillDispatchTo("SELECT * FROM tblEmployee ORDER BY Employee_Name ASC")
    End Sub

    Friend Sub LoadActionTaken()
        FillActionTaken("SELECT * FROM tblActionTaken ORDER BY Title ASC")
    End Sub

#End Region

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        'If Trim(Me.txtAction_Taken.TextLength) = 0 Then
        '    MessageBox.Show("Please select a area/office/dept. to send the complaints.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Me.txtAction_Taken.Focus()
        'Else
        'save the data entry
        CheckConnection(cn)

        Dim tmpDate As Date
        Dim FinalDate As String

        tmpDate = Me.dtpDateTime.Value
        'FinalDate = tmpDate.Year & "-" & tmpDate.Month & "-" & tmpDate.Day & " " & tmpDate.Hour
        FinalDate = tmpDate.ToString("yyyy-MM-dd HH:mm:ss")

        'update the data entry
        CheckConnection(cn)

        Dim sqlString As String = "UPDATE tblComplaints SET ActionTakenBy='" & Me.cmbxEmployee.Text & "',DateActionTaken='" & FinalDate & "',ActionTaken='" & Me.cmbxActionTaken.Text & "' WHERE ID=" & Me.txtSRNo.Text & ""
        Dim cmd As New MySqlCommand(sqlString, cn)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Compliant SR# " & Me.txtSRNo.Text & " has been successfully updated.", "created", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmComplaintAction.LoadData()
        Me.btnCancel_Click(sender, e)
        'End If

    End Sub

    Private Sub frmComplaintAction_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class