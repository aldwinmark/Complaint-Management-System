Imports MySql.Data.MySqlClient

Public Class frmUserAccounts_Entry

    Friend ID As Integer

#Region "Functions"

    Private Sub FillEmployee(ByVal Sqlstring As String)

        Me.cmbxEmployeeName.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
    
        Me.cmbxEmployeeName.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxEmployeeName.Items.Add(dr("Employee_Name"))
            Next
        End If
        Me.cmbxEmployeeName.Text = "<select>"

    End Sub

    Public Sub LoadDesignation()
        FillDesignation("SELECT * FROM tblDesignation")
    End Sub

    Private Sub FillDesignation(ByVal Sqlstring As String)

        Me.cmbxDesignation.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxDesignation.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxDesignation.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxDesignation.Text = "<select>"
    End Sub

#Region "Load Functions"

    Friend Sub LoadEmployee()
        FillEmployee("SELECT * FROM tblEmployee WHERE ListingCode='5' OR ListingCode='6'")
    End Sub

#End Region

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.txtUsername.TextLength = 0 Then
            MessageBox.Show("Please enter a valid username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUsername.Focus()
        ElseIf Me.txtPassword.TextLength = 0 Then
            MessageBox.Show("Please enter a valid password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPassword.Focus()
        ElseIf Me.txtRetypePassword.TextLength = 0 Then
            MessageBox.Show("Please enter a retype password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtRetypePassword.Focus()
        ElseIf Not Me.txtPassword.Text = Me.txtRetypePassword.Text Then
            MessageBox.Show("Password does not match.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPassword.Focus()
        ElseIf Me.cmbxEmployeeName.Text = "<select>" Then
            MessageBox.Show("Please select an employee name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxEmployeeName.Focus()
        ElseIf Me.cmbxDesignation.Text = "<select>" Then
            MessageBox.Show("Please select a designation for the.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDesignation.Focus()
        Else
            Dim sqlString As String

            If Me.btnEntry.Text = "&Save" Then
                'save the data entry
                CheckConnection(cn)

                sqlString = "INSERT INTO tblUserAccount (Username,Password,Name,Designation,UserLevel) VALUES ('" & Me.txtUsername.Text & "','" & Me.txtPassword.Text & "','" & Me.cmbxEmployeeName.Text & "','" & Me.cmbxDesignation.Text & "','" & Me.cmbxLevel.Text & "')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()

                MessageBox.Show("The user account has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'update the data entry
                CheckConnection(cn)

                sqlString = "UPDATE tblUserAccount SET Username='" & Me.txtUsername.Text & _
                                                        "',Password='" & Me.txtPassword.Text & _
                                                        "',Name='" & Me.cmbxEmployeeName.Text & _
                                                        "',Designation='" & Me.cmbxDesignation.Text & _
                                                        "',UserLevel='" & Me.cmbxLevel.Text & "' WHERE ID=" & ID & ""
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("The user account has been successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            frmUserAccounts_View.LoadData()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmUserAccounts_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
    End Sub

End Class