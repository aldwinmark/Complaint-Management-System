<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPowerInterruption_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPowerInterruption_Entry))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTimeEnded = New System.Windows.Forms.DateTimePicker()
        Me.dtpTimeStarted = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbxFeederName = New System.Windows.Forms.ComboBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpTimeEnded)
        Me.GroupBox1.Controls.Add(Me.dtpTimeStarted)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbxFeederName)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(530, 402)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Power Interruption Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Time Ended:"
        '
        'dtpTimeEnded
        '
        Me.dtpTimeEnded.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeEnded.Location = New System.Drawing.Point(146, 100)
        Me.dtpTimeEnded.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpTimeEnded.Name = "dtpTimeEnded"
        Me.dtpTimeEnded.Size = New System.Drawing.Size(366, 22)
        Me.dtpTimeEnded.TabIndex = 2
        '
        'dtpTimeStarted
        '
        Me.dtpTimeStarted.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeStarted.Location = New System.Drawing.Point(146, 68)
        Me.dtpTimeStarted.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpTimeStarted.Name = "dtpTimeStarted"
        Me.dtpTimeStarted.Size = New System.Drawing.Size(366, 22)
        Me.dtpTimeStarted.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(35, 135)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Feeder name:"
        '
        'cmbxFeederName
        '
        Me.cmbxFeederName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxFeederName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxFeederName.FormattingEnabled = True
        Me.cmbxFeederName.Items.AddRange(New Object() {"<select>", "3", "2", "1"})
        Me.cmbxFeederName.Location = New System.Drawing.Point(146, 132)
        Me.cmbxFeederName.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbxFeederName.Name = "cmbxFeederName"
        Me.cmbxFeederName.Size = New System.Drawing.Size(366, 24)
        Me.cmbxFeederName.TabIndex = 3
        '
        'txtSource
        '
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSource.Location = New System.Drawing.Point(146, 165)
        Me.txtSource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSource.MaxLength = 500
        Me.txtSource.Multiline = True
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(366, 224)
        Me.txtSource.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(73, 168)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Source:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(87, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(39, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Time Started:"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(146, 36)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(366, 22)
        Me.dtpDate.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(456, 425)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEntry
        '
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEntry.Image = CType(resources.GetObject("btnEntry.Image"), System.Drawing.Image)
        Me.btnEntry.Location = New System.Drawing.Point(357, 425)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(91, 37)
        Me.btnEntry.TabIndex = 1
        Me.btnEntry.Text = "Save"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'frmPowerInterruption_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPowerInterruption_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTimeEnded As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimeStarted As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbxFeederName As System.Windows.Forms.ComboBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
