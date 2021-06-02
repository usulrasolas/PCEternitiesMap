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
        ChkAertReset.Checked = AretResetMove
        NumAretMax.Value = AretCounter
        ChkPhenomSupport.Checked = PhenomSupport
        TBPhenomHJChance.Value = PhenomHellJChance
        TBPhenomMoveChance.Value = PhenomMoveChance
        LBLHJChance.Text = PhenomHellJChance & "% Chance of A Random Phenomenon on Helljump Movement (Default 25%)"
        LBLMoveChance.Text = PhenomMoveChance & "% Chance of A Random Phenomenon on Normal Movement (Default 0%)"
        ChkPCAnthology.Checked = PCAnthologies
        ChkAmon.Checked = ExpAmon
        ChkIxalan.Checked = ExpIxalan
        ChkFiora.Checked = ExpFiora
        ChkGeekscape.Checked = ExpGeek
        ChkPC2019.Checked = ExpPC2019
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

    Private Sub ChkAertReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAertReset.CheckedChanged
        AretResetMove = ChkAertReset.Checked
    End Sub

    Private Sub NumAretMax_ValueChanged(sender As Object, e As EventArgs) Handles NumAretMax.ValueChanged
        AretCounter = NumAretMax.Value
    End Sub

    Private Sub ChkPhenomSupport_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPhenomSupport.CheckedChanged
        PhenomSupport = ChkPhenomSupport.Checked
    End Sub

    Private Sub TBPhenomHJChance_Scroll(sender As Object, e As EventArgs) Handles TBPhenomHJChance.Scroll
        PhenomHellJChance = TBPhenomHJChance.Value
        LBLHJChance.Text = PhenomHellJChance & "% Chance of A Random Phenomenon on Helljump Movement (Default 25%)"
    End Sub

    Private Sub TBPhenomMoveChance_Scroll(sender As Object, e As EventArgs) Handles TBPhenomMoveChance.Scroll
        PhenomMoveChance = TBPhenomMoveChance.Value
        LBLMoveChance.Text = PhenomMoveChance & "% Chance of A Random Phenomenon on Normal Movement (Default 0%)"
    End Sub

    Private Sub ChkPCAnthology_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPCAnthology.CheckedChanged
        PCAnthologies = ChkPCAnthology.Checked
    End Sub

    Private Sub ChkFiora_CheckedChanged(sender As Object, e As EventArgs)
        ExpFiora = ChkFiora.Checked
    End Sub

    Private Sub ChkIxalan_CheckedChanged(sender As Object, e As EventArgs)
        ExpIxalan = ChkIxalan.Checked
    End Sub

    Private Sub ChkAmon_CheckedChanged(sender As Object, e As EventArgs)
        ExpAmon = ChkAmon.Checked
    End Sub

    Private Sub ChkGeekscape_CheckedChanged(sender As Object, e As EventArgs)
        ExpGeek = ChkGeekscape.Checked
    End Sub

    Private Sub ChkPC2019_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPC2019.CheckedChanged
        ExpPC2019 = ChkPC2019.Checked
    End Sub

    Private Sub TabPageCardSets_Click(sender As Object, e As EventArgs) Handles TabPageCardSets.Click

    End Sub

End Class