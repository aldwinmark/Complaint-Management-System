<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPrevRoutingSlip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPrevRoutingSlip))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPreparedBy = New System.Windows.Forms.Label()
        Me.cmbxPreparedBy = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNotedby = New System.Windows.Forms.Label()
        Me.lblReviewedby = New System.Windows.Forms.Label()
        Me.cmbxReviewedBy = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbxNotedBy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmbxDepartment)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lblPreparedBy)
        Me.GroupBox3.Controls.Add(Me.cmbxPreparedBy)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblNotedby)
        Me.GroupBox3.Controls.Add(Me.lblReviewedby)
        Me.GroupBox3.Controls.Add(Me.cmbxReviewedBy)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbxNotedBy)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 205)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report"
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.Location = New System.Drawing.Point(99, 13)
        Me.lblPreparedBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Size = New System.Drawing.Size(293, 16)
        Me.lblPreparedBy.TabIndex = 35
        Me.lblPreparedBy.Text = "Preparedby"
        Me.lblPreparedBy.Visible = False
        '
        'cmbxPreparedBy
        '
        Me.cmbxPreparedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxPreparedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxPreparedBy.FormattingEnabled = True
        Me.cmbxPreparedBy.Location = New System.Drawing.Point(101, 30)
        Me.cmbxPreparedBy.Name = "cmbxPreparedBy"
        Me.cmbxPreparedBy.Size = New System.Drawing.Size(301, 24)
        Me.cmbxPreparedBy.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Prepared by:"
        '
        'lblNotedby
        '
        Me.lblNotedby.Location = New System.Drawing.Point(99, 108)
        Me.lblNotedby.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNotedby.Name = "lblNotedby"
        Me.lblNotedby.Size = New System.Drawing.Size(293, 16)
        Me.lblNotedby.TabIndex = 32
        Me.lblNotedby.Text = "notedby"
        Me.lblNotedby.Visible = False
        '
        'lblReviewedby
        '
        Me.lblReviewedby.Location = New System.Drawing.Point(99, 58)
        Me.lblReviewedby.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReviewedby.Name = "lblReviewedby"
        Me.lblReviewedby.Size = New System.Drawing.Size(293, 16)
        Me.lblReviewedby.TabIndex = 28
        Me.lblReviewedby.Text = "Reviewedby"
        Me.lblReviewedby.Visible = False
        '
        'cmbxReviewedBy
        '
        Me.cmbxReviewedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxReviewedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxReviewedBy.FormattingEnabled = True
        Me.cmbxReviewedBy.Location = New System.Drawing.Point(101, 75)
        Me.cmbxReviewedBy.Name = "cmbxReviewedBy"
        Me.cmbxReviewedBy.Size = New System.Drawing.Size(301, 24)
        Me.cmbxReviewedBy.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Reviewed by:"
        '
        'cmbxNotedBy
        '
        Me.cmbxNotedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNotedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxNotedBy.FormattingEnabled = True
        Me.cmbxNotedBy.Location = New System.Drawing.Point(102, 123)
        Me.cmbxNotedBy.Name = "cmbxNotedBy"
        Me.cmbxNotedBy.Size = New System.Drawing.Size(300, 24)
        Me.cmbxNotedBy.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(27, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Noted by:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(323, 244)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 34)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEntry
        '
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnEntry.Image = Global.Complaint_Management_System.My.Resources.Resources.printer
        Me.btnEntry.Location = New System.Drawing.Point(189, 244)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(124, 34)
        Me.btnEntry.TabIndex = 1
        Me.btnEntry.Text = "Print Preview"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.Location = New System.Drawing.Point(101, 166)
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(300, 24)
        Me.cmbxDepartment.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Department:"
        '
        'frmPrintPrevRoutingSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrintPrevRoutingSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview Routing Slip"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNotedby As System.Windows.Forms.Label
    Friend WithEvents lblReviewedby As System.Windows.Forms.Label
    Friend WithEvents cmbxReviewedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbxNotedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents lblPreparedBy As System.Windows.Forms.Label
    Friend WithEvents cmbxPreparedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
