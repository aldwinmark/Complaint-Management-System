Imports MySql.Data.MySqlClient

Public Class frmRoutingSlip_Entry

#Region "Functions"

    Private Sub clearItemRoute(ByVal ID As Integer)
        'clear item route slip no.
        CheckConnection(cn)

        Dim sqlString As String = "UPDATE tblComplaints SET RoutedNo='' WHERE ID='" & ID & "'"
        Dim cmd As New MySqlCommand(sqlString, cn)
        cmd.ExecuteNonQuery()
    End Sub

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

    Private Sub saveToRoutedSlip(ByVal RoutingNo As String)

        Dim x As Integer

        For x = 0 To Me.lstvwRoutedComplaint.Items.Count - 1
            'save the data entry
            CheckConnection(cn)

            Dim sqlString As String = "UPDATE tblComplaints SET RoutedNo='" & RoutingNo & "' WHERE ID='" & Me.lstvwRoutedComplaint.Items(x).SubItems(0).Text & "'"
            Dim cmd As New MySqlCommand(sqlString, cn)
            cmd.ExecuteNonQuery()
        Next

    End Sub

    Private Function CheckExistItem(ByVal strItem As String, ByVal lstvwto As ListView) As Boolean

        CheckExistItem = False

        Dim x As Integer
        For x = 0 To lstvwto.Items.Count - 1
            If lstvwto.Items(x).SubItems(0).Text = strItem Then
                CheckExistItem = True
            End If
        Next

        Return CheckExistItem

    End Function

#End Region

#Region "Load List"

    Public Sub LoadDataGrid()
        Dim StartDate As String = Me.dtpDate.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Me.dtpDate.Value.ToString("yyyy-MM-dd 24:00:00")

        If Trim(Me.txtSearch.Text.Length) > 0 Then
            FillComplaints("SELECT * FROM tblComplaints WHERE " & getFilterField(Me.cmbxFilter) & " LIKE '%" & Me.txtSearch.Text & "%' AND DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        Else
            FillComplaints("SELECT * FROM tblComplaints WHERE DateReceipt >= '" & StartDate & "' AND DateReceipt <='" & EndDate & "'")
        End If

    End Sub

    Public Sub LoadRoutedComplaints()
        FillComplaintRouted("SELECT * FROM tblComplaints WHERE RoutedNo='" & Me.cmbxRoutingSlip.Text & "'")
    End Sub

    Public Sub LoadRoutingSlipNo()
        FillRoutingSlipNo("SELECT * FROM tblRouteSlip")
    End Sub

#Region "Fill List"

    Private Sub FillComplaintRouted(ByVal Sqlstring As String)

        Me.lstvwRoutedComplaint.Items.Clear()
        ds.Clear()

        da.SelectCommand = New MySqlCommand(Sqlstring, cn)
        cmbldr = New MySqlCommandBuilder(da)

        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Dim MyItem = Me.lstvwRoutedComplaint.Items.Add(dr("ID"), 0) '0
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Priority".ToString)) '1
                    .SubItems.Add(dr("Department_ID".ToString)) '2
                    '.SubItems.Add(dr("Name".ToString)) '3
                    '.SubItems.Add(dr("Address".ToString)) '4
                    '.SubItems.Add(dr("ContactNo".ToString)) '5
                    '.SubItems.Add(dr("NatureOfComplaint".ToString)) '6
                    '.SubItems.Add(dr("DateReceipt".ToString)) '7
                    '.SubItems.Add(dr("ReceivedBy".ToString)) '8
                    '.SubItems.Add(dr("Type".ToString)) '9
                End With
            Next
        End If
    End Sub

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
                End With
            Next
        End If
    End Sub

#End Region

#End Region

    Private Sub frmRoutingSlip_Entry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRoutingSlip_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGlobalBG(Me)
        Me.cmbxFilter.Text = "SR#"
        LoadDataGrid()
        LoadRoutingSlipNo()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim frmlstvw As ListView
        Dim tolstvw As ListView

        frmlstvw = Me.lstvwComplaints
        tolstvw = Me.lstvwRoutedComplaint

        Dim x As Integer
        Dim y As Integer
        For y = 0 To frmlstvw.Items.Count - 1
            If frmlstvw.Items(y).Checked = True Then
                'check if the item already exist in the routed list
                If CheckExistItem(frmlstvw.Items(y).SubItems(0).Text, tolstvw) = False Then
                    Dim MyItem = tolstvw.Items.Add(frmlstvw.Items(y).SubItems(0).Text)
                    MyItem.tag = x
                    x = x + 1
                    With MyItem
                        .SubItems.Add(frmlstvw.Items(y).SubItems(1).Text)
                        .SubItems.Add(frmlstvw.Items(y).SubItems(2).Text)
                    End With
                End If

            End If
        Next

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadDataGrid()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        clearItemRoute(Me.lstvwRoutedComplaint.SelectedItems(0).Text)
        Me.lstvwRoutedComplaint.SelectedItems(0).Remove()
    End Sub

    Private Sub CMSRoutedComplaint_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSRoutedComplaint.Opening

        If Me.lstvwRoutedComplaint.Items.Count > 0 Then
            Me.SaveToolStripMenuItem.Enabled = True
            Me.PrintPreviewToolStripMenuItem.Enabled = True
        Else
            Me.SaveToolStripMenuItem.Enabled = False
            Me.PrintPreviewToolStripMenuItem.Enabled = False
        End If

        If Me.lstvwRoutedComplaint.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btnAddRouteSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRouteSlip.Click
        frmRouteSlip_Add.ShowDialog()
    End Sub

    Private Sub btnDelRouteSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelRouteSlip.Click

        If Me.cmbxRoutingSlip.Text = "<select>" Then
            MessageBox.Show("Please select a route slip #.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxRoutingSlip.Focus()
        Else
            Dim StrSelect As String

            If MessageBox.Show("Are you sure you want to delete route slip # " & Me.cmbxRoutingSlip.Text & "?", "confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                StrSelect = "DELETE FROM tblRouteSlip WHERE ID= '" & Me.cmbxRoutingSlip.Text & "'"

                CheckConnection(cn)

                Dim cmd As New MySqlCommand(StrSelect, cn)

                cmd.ExecuteNonQuery()
                MsgBox("No. " & Me.cmbxRoutingSlip.Text & " has been successfully deleted.", MsgBoxStyle.Information, "Deleted")

                Me.LoadRoutingSlipNo()

            End If
        End If

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

    Private Sub cmbxRoutingSlip_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxRoutingSlip.DropDown
        LoadRoutingSlipNo()
    End Sub

    Private Sub cmbxRoutingSlip_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxRoutingSlip.SelectedIndexChanged
        If Not Me.cmbxRoutingSlip.Text = "<select>" Then
            getRouteDetails(Me.cmbxRoutingSlip.Text)
            LoadRoutedComplaints()
        Else
            Me.lstvwRoutedComplaint.Items.Clear()
            Me.lblDateCreated.Text = ""
            Me.lblSendTo.Text = ""
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If Me.cmbxRoutingSlip.Text = "<select>" Then
            MessageBox.Show("Please select a routing slip #.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxRoutingSlip.Focus()
        Else
            saveToRoutedSlip(Me.cmbxRoutingSlip.Text)
            MessageBox.Show("Complaints successfully updated with route slip #" & Me.cmbxRoutingSlip.Text, "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        With frmPrintPrevRoutingSlip
            .DateCreated = Me.lblDateCreated.Text
            .tmpArea = Me.lblSendTo.Text
            .RoutingSlip = Me.cmbxRoutingSlip.Text
            .ShowDialog()
        End With
    End Sub

End Class