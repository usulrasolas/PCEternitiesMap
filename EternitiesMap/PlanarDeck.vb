Module PlanarDeck
    Public DeckState As Integer = 0 ''0 Not Ready, 1 Ready, 2 Moving , 3 InEvent
    Public DeckCounter As Integer = 0
    Public CardLookup(86) As Integer
    Public CardStack(86, 5) As Integer '' DeckPos,XPos,YPos,Flag,Counter,State
    Public DrawBuffer As Integer
    Public InfinitePlane As Boolean = False
    Public NaarReset As Boolean = False
    Public PretranslateReset As Boolean = False
    Public ResetOnReturn As Boolean = True
    Public DistanceReset As Boolean = False
    Public AretCounter As Integer = 10
    Public AretResetMove As Boolean = True
    Public PhenomSupport As Boolean = False
    Public PhenomDealIn As Boolean = False
    Public PhenomMoveChance As Integer = 0
    Public PhenomHellJChance As Integer = 50
    Public PhenomDeck(7) As Integer
    Public Function ReadyDeck() As Boolean
        Dim DeckRndCounter As Integer = Int(Rnd() * 10)
        Dim WorkCounter As Integer
        If DeckState = 0 Then
            For WorkCounter = 0 To 86 Step 1
                CardStack(WorkCounter, 5) = 0 'Set All State To Inactive -1Disabled 0Inactive 1InDeck 2InHand 3OnBoard
                CardStack(WorkCounter, 4) = 0 'Counters
                CardStack(WorkCounter, 3) = 0 'Flags
                CardStack(WorkCounter, 2) = vbNull 'ypos
                CardStack(WorkCounter, 1) = vbNull 'xPos
                CardStack(WorkCounter, 0) = 0 'DeckPos
            Next
            CardStack(4, 3) = 5 ''Aeropolis Flag for 10 Counters Walks Away
            CardStack(40, 3) = 7 ''Mount Keralia Damage on Exit Reminder/Reset
            CardStack(43, 3) = 6 ''Naar Isle Counter Reset on Exit
            CardStack(53, 3) = 9 ''Pools of Becoming Triple Draw Chaos
            CardStack(65, 3) = 11 ''Stairs to Infinity Scry Planar Deck Chaos
            If PhenomSupport = False Then
                CardStack(9, 3) = 21 ''Chaotic Aether
                CardStack(26, 3) = 22 ''Interplanar Tunnel
                CardStack(39, 3) = 23 ''Morphic Tide
                CardStack(42, 3) = 24 ''Mutual Epiphany
                CardStack(52, 3) = 25 ''Planewide Disaster
                CardStack(57, 3) = 26 ''Reality Shaping
                CardStack(64, 3) = 27 ''Spatial Merging
                CardStack(80, 3) = 28 ''Time Distortion
                PhenomDeck = {9, 26, 39, 42, 52, 57, 64, 80}
                If PhenomDealIn = True Then
                    CardStack(9, 5) = 0
                    CardStack(26, 5) = 0
                    CardStack(39, 5) = 0
                    CardStack(42, 5) = 0
                    CardStack(52, 5) = 0
                    CardStack(57, 5) = 0
                    CardStack(64, 5) = 0
                    CardStack(80, 5) = 0
                End If
            End If

            For WorkCounter = 1 To 86 Step 1
                If CardStack(WorkCounter, 3) > -1 And CardStack(WorkCounter, 5) >= 0 Then
                    CardStack(WorkCounter, 0) = DeckCounter + 1
                    DeckCounter += 1
                    CardLookup(DeckCounter) = WorkCounter
                    CardStack(WorkCounter, 5) = 1
                End If
            Next
            DeckState = 1
            Shuffle()
            Return True
        End If
        Return False
    End Function
    Public Function UnreadyDeck() As Boolean
        For WorkCounter = 0 To 86 Step 1
            CardStack(WorkCounter, 5) = 0 'Set All State To Inactive -1Disabled 0Inactive 1InDeck 2InHand 3OnBoard
            CardStack(WorkCounter, 4) = 0 'Counters
            CardStack(WorkCounter, 3) = 0 'Flags
            CardStack(WorkCounter, 2) = 0 'ypos
            CardStack(WorkCounter, 1) = 0 'xPos
            CardStack(WorkCounter, 0) = 0 'DeckPos
            CardLookup(WorkCounter) = 0
        Next
        DeckCounter = 0
        DeckState = 0
    End Function
    Public Function Shuffle()
        Dim ShuffleTracker(86, 1) As Integer
        Dim ShufflePosCounter As Integer = DeckCounter
        Dim WorkCounter As Integer
        Randomize()
        If DeckState = 1 Or 2 Then
            For WorkCounter = 1 To DeckCounter Step 1
