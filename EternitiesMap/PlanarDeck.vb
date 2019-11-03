Module PlanarDeck
    Public DeckState As Integer = 0 ''0 Not Ready, 1 Ready, 2 Moving , 3 InEvent
    Public DeckCounter As Integer = 0
    Public CardLookup(86) As Integer
#Disable Warning CA1814 ' Prefer jagged arrays over multidimensional
    Public CardStack(1, 86, 5) As Integer '' 0,deck,1virtual;cardnumber;see readydeck for slot descriptions
#Enable Warning CA1814 ' Prefer jagged arrays over multidimensional
    Public DrawBuffer(4) As Integer
    Public InfinitePlane As Boolean = False
    Public NaarReset As Boolean = False
    Public PretranslateReset As Boolean = False
    Public ResetOnReturn As Boolean = True
    Public DistanceReset As Boolean = False
    Public AretCounter As Integer = 10
    Public AretResetMove As Boolean = True
    Public PhenomSupport As Boolean = False
    Public PhenomMoveChance As Integer = 0
    Public PhenomHellJChance As Integer = 25
    Public PhenomDeck() As Integer
    Public PhenomDeckSize As Integer
    Public CurrentPlane As Integer
    Public DoubleZoomBuffer(1) As Integer
    Public Function ReadyDeck() As Boolean
        Dim DeckRndCounter As Integer = Int(Rnd() * 10)
        Dim WorkCounter As Integer
        ReadyDeck = False
        If DeckState = 0 Then
            For WorkCounter = 0 To 86 Step 1
                CardStack(0, WorkCounter, 5) = 0 'Set All State -1disable 0ready 1indeck 2inhand 3onboard
                CardStack(0, WorkCounter, 4) = 0 'Counters
                CardStack(0, WorkCounter, 3) = 0 'Flags
                CardStack(0, WorkCounter, 2) = Nothing 'ypos
                CardStack(0, WorkCounter, 1) = Nothing 'xPos
                CardStack(0, WorkCounter, 0) = 0 'DeckPos
                CardLookup(WorkCounter) = 0
                CardStack(1, WorkCounter, 5) = -1 'Unpopulated
                CardStack(1, WorkCounter, 4) = -1 'Unpopulated
                CardStack(1, WorkCounter, 3) = -1 'PartnerCard
                CardStack(1, WorkCounter, 2) = -1 'CounterOverride
                CardStack(1, WorkCounter, 1) = -1 'DisplayOverride
                CardStack(1, WorkCounter, 0) = -1 'HasMetadata
            Next
            CardStack(0, 4, 3) = 5 ''Aeropolis Flag for 10 Counters Walks Away
            CardStack(0, 0, 3) = 7 ''Mount Keralia Damage on Exit Reminder/Reset
            CardStack(0, 43, 3) = 6 ''Naar Isle Counter Reset on Exit
            CardStack(0, 53, 3) = 9 ''Pools of Becoming Triple Draw Chaos
            CardStack(0, 65, 3) = 11 ''Stairs to Infinity Scry Planar Deck Chaos
            PhenomInitalize()
            For WorkCounter = 1 To 86 Step 1
                If CardStack(0, WorkCounter, 3) > -1 And CardStack(0, WorkCounter, 5) >= 0 Then
                    CardStack(0, WorkCounter, 0) = DeckCounter + 1
                    DeckCounter += 1
                    CardLookup(DeckCounter) = WorkCounter
                    CardStack(0, WorkCounter, 5) = 1
                End If
            Next
            DeckState = 1
            Shuffle()
            ReadyDeck = True
        End If
        Return ReadyDeck
    End Function

    Function PhenomInitalize()
        CardStack(0, 9, 5) = -1
        CardStack(0, 26, 5) = -1
        CardStack(0, 39, 5) = -1
        CardStack(0, 42, 5) = -1
        CardStack(0, 52, 5) = -1
        CardStack(0, 57, 5) = -1
        CardStack(0, 64, 5) = -1
        CardStack(0, 80, 5) = -1
        If PhenomSupport = True Then
            CardStack(0, 9, 3) = 21 ''Chaotic Aether
            CardStack(0, 26, 3) = 22 ''Interplanar Tunnel
            CardStack(0, 39, 3) = 23 ''Morphic Tide
            CardStack(0, 42, 3) = 24 ''Mutual Epiphany
            CardStack(0, 52, 3) = 25 ''Planewide Disaster
            CardStack(0, 57, 3) = 26 ''Reality Shaping
            CardStack(0, 64, 3) = 27 ''Spatial Merging
            CardStack(0, 80, 3) = 28 ''Time Distortion
        ElseIf PhenomSupport = False Then
            CardStack(0, 9, 3) = -1 ''Chaotic Aether
            CardStack(0, 26, 3) = -1 ''Interplanar Tunnel
            CardStack(0, 39, 3) = -1 ''Morphic Tide
            CardStack(0, 42, 3) = -1 ''Mutual Epiphany
            CardStack(0, 52, 3) = -1 ''Planewide Disaster
            CardStack(0, 57, 3) = -1 ''Reality Shaping
            CardStack(0, 64, 3) = -1 ''Spatial Merging
            CardStack(0, 80, 3) = -1 ''Time Distortion
        End If
        If PhenomSupport = True Then
            ReDim PhenomDeck(8)
            PhenomDeckSize = 8
            PhenomDeck = {-1, 80, 64, 57, 52, 42, 39, 26, 9}
        End If
    End Function

    Function PickRandomPhenom() As Integer
