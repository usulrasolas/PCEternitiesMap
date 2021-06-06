Public Class SplashPage
    Private Sub BCloseSplash_Click(sender As Object, e As EventArgs) Handles BCloseSplash.Click
        Close()
    End Sub

    Private Sub SplashPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class