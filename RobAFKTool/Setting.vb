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
    ''' <summary>
    ''' 傳入命令列指令，回傳命令列的結果
    ''' </summary>
    ''' <param name="strCmd">命列的指令</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DoCmd(ByVal strCmd As String) As String
        Dim prcInfo As New ProcessStartInfo("cmd.exe")
        prcInfo.Arguments = "/C " & strCmd
        prcInfo.RedirectStandardError = True
        prcInfo.RedirectStandardOutput = True
        prcInfo.UseShellExecute = False
        prcInfo.CreateNoWindow = True
        Dim prc As Process = Process.Start(prcInfo)
        Dim strOut As String = prc.StandardOutput.ReadToEnd
        prc.WaitForExit()
        Return IIf(strOut.Length > 0, strOut, prc.StandardError.ReadToEnd)
        prc.Close()
        prc.Dispose()
    End Function
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.End Then
            If TextBox2.Text.ToUpper = "CLS" Then
                TextBox1.Text = ""
            Else
                TextBox1.Text = TextBox1.Text & Chr(13) & DoCmd(TextBox2.Text)
            End If
            If TextBox1.Text.Length > 0 Then
                TextBox1.SelectionStart = TextBox1.Text.Length
            End If

            TextBox1.ScrollToCaret()
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox2.Select()
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btnCheckForUpdate_Click(sender As Object, e As EventArgs) Handles btnCheckForUpdate.Click
        TextBox1.Text = TextBox1.Text & Chr(13) & DoCmd("check.exe")
    End Sub
End Class