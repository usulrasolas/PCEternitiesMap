Public Class GameBoard
    Private CardArray(25) As PictureBox
    Private DispArray(25) As Label
    Public Shared CurrentPlane As Integer
    Private Sub GameBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CardArray(1) = PictureBox1
        DispArray(1) = Label1
        CardArray(2) = PictureBox2
        DispArray(2) = Label2
        CardArray(3) = PictureBox3
        DispArray(3) = Label3
        CardArray(4) = PictureBox4
        DispArray(4) = Label4
        CardArray(5) = PictureBox5
        DispArray(5) = Label5
        CardArray(6) = PictureBox6
        DispArray(6) = Label6
        CardArray(7) = PictureBox7
        DispArray(7) = Label7
        CardArray(8) = PictureBox8
        DispArray(8) = Label8
        CardArray(9) = PictureBox9
        DispArray(9) = Label9
        CardArray(10) = PictureBox10
        DispArray(10) = Label10
        CardArray(11) = PictureBox11
        DispArray(11) = Label11
        CardArray(12) = PictureBox12
        DispArray(12) = Label12
        CardArray(13) = PictureBox13
        DispArray(13) = Label13
        CardArray(14) = PictureBox14
        DispArray(14) = Label14
        CardArray(15) = PictureBox15
        DispArray(15) = Label15
        CardArray(16) = PictureBox16
        DispArray(16) = Label16
        CardArray(17) = PictureBox17
        DispArray(17) = Label17
        CardArray(18) = PictureBox18
        DispArray(18) = Label18
        CardArray(19) = PictureBox19
        DispArray(19) = Label19
        CardArray(20) = PictureBox20
        DispArray(20) = Label20
        CardArray(21) = PictureBox21
        DispArray(21) = Label21
        CardArray(22) = PictureBox22
        DispArray(22) = Label22
        CardArray(23) = PictureBox23
        DispArray(23) = Label23
        CardArray(24) = PictureBox24
        DispArray(24) = Label24
        CardArray(25) = PictureBox25
        DispArray(25) = Label25
        PBZoom.SendToBack()
        LBLZoom.SendToBack()
        PBZoom.Visible = False
        LBLZoom.Visible = False
        PBZoom.Enabled = False
        NCounter.Value = 0
        UpdateArrays()
        NewGame()
    End Sub
    Function DisplayZoom(CardNumber As Integer)
        If CheckPosition(CardNumber) = True Then
            PBZoom.Image = CardImage(CardNumber)
            PBZoom.BringToFront()
            PBZoom.Visible = True
            PBZoom.Enabled = True
            If CardStack(CardNumber, 4) <> 0 Then LBLZoom.Visible = True
            If CardStack(CardNumber, 4) <> 0 Then LBLZoom.BringToFront()
            If CardStack(CardNumber, 4) > 0 Then LBLZoom.BackColor = Color.DarkBlue
            If CardStack(CardNumber, 4) > 0 Then LBLZoom.ForeColor = Color.LightYellow
            If CardStack(CardNumber, 4) < 0 Then LBLZoom.ForeColor = Color.White
            If CardStack(CardNumber, 4) < 0 Then LBLZoom.BackColor = Color.Black
            If CardStack(CardNumber, 4) <> 0 Then LBLZoom.Text = CardStack(CardNumber, 4)
            NCounter.Enabled = False
        ElseIf CheckPosition(CardNumber) = False Then

        End If

    End Function
    Function GameEvent(EventType As Integer)
        If EventType = 9 Then ''Pools of Becoming Triple Draw
            DeckState = 3
            Dim PoBDraw1 As Integer = DrawCard()
            Dim PoBDraw2 As Integer = DrawCard()
            Dim PoBDraw3 As Integer = DrawCard()
            PickDisplay(CurrentPlane, Nothing, Nothing, PoBDraw1, PoBDraw2, PoBDraw3)
            ReturnCard(PoBDraw1)
            ReturnCard(PoBDraw2)
            ReturnCard(PoBDraw3)
            MsgBox("All 3 Revealed Chaos Effects Resolve." & vbCrLf & "Player who rolled chaos chooses resolve order." & vbCrLf & "Click Pools of Becoming to Return to Play when All Resolved", MsgBoxStyle.Information, "Pools of Becoming")
        ElseIf EventType = 11 Then ''Stairs to Infinity Scry Planar Deck on Chaos
            DeckState = 3
            PickDisplay(CurrentPlane, Nothing, Nothing, Nothing, CardLookup(DeckCounter), Nothing)
            MsgBox("Click on Revealed Card to Keep On Top of Planar Deck" & vbCrLf & "Click on Stairs to Infinity to Put Revealed Card on Bottom of Planar Deck", MsgBoxStyle.Information, "Stairs to Infinity")
        Else
        End If
    End Function
    Public Function PickDisplay(trigPlane As Integer, slot1 As Integer, slot2 As Integer, slot3 As Integer, slot4 As Integer, slot5 As Integer)
        PBZoom.Enabled = False
        PBZoom.Visible = False
        PBZoom.SendToBack()
        PBZoom.Image = Nothing
        Dim workcounter As Integer
        For workcounter = 1 To 25 Step 1
            CardArray(workcounter).Enabled = False
        Next
        PCardSelect1.BringToFront()
        PCardSelect2.BringToFront()
        PCardSelect3.BringToFront()
        PCardSelect4.BringToFront()
        PCardSelect5.BringToFront()
        PCardSelect6.BringToFront()
        PCardSelect1.Enabled = True
        PCardSelect2.Enabled = True
        PCardSelect3.Enabled = True
        PCardSelect4.Enabled = True
        PCardSelect5.Enabled = True
        PCardSelect6.Enabled = True
        PCardSelect1.Visible = False 'disabled until pick 5 for phenoms needed
        PCardSelect2.Visible = True
        PCardSelect3.Visible = False 'disabled until pick 5 for phenoms needed
        PCardSelect4.Visible = True
        PCardSelect5.Visible = True
        PCardSelect6.Visible = True
        PCardSelect1.Image = CardImage(slot1)
        PCardSelect2.Image = CardImage(trigPlane)
        PCardSelect3.Image = CardImage(slot2)
        PCardSelect4.Image = CardImage(slot3)
        PCardSelect5.Image = CardImage(slot4)
        PCardSelect6.Image = CardImage(slot5)
    End Function
    Public Function NewGame() As Boolean
        ReadyDeck()
        PlayCard(DrawCard, 3, 0, 0)
        PBZoom.Enabled = True
        PBZoom.Visible = True
        PBZoom.BringToFront()
        PBZoom.Image = CardImage(DrawBuffer)
        DeckState = 1
        HidePickDisplay()
        PopulateBoard()
        UpdateArrays()
    End Function
    Function HidePickDisplay()
        PCardSelect1.SendToBack()
        PCardSelect2.SendToBack()
        PCardSelect3.SendToBack()
        PCardSelect4.SendToBack()
        PCardSelect5.SendToBack()
        PCardSelect6.SendToBack()
        PCardSelect1.Enabled = False
        PCardSelect2.Enabled = False
        PCardSelect3.Enabled = False
        PCardSelect4.Enabled = False
        PCardSelect5.Enabled = False
        PCardSelect6.Enabled = False
        PCardSelect1.Visible = False
        PCardSelect2.Visible = False
        PCardSelect3.Visible = False
        PCardSelect4.Visible = False
        PCardSelect5.Visible = False
        PCardSelect6.Visible = False
        For workcounter = 1 To 25 Step 1
            CardArray(workcounter).Enabled = True
        Next
    End Function
    Function UpdateArrays() As Boolean
        Dim workcounter As Integer
        Dim DisplayBuffer(25) As Integer
        For workcounter = 1 To 25 Step 1
            DisplayBuffer(workcounter) = 0
            CardArray(workcounter).Image = Nothing
            CardArray(workcounter).Enabled = True
            CardArray(workcounter).Invalidate()
            DispArray(workcounter).Visible = False
            DispArray(workcounter).BackColor = Color.Transparent
            DispArray(workcounter).Text = " "
            DispArray(workcounter).ForeColor = Color.Gray
            DispArray(workcounter).Invalidate()
        Next
        For workcounter = 1 To 86 Step 1
            If CardStack(workcounter, 5) = 3 Then
                If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 3 Then
                    CardArray(1).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(1).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(1).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(1).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(1).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(1).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(1).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(1).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 2 Then
                    CardArray(2).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(2).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(2).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(2).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(2).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(2).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(2).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(2).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 2 Then
                    CardArray(3).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(3).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(3).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(3).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(3).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(3).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(3).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(3).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 2 Then
                    CardArray(4).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(4).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(4).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(4).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(4).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(4).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(4).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(4).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -2 And CardStack(workcounter, 2) = 1 Then
                    CardArray(5).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(5).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(5).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(5).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(5).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(5).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(5).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(5).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 1 Then
                    CardArray(6).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(6).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(6).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(6).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(6).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(6).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(6).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(6).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 1 Then
                    CardArray(7).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(7).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(7).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(7).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(7).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(7).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(7).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(7).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 1 Then
                    CardArray(8).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(8).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(8).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(8).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(8).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(8).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(8).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(8).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 2 And CardStack(workcounter, 2) = 1 Then
                    CardArray(9).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(9).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(9).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(9).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(9).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(9).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(9).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(9).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -3 And CardStack(workcounter, 2) = 0 Then
                    CardArray(10).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(10).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(10).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(10).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(10).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(10).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(10).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(10).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -2 And CardStack(workcounter, 2) = 0 Then
                    CardArray(11).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(11).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(11).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(11).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(11).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(11).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(11).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(11).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 0 Then
                    CardArray(12).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(12).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(12).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(12).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(12).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(12).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(12).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(12).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 0 Then
                    CardArray(13).Image = CardImage(workcounter)
                    CurrentPlane = workcounter
                    NCounter.Value = CardStack(workcounter, 4)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(13).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(13).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(13).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(13).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(13).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(13).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(13).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 0 Then
                    CardArray(14).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(14).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(14).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(14).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(14).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(14).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(14).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(14).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 2 And CardStack(workcounter, 2) = 0 Then
                    CardArray(15).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(15).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(15).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(15).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(15).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(15).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(15).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(15).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 3 And CardStack(workcounter, 2) = 0 Then
                    CardArray(16).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(16).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(16).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(16).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(16).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(16).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(16).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(16).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -2 And CardStack(workcounter, 2) = -1 Then
                    CardArray(17).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(17).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(17).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(17).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(17).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(17).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(17).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(17).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = -1 Then
                    CardArray(18).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(18).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(18).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(18).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(18).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(18).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(18).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(18).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -1 Then
                    CardArray(19).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(19).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(19).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(19).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(19).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(19).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(19).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(19).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = -1 Then
                    CardArray(20).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(20).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(20).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(20).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(20).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(20).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(20).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(20).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 2 And CardStack(workcounter, 2) = -1 Then
                    CardArray(21).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(21).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(21).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(21).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(21).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(21).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(21).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(21).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = -2 Then
                    CardArray(22).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(22).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(22).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(22).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(22).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(22).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(22).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(22).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -2 Then
                    CardArray(23).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(23).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(23).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(23).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(23).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(23).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(23).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(23).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = -2 Then
                    CardArray(24).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(24).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(24).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(24).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(24).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(24).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(24).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(24).Text = CardStack(workcounter, 4)
                ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -3 Then
                    CardArray(25).Image = CardImage(workcounter)
                    If CardStack(workcounter, 4) <> 0 Then DispArray(25).Enabled = True
                    If CardStack(workcounter, 4) <> 0 Then DispArray(25).Visible = True
                    If CardStack(workcounter, 4) > 0 Then DispArray(25).BackColor = Color.DarkBlue
                    If CardStack(workcounter, 4) > 0 Then DispArray(25).ForeColor = Color.LightYellow
                    If CardStack(workcounter, 4) < 0 Then DispArray(25).ForeColor = Color.White
                    If CardStack(workcounter, 4) < 0 Then DispArray(25).BackColor = Color.Black
                    If CardStack(workcounter, 4) <> 0 Then DispArray(25).Text = CardStack(workcounter, 4)
                End If
            End If
        Next
        Me.Invalidate()
    End Function
    Function MoveEventCheck()
        If CardStack(CurrentPlane, 3) = 5 Then ''Aeropolis Flag for 10 Counters Walks Away
            If CardStack(CurrentPlane, 4) >= AretCounter And AretResetMove = True Then CardStack(CurrentPlane, 4) = 0
        ElseIf CardStack(CurrentPlane, 3) = 6 Then ''Naar Isle Counter Reset on Exit if reset is true
            If NaarReset = True Then CardStack(CurrentPlane, 4) = 0
        ElseIf (CardStack(CurrentPlane, 3) = 7 And CardStack(CurrentPlane, 4) > 0) Then ''Mount Keralia Damage on Exit Reminder/Reset
            MsgBox("Mount Keralia Deals " & CardStack(CurrentPlane, 4) & " Damage to Each Creature and Each Planeswalker", MsgBoxStyle.Exclamation, "Mount Keralia Erupts!")
            CardStack(CurrentPlane, 4) = 0
        End If
    End Function
    Function CheckPosition(cardnumber As Integer) As Boolean
        Dim CardDeckPos As Integer = CardStack(cardnumber, 0)
        Dim CardxPos As Integer = CardStack(cardnumber, 1)
        Dim CardyPos As Integer = CardStack(cardnumber, 2)
        Dim DeckCheck As Integer = 0
        Dim XyCheck As Integer = 0
        For workcounter = 1 To 86 Step 1
            If CardStack(workcounter, 0) = carddeckpos And carddeckpos > 0 Then
                deckcheck += 1
            ElseIf carddeckpos = 0 Then
                If CardStack(workcounter, 1) = CardxPos And CardStack(workcounter, 2) = CardyPos Then
                    XyCheck += 1
                End If
            End If
            If DeckCheck = 0 And XyCheck = 1 Then
                CheckPosition = True
            ElseIf DeckCheck = 1 And XyCheck = 0 Then
                CheckPosition = True
            Else
                CheckPosition = False
            End If
        Next
        Return CheckPosition
    End Function
    Public Shared Function CardImage(CardNumber As Integer) As Image
        If CardNumber = 1 Then
            Return My.Resources.c1
        ElseIf CardNumber = 2 Then
            Return My.Resources.c2
        ElseIf CardNumber = 3 Then
            Return My.Resources.c3
        ElseIf CardNumber = 4 Then
            Return My.Resources.c4
        ElseIf CardNumber = 5 Then
            Return My.Resources.c5
        ElseIf CardNumber = 6 Then
            Return My.Resources.c6
        ElseIf CardNumber = 7 Then
            Return My.Resources.c7
        ElseIf CardNumber = 8 Then
            Return My.Resources.c8
        ElseIf CardNumber = 9 Then
            Return My.Resources.c9
        ElseIf CardNumber = 10 Then
            Return My.Resources.c10
        ElseIf CardNumber = 11 Then
            Return My.Resources.c11
        ElseIf CardNumber = 12 Then
            Return My.Resources.c12
        ElseIf CardNumber = 13 Then
            Return My.Resources.c13
        ElseIf CardNumber = 14 Then
            Return My.Resources.c14
        ElseIf CardNumber = 15 Then
            Return My.Resources.c15
        ElseIf CardNumber = 16 Then
            Return My.Resources.c16
        ElseIf CardNumber = 17 Then
            Return My.Resources.c17
        ElseIf CardNumber = 18 Then
            Return My.Resources.c18
        ElseIf CardNumber = 19 Then
            Return My.Resources.c19
        ElseIf CardNumber = 20 Then
            Return My.Resources.c20
        ElseIf CardNumber = 21 Then
            Return My.Resources.c21
        ElseIf CardNumber = 22 Then
            Return My.Resources.c22
        ElseIf CardNumber = 23 Then
            Return My.Resources.c23
        ElseIf CardNumber = 24 Then
            Return My.Resources.c24
        ElseIf CardNumber = 25 Then
            Return My.Resources.c25
        ElseIf CardNumber = 26 Then
            Return My.Resources.c26
        ElseIf CardNumber = 27 Then
            Return My.Resources.c27
        ElseIf CardNumber = 28 Then
            Return My.Resources.c28
        ElseIf CardNumber = 29 Then
            Return My.Resources.c29
        ElseIf CardNumber = 30 Then
            Return My.Resources.c30
        ElseIf CardNumber = 31 Then
            Return My.Resources.c31
        ElseIf CardNumber = 32 Then
            Return My.Resources.c32
        ElseIf CardNumber = 33 Then
            Return My.Resources.c33
        ElseIf CardNumber = 34 Then
            Return My.Resources.c34
        ElseIf CardNumber = 35 Then
            Return My.Resources.c35
        ElseIf CardNumber = 36 Then
            Return My.Resources.c36
        ElseIf CardNumber = 37 Then
            Return My.Resources.c37
        ElseIf CardNumber = 38 Then
            Return My.Resources.c38
        ElseIf CardNumber = 39 Then
            Return My.Resources.c39
        ElseIf CardNumber = 40 Then
            Return My.Resources.c40
        ElseIf CardNumber = 41 Then
            Return My.Resources.c41
        ElseIf CardNumber = 42 Then
            Return My.Resources.c42
        ElseIf CardNumber = 43 Then
            Return My.Resources.c43
        ElseIf CardNumber = 44 Then
            Return My.Resources.c44
        ElseIf CardNumber = 45 Then
            Return My.Resources.c45
        ElseIf CardNumber = 46 Then
            Return My.Resources.c46
        ElseIf CardNumber = 47 Then
            Return My.Resources.c47
        ElseIf CardNumber = 48 Then
            Return My.Resources.c48
        ElseIf CardNumber = 49 Then
            Return My.Resources.c49
        ElseIf CardNumber = 50 Then
            Return My.Resources.c50
        ElseIf CardNumber = 51 Then
            Return My.Resources.c51
        ElseIf CardNumber = 52 Then
            Return My.Resources.c52
        ElseIf CardNumber = 53 Then
            Return My.Resources.c53
        ElseIf CardNumber = 54 Then
            Return My.Resources.c54
        ElseIf CardNumber = 55 Then
            Return My.Resources.c55
        ElseIf CardNumber = 56 Then
            Return My.Resources.c56
        ElseIf CardNumber = 57 Then
            Return My.Resources.c57
        ElseIf CardNumber = 58 Then
            Return My.Resources.c58
        ElseIf CardNumber = 59 Then
            Return My.Resources.c59
        ElseIf CardNumber = 60 Then
            Return My.Resources.c60
        ElseIf CardNumber = 61 Then
            Return My.Resources.c61
        ElseIf CardNumber = 62 Then
            Return My.Resources.c62
        ElseIf CardNumber = 63 Then
            Return My.Resources.c63
        ElseIf CardNumber = 64 Then
            Return My.Resources.c64
        ElseIf CardNumber = 65 Then
            Return My.Resources.c65
        ElseIf CardNumber = 66 Then
            Return My.Resources.c66
        ElseIf CardNumber = 67 Then
            Return My.Resources.c67
        ElseIf CardNumber = 68 Then
            Return My.Resources.c68
        ElseIf CardNumber = 69 Then
            Return My.Resources.c69
        ElseIf CardNumber = 70 Then
            Return My.Resources.c70
        ElseIf CardNumber = 71 Then
            Return My.Resources.c71
        ElseIf CardNumber = 72 Then
            Return My.Resources.c72
        ElseIf CardNumber = 73 Then
            Return My.Resources.c73
        ElseIf CardNumber = 74 Then
            Return My.Resources.c74
        ElseIf CardNumber = 75 Then
            Return My.Resources.c75
        ElseIf CardNumber = 76 Then
            Return My.Resources.c76
        ElseIf CardNumber = 77 Then
            Return My.Resources.c77
        ElseIf CardNumber = 78 Then
            Return My.Resources.c78
        ElseIf CardNumber = 79 Then
            Return My.Resources.c79
        ElseIf CardNumber = 80 Then
            Return My.Resources.c80
        ElseIf CardNumber = 81 Then
            Return My.Resources.c81
        ElseIf CardNumber = 82 Then
            Return My.Resources.c82
        ElseIf CardNumber = 83 Then
            Return My.Resources.c83
        ElseIf CardNumber = 84 Then
            Return My.Resources.c84
        ElseIf CardNumber = 85 Then
            Return My.Resources.c85
        ElseIf CardNumber = 86 Then
            Return My.Resources.c86
        Else
            Return My.Resources.c0
        End If
    End Function
    Private Sub PBMenu_Click(sender As Object, e As EventArgs) Handles PBMenu.Click
        If MsgBox("Are you sure you want return to the main menu?" & vbCrLf & "Game in progress will be lost!", MsgBoxStyle.YesNo, "Return to Menu?") = MsgBoxResult.Yes Then
            Dim oForm As Form
            oForm = MainMenu
            oForm.Show()
            UnreadyDeck()
            Close()
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If DeckState = 2 Then
            MoveEventCheck()
            TranslateBoard(0, -1)
            UpdateArrays()
            PBWalk_Click(PictureBox7, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -2 And CardStack(workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If DeckState = 2 Then
            PlayCard(DrawCard, 3, -1, 1)
            MoveEventCheck()
            TranslateBoard(1, -1)
            UpdateArrays()
            PBWalk_Click(PictureBox6, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If DeckState = 2 Then
            PlayCard(DrawCard, 3, 1, 1)
            MoveEventCheck()
            TranslateBoard(-1, -1)
            UpdateArrays()
            PBWalk_Click(PictureBox8, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 2 And CardStack(workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 3 And CardStack(workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 2 And CardStack(workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If DeckState = 2 Then
            MoveEventCheck()
            TranslateBoard(-1, 0)
            UpdateArrays()
            PBWalk_Click(PictureBox14, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        For workcounter = 1 To 86 Step 1
            If CardStack(workcounter, 5) = 3 Then
                If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 0 Then
                    DisplayZoom(workcounter)
                End If
            End If
        Next
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If DeckState = 2 Then
            MoveEventCheck()
            TranslateBoard(1, 0)
            UpdateArrays()
            PBWalk_Click(PictureBox12, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -2 And CardStack(workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -3 And CardStack(workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -2 And CardStack(workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If DeckState = 2 Then
            PlayCard(DrawCard, 3, -1, -1)
            MoveEventCheck()
            TranslateBoard(1, 1)
            UpdateArrays()
            PBWalk_Click(PictureBox18, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If DeckState = 2 Then
            MoveEventCheck()
            TranslateBoard(0, 1)
            UpdateArrays()
            PBWalk_Click(PictureBox19, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If DeckState = 2 Then
            MoveEventCheck()
            PlayCard(DrawCard, 3, 1, -1)
            TranslateBoard(-1, 1)
            UpdateArrays()
            PBWalk_Click(PictureBox20, Nothing)
            PictureBox13_Click(Nothing, Nothing)
        ElseIf DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 2 And CardStack(workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = -2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = -2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PBWalk_Click(sender As Object, e As EventArgs) Handles PBWalk.Click
        UpdateArrays()
        If DeckState = 1 Then 'ready
            DeckState = 2
            NCounter.Enabled = False
            Dim workcounter As Integer
            For workcounter = 1 To 25 Step 1
                CardArray(workcounter).Visible = False
                DispArray(workcounter).Visible = False
            Next
            CardArray(13).Enabled = True
            CardArray(13).Visible = True
            If CardStack(CurrentPlane, 4) <> 0 Then DispArray(13).Visible = True
            Dim NEHellride As Boolean = True
            Dim SEHellride As Boolean = True
            Dim NWHellride As Boolean = True
            Dim SWHellride As Boolean = True
            For workcounter = 1 To 86 Step 1 'for every card
                If CardStack(workcounter, 5) = 3 Then 'that is active
                    If CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 0 Then 'if it occupies valid movement coodinates show and enable it.
                        CardArray(12).Visible = True
                        CardArray(12).Enabled = True
                        If CardStack(workcounter, 4) <> 0 Then DispArray(12).Visible = True
                    ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 0 Then
                        CardArray(14).Visible = True
                        CardArray(14).Enabled = True
                        If CardStack(workcounter, 4) <> 0 Then DispArray(14).Visible = True
                    ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 1 Then
                        CardArray(7).Visible = True
                        CardArray(7).Enabled = True
                        If CardStack(workcounter, 4) <> 0 Then DispArray(7).Visible = True
                    ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -1 Then
                        CardArray(19).Visible = True
                        CardArray(19).Enabled = True
                        If CardStack(workcounter, 4) <> 0 Then DispArray(19).Visible = True
                    ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = -1 Then 'if there's already a card in diagonal, don't allow hellriding
                        SEHellride = False
                    ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = -1 Then
                        SWHellride = False
                    ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 1 Then
                        NEHellride = False
                    ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 1 Then
                        NWHellride = False
                    End If
                    If DeckCounter < 1 Then 'disable hellride if no cards to draw
                        SEHellride = False
                        SWHellride = False
                        NEHellride = False
                        NWHellride = False
                    End If
                End If
            Next
            If SWHellride = True Then 'make visible and enable hellride slots
                CardArray(18).Visible = True
                CardArray(18).Enabled = True
            End If
            If SEHellride = True Then
                CardArray(20).Visible = True
                CardArray(20).Enabled = True
            End If
            If NWHellride = True Then
                CardArray(6).Visible = True
                CardArray(6).Enabled = True
            End If
            If NEHellride = True Then
                CardArray(8).Visible = True
                CardArray(8).Enabled = True
            End If
        ElseIf DeckState = 2 Then
            DeckState = 1
            NCounter.Enabled = True
            For workcounter = 1 To 25 Step 1
                CardArray(workcounter).Enabled = True
                CardArray(workcounter).Visible = True
            Next
        End If
    End Sub
    Private Sub PBChaos_Click(sender As Object, e As EventArgs) Handles PBChaos.Click
        If CardStack(CurrentPlane, 3) = 0 Then
            DisplayZoom(CurrentPlane)
        ElseIf CardStack(CurrentPlane, 3) = 5 Then ''Aretopolis Flag reminder to draw cards equal to counters
            MsgBox("Please draw " & CardStack(CurrentPlane, 4) & " cards.", MsgBoxStyle.Information, "Draw Cards: Aretopolis")
        ElseIf CardStack(CurrentPlane, 3) = 9 Then ''Pools of Becoming Triple Draw Chaos
            GameEvent(9)
        ElseIf CardStack(CurrentPlane, 3) = 11 Then ''Stairs to Infinity Scry Planar Deck
            GameEvent(11)
        ElseIf CardStack(CurrentPlane, 3) > -1 Then
            DisplayZoom(CurrentPlane)
        End If
    End Sub
    Private Sub PBZoom_Click(sender As Object, e As EventArgs) Handles PBZoom.Click
        PBZoom.Enabled = False
        PBZoom.Visible = False
        PBZoom.SendToBack()
        LBLZoom.Visible = False
        LBLZoom.SendToBack()
        NCounter.Enabled = True
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 3 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If DeckState = 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -3 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub NCounter_ValueChanged(sender As Object, e As EventArgs) Handles NCounter.ValueChanged
        If DeckState = 1 Then
            CardStack(CurrentPlane, 4) = NCounter.Value
            DispArray(13).Visible = False
            DispArray(13).BackColor = Color.Transparent
            DispArray(13).Text = " "
            DispArray(13).ForeColor = Color.Gray
            If CardStack(CurrentPlane, 4) <> 0 Then DispArray(13).Enabled = True
            If CardStack(CurrentPlane, 4) <> 0 Then DispArray(13).Visible = True
            If CardStack(CurrentPlane, 4) > 0 Then DispArray(13).BackColor = Color.DarkBlue
            If CardStack(CurrentPlane, 4) > 0 Then DispArray(13).ForeColor = Color.LightYellow
            If CardStack(CurrentPlane, 4) < 0 Then DispArray(13).ForeColor = Color.White
            If CardStack(CurrentPlane, 4) < 0 Then DispArray(13).BackColor = Color.Black
            If CardStack(CurrentPlane, 4) <> 0 Then DispArray(13).Text = CardStack(CurrentPlane, 4)
        End If
        If (CardStack(CurrentPlane, 3) = 5 And CardStack(CurrentPlane, 4) > 9) Then
            MsgBox(AretCounter & " or More Counters!" & vbCrLf & "Please Planeswalk Now", MsgBoxStyle.Exclamation, AretCounter & "+ on Aretopolis")
            PBWalk_Click(NCounter, Nothing)
            PictureBox13_Click(NCounter, Nothing)
        End If
    End Sub

    Private Sub PCardSelect2_Click(sender As Object, e As EventArgs) Handles PCardSelect2.Click
        If DeckState = 3 Then
            If CurrentPlane = 53 Then 'triple draw just needs to stay until clicked
                If MsgBox("Are you done applying all 3 chaos effects?", MsgBoxStyle.YesNo, "Pools of Becoming Exit") = vbYes Then
                    HidePickDisplay()
                    DeckState = 1
                End If
            ElseIf CurrentPlane = 65 Then
                If MsgBox("Are you sure you want to put the revealed card on the bottom?", MsgBoxStyle.YesNo, "Stairs to Infinity Exit") = vbYes Then
                    HidePickDisplay()
                    ReturnCard(DrawCard)
                    DeckState = 1
                End If
            End If
        End If
    End Sub
    Private Sub PCardSelect5_Click(sender As Object, e As EventArgs) Handles PCardSelect5.Click
        If DeckState = 3 Then
            If CurrentPlane = 65 Then
                If MsgBox("Are you sure you want to leave the revealed card on the top?", MsgBoxStyle.YesNo, "Stairs to Infinity Exit") = vbYes Then
                    HidePickDisplay()
                    DeckState = 1
                End If
            End If
        End If
    End Sub
End Class
