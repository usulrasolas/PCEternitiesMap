Public Class SplashPage
    Private Sub BCloseSplash_Click(sender As Object, e As EventArgs) Handles BCloseSplash.Click
        Dim oForm As Form
#Disable Warning CA2000 ' Dispose objects before losing scope
        oForm = New MainMenu
#Enable Warning CA2000 ' Dispose objects before losing scope
        oForm.Show()
        Close()
    End Sub

    Private Sub SplashPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
