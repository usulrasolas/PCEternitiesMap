Module PlanarDeck
    ''0 Not Ready, 1 Ready, 2 Moving , 3 InEvent
    Public Deckstate As Integer = 0
    Public deckCounter As Integer = 0
    Public Const masterDeckCount As Integer = 253
    Public CardLookup(masterDeckCount) As Integer
#Disable Warning CA1814 ' Prefer jagged arrays over multidimensional
    Public CardStack(1, masterDeckCount, 5) As Integer
#Enable Warning CA1814 ' Prefer jagged arrays over multidimensional
    Public DrawBuffer(4) As Integer
    Public InfinitePlane As Boolean = False
    Public naarReset As Boolean = False
    Public pretranslateReset As Boolean = False
    Public resetOnReturn As Boolean = True
    Public distanceReset As Boolean = False
    Public aretCounter As Integer = 10
    Public aretResetMove As Boolean = True
    Public phenomSupport As Boolean = False
    Public phenomMoveChance As Integer = 0
    Public phenomHellJChance As Integer = 25
    Public phenomDeck() As Integer
    Public phenomDeckSize As Integer
    Public currentPlane As Integer
    Public doubleZoomBuffer(1) As Integer
    Public pCAnthologies As Boolean = True
    Public expMEAmon As Boolean = False
    Public expMEFiora As Boolean = False
    Public ExpMEIxalan As Boolean = False
    Public ExpMEKaladesh As Boolean = False
    Public ExpMEExtra As Boolean = False
    Public ExpMEPhenoms As Boolean = False
    Public ExpMeTarkir As Boolean = False
    Public ExpMeTheros As Boolean = False
    Public ExpIxalan As Boolean = False
    Public ExpGeek As Boolean = False
    Public ExpPC2019 As Boolean = False
    Public ExpPC2019IxGame As Boolean = False
    Public ExpPc2019Throne As Boolean = False
    Public ExpPC2019Workshop As Boolean = False
    Public ExpPC2017 As Boolean = False

    Public Function ReadyDeck() As Boolean
        Dim WorkCounter As Integer
        ReadyDeck = False
        If Deckstate = 0 Then
            For WorkCounter = 0 To masterDeckCount Step 1
                CardStack(0, WorkCounter, 5) = -1 'Set All State -1disable 0ready 1indeck 2inhand 3onboard
                CardStack(0, WorkCounter, 4) = 0 'Counters
                CardStack(0, WorkCounter, 3) = -1 'Flags
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
                '' cardstack variable matrix information
                ''
                ''
                ''
            Next
            If pCAnthologies = True Then
                For WorkCounter = 1 To 86 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0 'Flags
                Next
                CardStack(0, 4, 3) = 5 ''Aeropolis Flag for 10 Counters Walks Away
                CardStack(0, 0, 3) = 7 ''Mount Keralia Damage on Exit Reminder/Reset
                CardStack(0, 43, 3) = 6 ''Naar Isle Counter Reset on Exit
                CardStack(0, 53, 3) = 9 ''Pools of Becoming Triple Draw Chaos
                CardStack(0, 65, 3) = 11 ''Stairs to Infinity Scry Planar Deck Chaos
            End If
            If expMEAmon = True Then
                For WorkCounter = 87 To 91 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If expMEFiora = True Then
                For WorkCounter = 92 To 96 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpMEIxalan = True Then
                For WorkCounter = 224 To 227 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpMEKaladesh = True Then
                For WorkCounter = 228 To 232 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpMEExtra = True Then
                For WorkCounter = 233 To 239 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpMEPhenoms = True Then
                For WorkCounter = 240 To 243 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpMeTarkir = True Then
                For WorkCounter = 244 To 248 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpMeTheros = True Then
                For WorkCounter = 249 To 253 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpIxalan = True Then
                For WorkCounter = 97 To 110 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
            End If
            If ExpGeek = True Then
                For WorkCounter = 111 To 140 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
                CardStack(0, 118, 3) = 101
            End If
            If ExpPC2019 = True Then
                For WorkCounter = 141 To 183 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
                CardStack(0, 145, 5) = -1
                CardStack(0, 149, 5) = -1

                If ExpPC2019IxGame = True Then 'Trigger for c156 makes you play a game of Explorers of Ixalan
                    CardStack(0, 156, 3) = 156
                Else
                    CardStack(0, 156, 5) = -1
                End If
                CardStack(0, 164, 5) = -1
                CardStack(0, 166, 5) = -1
                CardStack(0, 167, 5) = -1
                CardStack(0, 168, 5) = -1
                CardStack(0, 170, 5) = -1
                If ExpPc2019Throne = False Then CardStack(0, 176, 5) = -1
                If ExpPC2019Workshop = False Then CardStack(0, 173, 5) = -1
            End If
            If ExpPC2017 = True Then
                For WorkCounter = 184 To 223 Step 1
                    CardStack(0, WorkCounter, 5) = 0
                    CardStack(0, WorkCounter, 3) = 0
                Next
                CardStack(0, 190, 5) = -1
                CardStack(0, 191, 5) = -1
                CardStack(0, 197, 5) = -1
                CardStack(0, 208, 5) = -1
                CardStack(0, 209, 5) = -1
                CardStack(0, 211, 5) = -1
                CardStack(0, 219, 5) = -1
                CardStack(0, 220, 5) = -1
            End If
            PhenomInitalize()
            For WorkCounter = 1 To masterDeckCount Step 1
                If CardStack(0, WorkCounter, 3) > -1 AndAlso CardStack(0, WorkCounter, 5) >= 0 Then
                    CardStack(0, WorkCounter, 0) = deckCounter + 1
                    deckCounter += 1
                    CardLookup(deckCounter) = WorkCounter
                    CardStack(0, WorkCounter, 5) = 1
                End If
            Next

            Deckstate = 1
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
        CardStack(0, 97, 5) = -1
        CardStack(0, 98, 5) = -1
        CardStack(0, 99, 5) = -1
        CardStack(0, 101, 5) = -1
        CardStack(0, 102, 5) = -1
        CardStack(0, 103, 5) = -1
        CardStack(0, 104, 5) = -1
        CardStack(0, 107, 5) = -1
        CardStack(0, 108, 5) = -1
        CardStack(0, 145, 5) = -1
        CardStack(0, 164, 5) = -1
        CardStack(0, 172, 5) = -1
        CardStack(0, 183, 5) = -1
        CardStack(0, 240, 5) = -1
        CardStack(0, 241, 5) = -1
        CardStack(0, 242, 5) = -1
        CardStack(0, 243, 5) = -1
        phenomDeckSize = 0
        ReDim phenomDeck(-1)
        If phenomSupport = True Then
            ReDim phenomDeck(0)
            phenomDeck(0) = -1
            If pCAnthologies = True Then
                CardStack(0, 9, 3) = 21 ''Chaotic Aether
                CardStack(0, 26, 3) = 22 ''Interplanar Tunnel
                CardStack(0, 39, 3) = 23 ''Morphic Tide
                CardStack(0, 42, 3) = 24 ''Mutual Epiphany
                CardStack(0, 52, 3) = 25 ''Planewide Disaster
                CardStack(0, 57, 3) = 26 ''Reality Shaping
                CardStack(0, 64, 3) = 27 ''Spatial Merging
                CardStack(0, 80, 3) = 28 ''Time Distortion
                AddPhenomToActive(8, {-1, 80, 64, 57, 52, 42, 39, 26, 9})
            ElseIf pCAnthologies = False Then
                CardStack(0, 9, 3) = -1
                CardStack(0, 26, 3) = -1
                CardStack(0, 39, 3) = -1
                CardStack(0, 42, 3) = -1
                CardStack(0, 52, 3) = -1
                CardStack(0, 57, 3) = -1
                CardStack(0, 64, 3) = -1
                CardStack(0, 80, 3) = -1
            End If
            If ExpIxalan = True Then
                CardStack(0, 97, 3) = 29 ''Blessing of the Shapers
                CardStack(0, 98, 3) = 30 ''Bloodfast
                CardStack(0, 99, 3) = 31 ''Bloodstained Massacre
                CardStack(0, 101, 3) = 32 ''Dramatic Entrance
                CardStack(0, 102, 3) = 33 ''Gates of Orazca
                CardStack(0, 103, 3) = 34 ''Gold-Laden Shipwreck
                CardStack(0, 104, 3) = 35 ''Mass Mutiny
                CardStack(0, 107, 3) = 36 ''River's Rebuke
                CardStack(0, 108, 3) = 37 ''Savage Instinct
                AddPhenomToActive(9, {-1, 97, 98, 99, 101, 102, 103, 104, 107, 108})
            ElseIf ExpIxalan = False Then
                CardStack(0, 97, 3) = -1
                CardStack(0, 98, 3) = -1
                CardStack(0, 99, 3) = -1
                CardStack(0, 101, 3) = -1
                CardStack(0, 102, 3) = -1
                CardStack(0, 103, 3) = -1
                CardStack(0, 104, 3) = -1
                CardStack(0, 107, 3) = -1
                CardStack(0, 108, 3) = -1
            End If
            If ExpMEPhenoms = True Then
                CardStack(0, 240, 3) = 0
                CardStack(0, 241, 3) = 0
                CardStack(0, 242, 3) = 0
                CardStack(0, 243, 3) = 0
                AddPhenomToActive(4, {-1, 240, 241, 242, 243})
            ElseIf ExpMEPhenoms = False Then
                CardStack(0, 97, 3) = -1
                CardStack(0, 98, 3) = -1
                CardStack(0, 99, 3) = -1
                CardStack(0, 101, 3) = -1
            End If
        End If
        Return 0
    End Function

    Function AddPhenomToActive(APTAamount As Integer, APTAarray() As Integer)
        phenomDeckSize += APTAamount
        ReDim Preserve phenomDeck(phenomDeckSize)
        Dim WorkCounter As Integer
        Dim InjectionCounter As Integer = APTAamount
        For WorkCounter = ((phenomDeckSize - APTAamount) + 1) To phenomDeck.GetUpperBound(0) Step 1
            phenomDeck(WorkCounter) = APTAarray(InjectionCounter)
            InjectionCounter -= 1
        Next
        Return 0
    End Function

    Function PickRandomPhenom() As Integer
        If phenomDeckSize > 0 Then