555:
        Randomize()
        Dim RandomPhenomRoll As Integer = Int((PhenomDeckSize * Rnd()) + 1)
        PickRandomPhenom = PhenomDeck(RandomPhenomRoll)
        If DeckCounter < 5 Then
            If RandomPhenomRoll = 26 Then GoTo 555
        ElseIf DeckCounter < 2 Then
            If RandomPhenomRoll = 26 Then GoTo 555
            If RandomPhenomRoll = 64 Then GoTo 555
        End If
    End Function
    Public Function UnreadyDeck() As Boolean
        For WorkCounter = 0 To 86 Step 1
            CardStack(0, WorkCounter, 5) = -1 'Set All State
            CardStack(0, WorkCounter, 4) = -1 'Counters
            CardStack(0, WorkCounter, 3) = -1 'Flags
            CardStack(0, WorkCounter, 2) = vbNull 'ypos
            CardStack(0, WorkCounter, 1) = vbNull 'xPos
            CardStack(0, WorkCounter, 0) = 0 'DeckPos
            CardLookup(WorkCounter) = 0
            CardStack(1, WorkCounter, 5) = -1 'Set All virtual state
            CardStack(1, WorkCounter, 4) = -1 'Counters
            CardStack(1, WorkCounter, 3) = -1 'Flags
            CardStack(1, WorkCounter, 2) = vbNull 'ypos
            CardStack(1, WorkCounter, 1) = vbNull 'xPos
            CardStack(1, WorkCounter, 0) = 0 'DeckPos
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
                CardStack(0, CardLookup(WorkCounter), 0) = ShuffleTracker(WorkCounter, 1)
                CardLookup(ShuffleTracker(WorkCounter, 1)) = ShuffleTracker(WorkCounter, 0)
            Next
            Return True
        Else Return False
        End If
    End Function
    Public Function DrawCard() As Integer
        If DeckState = 1 Or DeckState = 2 Or DeckState = 5 Then
            DrawBuffer(0) = CardLookup(DeckCounter)
            CardStack(0, CardLookup(DeckCounter), 5) = 2
            CardStack(0, CardLookup(DeckCounter), 0) = 0
            CardStack(0, CardLookup(DeckCounter), 1) = vbNull
            CardStack(0, CardLookup(DeckCounter), 2) = vbNull
            CardLookup(DeckCounter) = 0
            DeckCounter -= 1
            Return DrawBuffer(0)
        ElseIf DeckState = 4 Or DeckState = 6 Or DeckState = 3 Then ''dont update draw buffer
            DrawCard = CardLookup(DeckCounter)
            CardStack(0, CardLookup(DeckCounter), 5) = 2
            CardStack(0, CardLookup(DeckCounter), 0) = 0
            CardStack(0, CardLookup(DeckCounter), 1) = vbNull
            CardStack(0, CardLookup(DeckCounter), 2) = vbNull
            CardLookup(DeckCounter) = 0
            DeckCounter -= 1
            Return DrawCard
        Else Return -1
        End If
    End Function
    Public Function PlayCard(CardNumber As Integer, ToState As Integer, XPos As Integer, YPos As Integer) As Boolean
        If ToState = 1 And CardStack(0, CardNumber, 5) = 2 Then 'to deck
            Dim workcounter As Integer
            For workcounter = DeckCounter To 1 Step -1
                Dim currentcard As Integer = CardLookup(workcounter)
                CardStack(0, CardLookup(workcounter), 0) += 1
                CardLookup(workcounter + 1) = currentcard
            Next
            CardStack(0, CardNumber, 0) = 1
            CardStack(0, CardNumber, 5) = 1
            CardStack(0, CardNumber, 1) = 0
            CardStack(0, CardNumber, 2) = 0
            DeckCounter += 1
            CardLookup(1) = CardNumber
            PlayCard = True
        ElseIf ToState = 3 And CardStack(0, CardNumber, 5) = 2 Then 'to play
            CardStack(0, CardNumber, 1) = XPos
            CardStack(0, CardNumber, 2) = YPos
            CardStack(0, CardNumber, 0) = 0
            CardStack(0, CardNumber, 5) = 3
            PlayCard = True
        Else
            PlayCard = False
        End If
        Return PlayCard
    End Function
    Public Function CheckPosition(cardnumber As Integer) As Boolean
        Dim CardDeckPos As Integer = CardStack(0, cardnumber, 0)
        Dim CardxPos As Integer = CardStack(0, cardnumber, 1)
        Dim CardyPos As Integer = CardStack(0, cardnumber, 2)
        Dim DeckCheck As Integer = 0
        Dim XyCheck As Integer = 0
        CheckPosition = False
        For workcounter = 1 To 86 Step 1
            If CardDeckPos = CardStack(0, workcounter, 0) And CardDeckPos > 0 Then
                DeckCheck += 1
                CheckPosition = False
            ElseIf CardDeckPos <= 0 And CardStack(0, workcounter, 5) = 3 Then
                If CardStack(0, workcounter, 1) = CardxPos And CardStack(0, workcounter, 2) = CardyPos Then
                    XyCheck += 1
                    CheckPosition = False
                End If
            End If
            If DeckCheck = 0 And XyCheck = 1 Then
                CheckPosition = True
            ElseIf DeckCheck = 1 And XyCheck = 0 Then
                CheckPosition = True
            End If
        Next
        Return CheckPosition
    End Function
    Public Function ReturnCard(CardNumber As Integer) As Boolean
        ReturnCard = False
        If CardStack(0, CardNumber, 5) = 3 Then 'if card being returned is on board then
            Dim workcounter As Integer
            For workcounter = DeckCounter To 1 Step -1 'for every card in deck counting down
                Dim currentcard As Integer = CardLookup(workcounter) 'current card is card in deckcounter position
                CardStack(0, currentcard, 0) += 1 'increase currentcard, deckpostion + 1
                CardLookup(workcounter + 1) = currentcard 'reverse lookup of new postion and current card
            Next
            CardStack(0, CardNumber, 0) = 1
            CardStack(0, CardNumber, 5) = 1
            CardStack(0, CardNumber, 1) = vbNull
            CardStack(0, CardNumber, 2) = vbNull
            CardStack(1, CardNumber, 0) = -1
            CardStack(1, CardNumber, 1) = -1
            CardStack(1, CardNumber, 2) = -1
            CardStack(1, CardNumber, 3) = -1
            CardStack(1, CardNumber, 4) = -1
            CardStack(1, CardNumber, 5) = -1
            If ResetOnReturn = True Then CardStack(0, CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            DeckCounter += 1
            ReturnCard = True
        ElseIf CardStack(0, CardNumber, 5) = 2 Then ''return card from hand copy for cardbreaking
            Dim workcounter As Integer
            For workcounter = DeckCounter To 1 Step -1 'for every card in deck counting down
                Dim currentcard As Integer = CardLookup(workcounter) 'current card is card in deckcounter position
                CardStack(0, currentcard, 0) += 1 'increase currentcard, deckpostion + 1
                CardLookup(workcounter + 1) = currentcard 'reverse lookup of new postion and current card
            Next
            CardStack(0, CardNumber, 0) = 1
            CardStack(0, CardNumber, 5) = 1
            CardStack(0, CardNumber, 1) = vbNull
            CardStack(0, CardNumber, 2) = vbNull
            CardStack(1, CardNumber, 0) = -1
            CardStack(1, CardNumber, 1) = -1
            CardStack(1, CardNumber, 2) = -1
            CardStack(1, CardNumber, 3) = -1
            CardStack(1, CardNumber, 4) = -1
            CardStack(1, CardNumber, 5) = -1
            If ResetOnReturn = True Then CardStack(0, CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            DeckCounter += 1
            ReturnCard = True
        End If
    End Function
    Public Function TranslateBoard(XChange As Integer, YChange As Integer) As Boolean
        Dim workcounter As Integer
        If PretranslateReset = True Then CardStack(0, CurrentPlane, 4) = 0 ''need to be refactored after phenoms
        If DeckState = 2 Or DeckState = 4 Or DeckState = 5 Then
            For workcounter = 1 To 86 Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    CardStack(0, workcounter, 1) += XChange
                    CardStack(0, workcounter, 2) += YChange
                End If
            Next
            PopulateBoard()
            If DistanceReset = True Then
                For workcounter = 1 To 86 Step 1
                    Dim distancecounter As Integer
                    distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                    If distancecounter > 3 And CardStack(0, workcounter, 5) = 3 Then
                        CardStack(0, workcounter, 4) = 0
                    End If
                Next
            End If
            For workcounter = 1 To 86 Step 1
                If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 0 Then
                    If CheckPosition(workcounter) = True Then ''set currentplane if single
                        CurrentPlane = workcounter
                    ElseIf CheckPosition(workcounter) = False Then
                        ''insert logic here
                    End If
                End If
            Next
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
                distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                If distancecounter > 3 And CardStack(0, workcounter, 5) = 3 Then
                    ReturnCard(workcounter)
                End If
            Next
            For workcounter = 1 To 86 Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                If distancecounter > 3 And CardStack(0, workcounter, 5) = 3 Then
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
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = 1 Then
                        NPopulateCheck = False

                    ElseIf CardStack(0, workcounter, 1) = 0 And CardStack(0, workcounter, 2) = -1 Then
                        SPopulateCheck = False

                    ElseIf CardStack(0, workcounter, 1) = 1 And CardStack(0, workcounter, 2) = 0 Then
                        EPopulateCheck = False

                    ElseIf CardStack(0, workcounter, 1) = -1 And CardStack(0, workcounter, 2) = 0 Then
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
