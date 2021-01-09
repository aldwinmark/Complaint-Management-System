Imports MySql.Data.MySqlClient

Public Class frmRouteSlip_Add

#Region "Load List"

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

#Region "Filling List"

    Private Sub FillDepartment(ByVal Sqlstring As String)

        Me.cmbxSendTo.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxSendTo.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxSendTo.Items.Add(dr("Department_ID"))
            Next
        End If
        Me.cmbxSendTo.Text = "<select>"

    End Sub

#End Region

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        If Me.cmbxSendTo.Text = "<select>" Then
            MessageBox.Show("Please select a area/office/dept. to send the complaints.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxSendTo.Focus()
        Else
            'save the data entry
            CheckConnection(cn)

            Dim tmpDate As Date
            Dim FinalDate As String

            tmpDate = Me.dtpCreated.Value
            'FinalDate = tmpDate.Year & "-" & tmpDate.Month & "-" & tmpDate.Day & " " & tmpDate.Hour
            FinalDate = tmpDate.ToString("yyyy-MM-dd HH:mm:ss")

            Dim sqlString As String = "INSERT INTO tblRouteslip (sendTo,DateCreated) VALUES ('" & Me.cmbxSendTo.Text & "','" & FinalDate & "')"
            Dim cmd As New MySqlCommand(sqlString, cn)

            cmd.ExecuteNonQuery()

            MessageBox.Show("The route slip # has been successfully created.", "created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmRoutingSlip_Entry.LoadRoutingSlipNo()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmRouteSlip_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDepartment()
    End Sub

End Class