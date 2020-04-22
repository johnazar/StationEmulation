<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStation
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
        Me.TxtReceived = New System.Windows.Forms.TextBox()
        Me.SerBluetooth = New System.IO.Ports.SerialPort(Me.components)
        Me.TmrConnect = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbCOMPorts = New System.Windows.Forms.ComboBox()
        Me.lblSerialDisp = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtRecHex = New System.Windows.Forms.TextBox()
        Me.LST = New System.Windows.Forms.Label()
        Me.LblReadSize = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblStep = New System.Windows.Forms.Label()
        Me.LblStepSPD = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtReceived
        '
        Me.TxtReceived.Location = New System.Drawing.Point(21, 165)
        Me.TxtReceived.Multiline = True
        Me.TxtReceived.Name = "TxtReceived"
        Me.TxtReceived.Size = New System.Drawing.Size(999, 118)
        Me.TxtReceived.TabIndex = 4
        '
        'SerBluetooth
        '
        Me.SerBluetooth.PortName = "COM17"
        '
        'TmrConnect
        '
        Me.TmrConnect.Interval = 500
        '
        'BtnConnect
        '
        Me.BtnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnect.Location = New System.Drawing.Point(6, 21)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(115, 40)
        Me.BtnConnect.TabIndex = 5
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbCOMPorts)
        Me.GroupBox1.Controls.Add(Me.lblSerialDisp)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnConnect)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 117)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Settings"
        '
        'CmbCOMPorts
        '
        Me.CmbCOMPorts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCOMPorts.FormattingEnabled = True
        Me.CmbCOMPorts.Items.AddRange(New Object() {"COM17", "COM1", "COM2", "COM3", "COM4", "COM5"})
        Me.CmbCOMPorts.Location = New System.Drawing.Point(203, 28)
        Me.CmbCOMPorts.Name = "CmbCOMPorts"
        Me.CmbCOMPorts.Size = New System.Drawing.Size(136, 28)
        Me.CmbCOMPorts.TabIndex = 7
        Me.CmbCOMPorts.Text = "COM17"
        '
        'lblSerialDisp
        '
        Me.lblSerialDisp.AutoSize = True
        Me.lblSerialDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialDisp.Location = New System.Drawing.Point(139, 31)
        Me.lblSerialDisp.Name = "lblSerialDisp"
        Me.lblSerialDisp.Size = New System.Drawing.Size(45, 20)
        Me.lblSerialDisp.TabIndex = 7
        Me.lblSerialDisp.Text = "OFF"
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(6, 67)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(135, 40)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Disconnect"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtRecHex
        '
        Me.TxtRecHex.Location = New System.Drawing.Point(21, 289)
        Me.TxtRecHex.Multiline = True
        Me.TxtRecHex.Name = "TxtRecHex"
        Me.TxtRecHex.Size = New System.Drawing.Size(999, 118)
        Me.TxtRecHex.TabIndex = 8
        '
        'LST
        '
        Me.LST.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LST.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST.Location = New System.Drawing.Point(395, 33)
        Me.LST.Name = "LST"
        Me.LST.Size = New System.Drawing.Size(65, 50)
        Me.LST.TabIndex = 9
        Me.LST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblReadSize
        '
        Me.LblReadSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReadSize.Location = New System.Drawing.Point(800, 38)
        Me.LblReadSize.Name = "LblReadSize"
        Me.LblReadSize.Size = New System.Drawing.Size(220, 50)
        Me.LblReadSize.TabIndex = 10
        Me.LblReadSize.Text = "0"
        Me.LblReadSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(858, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Count In"
        '
        'LblStep
        '
        Me.LblStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblStep.Location = New System.Drawing.Point(492, 33)
        Me.LblStep.Name = "LblStep"
        Me.LblStep.Size = New System.Drawing.Size(110, 43)
        Me.LblStep.TabIndex = 12
        Me.LblStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStepSPD
        '
        Me.LblStepSPD.BackColor = System.Drawing.Color.Tomato
        Me.LblStepSPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblStepSPD.Location = New System.Drawing.Point(492, 119)
        Me.LblStepSPD.Name = "LblStepSPD"
        Me.LblStepSPD.Size = New System.Drawing.Size(110, 43)
        Me.LblStepSPD.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(493, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "StepperSPD"
        '
        'FrmStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 480)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblStepSPD)
        Me.Controls.Add(Me.LblStep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblReadSize)
        Me.Controls.Add(Me.LST)
        Me.Controls.Add(Me.TxtRecHex)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtReceived)
        Me.Name = "FrmStation"
        Me.Text = "Emulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtReceived As TextBox
    Friend WithEvents SerBluetooth As IO.Ports.SerialPort
    Friend WithEvents TmrConnect As Timer
    Friend WithEvents BtnConnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents lblSerialDisp As Label
    Friend WithEvents CmbCOMPorts As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtRecHex As TextBox
    Friend WithEvents LST As Label
    Friend WithEvents LblReadSize As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblStep As Label
    Friend WithEvents LblStepSPD As Label
    Friend WithEvents Label3 As Label
End Class
