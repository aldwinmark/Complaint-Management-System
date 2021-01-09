Imports MySql.Data.MySqlClient

Public Class frmEmployee_Entry

    Friend ID As Integer

#Region "Loading Function"

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Me.cmbxDepartment.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        Dim sqlString As String
        If Me.txtEmployeeName.TextLength = 0 Then
            MessageBox.Show("Please enter an Employee name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtEmployeeName.Focus()
        ElseIf Me.txtPosition.TextLength = 0 Then
            MessageBox.Show("Please enter a postion.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPosition.Focus()
        ElseIf Me.cmbxDepartment.Text = "<select>" Then
            MessageBox.Show("Please select a department for the employee.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        ElseIf Me.cmbxListingCode.Text = "<select>" Then
            MessageBox.Show("Please select a listing code for the employee.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxListingCode.Focus()
        Else
            If Me.btnEntry.Text = "&Save" Then
                'save the data entry
                CheckConnection(cn)

                sqlString = "INSERT INTO tblEmployee (Employee_Name,Position,ListingCode) VALUES ('" & Me.txtEmployeeName.Text & "','" & Me.txtPosition.Text & "','" & Me.cmbxListingCode.Text & "')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("The employee has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'code for update
                'update the data entry
                CheckConnection(cn)

                sqlString = "UPDATE tblEmployee SET Employee_Name='" & Me.txtEmployeeName.Text & _
                                                        "',Position='" & Me.txtPosition.Text & _
                                                        "',ListingCode='" & Me.cmbxListingCode.Text & _
                                                        "',Department='" & Me.cmbxDepartment.Text & "' WHERE ID=" & ID & ""
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee has been successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            frmEmployee_View.LoadData()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmEmployee_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class