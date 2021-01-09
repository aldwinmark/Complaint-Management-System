Imports MySql.Data.MySqlClient

Public Class frmComplaint_Entry

    Friend ID As String

#Region "Functions"

#Region "User Functions"

    Public Function GenPicID() As String
        Dim StrSelect As String
FindNext:
        Dim RandomClass As New Random
        Dim code = (RandomClass.Next(9999))

        StrSelect = "SELECT * FROM tblComplaints WHERE PicID = '" & (code) & " '"
        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(StrSelect, cn)

        Dim objReader As MySqlDataReader = cmdSearch.ExecuteReader
        objReader.Read()

        If objReader.HasRows = True Then
            'close the reader
            objReader.Close()
            GoTo FindNext
        Else
            'close the reader
            objReader.Close()
            Return code
        End If

    End Function

#End Region

#Region "Load List"

    Public Sub LoadSearch()
        If Me.rbtnAcct.Checked = True Then
            FillSearch("SELECT * FROM billing WHERE ACCOUNT LIKE '%" & Me.txtSearch.Text & "%' ORDER BY ACCOUNT DESC LIMIT 5")
        ElseIf Me.rbtnName.Checked = True Then
            FillSearch("SELECT * FROM billing WHERE NAME LIKE '" & Me.txtSearch.Text & "%' ORDER BY NAME DESC LIMIT 5")
        Else
            FillSearch("SELECT * FROM billing WHERE METERSN LIKE '" & Me.txtSearch.Text & "%' ORDER BY METERSN DESC LIMIT 5")
        End If
    End Sub

    Public Sub LoadFollowUp()
        FillFollowUp("SELECT * FROM tblFollowUp WHERE SRNo='" & Me.txtServiceNo.Text & "' ORDER BY FUDate DESC")
    End Sub

    Public Sub LoadComplaintType()
        FillComplaintType("SELECT * FROM tblComplaintType")
    End Sub

    Public Sub LoadDepartment()
        FillDepartment("SELECT * FROM tblDepartments")
    End Sub

    Public Sub LoadNatureOfComplaint()
        FillNatureOfComplaint("SELECT * FROM tblNatureOfComplaint ORDER BY Title ASC")
    End Sub

    Public Sub LoadActionDesired()
        FillActionDesired("SELECT * FROM tblActionDesired ORDER BY Title ASC")
    End Sub

#End Region

#Region "Filling List"

    Private Sub FillSearch(ByVal Sqlstring As String)
        Dim Account As String
        Me.lstvwSearch.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, CheckConnection(cnPsion))
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Account = dr("ACCOUNT")
                Dim MyItem = Me.lstvwSearch.Items.Add(Account.Substring(2, 8), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("NAME".ToString)) '1
                    .SubItems.Add(dr("METERSN".ToString)) '2
                    .SubItems.Add(dr("ADDRESS".ToString)) '3
                End With
            Next

            Call listvwColorChange(Me.lstvwSearch)

        End If
    End Sub

    Private Sub FillFollowUp(ByVal Sqlstring As String)

        Me.lstvwFollowUp.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwFollowUp.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("SRNo".ToString)) '1
                    .SubItems.Add(dr("FUDate".ToString)) '1
                    .SubItems.Add(dr("Remarks".ToString)) '2
                End With
            Next

            Call listvwColorChange(Me.lstvwFollowUp)

        End If
    End Sub

    Private Sub FillActionDesired(ByVal Sqlstring As String)

        Me.cmbxAction_Desired.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxAction_Desired.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxAction_Desired.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxAction_Desired.Text = "<select>"

    End Sub

    Private Sub FillComplaintType(ByVal Sqlstring As String)

        Me.cmbxComplaintType.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxComplaintType.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxComplaintType.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxComplaintType.Text = "<select>"

    End Sub

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

    Private Sub FillNatureOfComplaint(ByVal Sqlstring As String)

        Me.cmbxNatureOfComplaint.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxNatureOfComplaint.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxNatureOfComplaint.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxNatureOfComplaint.Text = "<select>"

    End Sub

