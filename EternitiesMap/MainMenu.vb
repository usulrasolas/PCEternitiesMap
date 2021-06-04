Public Class MainMenu

    Private Sub BExit_Click(sender As Object, e As EventArgs) Handles BExit.Click
        Close()
    End Sub

    Private Sub BNewGame_Click(sender As Object, e As EventArgs) Handles BNewGame.Click
        Dim oForm As Form
#Disable Warning CA2000 ' Dispose objects before losing scope
        oForm = New GameBoard
#Enable Warning CA2000 ' Dispose objects before losing scope
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
        ChkBox2019Ixalan.Checked = ExpPC2019IxGame
        ChkBxPC2017.Checked = ExpPC2017
        ChkBxMultiverseIxalan.Checked = ExpMEIxalan
        ChkbxMultiverseKaladesh.Checked = ExpMEKaladesh
        ChkBxMultiverseExtras.Checked = ExpMEExtra
        ChkBxMultiversePhenom.Checked = ExpMEPhenoms
        ChkBxMultiverseTarkir.Checked = ExpMeTarkir
        ChkBxMultiverseTheros.Checked = ExpMeTheros
        ChkBx2019Monarch.Checked = ExpPc2019Throne
        ChkBx2019Contraption.Checked = ExpPC2019Workshop
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

    Private Sub ChkFiora_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFiora.CheckedChanged
        ExpFiora = ChkFiora.Checked
    End Sub

    Private Sub ChkGeekscape_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGeekscape.CheckedChanged
        ExpGeek = ChkGeekscape.Checked
    End Sub

    Private Sub ChkPC2019_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPC2019.CheckedChanged
        ExpPC2019 = ChkPC2019.Checked
        ChkBxPC2019CommanderCards.Enabled = ChkPC2019.Checked
        ChkBox2019Ixalan.Enabled = ChkPC2019.Checked
        ChkBx2019Contraption.Enabled = ChkPC2019.Checked
        ChkBx2019Monarch.Enabled = ChkPC2019.Checked
    End Sub

    Private Sub ChkBxMultiverse_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverse.CheckedChanged
        ChkAmon.Enabled = ChkBxMultiverse.Checked
        ChkFiora.Enabled = ChkBxMultiverse.Checked
        ChkbxMultiverseKaladesh.Enabled = ChkBxMultiverse.Checked
        ChkBxMultiverseIxalan.Enabled = ChkBxMultiverse.Checked
        ChkBxMultiverseTarkir.Enabled = ChkBxMultiverse.Checked
        ChkBxMultiverseTheros.Enabled = ChkBxMultiverse.Checked
        ChkBxMultiverseExtras.Enabled = ChkBxMultiverse.Checked
        ChkBxMultiversePhenom.Enabled = ChkBxMultiverse.Checked
    End Sub

    Private Sub ChkAmon_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAmon.CheckedChanged
        ExpAmon = ChkAmon.Checked
    End Sub

    Private Sub ChkBox2019Ixalan_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBox2019Ixalan.CheckedChanged
        ExpPC2019IxGame = ChkBox2019Ixalan.Checked
    End Sub

    Private Sub ChkBxPC2017_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxPC2017.CheckedChanged
        ExpPC2017 = ChkBxPC2017.Checked
    End Sub

    Private Sub ChkBxMultiverseIxalan_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseIxalan.CheckedChanged
        ExpMEIxalan = ChkBxMultiverseIxalan.Checked
    End Sub

    Private Sub ChkbxMultiverseKaladesh_CheckedChanged(sender As Object, e As EventArgs) Handles ChkbxMultiverseKaladesh.CheckedChanged
        ExpMEKaladesh = ChkbxMultiverseKaladesh.Checked
    End Sub

    Private Sub ChkBxMultiverseTarkir_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseTarkir.CheckedChanged
        ExpMeTarkir = ChkBxMultiverseTarkir.Checked
    End Sub

    Private Sub ChkBxMultiverseTheros_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseTheros.CheckedChanged
        ExpMeTheros = ChkBxMultiverseTheros.Checked
    End Sub

    Private Sub ChkBxMultiverseExtras_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseExtras.CheckedChanged
        ExpMEExtra = ChkBxMultiverseExtras.Checked
    End Sub

    Private Sub ChkBxMultiversePhenom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiversePhenom.CheckedChanged
        ExpMEPhenoms = ChkBxMultiversePhenom.Checked
    End Sub

    Private Sub ChkBx2019Monarch_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx2019Monarch.CheckedChanged
        ExpPc2019Throne = ChkBx2019Monarch.Checked
    End Sub

    Private Sub ChkBx2019Contraption_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx2019Contraption.CheckedChanged
        ExpPC2019Workshop = ChkBx2019Contraption.Checked
    End Sub
End Class