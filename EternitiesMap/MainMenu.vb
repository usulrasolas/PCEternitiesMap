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
    Private Sub CHKInfinite_CheckedChanged(sender As Object, e As EventArgs)
        InfinitePlane = CHKInfinite.Checked
    End Sub
    Private Sub ChkNaarReset_CheckedChanged(sender As Object, e As EventArgs)
        NaarReset = ChkNaarReset.Checked
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CHKInfinite.Checked = InfinitePlane
        ChkNaarReset.Checked = NaarReset
        ChkPreTransReset.Checked = PretranslateReset
        ChkResetReturn.Checked = ResetOnReturn
        ChkDistanceReset.Checked = DistanceReset
        ChkAertReset.Checked = AretResetMove
        NumAretMax.Value = AretCounter
        ChkPhenomSupport.Checked = PhenomSupport
        ChkPhenomDealIn.Checked = PhenomDealIn
    End Sub
    Private Sub ChkPreTransReset_CheckedChanged(sender As Object, e As EventArgs)
        PretranslateReset = ChkPreTransReset.Checked
    End Sub
    Private Sub ChkResetReturn_CheckedChanged(sender As Object, e As EventArgs)
        ResetOnReturn = ChkResetReturn.Checked
    End Sub
    Private Sub ChkDistanceReset_CheckedChanged(sender As Object, e As EventArgs)
        DistanceReset = ChkDistanceReset.Checked
    End Sub
    Private Sub ChkAertReset_CheckedChanged(sender As Object, e As EventArgs)
        AretResetMove = ChkAertReset.Checked
    End Sub
    Private Sub NumAretMax_ValueChanged(sender As Object, e As EventArgs)
        AretCounter = NumAretMax.Value
    End Sub

    Private Sub ChkPhenomSupport_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPhenomSupport.CheckedChanged
        PhenomSupport = ChkPhenomSupport.Checked
    End Sub
    Private Sub ChkPhenomDealIn_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPhenomDealIn.CheckedChanged
        PhenomDealIn = ChkPhenomDealIn.Checked
    End Sub

    Private Sub NumAretMax_ValueChanged_1(sender As Object, e As EventArgs) Handles NumAretMax.ValueChanged

    End Sub

    Private Sub ChkAertReset_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkAertReset.CheckedChanged

    End Sub
End Class