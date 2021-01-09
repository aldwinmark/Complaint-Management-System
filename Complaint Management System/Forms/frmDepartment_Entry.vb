Imports MySql.Data.MySqlClient

Public Class frmDepartment_Entry

    Friend ID As Integer

#Region "Funcntions"

    Friend Sub GetDepartment(ByVal ID As String)
        Dim StrSelect As String

        StrSelect = "SELECT * FROM tbldepartments WHERE ID = '" & ID & " '"
        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(StrSelect, cn)

        Dim objReader As MySqlDataReader = cmdSearch.ExecuteReader
        objReader.Read()

        If objReader.HasRows = True Then
            Me.txtDepartment_ID.Text = objReader("Department_ID").ToString
            Me.txtTitle.Text = objReader("Title").ToString
        Else
            Me.txtDepartment_ID.Text = ""
            Me.txtTitle.Text = ""
        End If
        'close the reader
        objReader.Close()
    End Sub

    Private Function CheckDuplicate(ByVal str As String) As Boolean

        Dim SQL As String
        SQL = "SELECT * FROM tblDepartments WHERE Department_ID='" & str & "'"

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

        If Me.txtDepartment_ID.TextLength = 0 Then
            MessageBox.Show("Please enter a department id.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtDepartment_ID.Focus()
        ElseIf Me.txtTitle.TextLength = 0 Then
            MessageBox.Show("Please enter title.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtTitle.Focus()
        ElseIf CheckDuplicate(Me.txtDepartment_ID.Text) = True And Me.btnEntry.Text = "Save" Then
            MessageBox.Show("Deaprtment ID is already existing! Please enter another department id.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtDepartment_ID.Focus()
        Else
            Dim sqlString As String
            If Me.btnEntry.Text = "Save" Then
                'save the data entry
                CheckConnection(cn)

                sqlString = "INSERT INTO tblDepartments (Department_ID,Title) VALUES ('" & Me.txtDepartment_ID.Text & "','" & Me.txtTitle.Text & "')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()

                MessageBox.Show("The department has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'code for update
                'update the data entry
                CheckConnection(cn)

                sqlString = "UPDATE tblDepartments SET Department_ID='" & Me.txtDepartment_ID.Text & _
                                                                "',Title='" & CSQ(Me.txtTitle.Text) & "' WHERE ID='" & ID & "'"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("The department has been successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            frmDepartment_View.LoadData()
            Me.btnCancel_Click(sender, e)
        End If

    End Sub

    Private Sub frmDepartment_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class