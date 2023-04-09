Imports System.Runtime.InteropServices

Public Class Main
    ' 引用DLL
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

    Private Shared Function FindWindow(
    ByVal lpClassName As String,
    ByVal lpWindowName As String
) As IntPtr
    End Function

    ' 主程式碼
    Dim afkTime As Long
    Dim clickKeyBoard As String

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim msgInfo
        msgInfo = MsgBox("是否要將RAFKT常駐進工作列？", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel)
        Select Case msgInfo
            Case MsgBoxResult.Cancel
                e.Cancel = True
            Case MsgBoxResult.Yes
                e.Cancel = True
                NotifyIcon1.Visible = True
                Me.Hide()
            Case MsgBoxResult.No
                End
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Icon = Me.Icon
        Timer1.Enabled = False
        ' 設定Hook
    End Sub

    Private Sub btnStartAFK_Click(sender As Object, e As EventArgs) Handles btnStartAFK.Click
        afkTime = frmSetting.tcbTurnTime.Value * 1000
        Timer1.Interval = afkTime
        Dim selItemsList = frmSetting.clbSelectBtn
        clickKeyBoard = ""
        For i = 0 To selItemsList.SelectedItems.Count - 1
            Select Case selItemsList.SelectedItems.Item(i)
                Case "方向鍵上({UP})"
                    clickKeyBoard = clickKeyBoard + "{UP}"
                Case "方向鍵下({DOWN})"
                    clickKeyBoard = clickKeyBoard + "{DOWN}"
                Case "方向鍵左({LEFT})"
                    clickKeyBoard = clickKeyBoard + "{LEFT}"
                Case "方向鍵右({RIGHT})"
                    clickKeyBoard = clickKeyBoard + "{RIGHT}"
                Case "空白鍵({SPACE})"
                    clickKeyBoard = clickKeyBoard + " "
                Case "W鍵(W)"
                    clickKeyBoard = clickKeyBoard + "/W"
                Case "A鍵(A)"
                    clickKeyBoard = clickKeyBoard + "A"
                Case "S鍵(S)"
                    clickKeyBoard = clickKeyBoard + "S"
                Case "D鍵(D)"
                    clickKeyBoard = clickKeyBoard + "D"
            End Select
        Next
        Debug.Print(clickKeyBoard)
        System.Threading.Thread.Sleep(3)
        ' 啟用計時器並開始腳本
        btnStopAFK.Enabled = True
        btnStartAFK.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub btnRunBg_Click(sender As Object, e As EventArgs) Handles frmMainGUI.Click
        NotifyIcon1.Visible = True
        Me.Hide()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSetting.Show()
    End Sub

    Private Sub btnStopAFK_Click(sender As Object, e As EventArgs) Handles btnStopAFK.Click
        Timer1.Enabled = False
        btnStopAFK.Enabled = False
        btnStartAFK.Enabled = True
        Exit Sub
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.Keyboard.SendKeys(clickKeyBoard)
    End Sub
End Class
