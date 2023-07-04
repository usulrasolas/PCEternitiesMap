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
        Infiniteplane = CHKInfinite.Checked
    End Sub

    Private Sub ChkNaarReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNaarReset.CheckedChanged
        Naarreset = ChkNaarReset.Checked
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CHKInfinite.Checked = Infiniteplane
        ChkNaarReset.Checked = Naarreset
        ChkPreTransReset.Checked = Pretranslatereset
        ChkResetReturn.Checked = Resetonreturn
        ChkDistanceReset.Checked = Distancereset
        ChkAertReset.Checked = Aretresetmove
        NumAretMax.Value = Aretcounter
        ChkPhenomSupport.Checked = Phenomsupport
        TBPhenomHJChance.Value = Phenomhelljchance
        TBPhenomMoveChance.Value = Phenommovechance
        LBLHJChance.Text = Phenomhelljchance & "% Chance of A Random Phenomenon on Helljump Movement (Default 25%)"
        LBLMoveChance.Text = Phenommovechance & "% Chance of A Random Phenomenon on Normal Movement (Default 0%)"
        ChkPCAnthology.Checked = Pcanthologies
        ChkMoc.Checked = ExpMoC
        ChkAmon.Checked = Expmeamon
        ChkIxalan.Checked = Expixalan
        ChkFiora.Checked = Expmefiora
        ChkGeekscape.Checked = Expgeekscape1
        ChkPC2019.Checked = ExpPC2019
        ChkBox2019Ixalan.Checked = ExpPC2019ixgame
        ChkBxPC2017.Checked = ExpPC2017
        ChkBxMultiverseIxalan.Checked = Expmeixalan
        ChkbxMultiverseKaladesh.Checked = Expmekaladesh
        ChkBxMultiverseExtras.Checked = Expmeextra
        ChkBxMultiversePhenom.Checked = Expmephenoms
        ChkBxMultiverseTarkir.Checked = Expmetarkir
        ChkBxMultiverseTheros.Checked = Expmetheros
        ChkBx2019Monarch.Checked = ExpPC2019throne
        ChkBx2019Contraption.Checked = ExpPC2019workshop
        ChkBxPC2019CommanderCards.Checked = ExpPC2019commander
    End Sub

    Private Sub ChkPreTransReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPreTransReset.CheckedChanged
        Pretranslatereset = ChkPreTransReset.Checked
    End Sub

    Private Sub ChkResetReturn_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResetReturn.CheckedChanged
        Resetonreturn = ChkResetReturn.Checked
    End Sub

    Private Sub ChkDistanceReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDistanceReset.CheckedChanged
        Distancereset = ChkDistanceReset.Checked
    End Sub

    Private Sub ChkAertReset_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAertReset.CheckedChanged
        Aretresetmove = ChkAertReset.Checked
    End Sub

    Private Sub NumAretMax_ValueChanged(sender As Object, e As EventArgs) Handles NumAretMax.ValueChanged
        Aretcounter = NumAretMax.Value
    End Sub

    Private Sub ChkPhenomSupport_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPhenomSupport.CheckedChanged
        Phenomsupport = ChkPhenomSupport.Checked
    End Sub

    Private Sub TBPhenomHJChance_Scroll(sender As Object, e As EventArgs) Handles TBPhenomHJChance.Scroll
        Phenomhelljchance = TBPhenomHJChance.Value
        LBLHJChance.Text = Phenomhelljchance & "% Chance of A Random Phenomenon on Helljump Movement (Default 25%)"
    End Sub

    Private Sub TBPhenomMoveChance_Scroll(sender As Object, e As EventArgs) Handles TBPhenomMoveChance.Scroll
        Phenommovechance = TBPhenomMoveChance.Value
        LBLMoveChance.Text = Phenommovechance & "% Chance of A Random Phenomenon on Normal Movement (Default 0%)"
    End Sub

    Private Sub ChkPCAnthology_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPCAnthology.CheckedChanged
        Pcanthologies = ChkPCAnthology.Checked
    End Sub

    Private Sub ChkMoC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMoC.CheckedChanged
        ExpMoC = ChkMoC.Checked
    End Sub

    Private Sub ChkFiora_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFiora.CheckedChanged
        Expmefiora = ChkFiora.Checked
    End Sub

    Private Sub ChkGeekscape_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGeekscape.CheckedChanged
        Expgeekscape1 = ChkGeekscape.Checked
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
        Expmeamon = ChkAmon.Checked
    End Sub

    Private Sub ChkBox2019Ixalan_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBox2019Ixalan.CheckedChanged
        ExpPC2019ixgame = ChkBox2019Ixalan.Checked
    End Sub

    Private Sub ChkBxPC2017_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxPC2017.CheckedChanged
        ExpPC2017 = ChkBxPC2017.Checked
    End Sub

    Private Sub ChkBxMultiverseIxalan_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseIxalan.CheckedChanged
        Expmeixalan = ChkBxMultiverseIxalan.Checked
    End Sub

    Private Sub ChkbxMultiverseKaladesh_CheckedChanged(sender As Object, e As EventArgs) Handles ChkbxMultiverseKaladesh.CheckedChanged
        Expmekaladesh = ChkbxMultiverseKaladesh.Checked
    End Sub

    Private Sub ChkBxMultiverseTarkir_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseTarkir.CheckedChanged
        Expmetarkir = ChkBxMultiverseTarkir.Checked
    End Sub

    Private Sub ChkBxMultiverseTheros_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseTheros.CheckedChanged
        Expmetheros = ChkBxMultiverseTheros.Checked
    End Sub

    Private Sub ChkBxMultiverseExtras_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiverseExtras.CheckedChanged
        Expmeextra = ChkBxMultiverseExtras.Checked
    End Sub

    Private Sub ChkBxMultiversePhenom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxMultiversePhenom.CheckedChanged
        Expmephenoms = ChkBxMultiversePhenom.Checked
    End Sub

    Private Sub ChkBx2019Monarch_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx2019Monarch.CheckedChanged
        ExpPC2019throne = ChkBx2019Monarch.Checked
    End Sub

    Private Sub ChkBx2019Contraption_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBx2019Contraption.CheckedChanged
        ExpPC2019workshop = ChkBx2019Contraption.Checked
    End Sub

    Private Sub ChkBxPC2019CommanderCards_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxPC2019CommanderCards.CheckedChanged
        ExpPC2019commander = ChkBxPC2019CommanderCards.Checked
    End Sub

    Private Sub ChkIxalan_CheckedChanged(sender As Object, e As EventArgs) Handles ChkIxalan.CheckedChanged
        Expixalan = ChkIxalan.Checked
    End Sub

End Class