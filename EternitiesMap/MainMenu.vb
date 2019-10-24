Public Class MainMenu
    Private Sub BExit_Click(sender As Object, e As EventArgs) Handles BExit.Click
        Close()
    End Sub
    Private Sub BNewGame_Click(sender As Object, e As EventArgs) Handles BNewGame.Click
        Dim oForm As Form
        oForm = New GameBoard
        oForm.Show()
        Close()
    End Sub
    Private Sub CHKInfinite_CheckedChanged(sender As Object, e As EventArgs) Handles CHKInfinite.CheckedChanged
        InfinitePlane = CHKInfinite.Checked
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class