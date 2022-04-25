<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picGraphics = New System.Windows.Forms.PictureBox()
        Me.pnlGraphics = New System.Windows.Forms.Panel()
        Me.lblSquareSize = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpMatrixSpecs = New System.Windows.Forms.GroupBox()
        Me.chkCross = New System.Windows.Forms.CheckBox()
        Me.chkInnerBox = New System.Windows.Forms.CheckBox()
        Me.chkMiddleBox = New System.Windows.Forms.CheckBox()
        Me.chkOuterBox = New System.Windows.Forms.CheckBox()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudSpeedIncrement = New System.Windows.Forms.NumericUpDown()
        Me.nudMatrixSize = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeedStart = New System.Windows.Forms.NumericUpDown()
        Me.nudLaserStart = New System.Windows.Forms.NumericUpDown()
        Me.nudLaserIncrement = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudTextSpeed = New System.Windows.Forms.NumericUpDown()
        Me.lblTextPower = New System.Windows.Forms.Label()
        Me.nudTextPower = New System.Windows.Forms.NumericUpDown()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.txtGCode = New System.Windows.Forms.TextBox()
        Me.btnToggleText = New System.Windows.Forms.Button()
        Me.tmrOriginUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picGraphics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGraphics.SuspendLayout()
        Me.grpMatrixSpecs.SuspendLayout()
        CType(Me.nudSpeedIncrement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMatrixSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeedStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLaserStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLaserIncrement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudTextSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTextPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGraphics
        '
        Me.picGraphics.BackColor = System.Drawing.SystemColors.Control
        Me.picGraphics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picGraphics.Location = New System.Drawing.Point(2, 2)
        Me.picGraphics.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picGraphics.Name = "picGraphics"
        Me.picGraphics.Size = New System.Drawing.Size(413, 413)
        Me.picGraphics.TabIndex = 0
        Me.picGraphics.TabStop = False
        '
        'pnlGraphics
        '
        Me.pnlGraphics.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGraphics.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlGraphics.Controls.Add(Me.picGraphics)
        Me.pnlGraphics.Location = New System.Drawing.Point(384, 13)
        Me.pnlGraphics.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlGraphics.Name = "pnlGraphics"
        Me.pnlGraphics.Padding = New System.Windows.Forms.Padding(2)
        Me.pnlGraphics.Size = New System.Drawing.Size(417, 417)
        Me.pnlGraphics.TabIndex = 1
        '
        'lblSquareSize
        '
        Me.lblSquareSize.AutoSize = True
        Me.lblSquareSize.Location = New System.Drawing.Point(18, 35)
        Me.lblSquareSize.Name = "lblSquareSize"
        Me.lblSquareSize.Size = New System.Drawing.Size(135, 20)
        Me.lblSquareSize.TabIndex = 1
        Me.lblSquareSize.Text = "Square size [mm]:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Starting laser power [%]:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Laser power increment [%]:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Work speed increment [mm/min]:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Starting work speed [mm/min]:"
        '
        'grpMatrixSpecs
        '
        Me.grpMatrixSpecs.Controls.Add(Me.chkCross)
        Me.grpMatrixSpecs.Controls.Add(Me.chkInnerBox)
        Me.grpMatrixSpecs.Controls.Add(Me.chkMiddleBox)
        Me.grpMatrixSpecs.Controls.Add(Me.chkOuterBox)
        Me.grpMatrixSpecs.Controls.Add(Me.cboOrigin)
        Me.grpMatrixSpecs.Controls.Add(Me.Label6)
        Me.grpMatrixSpecs.Controls.Add(Me.nudSpeedIncrement)
        Me.grpMatrixSpecs.Controls.Add(Me.lblSquareSize)
        Me.grpMatrixSpecs.Controls.Add(Me.Label3)
        Me.grpMatrixSpecs.Controls.Add(Me.nudMatrixSize)
        Me.grpMatrixSpecs.Controls.Add(Me.nudSpeedStart)
        Me.grpMatrixSpecs.Controls.Add(Me.Label1)
        Me.grpMatrixSpecs.Controls.Add(Me.Label4)
        Me.grpMatrixSpecs.Controls.Add(Me.nudLaserStart)
        Me.grpMatrixSpecs.Controls.Add(Me.nudLaserIncrement)
        Me.grpMatrixSpecs.Controls.Add(Me.Label2)
        Me.grpMatrixSpecs.Location = New System.Drawing.Point(12, 15)
        Me.grpMatrixSpecs.Name = "grpMatrixSpecs"
        Me.grpMatrixSpecs.Size = New System.Drawing.Size(358, 293)
        Me.grpMatrixSpecs.TabIndex = 0
        Me.grpMatrixSpecs.TabStop = False
        Me.grpMatrixSpecs.Text = "Test Grid"
        '
        'chkCross
        '
        Me.chkCross.AutoSize = True
        Me.chkCross.Checked = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.DrawCrossMark
        Me.chkCross.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCross.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "DrawCrossMark", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkCross.Location = New System.Drawing.Point(22, 259)
        Me.chkCross.Name = "chkCross"
        Me.chkCross.Size = New System.Drawing.Size(108, 24)
        Me.chkCross.TabIndex = 16
        Me.chkCross.Text = "Cross mark"
        Me.chkCross.UseVisualStyleBackColor = True
        '
        'chkInnerBox
        '
        Me.chkInnerBox.AutoSize = True
        Me.chkInnerBox.Checked = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.DrawInnerBox
        Me.chkInnerBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInnerBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "DrawInnerBox", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkInnerBox.Location = New System.Drawing.Point(246, 229)
        Me.chkInnerBox.Name = "chkInnerBox"
        Me.chkInnerBox.Size = New System.Drawing.Size(94, 24)
        Me.chkInnerBox.TabIndex = 15
        Me.chkInnerBox.Text = "Inner box"
        Me.chkInnerBox.UseVisualStyleBackColor = True
        '
        'chkMiddleBox
        '
        Me.chkMiddleBox.AutoSize = True
        Me.chkMiddleBox.Checked = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.DrawMiddleBox
        Me.chkMiddleBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMiddleBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "DrawMiddleBox", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkMiddleBox.Location = New System.Drawing.Point(131, 229)
        Me.chkMiddleBox.Name = "chkMiddleBox"
        Me.chkMiddleBox.Size = New System.Drawing.Size(103, 24)
        Me.chkMiddleBox.TabIndex = 14
        Me.chkMiddleBox.Text = "Middle box"
        Me.chkMiddleBox.UseVisualStyleBackColor = True
        '
        'chkOuterBox
        '
        Me.chkOuterBox.AutoSize = True
        Me.chkOuterBox.Checked = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.DrawOuterBox
        Me.chkOuterBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOuterBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "DrawOuterBox", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkOuterBox.Location = New System.Drawing.Point(22, 229)
        Me.chkOuterBox.Name = "chkOuterBox"
        Me.chkOuterBox.Size = New System.Drawing.Size(97, 24)
        Me.chkOuterBox.TabIndex = 13
        Me.chkOuterBox.Text = "Outer box"
        Me.chkOuterBox.UseVisualStyleBackColor = True
        '
        'cboOrigin
        '
        Me.cboOrigin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "MatrixWorkOriginCorner", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cboOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Items.AddRange(New Object() {"BL", "BR", "TL", "TR", "CTR"})
        Me.cboOrigin.Location = New System.Drawing.Point(266, 192)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(74, 28)
        Me.cboOrigin.TabIndex = 12
        Me.cboOrigin.Text = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.MatrixWorkOriginCorner
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Matrix work origin corner:"
        '
        'nudSpeedIncrement
        '
        Me.nudSpeedIncrement.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "LaserSpeedIncrement", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudSpeedIncrement.Location = New System.Drawing.Point(266, 160)
        Me.nudSpeedIncrement.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudSpeedIncrement.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSpeedIncrement.Name = "nudSpeedIncrement"
        Me.nudSpeedIncrement.Size = New System.Drawing.Size(74, 26)
        Me.nudSpeedIncrement.TabIndex = 10
        Me.nudSpeedIncrement.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.LaserSpeedIncrement
        '
        'nudMatrixSize
        '
        Me.nudMatrixSize.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "SquareSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudMatrixSize.Location = New System.Drawing.Point(266, 32)
        Me.nudMatrixSize.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMatrixSize.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudMatrixSize.Name = "nudMatrixSize"
        Me.nudMatrixSize.Size = New System.Drawing.Size(74, 26)
        Me.nudMatrixSize.TabIndex = 2
        Me.nudMatrixSize.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.SquareSize
        '
        'nudSpeedStart
        '
        Me.nudSpeedStart.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "LaserSpeedStart", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudSpeedStart.Location = New System.Drawing.Point(266, 128)
        Me.nudSpeedStart.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.nudSpeedStart.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSpeedStart.Name = "nudSpeedStart"
        Me.nudSpeedStart.Size = New System.Drawing.Size(74, 26)
        Me.nudSpeedStart.TabIndex = 8
        Me.nudSpeedStart.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.LaserSpeedStart
        '
        'nudLaserStart
        '
        Me.nudLaserStart.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "LaserPowerStart", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudLaserStart.Location = New System.Drawing.Point(266, 64)
        Me.nudLaserStart.Maximum = New Decimal(New Integer() {91, 0, 0, 0})
        Me.nudLaserStart.Name = "nudLaserStart"
        Me.nudLaserStart.Size = New System.Drawing.Size(74, 26)
        Me.nudLaserStart.TabIndex = 4
        Me.nudLaserStart.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.LaserPowerStart
        '
        'nudLaserIncrement
        '
        Me.nudLaserIncrement.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "LaserPowerIncrement", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudLaserIncrement.Location = New System.Drawing.Point(266, 96)
        Me.nudLaserIncrement.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudLaserIncrement.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLaserIncrement.Name = "nudLaserIncrement"
        Me.nudLaserIncrement.Size = New System.Drawing.Size(74, 26)
        Me.nudLaserIncrement.TabIndex = 6
        Me.nudLaserIncrement.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.LaserPowerIncrement
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudTextSpeed)
        Me.GroupBox1.Controls.Add(Me.lblTextPower)
        Me.GroupBox1.Controls.Add(Me.nudTextPower)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 104)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text Laser Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Text speed [mm/min]:"
        '
        'nudTextSpeed
        '
        Me.nudTextSpeed.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "TextLaserSpeed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudTextSpeed.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudTextSpeed.Location = New System.Drawing.Point(266, 32)
        Me.nudTextSpeed.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudTextSpeed.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudTextSpeed.Name = "nudTextSpeed"
        Me.nudTextSpeed.Size = New System.Drawing.Size(74, 26)
        Me.nudTextSpeed.TabIndex = 20
        Me.nudTextSpeed.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.TextLaserSpeed
        '
        'lblTextPower
        '
        Me.lblTextPower.AutoSize = True
        Me.lblTextPower.Location = New System.Drawing.Point(18, 67)
        Me.lblTextPower.Name = "lblTextPower"
        Me.lblTextPower.Size = New System.Drawing.Size(154, 20)
        Me.lblTextPower.TabIndex = 21
        Me.lblTextPower.Text = "Text laser power [%]:"
        '
        'nudTextPower
        '
        Me.nudTextPower.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default, "TextLaserPower", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudTextPower.Location = New System.Drawing.Point(266, 64)
        Me.nudTextPower.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTextPower.Name = "nudTextPower"
        Me.nudTextPower.Size = New System.Drawing.Size(74, 26)
        Me.nudTextPower.TabIndex = 22
        Me.nudTextPower.Value = Global.Snapmaker_Laser_Test_Grid.My.MySettings.Default.TextLaserPower
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.ImageIndex = 1
        Me.btnExport.ImageList = Me.imgIcons
        Me.btnExport.Location = New System.Drawing.Point(674, 444)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(126, 39)
        Me.btnExport.TabIndex = 26
        Me.btnExport.Text = "Save gCode"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'imgIcons
        '
        Me.imgIcons.ImageStream = CType(resources.GetObject("imgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIcons.Images.SetKeyName(0, "Copy")
        Me.imgIcons.Images.SetKeyName(1, "Save")
        Me.imgIcons.Images.SetKeyName(2, "Close")
        Me.imgIcons.Images.SetKeyName(3, "Preview")
        '
        'txtGCode
        '
        Me.txtGCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGCode.Location = New System.Drawing.Point(0, 13)
        Me.txtGCode.Multiline = True
        Me.txtGCode.Name = "txtGCode"
        Me.txtGCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGCode.Size = New System.Drawing.Size(10, 418)
        Me.txtGCode.TabIndex = 16
        Me.txtGCode.Visible = False
        '
        'btnToggleText
        '
        Me.btnToggleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnToggleText.Location = New System.Drawing.Point(12, 444)
        Me.btnToggleText.Name = "btnToggleText"
        Me.btnToggleText.Size = New System.Drawing.Size(110, 39)
        Me.btnToggleText.TabIndex = 23
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UseVisualStyleBackColor = True
        Me.btnToggleText.Visible = False
        '
        'tmrOriginUpdate
        '
        Me.tmrOriginUpdate.Interval = 15
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.ImageIndex = 0
        Me.btnCopy.ImageList = Me.imgIcons
        Me.btnCopy.Location = New System.Drawing.Point(384, 444)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(126, 39)
        Me.btnCopy.TabIndex = 24
        Me.btnCopy.Text = "Copy gCode"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.ImageIndex = 3
        Me.btnPreview.ImageList = Me.imgIcons
        Me.btnPreview.Location = New System.Drawing.Point(520, 444)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(144, 39)
        Me.btnPreview.TabIndex = 25
        Me.btnPreview.Text = "Preview gCode"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'dlgSave
        '
        Me.dlgSave.CheckFileExists = True
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 495)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.txtGCode)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpMatrixSpecs)
        Me.Controls.Add(Me.pnlGraphics)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#"
        CType(Me.picGraphics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGraphics.ResumeLayout(False)
        Me.grpMatrixSpecs.ResumeLayout(False)
        Me.grpMatrixSpecs.PerformLayout()
        CType(Me.nudSpeedIncrement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMatrixSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeedStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLaserStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLaserIncrement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudTextSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTextPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGraphics As PictureBox
    Friend WithEvents pnlGraphics As Panel
    Friend WithEvents lblSquareSize As Label
    Friend WithEvents nudMatrixSize As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudLaserStart As NumericUpDown
    Friend WithEvents nudLaserIncrement As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nudSpeedIncrement As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudSpeedStart As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents grpMatrixSpecs As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudTextSpeed As NumericUpDown
    Friend WithEvents lblTextPower As Label
    Friend WithEvents nudTextPower As NumericUpDown
    Friend WithEvents cboOrigin As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents txtGCode As TextBox
    Friend WithEvents btnToggleText As Button
    Friend WithEvents chkMiddleBox As CheckBox
    Friend WithEvents chkOuterBox As CheckBox
    Friend WithEvents chkInnerBox As CheckBox
    Friend WithEvents chkCross As CheckBox
    Friend WithEvents tmrOriginUpdate As Timer
    Friend WithEvents imgIcons As ImageList
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents errProvider As ErrorProvider
End Class
