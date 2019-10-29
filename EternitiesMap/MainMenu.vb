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
    Private Sub ChkNaarReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNaarReset.CheckedChanged
        NaarReset = ChkNaarReset.Checked
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CHKInfinite.Checked = InfinitePlane
        ChkNaarReset.Checked = NaarReset
        ChkPreTransReset.Checked = PretranslateReset
        ChkResetReturn.Checked = ResetOnReturn
        ChkDistanceReset.Checked = DistanceReset
    End Sub
    Private Sub ChkPreTransReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPreTransReset.CheckedChanged
        PretranslateReset = ChkPreTransReset.Checked
    End Sub
    Private Sub ChkResetReturn_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResetReturn.CheckedChanged
        ResetOnReturn = ChkResetReturn.Checked
    End Sub
    Private Sub ChkDistanceReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDistanceReset.CheckedChanged
        DistanceReset = ChkDistanceReset.Checked
    End Sub
End Class