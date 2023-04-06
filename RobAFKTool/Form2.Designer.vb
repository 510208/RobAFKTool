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
        Me.GroupBox1.SuspendLayout()
        CType(Me.tcbTurnTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tcbTurnTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "選擇每次移動間隔時間"
        '
        'tcbTurnTime
        '
        Me.tcbTurnTime.Location = New System.Drawing.Point(6, 28)
        Me.tcbTurnTime.Maximum = 20
        Me.tcbTurnTime.Minimum = 1
        Me.tcbTurnTime.Name = "tcbTurnTime"
        Me.tcbTurnTime.Size = New System.Drawing.Size(433, 69)
        Me.tcbTurnTime.TabIndex = 1
        Me.tcbTurnTime.Value = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clbSelectBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 135)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "要按下的按鍵"
        '
        'clbSelectBtn
        '
        Me.clbSelectBtn.FormattingEnabled = True
        Me.clbSelectBtn.Items.AddRange(New Object() {"方向鍵上({UP})", "方向鍵下({DOWN})", "方向鍵左({LEFT})", "方向鍵右({RIGHT})", "空白鍵({SPACE})"})
        Me.clbSelectBtn.Location = New System.Drawing.Point(6, 24)
        Me.clbSelectBtn.Name = "clbSelectBtn"
        Me.clbSelectBtn.Size = New System.Drawing.Size(433, 100)
        Me.clbSelectBtn.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(342, 273)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 35)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "確定(&S)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 320)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSetting"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tcbTurnTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tcbTurnTime As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents clbSelectBtn As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