555:
            Randomize()
            Dim RandomPhenomRoll As Integer = Int((phenomDeckSize * Rnd()) + 1)
            PickRandomPhenom = phenomDeck(RandomPhenomRoll)
            If deckCounter < 5 Then
                If RandomPhenomRoll = 26 Then GoTo 555
            ElseIf deckCounter < 2 Then
                If RandomPhenomRoll = 26 Then GoTo 555
                If RandomPhenomRoll = 64 Then GoTo 555
            End If
        Else
            PickRandomPhenom = -1
        End If
    End Function

    Public Function UnreadyDeck() As Boolean
        For WorkCounter = 0 To masterDeckCount Step 1
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
        deckCounter = 0
        Deckstate = 0
        Return 0
    End Function

    Public Function Shuffle()
#Disable Warning CA1814 ' Prefer jagged arrays over multidimensional
        Dim ShuffleTracker(masterDeckCount, 1) As Integer
#Enable Warning CA1814 ' Prefer jagged arrays over multidimensional
        Dim ShufflePosCounter As Integer = deckCounter
        Dim WorkCounter As Integer
        Randomize()
        If Deckstate = 1 Or 2 Then
            For WorkCounter = 1 To deckCounter Step 1
500:
                Dim ShuffleRandomVal As Integer = Rnd() * deckCounter
                Dim CheckCounter As Integer
                For CheckCounter = 1 To deckCounter Step 1
                    If ShuffleRandomVal = ShuffleTracker(CheckCounter, 1) Then
                        Randomize()
                        GoTo 500
                    End If
                Next
                ShuffleTracker(WorkCounter, 0) = CardLookup(ShufflePosCounter)
                ShuffleTracker(WorkCounter, 1) = ShuffleRandomVal
                ShufflePosCounter -= 1
            Next
            For WorkCounter = 1 To deckCounter Step 1
                CardStack(0, CardLookup(WorkCounter), 0) = ShuffleTracker(WorkCounter, 1)
                CardLookup(ShuffleTracker(WorkCounter, 1)) = ShuffleTracker(WorkCounter, 0)
            Next
            Return True
        Else Return False
        End If
    End Function

    Public Function DrawCard() As Integer
        If Deckstate = 1 OrElse Deckstate = 2 OrElse Deckstate = 5 Then
            DrawBuffer(0) = CardLookup(deckCounter)
            CardStack(0, CardLookup(deckCounter), 5) = 2
            CardStack(0, CardLookup(deckCounter), 0) = 0
            CardStack(0, CardLookup(deckCounter), 1) = vbNull
            CardStack(0, CardLookup(deckCounter), 2) = vbNull
            CardLookup(deckCounter) = 0
            deckCounter -= 1
            Return DrawBuffer(0)
        ElseIf Deckstate = 4 OrElse Deckstate = 6 OrElse Deckstate = 3 Then ''dont update draw buffer
            DrawCard = CardLookup(deckCounter)
            CardStack(0, CardLookup(deckCounter), 5) = 2
            CardStack(0, CardLookup(deckCounter), 0) = 0
            CardStack(0, CardLookup(deckCounter), 1) = vbNull
            CardStack(0, CardLookup(deckCounter), 2) = vbNull
            CardLookup(deckCounter) = 0
            deckCounter -= 1
            Return DrawCard
        Else Return -1
        End If
    End Function

    Public Function PlayCard(CardNumber As Integer, ToState As Integer, XPos As Integer, YPos As Integer) As Boolean
        If ToState = 1 AndAlso CardStack(0, CardNumber, 5) = 2 Then 'to deck
            Dim workcounter As Integer
            For workcounter = deckCounter To 1 Step -1
                Dim currentcard As Integer = CardLookup(workcounter)
                CardStack(0, CardLookup(workcounter), 0) += 1
                CardLookup(workcounter + 1) = currentcard
            Next
            CardStack(0, CardNumber, 0) = 1
            CardStack(0, CardNumber, 5) = 1
            CardStack(0, CardNumber, 1) = 0
            CardStack(0, CardNumber, 2) = 0
            deckCounter += 1
            CardLookup(1) = CardNumber
            PlayCard = True
        ElseIf ToState = 3 AndAlso CardStack(0, CardNumber, 5) = 2 Then 'to play
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
        For workcounter = 1 To masterDeckCount Step 1
            If CardDeckPos = CardStack(0, workcounter, 0) AndAlso CardDeckPos > 0 Then
                DeckCheck += 1
                CheckPosition = False
            ElseIf CardDeckPos <= 0 AndAlso CardStack(0, workcounter, 5) = 3 Then
                If CardStack(0, workcounter, 1) = CardxPos AndAlso CardStack(0, workcounter, 2) = CardyPos Then
                    XyCheck += 1
                    CheckPosition = False
                End If
            End If
            If DeckCheck = 0 AndAlso XyCheck = 1 Then
                CheckPosition = True
            ElseIf DeckCheck = 1 AndAlso XyCheck = 0 Then
                CheckPosition = True
            End If
        Next
        Return CheckPosition
    End Function

    Public Function ReturnCard(CardNumber As Integer) As Boolean
        ReturnCard = False
        Dim workcounter As Integer
        If CardStack(0, CardNumber, 5) = 3 Then 'if card being returned is on board then
            For workcounter = deckCounter To 1 Step -1 'for every card in deck counting down
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
            If resetOnReturn = True Then CardStack(0, CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            deckCounter += 1
            ReturnCard = True
        ElseIf CardStack(0, CardNumber, 5) = 2 Then ''return card from hand copy for cardbreaking
            For workcounter = deckCounter To 1 Step -1 'for every card in deck counting down
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
            If resetOnReturn = True Then CardStack(0, CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            deckCounter += 1
            ReturnCard = True
        End If
    End Function

    Public Function TranslateBoard(XChange As Integer, YChange As Integer) As Boolean
        Dim workcounter As Integer
        If pretranslateReset = True Then CardStack(0, currentPlane, 4) = 0 ''need to be refactored after phenoms
        If Deckstate = 2 OrElse Deckstate = 4 OrElse Deckstate = 5 Then
            For workcounter = 1 To masterDeckCount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    CardStack(0, workcounter, 1) += XChange
                    CardStack(0, workcounter, 2) += YChange
                End If
            Next
            PopulateBoard()
            If distanceReset = True Then
                For workcounter = 1 To masterDeckCount Step 1
                    Dim distancecounter As Integer
                    distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                    If distancecounter > 3 AndAlso CardStack(0, workcounter, 5) = 3 Then
                        CardStack(0, workcounter, 4) = 0
                    End If
                Next
            End If
            For workcounter = 1 To masterDeckCount Step 1
                If CardStack(0, workcounter, 1) = 0 AndAlso CardStack(0, workcounter, 2) = 0 Then
                    If CheckPosition(workcounter) = True Then ''set currentplane if single
                        currentPlane = workcounter
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
        If InfinitePlane = False AndAlso Deckstate = 2 Then
            For workcounter = 1 To masterDeckCount Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                If distancecounter > 3 AndAlso CardStack(0, workcounter, 5) = 3 Then
                    ReturnCard(workcounter)
                End If
            Next
            For workcounter = 1 To masterDeckCount Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                If distancecounter > 3 AndAlso CardStack(0, workcounter, 5) = 3 Then
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
        If Deckstate = 2 Or 1 Then
            For workcounter = 1 To masterDeckCount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 AndAlso CardStack(0, workcounter, 2) = 1 Then
                        NPopulateCheck = False
                    ElseIf CardStack(0, workcounter, 1) = 0 AndAlso CardStack(0, workcounter, 2) = -1 Then
                        SPopulateCheck = False
                    ElseIf CardStack(0, workcounter, 1) = 1 AndAlso CardStack(0, workcounter, 2) = 0 Then
                        EPopulateCheck = False
                    ElseIf CardStack(0, workcounter, 1) = -1 AndAlso CardStack(0, workcounter, 2) = 0 Then
                        WPopulateCheck = False
                    End If
                End If
            Next
            If NPopulateCheck = True AndAlso deckCounter > 0 Then
                If PlayCard(DrawCard, 3, 0, 1) = True Then PopulateBoard = True
            End If
            If SPopulateCheck = True AndAlso deckCounter > 0 Then
                If PlayCard(DrawCard, 3, 0, -1) = True Then PopulateBoard = True
            End If
            If EPopulateCheck = True AndAlso deckCounter > 0 Then
                If PlayCard(DrawCard, 3, 1, 0) = True Then PopulateBoard = True
            End If
            If WPopulateCheck = True AndAlso deckCounter > 0 Then
                If PlayCard(DrawCard, 3, -1, 0) = True Then PopulateBoard = True
            End If
        End If
    End Function

End Module