#End Region

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click

        If Me.txtName.TextLength = 0 Then
            MessageBox.Show("Please enter name of complainant.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtName.Focus()
        ElseIf Me.txtAddress.TextLength = 0 Then
            MessageBox.Show("Please enter address of complainant.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtAddress.Focus()
        ElseIf Me.cmbxSendTo.Text = "<select>" Then
            MessageBox.Show("Please select where to send the complaint.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxSendTo.Focus()
        ElseIf Me.txtContactNo.TextLength = 0 Then
            MessageBox.Show("Please enter contact # of complainant.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtContactNo.Focus()
        ElseIf Me.cmbxPriority.Text = "<select>" Then
            MessageBox.Show("Please select priority for the complaint.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxPriority.Focus()
        ElseIf Me.cmbxNatureOfComplaint.Text = "<select>" Then
            MessageBox.Show("Please select nature of the complaint.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxNatureOfComplaint.Focus()
        ElseIf Me.cmbxAction_Desired.Text = "<select>" Then
            MessageBox.Show("Please select an action desired.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxAction_Desired.Focus()
        ElseIf Me.cmbxComplaintType.Text = "<select>" Then
            MessageBox.Show("Please select a complaint type.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxComplaintType.Focus()
        Else
            Dim sqlString As String

            Dim tmpDate As Date
            Dim tmpTime As Date
            Dim FinalDate As String

            tmpDate = Me.dtpReceipt.Value
            tmpTime = Me.dtpTime.Value
            'FinalDate = tmpDate.Year & "-" & tmpDate.Month & "-" & tmpDate.Day & " " & tmpDate.Hour
            FinalDate = tmpDate.ToString("yyyy-MM-dd") & " " & tmpTime.ToString("HH:mm:ss")

            If Me.btnEntry.Text = "Save" Then
                'save the data entry
                CheckConnection(cn)

                sqlString = "INSERT INTO tblComplaints (Type,Department_ID,Name,Address,ContactNo,NatureOfComplaint,DateReceipt,ActionDesired,ReceivedBy,Priority,AccountNo,MeterNo,EmailAddress,AccountName,ActionTaken) VALUES ('" & Me.cmbxComplaintType.Text & "','" & Me.cmbxSendTo.Text & "','" & Me.txtName.Text & "','" & Me.txtAddress.Text & "','" & Me.txtContactNo.Text & "','" & Me.cmbxNatureOfComplaint.Text & "','" & FinalDate & "','" & Me.cmbxAction_Desired.Text & "','" & frmMain.lblUsername.Text & "','" & Me.cmbxPriority.Text & "','" & Me.txtAccount.Text & "','" & Me.txtMeter.Text & "','" & Me.txtEmail.Text & "','" & Me.txtAccountName.Text & "','')"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("The complaint has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'code for update
                'update the data entry
                CheckConnection(cn)

                sqlString = "UPDATE tblComplaints SET Type='" & Me.cmbxComplaintType.Text & _
                                                                "',Department_ID='" & Me.cmbxSendTo.Text & _
                                                                "',Name='" & Me.txtName.Text & _
                                                                "',Address='" & Me.txtAddress.Text & _
                                                                "',ContactNo='" & Me.txtContactNo.Text & _
                                                                "',NatureOfComplaint='" & Me.cmbxNatureOfComplaint.Text & _
                                                                "',DateReceipt='" & FinalDate & _
                                                                "',ActionDesired='" & Me.cmbxAction_Desired.Text & _
                                                                "',ReceivedBy='" & frmMain.lblUsername.Text & _
                                                                "',Priority='" & Me.cmbxPriority.Text & _
                                                                "',AccountNo='" & Me.txtAccount.Text & _
                                                                "',MeterNo='" & Me.txtMeter.Text & _
                                                                "',EmailAddress='" & Me.txtEmail.Text & _
                                                                "',AccountName='" & Me.txtAccountName.Text & "' WHERE ID='" & ID & "'"
                Dim cmd As New MySqlCommand(sqlString, cn)

                cmd.ExecuteNonQuery()
                MessageBox.Show("The complaint has been successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            frmComplaint_View.LoadDataGrid()
            Me.btnCancel_Click(sender, e)
        End If


    End Sub

    Private Sub cmbxComplaintType_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxComplaintType.DropDown
        LoadComplaintType()
    End Sub

    Private Sub txtAccountName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountName.TextChanged
        Me.txtName.Text = Me.txtAccountName.Text
    End Sub

    Private Sub frmComplaint_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetGlobalBG(Me)
        LoadFollowUp()
        'Me.picCanvas.Image = Image.FromFile("\\192.168.1.254\Complaint Location Pictures\sample.pic")
    End Sub

    Private Sub CMSFollowUp_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSFollowUp.Opening
        If Me.lstvwFollowUp.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.LoadFollowUp()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmFollowUp_Entry
            .btnEntry.Text = "&Save"
            .lblSR.Text = Me.txtServiceNo.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmFollowUp_Entry
            .ID = Me.lstvwFollowUp.SelectedItems(0).Text
            .btnEntry.Text = "&Update"
            .lblSR.Text = Me.txtServiceNo.Text
            .dtpDate.Value = CDate(Me.lstvwFollowUp.SelectedItems(0).SubItems(2).Text)
            .txtRemarks.Text = Me.lstvwFollowUp.SelectedItems(0).SubItems(3).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String

        If MessageBox.Show("Are you sure you want to delete this follow-up?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblFollowUp WHERE ID= '" & Me.lstvwFollowUp.SelectedItems(0).Text & "'"

            CheckConnection(cn)

            Dim cmd As New MySqlCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox("frmFollowUp_Entry-up has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

            Me.LoadFollowUp()

        End If

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            With lstvwSearch
                .Focus()
                .TopItem.Selected = True
                .Items(0).Selected = True
                .Items(0).Focused = True
            End With
        ElseIf e.KeyValue = Keys.Enter And Trim(Me.txtSearch.Text).Length > 0 Then
            Me.lstvwSearch.Visible = True
            Me.lstvwSearch.Height = 100
            LoadSearch()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If Trim(Me.txtSearch.Text).Length <= 0 Then
            Me.lstvwSearch.Visible = False
        End If
    End Sub

    Private Sub lstvwSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstvwSearch.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.txtSearch.Focus()
        ElseIf e.KeyValue = Keys.Enter Then
            Me.txtAccount.Text = Me.lstvwSearch.SelectedItems(0).SubItems(0).Text
            Me.txtAccountName.Text = Me.lstvwSearch.SelectedItems(0).SubItems(1).Text
            Me.txtMeter.Text = Me.lstvwSearch.SelectedItems(0).SubItems(2).Text
            Me.txtName.Text = Me.lstvwSearch.SelectedItems(0).SubItems(1).Text
            Me.txtAddress.Text = Me.lstvwSearch.SelectedItems(0).SubItems(3).Text
            Me.lstvwSearch.Visible = False
            Me.txtAccount.Focus()
        End If
    End Sub

    Private Sub txtAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccount.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.txtSearch.Focus()
        End If
    End Sub

End Class