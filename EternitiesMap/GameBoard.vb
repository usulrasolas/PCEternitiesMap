Public Class GameBoard
    Private ReadOnly CardArray(25) As PictureBox
    Private ReadOnly DispArray(25) As Label
    Private eventCardInPlay As Integer
    Private eventXloc As Integer = Nothing
    Private eventYloc As Integer = Nothing

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
        PBDoubleZoom1.Enabled = False
        PBDoubleZoom1.Visible = False
        PBDoubleZoom1.SendToBack()
        PBDoubleZoom2.Enabled = False
        PBDoubleZoom2.Visible = False
        PBDoubleZoom2.SendToBack()
        NDoubleZoom1.Enabled = False
        NDoubleZoom1.Visible = False
        NDoubleZoom1.SendToBack()
        NDoubleZoom2.Enabled = False
        NDoubleZoom2.Visible = False
        NDoubleZoom2.SendToBack()
        PBZoom.Visible = False
        LBLZoom.Visible = False
        PBZoom.Enabled = False
        NCounter.Value = 0
        UpdateArrays()
        NewGame()
    End Sub

    Function DoubleZoom(center As Integer, slot1 As Integer, slot2 As Integer)
        For workcounter = 1 To 25 Step 1
            CardArray(workcounter).Enabled = False
            CardArray(workcounter).Visible = False
        Next
        Doublezoombuffer(0) = slot1
        Doublezoombuffer(1) = slot2
        PBDoubleZoom1.Enabled = True
        PBDoubleZoom1.Visible = True
        PBDoubleZoom1.BringToFront()
        PBDoubleZoom2.Enabled = True
        PBDoubleZoom2.Visible = True
        PBDoubleZoom2.BringToFront()
        If Deckstate <> 6 Then NDoubleZoom1.Enabled = True
        If Deckstate <> 6 Then NDoubleZoom1.Visible = True
        If Deckstate <> 6 Then NDoubleZoom1.BringToFront()
        If Deckstate <> 6 Then NDoubleZoom2.Enabled = True
        If Deckstate <> 6 Then NDoubleZoom2.Visible = True
        If Deckstate <> 6 Then NDoubleZoom2.BringToFront()
        PCardSelect2.Enabled = True
        PCardSelect2.Visible = True
        PCardSelect2.BringToFront()
        PCardSelect2.Image = CardImage(center)
        PBDoubleZoom1.Image = CardImage(slot1)
        PBDoubleZoom2.Image = CardImage(slot2)
        If Deckstate <> 6 Then NDoubleZoom1.Value = CardStack(0, slot1, 4)
        If Deckstate <> 6 Then NDoubleZoom2.Value = CardStack(0, slot2, 4)
        Return 0
    End Function

    Function HideDoubleZoom()
        For workcounter = 1 To 25 Step 1
            CardArray(workcounter).Enabled = True
            CardArray(workcounter).Visible = True
        Next
        PBDoubleZoom1.Enabled = False
        PBDoubleZoom1.Visible = False
        PBDoubleZoom1.SendToBack()
        PBDoubleZoom2.Enabled = False
        PBDoubleZoom2.Visible = False
        PBDoubleZoom2.SendToBack()
        NDoubleZoom1.Enabled = False
        NDoubleZoom1.Visible = False
        NDoubleZoom1.SendToBack()
        NDoubleZoom2.Enabled = False
        NDoubleZoom2.Visible = False
        NDoubleZoom2.SendToBack()
        PCardSelect2.Enabled = False
        PCardSelect2.Visible = False
        PCardSelect2.SendToBack()
        Deckstate = 1
        Return 0
    End Function

    Function DisplayZoom(CardNumber As Integer) As Boolean
        If CheckPosition(CardNumber) = True And Deckstate < 9 Then
            PBZoom.Image = CardImage(CardNumber)
            PBZoom.BringToFront()
            PBZoom.Visible = True
            PBZoom.Enabled = True
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.Visible = True
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.BringToFront()
            If CardStack(0, CardNumber, 4) > 0 Then LBLZoom.BackColor = Color.DarkBlue
            If CardStack(0, CardNumber, 4) > 0 Then LBLZoom.ForeColor = Color.LightYellow
            If CardStack(0, CardNumber, 4) < 0 Then LBLZoom.ForeColor = Color.White
            If CardStack(0, CardNumber, 4) < 0 Then LBLZoom.BackColor = Color.Black
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.Text = CardStack(0, CardNumber, 4)
            NCounter.Enabled = False
            DisplayZoom = True
        ElseIf CheckPosition(CardNumber) = False And Deckstate = 6 Then
            PBZoom.Image = CardImage(CardNumber)
            PBZoom.BringToFront()
            PBZoom.Visible = True
            PBZoom.Enabled = True
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.Visible = True
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.BringToFront()
            If CardStack(0, CardNumber, 4) > 0 Then LBLZoom.BackColor = Color.DarkBlue
            If CardStack(0, CardNumber, 4) > 0 Then LBLZoom.ForeColor = Color.LightYellow
            If CardStack(0, CardNumber, 4) < 0 Then LBLZoom.ForeColor = Color.White
            If CardStack(0, CardNumber, 4) < 0 Then LBLZoom.BackColor = Color.Black
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.Text = CardStack(0, CardNumber, 4)
            NCounter.Enabled = False
            DisplayZoom = True
        ElseIf CheckPosition(CardNumber) = False And Deckstate = 9 Then
            PBZoom.Image = CardImage(CardNumber)
            PBZoom.BringToFront()
            PBZoom.Visible = True
            PBZoom.Enabled = True
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.Visible = True
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.BringToFront()
            If CardStack(0, CardNumber, 4) > 0 Then LBLZoom.BackColor = Color.DarkBlue
            If CardStack(0, CardNumber, 4) > 0 Then LBLZoom.ForeColor = Color.LightYellow
            If CardStack(0, CardNumber, 4) < 0 Then LBLZoom.ForeColor = Color.White
            If CardStack(0, CardNumber, 4) < 0 Then LBLZoom.BackColor = Color.Black
            If CardStack(0, CardNumber, 4) <> 0 Then LBLZoom.Text = CardStack(0, CardNumber, 4)
            NCounter.Enabled = False
            DisplayZoom = True
        ElseIf CheckPosition(CardNumber) = False Then ''if multiple occupancy
            If CardStack(1, CardNumber, 0) >= 1 Then ''if HASMETADATA is set to any >0 value
                Dim UpdateCard1 As Integer = CardNumber
                Dim UpdatePartner1 As Integer = CardStack(1, UpdateCard1, 3)
                Dim UpdateDisplay1 As Integer = CardStack(1, UpdateCard1, 1)
                Dim UpdateCard2 As Integer = CardStack(1, UpdateCard1, 3)
                Dim UpdatePartner2 As Integer = CardStack(1, UpdateCard2, 3)
                Dim UpdateDisplay2 As Integer = CardStack(1, UpdateCard2, 1)
                If UpdateDisplay1 = UpdateDisplay2 AndAlso UpdateCard1 = UpdatePartner2 AndAlso UpdatePartner1 = UpdateCard2 Then ''check linked metadata for match
                    DoubleZoom(UpdateDisplay1, UpdateCard1, UpdatePartner1)
                    DisplayZoom = True
                Else ''mismatched metadata
                    DisplayZoom = False
                    PBZoom.Image = CardImage(-1)
                    PBZoom.BringToFront()
                    PBZoom.Visible = True
                    PBZoom.Enabled = True
                    NCounter.Enabled = False
                End If
            ElseIf CheckPosition(CardNumber) = False And CardStack(0, CardNumber, 3) >= 20 Then
                DisplayZoom = True
                PBZoom.Image = CardImage(CardNumber)
                PBZoom.BringToFront()
                PBZoom.Visible = True
                PBZoom.Enabled = True
                NCounter.Enabled = False
            Else ''double occupancy without metadata
                PBZoom.Image = CardImage(-1)
                PBZoom.BringToFront()
                PBZoom.Visible = True
                PBZoom.Enabled = True
                NCounter.Enabled = False
                DisplayZoom = True
            End If
        End If
        Return DisplayZoom
    End Function

    Function PhenomEvent(phenomnumber As Integer, xloc As Integer, yloc As Integer)
        eventXloc = xloc
        eventYloc = yloc
        If phenomnumber = 26 Then ''Interplanar Tunnel
            eventCardInPlay = phenomnumber
            Deckstate = 4
            Drawbuffer(0) = DrawCard()
            Drawbuffer(1) = DrawCard()
            Drawbuffer(2) = DrawCard()
            Drawbuffer(3) = DrawCard()
            Drawbuffer(4) = DrawCard()
            PickDisplay(26, Drawbuffer(0), Drawbuffer(1), Drawbuffer(2), Drawbuffer(3), Drawbuffer(4))
            MsgBox("Select one Plane to go ontop of Planar Deck" & vbCrLf & "Click on Plane of your Selection to Resolve Interplanar Tunnel", MsgBoxStyle.Information, "Interplanar Tunnel")
        ElseIf phenomnumber = 64 Then ''Spatial Merging
            eventCardInPlay = phenomnumber
            Deckstate = 6
            Drawbuffer(0) = DrawCard()
            Drawbuffer(1) = DrawCard()
            Dim eventdistance As Integer = Math.Abs(xloc) + Math.Abs(yloc)
            If eventdistance = 2 Then
                DoubleZoom(phenomnumber, Drawbuffer(0), Drawbuffer(1))
                PlayCard(Drawbuffer(0), 3, xloc, yloc)
                PlayCard(Drawbuffer(1), 3, xloc, yloc)
            ElseIf eventdistance = 1 Then
                Dim ExistingPlane As Integer
                For workcounter = 1 To Masterdeckcount Step 1
                    If CardStack(0, workcounter, 1) = xloc And CardStack(0, workcounter, 2) = yloc Then
                        ExistingPlane = workcounter
                        ReturnCard(ExistingPlane)
                    End If
                    DoubleZoom(phenomnumber, Drawbuffer(0), Drawbuffer(1))
                    PlayCard(Drawbuffer(0), 3, xloc, yloc)
                    PlayCard(Drawbuffer(1), 3, xloc, yloc)
                Next
            Else
                DisplayZoom(-1)
            End If
        Else
            StdPhenomEvent(phenomnumber, xloc, yloc)
        End If
        Return 0
    End Function

    Function StdPhenomEvent(phenomnumber As Integer, xloc As Integer, yloc As Integer)
        eventCardInPlay = phenomnumber
        Deckstate = 4
        DisplayZoom(phenomnumber)
        Dim eventdistance = Math.Abs(xloc) + Math.Abs(yloc)
        If eventdistance = 2 Then PlayCard(DrawCard, 3, xloc, yloc)
        MoveEventCheck()
        Dim invxloc As Integer
        Dim invyloc As Integer
        If xloc = 1 Then
            invxloc = -1
        ElseIf xloc = -1 Then
            invxloc = 1
        Else
            invxloc = 0
        End If
        If yloc = 1 Then
            invyloc = -1
        ElseIf yloc = -1 Then
            invyloc = 1
        Else
            invyloc = 0
        End If
        TranslateBoard(invxloc, invyloc)
        Return 0
    End Function

    Function ResolvePhenom(phenomnumber As Integer)
        ResolvePhenom = True
        Dim PersistPhenomDisplay As Boolean = False
        If phenomnumber = 9 Or 97 Or 98 Or 108 Or 208 Or 220 Then PersistPhenomDisplay = True ''this is where you set the phenom to persist on screen
        ''only need special handlers with additon of generic handler with persistdisplayoptionstuff
        If phenomnumber = 26 Then ''Interplanar Tunnel
            Dim eventdistance = Math.Abs(eventXloc) + Math.Abs(eventYloc)
            If eventdistance = 2 Then PlayCard(DrawCard, 3, eventXloc, eventYloc)
            MoveEventCheck()
            Dim invxloc As Integer
            Dim invyloc As Integer
            If eventXloc = 1 Then
                invxloc = -1
            ElseIf eventXloc = -1 Then
                invxloc = 1
            Else
                invxloc = 0
            End If
            If eventYloc = 1 Then
                invyloc = -1
            ElseIf eventYloc = -1 Then
                invyloc = 1
            Else
                invyloc = 0
            End If
            TranslateBoard(invxloc, invyloc)
            Deckstate = 1
            PBWalk_Click(Nothing, Nothing)
            PBWalk_Click(Nothing, Nothing)
            UpdateArrays()
        ElseIf phenomnumber = 64 Then ''Spatial Merging
            CardStack(1, Drawbuffer(0), 0) = 1
            CardStack(1, Drawbuffer(1), 0) = 1
            CardStack(1, Drawbuffer(0), 1) = 64
            CardStack(1, Drawbuffer(1), 1) = 64
            CardStack(1, Drawbuffer(1), 2) = 0
            CardStack(1, Drawbuffer(0), 2) = 0
            CardStack(1, Drawbuffer(1), 3) = Drawbuffer(0)
            CardStack(1, Drawbuffer(0), 3) = Drawbuffer(1)
            MoveEventCheck()
            Dim invxloc As Integer
            Dim invyloc As Integer
            If eventXloc = 1 Then
                invxloc = -1
            ElseIf eventXloc = -1 Then
                invxloc = 1
            Else
                invxloc = 0
            End If
            If eventYloc = 1 Then
                invyloc = -1
            ElseIf eventYloc = -1 Then
                invyloc = 1
            Else
                invyloc = 0
            End If
            TranslateBoard(invxloc, invyloc)
            Deckstate = 1
            PlayCard(Drawbuffer(0), 3, 0, 0)
            PlayCard(Drawbuffer(1), 3, 0, 0)
            PBWalk_Click(Nothing, Nothing)
            PBWalk_Click(Nothing, Nothing)
            UpdateArrays()
        Else ''generic handler
            Deckstate = 1
            If PersistPhenomDisplay = True Then
                PCardSelect6.BringToFront()
                PCardSelect6.Visible = True
                PCardSelect6.Image = CardImage(phenomnumber)
            End If
        End If
    End Function

    Function GameEvent(EventType As Integer) As Integer
        GameEvent = -1
        If EventType = 9 Then ''Pools of Becoming Triple Draw
            Deckstate = 3
            Drawbuffer(0) = DrawCard()
            Drawbuffer(1) = DrawCard()
            Drawbuffer(2) = DrawCard()
            PickDisplay(Currentplane, Nothing, Nothing, Drawbuffer(0), Drawbuffer(1), Drawbuffer(2))
            ReturnCard(Drawbuffer(0))
            ReturnCard(Drawbuffer(1))
            ReturnCard(Drawbuffer(2))
            MsgBox("All 3 Revealed Chaos Effects Resolve." & vbCrLf & "Player who rolled chaos chooses resolve order." & vbCrLf & "Click Pools of Becoming to Return to Play when All Resolved", MsgBoxStyle.Information, "Pools of Becoming")
            GameEvent = EventType
        ElseIf EventType = 11 Then ''Stairs to Infinity Scry Planar Deck on Chaos
            Deckstate = 3
            PickDisplay(Currentplane, Nothing, Nothing, Nothing, CardLookup(Deckcounter), Nothing)
            MsgBox("Click on Revealed Card to Keep On Top of Planar Deck" & vbCrLf & "Click on Stairs to Infinity to Put Revealed Card on Bottom of Planar Deck", MsgBoxStyle.Information, "Stairs to Infinity")
            GameEvent = EventType
        ElseIf EventType = 118 Then
            PBWalk_Click(Nothing, Nothing)
            MsgBox("Planeswalk then Roll the Planar die and treat ANY result as Chaos. Resolve Chaos of New Plane Immediately after Walk.", MsgBoxStyle.Information, "Holodeck Chaos Walk")
        Else
            MsgBox("GameEvent Called But Not Configured", MsgBoxStyle.Critical, "GameEvent Call Failure")
        End If
        Return GameEvent
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
        If slot1 > 0 Then PCardSelect1.BringToFront()
        If trigPlane > 0 Then PCardSelect2.BringToFront()
        If slot2 > 0 Then PCardSelect3.BringToFront()
        If slot3 > 0 Then PCardSelect4.BringToFront()
        If slot4 > 0 Then PCardSelect5.BringToFront()
        If slot5 > 0 Then PCardSelect6.BringToFront()
        If slot1 > 0 Then PCardSelect1.Enabled = True
        If trigPlane > 0 Then PCardSelect2.Enabled = True
        If slot2 > 0 Then PCardSelect3.Enabled = True
        If slot3 > 0 Then PCardSelect4.Enabled = True
        If slot4 > 0 Then PCardSelect5.Enabled = True
        If slot5 > 0 Then PCardSelect6.Enabled = True
        If slot1 > 0 Then PCardSelect1.Visible = True
        If trigPlane > 0 Then PCardSelect2.Visible = True
        If slot2 > 0 Then PCardSelect3.Visible = True
        If slot3 > 0 Then PCardSelect4.Visible = True
        If slot4 > 0 Then PCardSelect5.Visible = True
        If slot5 > 0 Then PCardSelect6.Visible = True
        If slot1 > 0 Then PCardSelect1.Image = CardImage(slot1)
        If trigPlane > 0 Then PCardSelect2.Image = CardImage(trigPlane)
        If slot2 > 0 Then PCardSelect3.Image = CardImage(slot2)
        If slot3 > 0 Then PCardSelect4.Image = CardImage(slot3)
        If slot4 > 0 Then PCardSelect5.Image = CardImage(slot4)
        If slot5 > 0 Then PCardSelect6.Image = CardImage(slot5)
        PBChaos.Enabled = False
        NCounter.Enabled = False
        PBWalk.Enabled = False
        PickDisplay = True
    End Function

    Public Function NewGame()
        ReadyDeck()
        PlayCard(DrawCard, 3, 0, 0)
        PBZoom.Enabled = True
        PBZoom.Visible = True
        PBZoom.BringToFront()
        PBZoom.Image = CardImage(Drawbuffer(0))
        Deckstate = 1
        HidePickDisplay()
        PopulateBoard()
        UpdateArrays()
        Return 0
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
        PBChaos.Enabled = True
        NCounter.Enabled = True
        PBWalk.Enabled = True
        Return 0
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
#Disable Warning CA1303 ' Do not pass literals as localized parameters
            DispArray(workcounter).Text = " "
