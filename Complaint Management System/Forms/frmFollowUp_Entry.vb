Imports MySql.Data.MySqlClient

Public Class frmFollowUp_Entry

    Friend ID As Integer

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        Dim sqlstring As String

        If Trim(Me.txtRemarks.Text).Length = 0 Then
            MessageBox.Show("Please enter a remarks for the follow-up", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtRemarks.Focus()
        Else
            If Me.btnEntry.Text = "&Save" Then


                'save the data entry
                CheckConnection(cn)

                sqlstring = "INSERT INTO tblFollowUp (SRNo,FUDate,Remarks) VALUES ('" & Me.lblSR.Text & "','" & Me.dtpDate.Value.ToShortDateString & "','" & Me.txtRemarks.Text & "')"
                Dim cmd As New MySqlCommand(sqlstring, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("The follow-up has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                'code for update
                'update the data entry
                CheckConnection(cn)

                sqlstring = "UPDATE tblFollowUp SET SRNo='" & Me.lblSR.Text & _
                                                                "',FUDate='" & Me.dtpDate.Value.ToShortDateString & _
                                                                "',Remarks='" & Me.txtRemarks.Text & "' WHERE ID='" & ID & "'"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Follow-up has been successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            frmComplaint_Entry.LoadFollowUp()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmFollowUp_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class