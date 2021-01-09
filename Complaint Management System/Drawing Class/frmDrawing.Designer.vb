<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    'Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    '    Me.components = New System.ComponentModel.Container()
    '    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrawing))
    '    Me.picCanvas = New System.Windows.Forms.PictureBox()
    '    Me.ToolBar1 = New System.Windows.Forms.ToolBar()
    '    Me.tbtnPointer = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnLine = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnRectangle = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnEllipse = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnStar = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnImage = New System.Windows.Forms.ToolBarButton()
    '    Me.tbarSep1 = New System.Windows.Forms.ToolBarButton()
    '    Me.tcboThickness = New System.Windows.Forms.ToolBarButton()
    '    Me.tcboLineColor = New System.Windows.Forms.ToolBarButton()
    '    Me.tcboFillColor = New System.Windows.Forms.ToolBarButton()
    '    Me.tbarSep2 = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnBringToFront = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnSendToBack = New System.Windows.Forms.ToolBarButton()
    '    Me.tbtnDelete = New System.Windows.Forms.ToolBarButton()
    '    Me.imlToolbarButtons = New System.Windows.Forms.ImageList(Me.components)
    '    CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.SuspendLayout()
    '    '
    '    'picCanvas
    '    '
    '    Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
    '    Me.picCanvas.Location = New System.Drawing.Point(0, 0)
    '    Me.picCanvas.Name = "picCanvas"
    '    Me.picCanvas.Size = New System.Drawing.Size(507, 362)
    '    Me.picCanvas.TabIndex = 1
    '    Me.picCanvas.TabStop = False
    '    '
    '    'ToolBar1
    '    '
    '    Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbtnPointer, Me.tbtnLine, Me.tbtnRectangle, Me.tbtnEllipse, Me.tbtnStar, Me.tbtnImage, Me.tbarSep1, Me.tcboThickness, Me.tcboLineColor, Me.tcboFillColor, Me.tbarSep2, Me.tbtnBringToFront, Me.tbtnSendToBack, Me.tbtnDelete})
    '    Me.ToolBar1.DropDownArrows = True
    '    Me.ToolBar1.ImageList = Me.imlToolbarButtons
    '    Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
    '    Me.ToolBar1.Name = "ToolBar1"
    '    Me.ToolBar1.ShowToolTips = True
    '    Me.ToolBar1.Size = New System.Drawing.Size(507, 28)
    '    Me.ToolBar1.TabIndex = 2
    '    '
    '    'tbtnPointer
    '    '
    '    Me.tbtnPointer.ImageIndex = 0
    '    Me.tbtnPointer.Name = "tbtnPointer"
    '    Me.tbtnPointer.Pushed = True
    '    Me.tbtnPointer.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    '    Me.tbtnPointer.ToolTipText = "Pointer"
    '    '
    '    'tbtnLine
    '    '
    '    Me.tbtnLine.ImageIndex = 1
    '    Me.tbtnLine.Name = "tbtnLine"
    '    Me.tbtnLine.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    '    Me.tbtnLine.ToolTipText = "Line"
    '    '
    '    'tbtnRectangle
    '    '
    '    Me.tbtnRectangle.ImageIndex = 2
    '    Me.tbtnRectangle.Name = "tbtnRectangle"
    '    Me.tbtnRectangle.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    '    Me.tbtnRectangle.ToolTipText = "Rectangle"
    '    '
    '    'tbtnEllipse
    '    '
    '    Me.tbtnEllipse.ImageIndex = 3
    '    Me.tbtnEllipse.Name = "tbtnEllipse"
    '    Me.tbtnEllipse.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    '    Me.tbtnEllipse.ToolTipText = "Ellipse"
    '    '
    '    'tbtnStar
    '    '
    '    Me.tbtnStar.ImageIndex = 4
    '    Me.tbtnStar.Name = "tbtnStar"
    '    Me.tbtnStar.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    '    Me.tbtnStar.ToolTipText = "Star"
    '    '
    '    'tbtnImage
    '    '
    '    Me.tbtnImage.ImageIndex = 8
    '    Me.tbtnImage.Name = "tbtnImage"
    '    Me.tbtnImage.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
    '    Me.tbtnImage.ToolTipText = "Image"
    '    '
    '    'tbarSep1
    '    '
    '    Me.tbarSep1.Name = "tbarSep1"
    '    Me.tbarSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '    '
    '    'tcboThickness
    '    '
    '    Me.tcboThickness.Name = "tcboThickness"
    '    Me.tcboThickness.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    '    Me.tcboThickness.ToolTipText = "Line thickness"
    '    '
    '    'tcboLineColor
    '    '
    '    Me.tcboLineColor.Name = "tcboLineColor"
    '    Me.tcboLineColor.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    '    Me.tcboLineColor.ToolTipText = "Line color"
    '    '
    '    'tcboFillColor
    '    '
    '    Me.tcboFillColor.Name = "tcboFillColor"
    '    Me.tcboFillColor.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
    '    Me.tcboFillColor.ToolTipText = "Fill color"
    '    '
    '    'tbarSep2
    '    '
    '    Me.tbarSep2.Name = "tbarSep2"
    '    Me.tbarSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '    '
    '    'tbtnBringToFront
    '    '
    '    Me.tbtnBringToFront.ImageIndex = 5
    '    Me.tbtnBringToFront.Name = "tbtnBringToFront"
    '    Me.tbtnBringToFront.ToolTipText = "Bring To Front"
    '    '
    '    'tbtnSendToBack
    '    '
    '    Me.tbtnSendToBack.ImageIndex = 6
    '    Me.tbtnSendToBack.Name = "tbtnSendToBack"
    '    Me.tbtnSendToBack.ToolTipText = "Send To Back"
    '    '
    '    'tbtnDelete
    '    '
    '    Me.tbtnDelete.ImageIndex = 7
    '    Me.tbtnDelete.Name = "tbtnDelete"
    '    Me.tbtnDelete.ToolTipText = "Delete"
    '    '
    '    'imlToolbarButtons
    '    '
    '    Me.imlToolbarButtons.ImageStream = CType(resources.GetObject("imlToolbarButtons.ImageStream"), System.Windows.Forms.ImageListStreamer)
    '    Me.imlToolbarButtons.TransparentColor = System.Drawing.Color.Transparent
    '    Me.imlToolbarButtons.Images.SetKeyName(0, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(1, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(2, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(3, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(4, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(5, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(6, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(7, "")
    '    Me.imlToolbarButtons.Images.SetKeyName(8, "tbtnImage.bmp")
    '    '
    '    'frmDrawing
    '    '
    '    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.ClientSize = New System.Drawing.Size(507, 362)
    '    Me.Controls.Add(Me.ToolBar1)
    '    Me.Controls.Add(Me.picCanvas)
    '    Me.Name = "frmDrawing"
    '    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    '    Me.Text = "Location Drawing"
    '    CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub
    'Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents tbtnPointer As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnLine As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnRectangle As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnEllipse As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnStar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnImage As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbarSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tcboThickness As System.Windows.Forms.ToolBarButton
    Friend WithEvents tcboLineColor As System.Windows.Forms.ToolBarButton
    Friend WithEvents tcboFillColor As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbarSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnBringToFront As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnSendToBack As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents imlToolbarButtons As System.Windows.Forms.ImageList
    Friend WithEvents tbtnText As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtInputText As System.Windows.Forms.TextBox
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents txtInputString As System.Windows.Forms.TextBox
    Friend WithEvents pcbxImage As System.Windows.Forms.PictureBox
    Friend WithEvents cmbxFontSize As System.Windows.Forms.ComboBox
End Class
