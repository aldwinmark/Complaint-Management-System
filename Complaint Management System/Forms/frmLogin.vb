Imports MySql.Data.MySqlClient

Public Class frmLogin

#Region "User Functions"

    Private Sub verifyUserAccount(ByVal username As String, ByVal password As String)

        Dim SQL As String
        SQL = "SELECT * FROM tblUserAccount WHERE Username='" & username & "' and Password='" & password & "'"

        CheckConnection(cn)
        Dim cmd As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmd.ExecuteReader

        r.Read()
        If r.HasRows = False Then
            MessageBox.Show("Please enter a valid Username or Paswword.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUsername.Clear()
            Me.txtPassword.Clear()
            Me.cmbxDepartment.Text = "<select>"
            Me.txtUsername.Focus()
        Else
            With frmMain
                .lblEmployeeName.Text = r("Name")
                .lblUserLevel.Text = r("UserLevel")
                .lblArea.Text = Me.cmbxDepartment.Text
                .lblUsername.Text = username

                If r("UserLevel") = 1 Then
                    frmMain.MaintenanceToolStripMenuItem.Enabled = True
                Else
                    frmMain.MaintenanceToolStripMenuItem.Enabled = False
                End If

                Me.Close()
                Me.Dispose()
            End With
        End If

        r.Close()

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

#Region "Load Functions"

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If Trim(Me.txtUsername.Text).Length = 0 Then
            MessageBox.Show("Please enter a valid username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUsername.Clear()
            Me.txtUsername.Focus()
        ElseIf Trim(Me.txtPassword.Text).Length = 0 Then
            MessageBox.Show("Please enter a valid password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPassword.Clear()
            Me.txtPassword.Focus()
        ElseIf Me.cmbxDepartment.Text = "<select>" Then
            MessageBox.Show("Please select a department.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxDepartment.Focus()
        Else
            verifyUserAccount(Me.txtUsername.Text, Me.txtPassword.Text)
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        CheckConnection(cn)
        LoadDepartment()
        'start the process of copying the bcadjhc4.dbf
        System.Diagnostics.Process.Start(Application.StartupPath & "\Update.bat")

        'Me.txtUsername.Text = "mark"
        'Me.txtPassword.Text = "mark"
        'Me.cmbxDepartment.Text = "MISDP"

    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.cmbxDepartment.Focus()
        End If
    End Sub

    Private Sub cmbxDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbxDepartment.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.btnEnter.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("\\192.168.1.254\Complaint Location Pictures\sample.pdf")
    End Sub

End Class