Public Class frmMain

    Private Sub DepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem.Click
        frmDepartment_View.ShowDialog()
    End Sub

    Private Sub NatureOfComplaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NatureOfComplaintToolStripMenuItem.Click
        frmNatureOfComplaint_View.ShowDialog()
    End Sub

    Private Sub UserAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountToolStripMenuItem.Click
        frmUserAccounts_View.ShowDialog()
    End Sub

    Private Sub DesignationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesignationToolStripMenuItem.Click
        frmDesignation_View.ShowDialog()
    End Sub

    Private Sub ComplaintListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintListToolStripMenuItem.Click
        frmComplaint_View.ShowDialog()
    End Sub

    Private Sub RoutingSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoutingSlipToolStripMenuItem.Click
        frmRoutingSlip_Entry.ShowDialog()
    End Sub

    Private Sub AreaComplaintListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaComplaintListToolStripMenuItem.Click
        frmSubCompDesk.ShowDialog()
    End Sub

    Private Sub TroubleshooterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TroubleshooterToolStripMenuItem.Click
        frmEmployee_View.ShowDialog()
    End Sub

    Private Sub ComplaintActionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintActionToolStripMenuItem.Click
        frmComplaintAction.ShowDialog()
    End Sub

    Private Sub ComplaintListToERCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintListToERCToolStripMenuItem.Click
        frmPrintPrevToERC.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim frm As New frmLogin
        'frm.MdiParent = Me
        frmLogin.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.lblUsername.Text = "-----"
        Me.lblUserLevel.Text = "-----"
        Me.lblArea.Text = "-----"
        frmLogin.ShowDialog()
    End Sub

    Private Sub ComplaintTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintTypeToolStripMenuItem.Click
        frmComplaintType_View.ShowDialog()
    End Sub

    Private Sub ReceivedComplaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceivedComplaintToolStripMenuItem.Click
        frmReceivedCompl.ShowDialog()
    End Sub

    Private Sub ComplaintsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintsToolStripMenuItem.Click
        frmComMonitoring.ShowDialog()
    End Sub

    Private Sub PowerInterruptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerInterruptionToolStripMenuItem.Click
        frmPowerInterruption_View.ShowDialog()
    End Sub

    Private Sub ActionDesiredToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionDesiredToolStripMenuItem.Click
        frmActionDesired_View.ShowDialog()
    End Sub

    Private Sub FeederNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeederNameToolStripMenuItem.Click
        frmFeeder_View.ShowDialog()
    End Sub

    Private Sub ActionTakenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTakenToolStripMenuItem.Click
        frmActionTaken_View.ShowDialog()
    End Sub

    Private Sub ComplaintSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintSummaryToolStripMenuItem.Click
        frmPrintPrevComplaintSummary.ShowDialog()
    End Sub

    Private Sub ComplaintByNOCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintByNOCToolStripMenuItem.Click
        frmPrintPrevByNOC.ShowDialog()
    End Sub

    Private Sub WeeklySummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeeklySummaryToolStripMenuItem.Click
        frmPrintPrevWeeklyReport.ShowDialog()
    End Sub
End Class