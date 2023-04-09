Public Class frmAbout

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "RobAFKTool v" & Application.ProductVersion
    End Sub

    Private Sub btnMySite_Click(sender As Object, e As EventArgs) Handles btnMySite.Click
        SiteBrowser.Show()
    End Sub
End Class