500:
                Dim ShuffleRandomVal As Integer = Rnd() * DeckCounter
                Dim CheckCounter As Integer
                For CheckCounter = 1 To DeckCounter Step 1
                    If ShuffleRandomVal = ShuffleTracker(CheckCounter, 1) Then
                        Randomize()
                        GoTo 500
                    End If
                Next
                ShuffleTracker(WorkCounter, 0) = CardLookup(ShufflePosCounter)
                ShuffleTracker(WorkCounter, 1) = ShuffleRandomVal
                ShufflePosCounter -= 1
            Next
            For WorkCounter = 1 To DeckCounter Step 1
                CardStack(CardLookup(WorkCounter), 0) = ShuffleTracker(WorkCounter, 1)
                CardLookup(ShuffleTracker(WorkCounter, 1)) = ShuffleTracker(WorkCounter, 0)
            Next
            Return True
        Else Return False
        End If
    End Function
    Public Function DrawCard() As Integer
        If DeckState = 1 Or 2 Then
            DrawBuffer = CardLookup(DeckCounter)
            CardStack(CardLookup(DeckCounter), 5) = 2
            CardStack(CardLookup(DeckCounter), 0) = 0
            CardStack(CardLookup(DeckCounter), 1) = 0
            CardStack(CardLookup(DeckCounter), 2) = 0
            CardLookup(DeckCounter) = 0
            DeckCounter -= 1
            Return DrawBuffer
        ElseIf DeckState = 3 Then ''event draw, this is currently same but seperated to allow me to breakcode
            DrawBuffer = CardLookup(DeckCounter)
            CardStack(CardLookup(DeckCounter), 5) = 2
            CardStack(CardLookup(DeckCounter), 0) = 0
            CardStack(CardLookup(DeckCounter), 1) = 0
            CardStack(CardLookup(DeckCounter), 2) = 0
            CardLookup(DeckCounter) = 0
            DeckCounter -= 1
            Return DrawBuffer
        Else Return -1
        End If
    End Function
    Public Function PlayCard(
            CardNumber As Integer, ToState As Integer, XPos As Integer, YPos As Integer) As Boolean
        If DeckState = 1 Or 2 Then
            If ToState = 1 And CardStack(CardNumber, 5) = 2 Then 'to deck
                Dim workcounter As Integer
                For workcounter = DeckCounter To 1 Step -1
                    Dim currentcard As Integer = CardLookup(workcounter)
                    CardStack(CardLookup(workcounter), 0) += 1
                    CardLookup(workcounter + 1) = currentcard
                Next
                CardStack(CardNumber, 0) = 1
                CardStack(CardNumber, 5) = 1
                CardStack(CardNumber, 1) = 0
                CardStack(CardNumber, 2) = 0
                DeckCounter += 1
                CardLookup(1) = CardNumber
                Return True
            ElseIf ToState = 3 And CardStack(CardNumber, 5) = 2 Then 'to play
                CardStack(CardNumber, 1) = XPos
                CardStack(CardNumber, 2) = YPos
                CardStack(CardNumber, 0) = 0
                CardStack(CardNumber, 5) = 3
                Return True
            Else
                Return False
            End If
        Else Return False
        End If
    End Function
    Public Function ReturnCard(CardNumber As Integer) As Boolean
        ReturnCard = False
        If CardStack(CardNumber, 5) = 3 Then 'if card being returned is on board then
            Dim workcounter As Integer
            For workcounter = DeckCounter To 1 Step -1 'for every card in deck counting down
                Dim currentcard As Integer = CardLookup(workcounter) 'current card is card in deckcounter position
                CardStack(currentcard, 0) += 1 'increase currentcard, deckpostion + 1
                CardLookup(workcounter + 1) = currentcard 'reverse lookup of new postion and current card
            Next
            CardStack(CardNumber, 0) = 1
            CardStack(CardNumber, 5) = 1
            CardStack(CardNumber, 1) = vbNull
            CardStack(CardNumber, 2) = vbNull
            If ResetOnReturn = True Then CardStack(CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            DeckCounter += 1
            ReturnCard = True
        ElseIf CardStack(CardNumber, 5) = 2 Then ''return card from hand copy for cardbreaking
            Dim workcounter As Integer
            For workcounter = DeckCounter To 1 Step -1 'for every card in deck counting down
                Dim currentcard As Integer = CardLookup(workcounter) 'current card is card in deckcounter position
                CardStack(currentcard, 0) += 1 'increase currentcard, deckpostion + 1
                CardLookup(workcounter + 1) = currentcard 'reverse lookup of new postion and current card
            Next
            CardStack(CardNumber, 0) = 1
            CardStack(CardNumber, 5) = 1
            CardStack(CardNumber, 1) = vbNull
            CardStack(CardNumber, 2) = vbNull
            If ResetOnReturn = True Then CardStack(CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            DeckCounter += 1
            ReturnCard = True
        End If
    End Function
    Public Function TranslateBoard(XChange As Integer, YChange As Integer) As Boolean
        Dim workcounter As Integer
        If PretranslateReset = True Then CardStack(GameBoard.CurrentPlane, 4) = 0
        If DeckState = 2 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    CardStack(workcounter, 1) += XChange
                    CardStack(workcounter, 2) += YChange
                End If
            Next
            PopulateBoard()
            If DistanceReset = True Then
                For workcounter = 1 To 86 Step 1
                    Dim distancecounter As Integer
                    distancecounter = Math.Abs(CardStack(workcounter, 1)) + Math.Abs(CardStack(workcounter, 2))
                    If distancecounter > 3 And CardStack(workcounter, 5) = 3 Then
                        CardStack(workcounter, 4) = 0
                    End If
                Next
            End If
            CullBoard()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CullBoard() As Boolean
        Dim workcounter As Integer
        CullBoard = False
        If InfinitePlane = False And DeckState = 2 Then
            For workcounter = 1 To 86 Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(workcounter, 1)) + Math.Abs(CardStack(workcounter, 2))
                If distancecounter > 3 And CardStack(workcounter, 5) = 3 Then
                    ReturnCard(workcounter)
                End If
            Next
            For workcounter = 1 To 86 Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(workcounter, 1)) + Math.Abs(CardStack(workcounter, 2))
                If distancecounter > 3 And CardStack(workcounter, 5) = 3 Then
                    Return False
                End If
                Shuffle()
                CullBoard = True
            Next
        Else
            CullBoard = False
        End If
    End Function
    Public Function PopulateBoard() As Boolean
        Dim workcounter As Integer
        Dim NPopulateCheck As Boolean = True
        Dim SPopulateCheck As Boolean = True
        Dim EPopulateCheck As Boolean = True
        Dim WPopulateCheck As Boolean = True
        PopulateBoard = False
        If DeckState = 2 Or 1 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(workcounter, 5) = 3 Then
                    If CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = 1 Then
                        NPopulateCheck = False

                    ElseIf CardStack(workcounter, 1) = 0 And CardStack(workcounter, 2) = -1 Then
                        SPopulateCheck = False

                    ElseIf CardStack(workcounter, 1) = 1 And CardStack(workcounter, 2) = 0 Then
                        EPopulateCheck = False

                    ElseIf CardStack(workcounter, 1) = -1 And CardStack(workcounter, 2) = 0 Then
                        WPopulateCheck = False
                    End If
                End If
            Next
            If NPopulateCheck = True And DeckCounter > 0 Then
                If PlayCard(DrawCard, 3, 0, 1) = True Then PopulateBoard = True
            End If
            If SPopulateCheck = True And DeckCounter > 0 Then
                If PlayCard(DrawCard, 3, 0, -1) = True Then PopulateBoard = True
            End If
            If EPopulateCheck = True And DeckCounter > 0 Then
                If PlayCard(DrawCard, 3, 1, 0) = True Then PopulateBoard = True
            End If
            If WPopulateCheck = True And DeckCounter > 0 Then
                If PlayCard(DrawCard, 3, -1, 0) = True Then PopulateBoard = True
            End If
        End If
    End Function
End Module
