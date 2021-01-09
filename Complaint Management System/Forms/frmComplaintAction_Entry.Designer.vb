<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComplaintAction_Entry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxActionTaken = New System.Windows.Forms.ComboBox()
        Me.lblDatetimeReceipt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNatureOfComplaint = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbxEmployee = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSRNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxActionTaken)
        Me.GroupBox1.Controls.Add(Me.lblDatetimeReceipt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblNatureOfComplaint)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbxEmployee)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSRNo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(516, 323)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Account Details"
        '
        'cmbxActionTaken
        '
        Me.cmbxActionTaken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxActionTaken.DropDownHeight = 80
        Me.cmbxActionTaken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxActionTaken.DropDownWidth = 337
        Me.cmbxActionTaken.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxActionTaken.FormattingEnabled = True
        Me.cmbxActionTaken.IntegralHeight = False
        Me.cmbxActionTaken.Location = New System.Drawing.Point(171, 281)
        Me.cmbxActionTaken.MaxDropDownItems = 5
        Me.cmbxActionTaken.Name = "cmbxActionTaken"
        Me.cmbxActionTaken.Size = New System.Drawing.Size(329, 24)
        Me.cmbxActionTaken.TabIndex = 34
        '
        'lblDatetimeReceipt
        '
        Me.lblDatetimeReceipt.AutoSize = True
        Me.lblDatetimeReceipt.Location = New System.Drawing.Point(168, 136)
        Me.lblDatetimeReceipt.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDatetimeReceipt.Name = "lblDatetimeReceipt"
        Me.lblDatetimeReceipt.Size = New System.Drawing.Size(332, 16)
        Me.lblDatetimeReceipt.TabIndex = 33
        Me.lblDatetimeReceipt.Text = "---------------------------------------------------------------------------------" & _
            ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 136)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Datetime Receipt:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(168, 63)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(332, 16)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "---------------------------------------------------------------------------------" & _
            ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Complainant Name:"
        '
        'lblNatureOfComplaint
        '
        Me.lblNatureOfComplaint.Location = New System.Drawing.Point(168, 92)
        Me.lblNatureOfComplaint.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNatureOfComplaint.Name = "lblNatureOfComplaint"
        Me.lblNatureOfComplaint.Size = New System.Drawing.Size(333, 38)
        Me.lblNatureOfComplaint.TabIndex = 29
        Me.lblNatureOfComplaint.Text = "---------------------------------------------------------------------------------" & _
            ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nature of Complaint:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 284)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Action/s Taken:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpDateTime)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 46)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'dtpDateTime
        '
        Me.dtpDateTime.CustomFormat = ""
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDateTime.Location = New System.Drawing.Point(7, 15)
        Me.dtpDateTime.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(316, 22)
        Me.dtpDateTime.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Date/Time of Action:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(60, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Dispatch To:"
        '
        'cmbxEmployee
        '
        Me.cmbxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxEmployee.FormattingEnabled = True
        Me.cmbxEmployee.Location = New System.Drawing.Point(171, 163)
        Me.cmbxEmployee.Name = "cmbxEmployee"
        Me.cmbxEmployee.Size = New System.Drawing.Size(330, 24)
        Me.cmbxEmployee.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(23, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Service Request #:"
        '
        'txtSRNo
        '
        Me.txtSRNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSRNo.Enabled = False
        Me.txtSRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRNo.Location = New System.Drawing.Point(170, 31)
        Me.txtSRNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSRNo.Name = "txtSRNo"
        Me.txtSRNo.Size = New System.Drawing.Size(330, 19)
        Me.txtSRNo.TabIndex = 0
        Me.txtSRNo.TabStop = False
        Me.txtSRNo.Text = "Auto Generated"
        Me.txtSRNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(425, 347)
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
        Me.btnEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.Image = Global.Complaint_Management_System.My.Resources.Resources.page_save
        Me.btnEntry.Location = New System.Drawing.Point(318, 347)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(98, 34)
        Me.btnEntry.TabIndex = 1
        Me.btnEntry.Text = "Update"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'frmComplaintAction_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(533, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmComplaintAction_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint Action Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbxEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSRNo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNatureOfComplaint As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDatetimeReceipt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbxActionTaken As System.Windows.Forms.ComboBox
End Class
