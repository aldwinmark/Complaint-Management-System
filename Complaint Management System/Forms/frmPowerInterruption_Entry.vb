Imports MySql.Data.MySqlClient

Public Class frmPowerInterruption_Entry

#Region "Functions"

    Public Sub LoadFeederName()
        FillFeederName("SELECT * FROM tblFeederName", Me.cmbxFeederName, "Title")
    End Sub

    Private Sub FillFeederName(ByVal Sqlstring As String, ByVal cmbx As ComboBox, ByVal Field As String)

        cmbx.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        cmbx.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                cmbx.Items.Add(dr(Field))
            Next
        End If
        cmbx.Text = "<select>"
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxFeederName.Text = "<select>" Then
            MessageBox.Show("Please select a feeder name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxFeederName.Focus()
        ElseIf Trim(Me.txtSource.Text).Length = 0 Then
            MessageBox.Show("Please enter a source for the power interruption.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtSource.Focus()
        Else
            If Me.btnEntry.Text = "Save" Then
                'save the data entry
                CheckConnection(cn)

                Dim sqlString As String = "INSERT INTO tblPowerInterruption (DateOccur,TimeEnded,TimeStarted,FeederName,Source) VALUES ('" & Me.dtpDate.Value.ToShortDateString & "','" & Me.dtpTimeStarted.Value.ToShortTimeString & "','" & Me.dtpTimeEnded.Value.ToShortTimeString & "','" & Me.cmbxFeederName.Text & "','" & Me.txtSource.Text & "')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()

                MessageBox.Show("The power interruption schedule has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmPowerInterruption_View.LoadData()
                Me.btnCancel_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub frmPowerInterruption_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
    End Sub

End Class