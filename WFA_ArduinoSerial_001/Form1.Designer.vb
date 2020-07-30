<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.receivedData_head_LBL = New System.Windows.Forms.Label()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.refreshCOM_CB_BTN = New System.Windows.Forms.Button()
        Me.send_TB = New System.Windows.Forms.TextBox()
        Me.send_BTN = New System.Windows.Forms.Button()
        Me.connecting_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.UpDn_GB = New System.Windows.Forms.GroupBox()
        Me.Down_RB = New System.Windows.Forms.RadioButton()
        Me.Up_RB = New System.Windows.Forms.RadioButton()
        Me.SetSpeed_TB = New System.Windows.Forms.TextBox()
        Me.SetHeight_TB = New System.Windows.Forms.TextBox()
        Me.SetDir_BTN = New System.Windows.Forms.Button()
        Me.SetSpeed_BTN = New System.Windows.Forms.Button()
        Me.SetHeight_BTN = New System.Windows.Forms.Button()
        Me.Run_BTN = New System.Windows.Forms.Button()
        Me.Halt_BTN = New System.Windows.Forms.Button()
        Me.AutoUp_BTN = New System.Windows.Forms.Button()
        Me.AutoDown_BTN = New System.Windows.Forms.Button()
        Me.GetHeight_BTN = New System.Windows.Forms.Button()
        Me.GetSpeed_BTN = New System.Windows.Forms.Button()
        Me.GetDir_BTN = New System.Windows.Forms.Button()
        Me.GetNowHt_BTN = New System.Windows.Forms.Button()
        Me.GroupingBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.UpDn_GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(68, 66)
        Me.comPort_ComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(180, 28)
        Me.comPort_ComboBox.TabIndex = 1
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(99, 31)
        Me.COMport_LBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(119, 29)
        Me.COMport_LBL.TabIndex = 17
        Me.COMport_LBL.Text = "COM Port"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(456, 152)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(342, 767)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
        '
        'receivedData_head_LBL
        '
        Me.receivedData_head_LBL.AutoSize = True
        Me.receivedData_head_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receivedData_head_LBL.Location = New System.Drawing.Point(490, 118)
        Me.receivedData_head_LBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.receivedData_head_LBL.Name = "receivedData_head_LBL"
        Me.receivedData_head_LBL.Size = New System.Drawing.Size(288, 29)
        Me.receivedData_head_LBL.TabIndex = 22
        Me.receivedData_head_LBL.Text = "Received from Moto-Mast"
        '
        'clear_BTN
        '
        Me.clear_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_BTN.Location = New System.Drawing.Point(575, 929)
        Me.clear_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(112, 46)
        Me.clear_BTN.TabIndex = 10
        Me.clear_BTN.Text = "Clear"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(272, 58)
        Me.connect_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(180, 46)
        Me.connect_BTN.TabIndex = 3
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(294, 25)
        Me.Timer_LBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(138, 29)
        Me.Timer_LBL.TabIndex = 24
        Me.Timer_LBL.Text = "Timer: OFF"
        Me.Timer_LBL.Visible = False
        '
        'refreshCOM_CB_BTN
        '
        Me.refreshCOM_CB_BTN.Location = New System.Drawing.Point(21, 63)
        Me.refreshCOM_CB_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.refreshCOM_CB_BTN.Name = "refreshCOM_CB_BTN"
        Me.refreshCOM_CB_BTN.Size = New System.Drawing.Size(38, 38)
        Me.refreshCOM_CB_BTN.TabIndex = 2
        Me.refreshCOM_CB_BTN.Text = "R"
        Me.refreshCOM_CB_BTN.UseVisualStyleBackColor = True
        '
        'send_TB
        '
        Me.send_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send_TB.Location = New System.Drawing.Point(21, 1025)
        Me.send_TB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.send_TB.Name = "send_TB"
        Me.send_TB.Size = New System.Drawing.Size(466, 30)
        Me.send_TB.TabIndex = 54
        '
        'send_BTN
        '
        Me.send_BTN.Location = New System.Drawing.Point(495, 1025)
        Me.send_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.send_BTN.Name = "send_BTN"
        Me.send_BTN.Size = New System.Drawing.Size(112, 35)
        Me.send_BTN.TabIndex = 55
        Me.send_BTN.Text = "Send"
        Me.send_BTN.UseVisualStyleBackColor = True
        '
        'connecting_Timer
        '
        Me.connecting_Timer.Interval = 250
        '
        'UpDn_GB
        '
        Me.UpDn_GB.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.UpDn_GB.Controls.Add(Me.Down_RB)
        Me.UpDn_GB.Controls.Add(Me.Up_RB)
        Me.UpDn_GB.Location = New System.Drawing.Point(172, 315)
        Me.UpDn_GB.Name = "UpDn_GB"
        Me.UpDn_GB.Size = New System.Drawing.Size(148, 62)
        Me.UpDn_GB.TabIndex = 66
        Me.UpDn_GB.TabStop = False
        '
        'Down_RB
        '
        Me.Down_RB.AutoSize = True
        Me.Down_RB.Location = New System.Drawing.Point(62, 20)
        Me.Down_RB.Name = "Down_RB"
        Me.Down_RB.Size = New System.Drawing.Size(75, 24)
        Me.Down_RB.TabIndex = 59
        Me.Down_RB.TabStop = True
        Me.Down_RB.Text = "Down"
        Me.Down_RB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Down_RB.UseVisualStyleBackColor = True
        '
        'Up_RB
        '
        Me.Up_RB.AutoSize = True
        Me.Up_RB.Location = New System.Drawing.Point(0, 20)
        Me.Up_RB.Name = "Up_RB"
        Me.Up_RB.Size = New System.Drawing.Size(55, 24)
        Me.Up_RB.TabIndex = 58
        Me.Up_RB.TabStop = True
        Me.Up_RB.Text = "Up"
        Me.Up_RB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Up_RB.UseVisualStyleBackColor = True
        '
        'SetSpeed_TB
        '
        Me.SetSpeed_TB.Location = New System.Drawing.Point(172, 279)
        Me.SetSpeed_TB.Name = "SetSpeed_TB"
        Me.SetSpeed_TB.Size = New System.Drawing.Size(70, 26)
        Me.SetSpeed_TB.TabIndex = 65
        '
        'SetHeight_TB
        '
        Me.SetHeight_TB.Location = New System.Drawing.Point(172, 222)
        Me.SetHeight_TB.Name = "SetHeight_TB"
        Me.SetHeight_TB.Size = New System.Drawing.Size(70, 26)
        Me.SetHeight_TB.TabIndex = 64
        '
        'SetDir_BTN
        '
        Me.SetDir_BTN.Location = New System.Drawing.Point(36, 330)
        Me.SetDir_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SetDir_BTN.Name = "SetDir_BTN"
        Me.SetDir_BTN.Size = New System.Drawing.Size(130, 35)
        Me.SetDir_BTN.TabIndex = 63
        Me.SetDir_BTN.Text = "Direction"
        Me.SetDir_BTN.UseVisualStyleBackColor = True
        '
        'SetSpeed_BTN
        '
        Me.SetSpeed_BTN.Location = New System.Drawing.Point(36, 275)
        Me.SetSpeed_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SetSpeed_BTN.Name = "SetSpeed_BTN"
        Me.SetSpeed_BTN.Size = New System.Drawing.Size(130, 35)
        Me.SetSpeed_BTN.TabIndex = 62
        Me.SetSpeed_BTN.Text = "Set Speed"
        Me.SetSpeed_BTN.UseVisualStyleBackColor = True
        '
        'SetHeight_BTN
        '
        Me.SetHeight_BTN.Location = New System.Drawing.Point(36, 218)
        Me.SetHeight_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SetHeight_BTN.Name = "SetHeight_BTN"
        Me.SetHeight_BTN.Size = New System.Drawing.Size(130, 35)
        Me.SetHeight_BTN.TabIndex = 61
        Me.SetHeight_BTN.Text = "Set Height"
        Me.SetHeight_BTN.UseVisualStyleBackColor = True
        '
        'Run_BTN
        '
        Me.Run_BTN.Location = New System.Drawing.Point(36, 416)
        Me.Run_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Run_BTN.Name = "Run_BTN"
        Me.Run_BTN.Size = New System.Drawing.Size(130, 35)
        Me.Run_BTN.TabIndex = 67
        Me.Run_BTN.Text = "Run"
        Me.Run_BTN.UseVisualStyleBackColor = True
        '
        'Halt_BTN
        '
        Me.Halt_BTN.Location = New System.Drawing.Point(36, 472)
        Me.Halt_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Halt_BTN.Name = "Halt_BTN"
        Me.Halt_BTN.Size = New System.Drawing.Size(130, 35)
        Me.Halt_BTN.TabIndex = 68
        Me.Halt_BTN.Text = "HALT"
        Me.Halt_BTN.UseVisualStyleBackColor = True
        '
        'AutoUp_BTN
        '
        Me.AutoUp_BTN.Location = New System.Drawing.Point(36, 528)
        Me.AutoUp_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AutoUp_BTN.Name = "AutoUp_BTN"
        Me.AutoUp_BTN.Size = New System.Drawing.Size(130, 35)
        Me.AutoUp_BTN.TabIndex = 69
        Me.AutoUp_BTN.Text = "Auto-Up"
        Me.AutoUp_BTN.UseVisualStyleBackColor = True
        '
        'AutoDown_BTN
        '
        Me.AutoDown_BTN.Location = New System.Drawing.Point(36, 584)
        Me.AutoDown_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AutoDown_BTN.Name = "AutoDown_BTN"
        Me.AutoDown_BTN.Size = New System.Drawing.Size(130, 35)
        Me.AutoDown_BTN.TabIndex = 70
        Me.AutoDown_BTN.Text = "Auto-Down"
        Me.AutoDown_BTN.UseVisualStyleBackColor = True
        '
        'GetHeight_BTN
        '
        Me.GetHeight_BTN.Location = New System.Drawing.Point(36, 672)
        Me.GetHeight_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GetHeight_BTN.Name = "GetHeight_BTN"
        Me.GetHeight_BTN.Size = New System.Drawing.Size(130, 35)
        Me.GetHeight_BTN.TabIndex = 71
        Me.GetHeight_BTN.Text = "Get Set Height"
        Me.GetHeight_BTN.UseVisualStyleBackColor = True
        '
        'GetSpeed_BTN
        '
        Me.GetSpeed_BTN.Location = New System.Drawing.Point(36, 849)
        Me.GetSpeed_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GetSpeed_BTN.Name = "GetSpeed_BTN"
        Me.GetSpeed_BTN.Size = New System.Drawing.Size(130, 35)
        Me.GetSpeed_BTN.TabIndex = 72
        Me.GetSpeed_BTN.Text = "Get Speed"
        Me.GetSpeed_BTN.UseVisualStyleBackColor = True
        '
        'GetDir_BTN
        '
        Me.GetDir_BTN.Location = New System.Drawing.Point(36, 792)
        Me.GetDir_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GetDir_BTN.Name = "GetDir_BTN"
        Me.GetDir_BTN.Size = New System.Drawing.Size(130, 35)
        Me.GetDir_BTN.TabIndex = 73
        Me.GetDir_BTN.Text = "Get Direction"
        Me.GetDir_BTN.UseVisualStyleBackColor = True
        '
        'GetNowHt_BTN
        '
        Me.GetNowHt_BTN.Location = New System.Drawing.Point(36, 735)
        Me.GetNowHt_BTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GetNowHt_BTN.Name = "GetNowHt_BTN"
        Me.GetNowHt_BTN.Size = New System.Drawing.Size(130, 35)
        Me.GetNowHt_BTN.TabIndex = 74
        Me.GetNowHt_BTN.Text = "Get Cur Height"
        Me.GetNowHt_BTN.UseVisualStyleBackColor = True
        '
        'GroupingBox
        '
        Me.GroupingBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupingBox.Location = New System.Drawing.Point(21, 181)
        Me.GroupingBox.Name = "GroupingBox"
        Me.GroupingBox.Size = New System.Drawing.Size(315, 738)
        Me.GroupingBox.TabIndex = 75
        Me.GroupingBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 26)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Moto-Mast Controls"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 997)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Direct Send to Arduino Serial"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(447, 58)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(109, 46)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 78
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(820, 1085)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetNowHt_BTN)
        Me.Controls.Add(Me.GetDir_BTN)
        Me.Controls.Add(Me.GetSpeed_BTN)
        Me.Controls.Add(Me.GetHeight_BTN)
        Me.Controls.Add(Me.AutoDown_BTN)
        Me.Controls.Add(Me.AutoUp_BTN)
        Me.Controls.Add(Me.Halt_BTN)
        Me.Controls.Add(Me.Run_BTN)
        Me.Controls.Add(Me.UpDn_GB)
        Me.Controls.Add(Me.SetSpeed_TB)
        Me.Controls.Add(Me.SetHeight_TB)
        Me.Controls.Add(Me.SetDir_BTN)
        Me.Controls.Add(Me.SetSpeed_BTN)
        Me.Controls.Add(Me.SetHeight_BTN)
        Me.Controls.Add(Me.send_BTN)
        Me.Controls.Add(Me.send_TB)
        Me.Controls.Add(Me.refreshCOM_CB_BTN)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.COMport_LBL)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.receivedData_head_LBL)
        Me.Controls.Add(Me.clear_BTN)
        Me.Controls.Add(Me.GroupingBox)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Moto-Mast Serial Control"
        Me.UpDn_GB.ResumeLayout(False)
        Me.UpDn_GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comPort_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents COMport_LBL As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents receivedData_head_LBL As System.Windows.Forms.Label
    Friend WithEvents clear_BTN As System.Windows.Forms.Button
    Friend WithEvents connect_BTN As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents refreshCOM_CB_BTN As System.Windows.Forms.Button
    Friend WithEvents send_TB As System.Windows.Forms.TextBox
    Friend WithEvents send_BTN As System.Windows.Forms.Button
    Friend WithEvents connecting_Timer As System.Windows.Forms.Timer
    Friend WithEvents UpDn_GB As GroupBox
    Friend WithEvents Down_RB As RadioButton
    Friend WithEvents Up_RB As RadioButton
    Friend WithEvents SetSpeed_TB As TextBox
    Friend WithEvents SetHeight_TB As TextBox
    Friend WithEvents SetDir_BTN As Button
    Friend WithEvents SetSpeed_BTN As Button
    Friend WithEvents SetHeight_BTN As Button
    Friend WithEvents Run_BTN As Button
    Friend WithEvents Halt_BTN As Button
    Friend WithEvents AutoUp_BTN As Button
    Friend WithEvents AutoDown_BTN As Button
    Friend WithEvents GetHeight_BTN As Button
    Friend WithEvents GetSpeed_BTN As Button
    Friend WithEvents GetDir_BTN As Button
    Friend WithEvents GetNowHt_BTN As Button
    Friend WithEvents GroupingBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
