Imports Microsoft.VisualBasic.Devices.Keyboard
Public Class frmSetting

    Private Sub tcbTurnTime_Scroll(sender As Object, e As EventArgs) Handles tcbTurnTime.Scroll
        GroupBox1.Text = "選擇每次移動間隔時間：" & tcbTurnTime.Value & "秒"
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = "選擇每次移動間隔時間：" & tcbTurnTime.Value & "秒"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Hide()
    End Sub

    Private Sub llblAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAbout.LinkClicked
        frmAbout.Show()
    End Sub
End Class