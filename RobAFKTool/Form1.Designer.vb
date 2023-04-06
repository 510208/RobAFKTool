<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.frmMainGUI = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnStopAFK = New System.Windows.Forms.Button()
        Me.btnStartAFK = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'frmMainGUI
        '
        Me.frmMainGUI.BackColor = System.Drawing.Color.White
        Me.frmMainGUI.Image = Global.RobAFKTool.My.Resources.Resources.taskbar
        Me.frmMainGUI.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.frmMainGUI.Location = New System.Drawing.Point(401, 12)
        Me.frmMainGUI.Name = "frmMainGUI"
        Me.frmMainGUI.Size = New System.Drawing.Size(123, 129)
        Me.frmMainGUI.TabIndex = 3
        Me.frmMainGUI.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "後臺運行(&B)"
        Me.frmMainGUI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.frmMainGUI.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.White
        Me.btnSettings.Image = Global.RobAFKTool.My.Resources.Resources.settings_svgrepo_com
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSettings.Location = New System.Drawing.Point(272, 12)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(123, 129)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "掛機設定(&S)"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnStopAFK
        '
        Me.btnStopAFK.BackColor = System.Drawing.Color.White
        Me.btnStopAFK.Enabled = False
        Me.btnStopAFK.Image = Global.RobAFKTool.My.Resources.Resources.buildtype_14px_svgrepo_com
        Me.btnStopAFK.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStopAFK.Location = New System.Drawing.Point(142, 12)
        Me.btnStopAFK.Name = "btnStopAFK"
        Me.btnStopAFK.Size = New System.Drawing.Size(124, 129)
        Me.btnStopAFK.TabIndex = 1
        Me.btnStopAFK.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "結束掛機(F9)"
        Me.btnStopAFK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStopAFK.UseVisualStyleBackColor = False
        '
        'btnStartAFK
        '
        Me.btnStartAFK.BackColor = System.Drawing.Color.White
        Me.btnStartAFK.Image = Global.RobAFKTool.My.Resources.Resources.run_svgrepo_com1
        Me.btnStartAFK.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStartAFK.Location = New System.Drawing.Point(12, 12)
        Me.btnStartAFK.Name = "btnStartAFK"
        Me.btnStartAFK.Size = New System.Drawing.Size(124, 129)
        Me.btnStartAFK.TabIndex = 0
        Me.btnStartAFK.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "開始掛機(F9)"
        Me.btnStartAFK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStartAFK.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 153)
        Me.Controls.Add(Me.frmMainGUI)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnStopAFK)
        Me.Controls.Add(Me.btnStartAFK)
        Me.Name = "Form1"
        Me.Text = "RAFKT Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartAFK As System.Windows.Forms.Button
    Friend WithEvents btnStopAFK As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents frmMainGUI As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
