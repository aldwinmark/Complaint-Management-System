﻿Imports MySql.Data.MySqlClient

Public Class frmNatureOfComplaint_Entry

#Region "Functions"

    Private Function CheckDuplicate(ByVal str As String) As Boolean

        Dim SQL As String
        SQL = "SELECT * FROM tblNatureOfComplaint WHERE title='" & str & "'"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            CheckDuplicate = True
        Else
            CheckDuplicate = False
        End If
        r.Close()

        Return CheckDuplicate

    End Function

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.txtTitle.TextLength = 0 Then
            MessageBox.Show("Please enter a nature of complaint title.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtTitle.Focus()
        ElseIf Me.txtDescription.TextLength = 0 Then
            MessageBox.Show("Please enter a description.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtDescription.Focus()
        ElseIf CheckDuplicate(Me.txtTitle.Text) = True Then
            MessageBox.Show("title is already existing! Please enter another nature of complaint.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtTitle.Focus()
        Else
            If Me.btnEntry.Text = "Save" Then
                'save the data entry
                CheckConnection(cn)

                Dim sqlString As String = "INSERT INTO tblNatureOfComplaint (Title,Description) VALUES ('" & Me.txtTitle.Text & "','" & Me.txtDescription.Text & "')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()

                MessageBox.Show("The nature of complaint has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmNatureOfComplaint_View.LoadData()
                Me.btnCancel_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub frmNatureOfComplaint_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class