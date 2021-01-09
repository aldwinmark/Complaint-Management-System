Imports MySql.Data.MySqlClient

Public Class frmReceivedCompl

#Region "User Functions"

    Private Sub getRouteDetails(ByVal str As String)

        Dim SQL As String
        SQL = "SELECT * FROM tblRouteSlip WHERE ID='" & str & "'"

        CheckConnection(cn)
        Dim cmdSearch As New MySqlCommand(SQL, cn)
        Dim r As MySqlDataReader = cmdSearch.ExecuteReader

        r.Read()
        If r.HasRows = True Then
            Me.lblDateCreated.Text = r("DateCreated").ToString
            Me.lblSendTo.Text = r("SendTo").ToString
        End If
        r.Close()

    End Sub

    Private Sub Checking()

        Dim x As Integer

        For x = 0 To Me.lstvwComplaints.Items.Count - 1
            If Me.lstvwComplaints.Items(x).SubItems(10).Text = 1 Then
                Me.lstvwComplaints.Items(x).Checked = True
            Else
                Me.lstvwComplaints.Items(x).Checked = False
            End If
        Next

    End Sub

    Private Sub updateTransferReceived()

        Dim x As Integer
        Dim sqlString As String

        For x = 0 To Me.lstvwComplaints.Items.Count - 1
            'save the data entry
            CheckConnection(cn)
            If Me.lstvwComplaints.Items(x).Checked = True Then
                sqlString = "UPDATE tblComplaints SET Transferred=" & 1 & " WHERE ID='" & Me.lstvwComplaints.Items(x).SubItems(0).Text & "'"
            Else
                sqlString = "UPDATE tblComplaints SET Transferred=" & 0 & " WHERE ID='" & Me.lstvwComplaints.Items(x).SubItems(0).Text & "'"
            End If

            Dim cmd As New MySqlCommand(sqlString, cn)
            cmd.ExecuteNonQuery()
        Next
        MessageBox.Show("Complaint has been successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#Region "Load List"

    Public Sub LoadRoutingSlipNo()
        FillRoutingSlipNo("SELECT * FROM tblRouteSlip")
    End Sub

    Public Sub LoadData()
        Dim StartDate As String = Me.dtpDate.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpDate.Value.ToString("yyyy-MM-dd 24:00:00")

        If Trim(Me.txtSearch.Text.Length) > 0 Then
            If Me.cmbxRoutingSlip.Text = "<select>" Then
                FillComplaints("SELECT * FROM tblComplaints WHERE " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND RoutedNo<>'' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
            Else
                FillComplaints("SELECT * FROM tblComplaints WHERE " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND RoutedNo='" & Me.cmbxRoutingSlip.Text & "' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
            End If
        Else
            If Me.cmbxRoutingSlip.Text = "<select>" Then
                FillComplaints("SELECT * FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND RoutedNo<>'' AND DateReceipt <='" & EndDate & "'")
            Else
                FillComplaints("SELECT * FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND RoutedNo='" & Me.cmbxRoutingSlip.Text & "' AND DateReceipt <='" & EndDate & "'")
            End If
        End If
        Checking()
    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillRoutingSlipNo(ByVal Sqlstring As String)

        Me.cmbxRoutingSlip.Items.Clear()
        CheckConnection(cn)
        da.SelectCommand = New MySqlCommand(Sqlstring, cn)

        'cmbldr = New MySqlCommandBuilder(da)

        ds.Clear()
        da.Fill(ds)
        Me.cmbxRoutingSlip.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxRoutingSlip.Items.Add(dr("ID"))
            Next
        End If
        Me.cmbxRoutingSlip.Text = "<select>"

    End Sub

    Private Sub FillComplaints(ByVal Sqlstring As String)

        Me.lstvwComplaints.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwComplaints.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Priority".ToString)) '1
                    .SubItems.Add(dr("Department_ID".ToString)) '2
                    .SubItems.Add(dr("Name".ToString)) '3
                    .SubItems.Add(dr("Address".ToString)) '4
                    .SubItems.Add(dr("ContactNo".ToString)) '5
                    .SubItems.Add(dr("NatureOfComplaint".ToString)) '6
                    .SubItems.Add(dr("DateReceipt".ToString)) '7
                    .SubItems.Add(dr("ReceivedBy".ToString)) '8
                    .SubItems.Add(dr("Type".ToString)) '9
                    .SubItems.Add(dr("Transferred".ToString)) '9
                End With
            Next
        End If
    End Sub

#End Region

    Private Sub frmReceivedCompl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        Me.cmbxFilter.Text = "SR#"
        LoadRoutingSlipNo()
        LoadData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub RecieveComplaintsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecieveComplaintsToolStripMenuItem.Click
        updateTransferReceived()
    End Sub

    Private Sub chkbxAll_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkbxAll.CheckStateChanged
        Dim x As Integer
        If Me.chkbxAll.CheckState = CheckState.Checked Then
            For x = 0 To Me.lstvwComplaints.Items.Count - 1
                Me.lstvwComplaints.Items(x).Checked = True
            Next
        Else
            For x = 0 To Me.lstvwComplaints.Items.Count - 1
                Me.lstvwComplaints.Items(x).Checked = False
            Next
        End If
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwComplaints.Items.Count > 0 Then
            Me.RecieveComplaintsToolStripMenuItem.Enabled = True
        Else
            Me.RecieveComplaintsToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub cmbxRoutingSlip_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxRoutingSlip.SelectedIndexChanged
        If Not Me.cmbxRoutingSlip.Text = "<select>" Then
            getRouteDetails(Me.cmbxRoutingSlip.Text)
        Else
            Me.lblDateCreated.Text = ""
            Me.lblSendTo.Text = ""
        End If
    End Sub

End Class