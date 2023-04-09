<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tcbTurnTime = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clbSelectBtn = New System.Windows.Forms.CheckedListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.llblAbout = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnCheckForUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tcbTurnTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tcbTurnTime)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 76)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "選擇每次移動間隔時間"
        '
        'tcbTurnTime
        '
        Me.tcbTurnTime.Location = New System.Drawing.Point(4, 19)
        Me.tcbTurnTime.Margin = New System.Windows.Forms.Padding(2)
        Me.tcbTurnTime.Maximum = 60
        Me.tcbTurnTime.Minimum = 1
        Me.tcbTurnTime.Name = "tcbTurnTime"
        Me.tcbTurnTime.Size = New System.Drawing.Size(289, 45)
        Me.tcbTurnTime.TabIndex = 1
        Me.tcbTurnTime.Value = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clbSelectBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(297, 111)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "要按下的按鍵"
        '
        'clbSelectBtn
        '
        Me.clbSelectBtn.FormattingEnabled = True
        Me.clbSelectBtn.Items.AddRange(New Object() {"方向鍵上({UP})", "方向鍵下({DOWN})", "方向鍵左({LEFT})", "方向鍵右({RIGHT})", "空白鍵({SPACE})", "W鍵(W)", "A鍵(A)", "S鍵(S)", "D鍵(D)"})
        Me.clbSelectBtn.Location = New System.Drawing.Point(4, 16)
        Me.clbSelectBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.clbSelectBtn.Name = "clbSelectBtn"
        Me.clbSelectBtn.Size = New System.Drawing.Size(290, 89)
        Me.clbSelectBtn.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(228, 205)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "確定(&S)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'llblAbout
        '
        Me.llblAbout.AutoSize = True
        Me.llblAbout.Location = New System.Drawing.Point(10, 216)
        Me.llblAbout.Name = "llblAbout"
        Me.llblAbout.Size = New System.Drawing.Size(81, 12)
        Me.llblAbout.TabIndex = 4
        Me.llblAbout.TabStop = True
        Me.llblAbout.Text = "關於此軟體(&A)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCheckForUpdate)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(310, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "更新資訊"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 73)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 70)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Visible = False
        '
        'btnCheckForUpdate
        '
        Me.btnCheckForUpdate.Location = New System.Drawing.Point(104, 98)
        Me.btnCheckForUpdate.Name = "btnCheckForUpdate"
        Me.btnCheckForUpdate.Size = New System.Drawing.Size(90, 20)
        Me.btnCheckForUpdate.TabIndex = 9
        Me.btnCheckForUpdate.Text = "檢查更新(&C)"
        Me.btnCheckForUpdate.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 237)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.llblAbout)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSetting"
        Me.Text = "RobAFKTool組態設定介面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tcbTurnTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tcbTurnTime As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents clbSelectBtn As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents llblAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCheckForUpdate As System.Windows.Forms.Button
End Class