#Enable Warning CA1303 ' Do not pass literals as localized parameters
            DispArray(workcounter).ForeColor = Color.Gray
            DispArray(workcounter).Invalidate()
        Next
        For workcounter = 1 To Masterdeckcount Step 1
            If CardStack(0, workcounter, 5) = 3 Then
                If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 3 Then
                    UpdateArrayElement(1, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 2 Then
                    UpdateArrayElement(2, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 2 Then
                    UpdateArrayElement(3, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 2 Then
                    UpdateArrayElement(4, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -2 And CardStack(0, workcounter, 2) = 1 Then
                    UpdateArrayElement(5, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 1 Then
                    UpdateArrayElement(6, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 1 Then
                    UpdateArrayElement(7, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 1 Then
                    UpdateArrayElement(8, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 2 And CardStack(0, workcounter, 2) = 1 Then
                    UpdateArrayElement(9, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -3 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(10, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -2 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(11, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(12, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(13, workcounter)
                    If CheckPosition(workcounter) = True Then
                        NCounter.Enabled = True
                    ElseIf CheckPosition(workcounter) = False Then
                        NCounter.Enabled = False
                    End If
                    Currentplane = workcounter
                    NCounter.Value = CardStack(0, workcounter, 4)
                ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(14, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 2 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(15, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 3 And CardStack(0, workcounter, 2) = 0 Then
                    UpdateArrayElement(16, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -2 And CardStack(0, workcounter, 2) = -1 Then
                    UpdateArrayElement(17, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = -1 Then
                    UpdateArrayElement(18, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -1 Then
                    UpdateArrayElement(19, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = -1 Then
                    UpdateArrayElement(20, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 2 And CardStack(0, workcounter, 2) = -1 Then
                    UpdateArrayElement(21, workcounter)
                ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = -2 Then
                    UpdateArrayElement(22, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -2 Then
                    UpdateArrayElement(23, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = -2 Then
                    UpdateArrayElement(24, workcounter)
                ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -3 Then
                    UpdateArrayElement(25, workcounter)
                End If
            End If
        Next
        Me.Invalidate()
        Return 0
    End Function

    Function UpdateArrayElement(DispNumber As Integer, Cardnumber As Integer)
        If CheckPosition(Cardnumber) = True Then
            CardArray(DispNumber).Image = CardImage(Cardnumber)
            If CardStack(0, Cardnumber, 4) <> 0 Then DispArray(DispNumber).Enabled = True
            If CardStack(0, Cardnumber, 4) <> 0 Then DispArray(DispNumber).Visible = True
            If CardStack(0, Cardnumber, 4) > 0 Then DispArray(DispNumber).BackColor = Color.DarkBlue
            If CardStack(0, Cardnumber, 4) > 0 Then DispArray(DispNumber).ForeColor = Color.LightYellow
            If CardStack(0, Cardnumber, 4) < 0 Then DispArray(DispNumber).ForeColor = Color.White
            If CardStack(0, Cardnumber, 4) < 0 Then DispArray(DispNumber).BackColor = Color.Black
            If CardStack(0, Cardnumber, 4) <> 0 Then DispArray(DispNumber).Text = CardStack(0, Cardnumber, 4)
        ElseIf CheckPosition(Cardnumber) = False Then ''if multiple occupancy
            If CardStack(1, Cardnumber, 0) >= 1 Then ''if HASMETADATA is set to any >0 value
                Dim UpdateCard1 As Integer = Cardnumber
                Dim UpdatePartner1 As Integer = CardStack(1, UpdateCard1, 3)
                Dim UpdateDisplay1 As Integer = CardStack(1, UpdateCard1, 1)
                Dim UpdateCard2 As Integer = CardStack(1, UpdateCard1, 3)
                Dim UpdatePartner2 As Integer = CardStack(1, UpdateCard2, 3)
                Dim UpdateDisplay2 As Integer = CardStack(1, UpdateCard2, 1)
                If UpdateDisplay1 = UpdateDisplay2 AndAlso UpdateCard1 = UpdatePartner2 AndAlso UpdatePartner1 = UpdateCard2 Then ''check linked metadata for match
                    CardArray(DispNumber).Image = CardImage(UpdateDisplay1) ''display metadata card instead
                Else
                    GoTo 850
                End If
            Else
850:
                CardArray(DispNumber).Image = CardImage(-1)
            End If
        End If
        Return 0
    End Function

    Function MoveEventCheck()
        PCardSelect6.SendToBack()
        PCardSelect6.Visible = False
        PCardSelect6.Image = Nothing
        If CardStack(0, Currentplane, 3) = 5 Then ''Aeropolis Flag for 10 Counters Walks Away
            If CardStack(0, Currentplane, 4) >= Aretcounter And Aretresetmove = True Then CardStack(0, Currentplane, 4) = 0
        ElseIf CardStack(0, Currentplane, 3) = 6 Then ''Naar Isle Counter Reset on Exit if reset is true
            If Naarreset = True Then CardStack(0, Currentplane, 4) = 0
        ElseIf (CardStack(0, Currentplane, 3) = 7 And CardStack(0, Currentplane, 4) > 0) Then ''Mount Keralia Damage on Exit Reminder/Reset
            MsgBox("Mount Keralia Deals " & CardStack(0, Currentplane, 4) & " Damage to Each Creature and Each Planeswalker", MsgBoxStyle.Exclamation, "Mount Keralia Erupts!")
            CardStack(0, Currentplane, 4) = 0
        End If
        Return 0
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
        ElseIf CardNumber = 87 Then
            Return My.Resources.c87
        ElseIf CardNumber = 88 Then
            Return My.Resources.c88
        ElseIf CardNumber = 89 Then
            Return My.Resources.c89
        ElseIf CardNumber = 90 Then
            Return My.Resources.c90
        ElseIf CardNumber = 91 Then
            Return My.Resources.c91
        ElseIf CardNumber = 92 Then
            Return My.Resources.c92
        ElseIf CardNumber = 93 Then
            Return My.Resources.c93
        ElseIf CardNumber = 94 Then
            Return My.Resources.c94
        ElseIf CardNumber = 95 Then
            Return My.Resources.c95
        ElseIf CardNumber = 96 Then
            Return My.Resources.c96
        ElseIf CardNumber = 97 Then
            Return My.Resources.c97
        ElseIf CardNumber = 98 Then
            Return My.Resources.c98
        ElseIf CardNumber = 99 Then
            Return My.Resources.c99
        ElseIf CardNumber = 100 Then
            Return My.Resources.c100
        ElseIf CardNumber = 101 Then
            Return My.Resources.c101
        ElseIf CardNumber = 102 Then
            Return My.Resources.c102
        ElseIf CardNumber = 103 Then
            Return My.Resources.c103
        ElseIf CardNumber = 104 Then
            Return My.Resources.c104
        ElseIf CardNumber = 105 Then
            Return My.Resources.c105
        ElseIf CardNumber = 106 Then
            Return My.Resources.c106
        ElseIf CardNumber = 107 Then
            Return My.Resources.c107
        ElseIf CardNumber = 108 Then
            Return My.Resources.c108
        ElseIf CardNumber = 109 Then
            Return My.Resources.c109
        ElseIf CardNumber = 110 Then
            Return My.Resources.c110
        ElseIf CardNumber = 111 Then
            Return My.Resources.c111
        ElseIf CardNumber = 112 Then
            Return My.Resources.c112
        ElseIf CardNumber = 113 Then
            Return My.Resources.c113
        ElseIf CardNumber = 114 Then
            Return My.Resources.c114
        ElseIf CardNumber = 115 Then
            Return My.Resources.c115
        ElseIf CardNumber = 116 Then
            Return My.Resources.c116
        ElseIf CardNumber = 117 Then
            Return My.Resources.c117
        ElseIf CardNumber = 118 Then
            Return My.Resources.c118
        ElseIf CardNumber = 119 Then
            Return My.Resources.c119
        ElseIf CardNumber = 120 Then
            Return My.Resources.c120
        ElseIf CardNumber = 121 Then
            Return My.Resources.c121
        ElseIf CardNumber = 122 Then
            Return My.Resources.c122
        ElseIf CardNumber = 123 Then
            Return My.Resources.c123
        ElseIf CardNumber = 124 Then
            Return My.Resources.c124
        ElseIf CardNumber = 125 Then
            Return My.Resources.c125
        ElseIf CardNumber = 126 Then
            Return My.Resources.c126
        ElseIf CardNumber = 127 Then
            Return My.Resources.c127
        ElseIf CardNumber = 128 Then
            Return My.Resources.c128
        ElseIf CardNumber = 129 Then
            Return My.Resources.c129
        ElseIf CardNumber = 130 Then
            Return My.Resources.c130
        ElseIf CardNumber = 131 Then
            Return My.Resources.c131
        ElseIf CardNumber = 132 Then
            Return My.Resources.c132
        ElseIf CardNumber = 133 Then
            Return My.Resources.c133
        ElseIf CardNumber = 134 Then
            Return My.Resources.c134
        ElseIf CardNumber = 135 Then
            Return My.Resources.c135
        ElseIf CardNumber = 136 Then
            Return My.Resources.c136
        ElseIf CardNumber = 137 Then
            Return My.Resources.c137
        ElseIf CardNumber = 138 Then
            Return My.Resources.c138
        ElseIf CardNumber = 139 Then
            Return My.Resources.c139
        ElseIf CardNumber = 140 Then
            Return My.Resources.c140
        ElseIf CardNumber = 141 Then
            Return My.Resources.c141
        ElseIf CardNumber = 142 Then
            Return My.Resources.c142
        ElseIf CardNumber = 143 Then
            Return My.Resources.c143
        ElseIf CardNumber = 144 Then
            Return My.Resources.c144
        ElseIf CardNumber = 145 Then
            Return My.Resources.c145
        ElseIf CardNumber = 146 Then
            Return My.Resources.c146
        ElseIf CardNumber = 147 Then
            Return My.Resources.c147
        ElseIf CardNumber = 148 Then
            Return My.Resources.c148
        ElseIf CardNumber = 149 Then
            Return My.Resources.c149
        ElseIf CardNumber = 150 Then
            Return My.Resources.c150
        ElseIf CardNumber = 151 Then
            Return My.Resources.c151
        ElseIf CardNumber = 152 Then
            Return My.Resources.c152
        ElseIf CardNumber = 153 Then
            Return My.Resources.c153
        ElseIf CardNumber = 154 Then
            Return My.Resources.c154
        ElseIf CardNumber = 155 Then
            Return My.Resources.c155
        ElseIf CardNumber = 156 Then
            Return My.Resources.c156
        ElseIf CardNumber = 157 Then
            Return My.Resources.c157
        ElseIf CardNumber = 158 Then
            Return My.Resources.c158
        ElseIf CardNumber = 159 Then
            Return My.Resources.c159
        ElseIf CardNumber = 160 Then
            Return My.Resources.c160
        ElseIf CardNumber = 161 Then
            Return My.Resources.c161
        ElseIf CardNumber = 162 Then
            Return My.Resources.c162
        ElseIf CardNumber = 163 Then
            Return My.Resources.c163
        ElseIf CardNumber = 164 Then
            Return My.Resources.c164
        ElseIf CardNumber = 165 Then
            Return My.Resources.c165
        ElseIf CardNumber = 166 Then
            Return My.Resources.c166
        ElseIf CardNumber = 167 Then
            Return My.Resources.c167
        ElseIf CardNumber = 168 Then
            Return My.Resources.c168
        ElseIf CardNumber = 169 Then
            Return My.Resources.c169
        ElseIf CardNumber = 170 Then
            Return My.Resources.c170
        ElseIf CardNumber = 171 Then
            Return My.Resources.c171
        ElseIf CardNumber = 172 Then
            Return My.Resources.c172
        ElseIf CardNumber = 173 Then
            Return My.Resources.c173
        ElseIf CardNumber = 174 Then
            Return My.Resources.c174
        ElseIf CardNumber = 175 Then
            Return My.Resources.c175
        ElseIf CardNumber = 176 Then
            Return My.Resources.c176
        ElseIf CardNumber = 177 Then
            Return My.Resources.c177
        ElseIf CardNumber = 178 Then
            Return My.Resources.c178
        ElseIf CardNumber = 179 Then
            Return My.Resources.c179
        ElseIf CardNumber = 180 Then
            Return My.Resources.c180
        ElseIf CardNumber = 181 Then
            Return My.Resources.c181
        ElseIf CardNumber = 182 Then
            Return My.Resources.c182
        ElseIf CardNumber = 183 Then
            Return My.Resources.c183
        ElseIf CardNumber = 184 Then
            Return My.Resources.c184
        ElseIf CardNumber = 185 Then
            Return My.Resources.c185
        ElseIf CardNumber = 186 Then
            Return My.Resources.c186
        ElseIf CardNumber = 187 Then
            Return My.Resources.c187
        ElseIf CardNumber = 188 Then
            Return My.Resources.c188
        ElseIf CardNumber = 189 Then
            Return My.Resources.c189
        ElseIf CardNumber = 190 Then
            Return My.Resources.c190
        ElseIf CardNumber = 191 Then
            Return My.Resources.c191
        ElseIf CardNumber = 192 Then
            Return My.Resources.c192
        ElseIf CardNumber = 193 Then
            Return My.Resources.c193
        ElseIf CardNumber = 194 Then
            Return My.Resources.c194
        ElseIf CardNumber = 195 Then
            Return My.Resources.c195
        ElseIf CardNumber = 196 Then
            Return My.Resources.c196
        ElseIf CardNumber = 197 Then
            Return My.Resources.c197
        ElseIf CardNumber = 198 Then
            Return My.Resources.c198
        ElseIf CardNumber = 199 Then
            Return My.Resources.c199
        ElseIf CardNumber = 200 Then
            Return My.Resources.c200
        ElseIf CardNumber = 201 Then
            Return My.Resources.c201
        ElseIf CardNumber = 202 Then
            Return My.Resources.c202
        ElseIf CardNumber = 203 Then
            Return My.Resources.c203
        ElseIf CardNumber = 204 Then
            Return My.Resources.c204
        ElseIf CardNumber = 205 Then
            Return My.Resources.c205
        ElseIf CardNumber = 206 Then
            Return My.Resources.c206
        ElseIf CardNumber = 207 Then
            Return My.Resources.c207
        ElseIf CardNumber = 208 Then
            Return My.Resources.c208
        ElseIf CardNumber = 209 Then
            Return My.Resources.c209
        ElseIf CardNumber = 210 Then
            Return My.Resources.c210
        ElseIf CardNumber = 211 Then
            Return My.Resources.c211
        ElseIf CardNumber = 212 Then
            Return My.Resources.c212
        ElseIf CardNumber = 213 Then
            Return My.Resources.c213
        ElseIf CardNumber = 214 Then
            Return My.Resources.c214
        ElseIf CardNumber = 215 Then
            Return My.Resources.c215
        ElseIf CardNumber = 216 Then
            Return My.Resources.c216
        ElseIf CardNumber = 217 Then
            Return My.Resources.c217
        ElseIf CardNumber = 218 Then
            Return My.Resources.c218
        ElseIf CardNumber = 219 Then
            Return My.Resources.c219
        ElseIf CardNumber = 220 Then
            Return My.Resources.c220
        ElseIf CardNumber = 221 Then
            Return My.Resources.c221
        ElseIf CardNumber = 222 Then
            Return My.Resources.c222
        ElseIf CardNumber = 223 Then
            Return My.Resources.c223
        ElseIf CardNumber = 224 Then
            Return My.Resources.c224
        ElseIf CardNumber = 225 Then
            Return My.Resources.c225
        ElseIf CardNumber = 226 Then
            Return My.Resources.c226
        ElseIf CardNumber = 227 Then
            Return My.Resources.c227
        ElseIf CardNumber = 228 Then
            Return My.Resources.c228
        ElseIf CardNumber = 229 Then
            Return My.Resources.c229
        ElseIf CardNumber = 230 Then
            Return My.Resources.c230
        ElseIf CardNumber = 231 Then
            Return My.Resources.c231
        ElseIf CardNumber = 232 Then
            Return My.Resources.c232
        ElseIf CardNumber = 233 Then
            Return My.Resources.c233
        ElseIf CardNumber = 234 Then
            Return My.Resources.c234
        ElseIf CardNumber = 235 Then
            Return My.Resources.c235
        ElseIf CardNumber = 236 Then
            Return My.Resources.c236
        ElseIf CardNumber = 237 Then
            Return My.Resources.c237
        ElseIf CardNumber = 238 Then
            Return My.Resources.c238
        ElseIf CardNumber = 239 Then
            Return My.Resources.c239
        ElseIf CardNumber = 240 Then
            Return My.Resources.c240
        ElseIf CardNumber = 241 Then
            Return My.Resources.c241
        ElseIf CardNumber = 242 Then
            Return My.Resources.c242
        ElseIf CardNumber = 243 Then
            Return My.Resources.c243
        ElseIf CardNumber = 244 Then
            Return My.Resources.c244
        ElseIf CardNumber = 245 Then
            Return My.Resources.c245
        ElseIf CardNumber = 246 Then
            Return My.Resources.c246
        ElseIf CardNumber = 247 Then
            Return My.Resources.c247
        ElseIf CardNumber = 248 Then
            Return My.Resources.c248
        ElseIf CardNumber = 249 Then
            Return My.Resources.c249
        ElseIf CardNumber = 250 Then
            Return My.Resources.c250
        ElseIf CardNumber = 251 Then
            Return My.Resources.c251
        ElseIf CardNumber = 252 Then
            Return My.Resources.c252
        ElseIf CardNumber = 253 Then
            Return My.Resources.c253
        ElseIf CardNumber = -1 Then
            Return My.Resources.SHGR
        Else
            Return My.Resources.SHGR
        End If
    End Function

    Shared Function PhenomMoveChanceCheck() As Boolean
        If Phenommovechance > 0 And Phenomsupport = True Then
            PhenomMoveChanceCheck = False
            Dim randomroll As Integer = Int((100 * Rnd()) + 1)
            If randomroll <= Phenommovechance Then PhenomMoveChanceCheck = True
        Else
            PhenomMoveChanceCheck = False
        End If
    End Function

    Shared Function PhenomHellMoveChanceCheck() As Boolean
        If Phenomhelljchance > 0 And Phenomsupport = True Then
            PhenomHellMoveChanceCheck = False
            Dim randomroll As Integer = Int((100 * Rnd()) + 1)
            If randomroll <= Phenomhelljchance Then PhenomHellMoveChanceCheck = True
        Else
            PhenomHellMoveChanceCheck = False
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
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Deckstate = 2 Then
            If PhenomMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                TranslateBoard(0, -1)
                UpdateArrays()
                PBWalk_Click(PictureBox7, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, 0, 1)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -2 And CardStack(0, workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Deckstate = 2 Then
            If PhenomHellMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                PlayCard(DrawCard, 3, -1, 1)
                MoveEventCheck()
                TranslateBoard(1, -1)
                UpdateArrays()
                PBWalk_Click(PictureBox6, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, -1, 1)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If Deckstate = 2 Then
            If PhenomHellMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                PlayCard(DrawCard, 3, 1, 1)
                MoveEventCheck()
                TranslateBoard(-1, -1)
                UpdateArrays()
                PBWalk_Click(PictureBox8, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, 1, 1)
            End If

        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 2 And CardStack(0, workcounter, 2) = 1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 3 And CardStack(0, workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 2 And CardStack(0, workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If Deckstate = 2 Then
            If PhenomMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                MoveEventCheck()
                TranslateBoard(-1, 0)
                UpdateArrays()
                PBWalk_Click(PictureBox14, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, 1, 0)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        For workcounter = 1 To Masterdeckcount Step 1
            If CardStack(0, workcounter, 5) = 3 Then
                If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 0 Then
                    DisplayZoom(workcounter)
                End If
            End If
        Next
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If Deckstate = 2 Then
            If PhenomMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                MoveEventCheck()
                TranslateBoard(1, 0)
                UpdateArrays()
                PBWalk_Click(PictureBox12, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, -1, 0)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -2 And CardStack(0, workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -3 And CardStack(0, workcounter, 2) = 0 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -2 And CardStack(0, workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If Deckstate = 2 Then
            If PhenomHellMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                PlayCard(DrawCard, 3, -1, -1)
                MoveEventCheck()
                TranslateBoard(1, 1)
                UpdateArrays()
                PBWalk_Click(PictureBox18, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, -1, -1)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If Deckstate = 2 Then
            If PhenomMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                MoveEventCheck()
                TranslateBoard(0, 1)
                UpdateArrays()
                PBWalk_Click(PictureBox19, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, 0, -1)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If Deckstate = 2 Then
            If PhenomHellMoveChanceCheck() = False Or Phenomdecksize < 1 Then
                MoveEventCheck()
                PlayCard(DrawCard, 3, 1, -1)
                TranslateBoard(-1, 1)
                UpdateArrays()
                PBWalk_Click(PictureBox20, Nothing)
                PictureBox13_Click(Nothing, Nothing)
            Else
                PhenomEvent(PickRandomPhenom, 1, -1)
            End If
        ElseIf Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 2 And CardStack(0, workcounter, 2) = -1 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = -2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = -2 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PBWalk_Click(sender As Object, e As EventArgs) Handles PBWalk.Click
        UpdateArrays()
        If Deckstate = 1 Then 'ready
            Deckstate = 2
            NCounter.Enabled = False
            Dim workcounter As Integer
            For workcounter = 1 To 25 Step 1
                CardArray(workcounter).Visible = False
                DispArray(workcounter).Visible = False
            Next
            CardArray(13).Enabled = True
            CardArray(13).Visible = True
            If CardStack(0, Currentplane, 4) <> 0 Then DispArray(13).Visible = True
            Dim NEHellride As Boolean = True
            Dim SEHellride As Boolean = True
            Dim NWHellride As Boolean = True
            Dim SWHellride As Boolean = True
            For workcounter = 1 To Masterdeckcount Step 1 'for every card
                If CardStack(0, workcounter, 5) = 3 Then 'that is active
                    If CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 0 Then 'if it occupies valid movement coodinates show and enable it.
                        CardArray(12).Visible = True
                        CardArray(12).Enabled = True
                        If CardStack(0, workcounter, 4) <> 0 Then DispArray(12).Visible = True
                    ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 0 Then
                        CardArray(14).Visible = True
                        CardArray(14).Enabled = True
                        If CardStack(0, workcounter, 4) <> 0 Then DispArray(14).Visible = True
                    ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 1 Then
                        CardArray(7).Visible = True
                        CardArray(7).Enabled = True
                        If CardStack(0, workcounter, 4) <> 0 Then DispArray(7).Visible = True
                    ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -1 Then
                        CardArray(19).Visible = True
                        CardArray(19).Enabled = True
                        If CardStack(0, workcounter, 4) <> 0 Then DispArray(19).Visible = True
                    ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = -1 Then 'if there's already a card in diagonal, don't allow hellriding
                        SEHellride = False
                    ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = -1 Then
                        SWHellride = False
                    ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 1 Then
                        NEHellride = False
                    ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 1 Then
                        NWHellride = False
                    End If
                    If Deckcounter < 1 Then 'disable hellride if no cards to draw
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
        ElseIf Deckstate = 2 Then
            Deckstate = 1
            NCounter.Enabled = True
            For workcounter = 1 To 25 Step 1
                CardArray(workcounter).Enabled = True
                CardArray(workcounter).Visible = True
            Next
        End If
    End Sub

    Private Sub PBChaos_Click(sender As Object, e As EventArgs) Handles PBChaos.Click
        If CardStack(0, Currentplane, 3) = 0 Then
            DisplayZoom(Currentplane)
        ElseIf CardStack(0, Currentplane, 3) = 5 Then ''Aretopolis Flag reminder to draw cards equal to counters
            MsgBox("Please draw " & CardStack(0, Currentplane, 4) & " cards.", MsgBoxStyle.Information, "Draw Cards: Aretopolis")
        ElseIf CardStack(0, Currentplane, 3) = 9 Then ''Pools of Becoming Triple Draw Chaos
            If Deckcounter >= 3 Then
                GameEvent(9)
            Else
                MsgBox("Less Than 3 Cards on Planar Deck. Unable to Perform Chaos Action", MsgBoxStyle.Exclamation, "Pools of Becoming Failure")
            End If
        ElseIf CardStack(0, Currentplane, 3) = 11 Then ''Stairs to Infinity Scry Planar Deck
            If Deckcounter >= 2 Then
                GameEvent(11)
            Else
                MsgBox("Less than 2 Cards on Planar Deck. Unable to Perform Chaos Action", MsgBoxStyle.Exclamation, "Stairs to Infinity Scry")
            End If
        ElseIf CardStack(0, Currentplane, 3) = 101 Then 'holodeck
            GameEvent(118)
        ElseIf CardStack(0, Currentplane, 3) > -1 Then
            DisplayZoom(Currentplane)
        End If
    End Sub

    Private Sub PBZoom_Click(sender As Object, e As EventArgs) Handles PBZoom.Click
        If Deckstate = 4 Then
            Deckstate = 5
            PBZoom.Enabled = False
            PBZoom.Visible = False
            PBZoom.SendToBack()
            LBLZoom.Visible = False
            LBLZoom.SendToBack()
            NCounter.Enabled = True
            ResolvePhenom(eventCardInPlay)
            PBWalk_Click(PBZoom, Nothing)
            PBWalk_Click(PBZoom, Nothing)
            UpdateArrays()
        Else
            PBZoom.Enabled = False
            PBZoom.Visible = False
            PBZoom.SendToBack()
            LBLZoom.Visible = False
            LBLZoom.SendToBack()
            NCounter.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 3 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If Deckstate = 1 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -3 Then
                        DisplayZoom(workcounter)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub NCounter_ValueChanged(sender As Object, e As EventArgs) Handles NCounter.ValueChanged
        If Deckstate = 1 Then
            CardStack(0, Currentplane, 4) = NCounter.Value
            DispArray(13).Visible = False
            DispArray(13).BackColor = Color.Transparent
#Disable Warning CA1303 ' Do not pass literals as localized parameters
            DispArray(13).Text = " "
#Enable Warning CA1303 ' Do not pass literals as localized parameters
            DispArray(13).ForeColor = Color.Gray
            If CardStack(0, Currentplane, 4) <> 0 Then DispArray(13).Enabled = True
            If CardStack(0, Currentplane, 4) <> 0 Then DispArray(13).Visible = True
            If CardStack(0, Currentplane, 4) > 0 Then DispArray(13).BackColor = Color.DarkBlue
            If CardStack(0, Currentplane, 4) > 0 Then DispArray(13).ForeColor = Color.LightYellow
            If CardStack(0, Currentplane, 4) < 0 Then DispArray(13).ForeColor = Color.White
            If CardStack(0, Currentplane, 4) < 0 Then DispArray(13).BackColor = Color.Black
            If CardStack(0, Currentplane, 4) <> 0 Then DispArray(13).Text = CardStack(0, Currentplane, 4)
        End If
        If (CardStack(0, Currentplane, 3) = 5 And CardStack(0, Currentplane, 4) > 9) Then
            MsgBox(Aretcounter & " or More Counters!" & vbCrLf & "Please Planeswalk Now", MsgBoxStyle.Exclamation, Aretcounter & "+ on Aretopolis")
            PBWalk_Click(NCounter, Nothing)
            PictureBox13_Click(NCounter, Nothing)
        End If
    End Sub

    Private Sub PCardSelect2_Click(sender As Object, e As EventArgs) Handles PCardSelect2.Click
        If Deckstate = 3 Then
            If Currentplane = 53 Then 'triple draw just needs to stay until clicked
                If MsgBox("Are you done applying all 3 chaos effects?", MsgBoxStyle.YesNo, "Pools of Becoming Exit") = vbYes Then
                    HidePickDisplay()
                    Deckstate = 1
                End If
            ElseIf Currentplane = 65 Then
                If MsgBox("Are you sure you want to put the revealed card on the bottom?", MsgBoxStyle.YesNo, "Stairs to Infinity Exit") = vbYes Then
                    HidePickDisplay()
                    ReturnCard(DrawCard)
                    Deckstate = 1
                End If
            End If
        ElseIf Deckstate = 6 Then
            If MsgBox("Spatial Merging Resolves with Both Displayed Planes. Continue?", MsgBoxStyle.YesNo, "Spatial Merging Resolves") = MsgBoxResult.Yes Then
                HideDoubleZoom()
                Deckstate = 5
                ResolvePhenom(eventCardInPlay)
            End If
        ElseIf Deckstate = 9 Then
            HideDoubleZoom()
        Else
            HideDoubleZoom()
            HidePickDisplay()
            UpdateArrays()
        End If
    End Sub

    Private Sub PCardSelect5_Click(sender As Object, e As EventArgs) Handles PCardSelect5.Click
        If Deckstate = 3 Then
            If Currentplane = 65 Then
                If MsgBox("Are you sure you want to leave the revealed card on the top?", MsgBoxStyle.YesNo, "Stairs to Infinity Exit") = vbYes Then
                    HidePickDisplay()
                    Deckstate = 1
                End If
            End If
        ElseIf Deckstate = 4 Then
            Deckstate = 5
            CardStack(0, Drawbuffer(3), 0) = Deckcounter + 1
            Deckcounter += 1
            CardLookup(Deckcounter) = Drawbuffer(3)
            ReturnCard(Drawbuffer(1))
            ReturnCard(Drawbuffer(2))
            ReturnCard(Drawbuffer(0))
            ReturnCard(Drawbuffer(4))
            HidePickDisplay()
            ResolvePhenom(eventCardInPlay)
        End If
    End Sub

    Private Sub PCardSelect1_Click(sender As Object, e As EventArgs) Handles PCardSelect1.Click
        If Deckstate = 4 Then
            Deckstate = 5
            CardStack(0, Drawbuffer(0), 0) = Deckcounter + 1
            Deckcounter += 1
            CardLookup(Deckcounter) = Drawbuffer(0)
            ReturnCard(Drawbuffer(1))
            ReturnCard(Drawbuffer(2))
            ReturnCard(Drawbuffer(3))
            ReturnCard(Drawbuffer(4))
            HidePickDisplay()
            ResolvePhenom(eventCardInPlay)
        End If
    End Sub

    Private Sub PCardSelect6_Click(sender As Object, e As EventArgs) Handles PCardSelect6.Click
        If Deckstate = 4 Then
            Deckstate = 5
            CardStack(0, Drawbuffer(4), 0) = Deckcounter + 1
            Deckcounter += 1
            CardLookup(Deckcounter) = Drawbuffer(4)
            ReturnCard(Drawbuffer(1))
            ReturnCard(Drawbuffer(2))
            ReturnCard(Drawbuffer(0))
            ReturnCard(Drawbuffer(3))
            HidePickDisplay()
            ResolvePhenom(eventCardInPlay)
        ElseIf Deckstate = 6 Then
            DisplayZoom(Drawbuffer(1))
        End If
    End Sub

    Private Sub PCardSelect4_Click(sender As Object, e As EventArgs) Handles PCardSelect4.Click
        If Deckstate = 4 Then
            Deckstate = 5
            CardStack(0, Drawbuffer(2), 0) = Deckcounter + 1
            Deckcounter += 1
            CardLookup(Deckcounter) = Drawbuffer(2)
            ReturnCard(Drawbuffer(1))
            ReturnCard(Drawbuffer(3))
            ReturnCard(Drawbuffer(0))
            ReturnCard(Drawbuffer(4))
            HidePickDisplay()
            ResolvePhenom(eventCardInPlay)
        ElseIf Deckstate = 6 Then
            DisplayZoom(Drawbuffer(0))
        End If
    End Sub

    Private Sub PCardSelect3_Click(sender As Object, e As EventArgs) Handles PCardSelect3.Click
        If Deckstate = 4 Then
            Deckstate = 5
            CardStack(0, Drawbuffer(1), 0) = Deckcounter + 1
            Deckcounter += 1
            CardLookup(Deckcounter) = Drawbuffer(1)
            ReturnCard(Drawbuffer(3))
            ReturnCard(Drawbuffer(2))
            ReturnCard(Drawbuffer(0))
            ReturnCard(Drawbuffer(4))
            HidePickDisplay()
            ResolvePhenom(eventCardInPlay)
        End If
    End Sub

    Private Sub NDoubleZoom1_ValueChanged(sender As Object, e As EventArgs) Handles NDoubleZoom1.ValueChanged
        CardStack(0, Doublezoombuffer(0), 4) = NDoubleZoom1.Value
    End Sub

    Private Sub NDoubleZoom2_ValueChanged(sender As Object, e As EventArgs) Handles NDoubleZoom2.ValueChanged
        CardStack(0, Doublezoombuffer(1), 4) = NDoubleZoom2.Value
    End Sub

End Class