Imports MySql.Data.MySqlClient

Public Class frmFeeder_Entry

#Region "Functions"

    Private Function CheckDuplicate(ByVal str As String) As Boolean

        Dim SQL As String
        SQL = "SELECT * FROM tblFeederName WHERE title='" & str & "'"

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
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click

        If Me.txtTitle.TextLength = 0 Then
            MessageBox.Show("Please enter an feeder name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtTitle.Focus()
        ElseIf CheckDuplicate(Me.txtTitle.Text) = True Then
            MessageBox.Show("title is already existing! Please enter another feeder name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtTitle.Focus()
        Else
            If Me.btnEntry.Text = "Save" Then
                'save the data entry
                CheckConnection(cn)

                Dim sqlString As String = "INSERT INTO tblFeederName (Title) VALUES ('" & Me.txtTitle.Text & "')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()

                MessageBox.Show("The feeder name has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmFeeder_View.LoadData()
                Me.btnCancel_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub frmFeeder_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class