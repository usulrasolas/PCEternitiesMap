Module PlanarDeck

    ''0 Not Ready, 1 Ready, 2 Moving , 3 InEvent
    Public Deckstate As Integer = 0

    Public Deckcounter As Integer = 0
    Public Const Masterdeckcount As Integer = 278
    Public CardLookup(Masterdeckcount) As Integer
#Disable Warning CA1814 ' Prefer jagged arrays over multidimensional
    Public CardStack(1, Masterdeckcount, 5) As Integer
#Enable Warning CA1814 ' Prefer jagged arrays over multidimensional
    Public Drawbuffer(4) As Integer
    Public Infiniteplane As Boolean = False
    Public Naarreset As Boolean = False
    Public Pretranslatereset As Boolean = False
    Public Resetonreturn As Boolean = True
    Public Distancereset As Boolean = False
    Public Aretcounter As Integer = 10
    Public Aretresetmove As Boolean = True
    Public Phenomsupport As Boolean = False
    Public Phenommovechance As Integer = 0
    Public Phenomhelljchance As Integer = 25
    Public Phenomdeck() As Integer
    Public Phenomdecksize As Integer
    Public Currentplane As Integer
    Public Doublezoombuffer(1) As Integer
    Public Pcanthologies As Boolean = True
    Public ExpMoC As Boolean = True
    Public Expmeamon As Boolean = False
    Public Expmefiora As Boolean = False
    Public Expmeixalan As Boolean = False
    Public Expmekaladesh As Boolean = False
    Public Expmeextra As Boolean = False
    Public Expmephenoms As Boolean = False
    Public Expmetarkir As Boolean = False
    Public Expmetheros As Boolean = False
    Public Expixalan As Boolean = False
    Public Expgeekscape1 As Boolean = False
    Public ExpPC2019 As Boolean = False
    Public ExpPC2019ixgame As Boolean = False
    Public ExpPC2019throne As Boolean = False
    Public ExpPC2019workshop As Boolean = False
    Public ExpPC2019commander As Boolean = False
    Public ExpPC2017 As Boolean = False

    Public Function ReadyCards(start As Integer, finish As Integer)
        Dim WorkCounter As Integer
        For WorkCounter = start To finish Step 1
            ReadyCard(WorkCounter)
        Next
        Return 0
    End Function

    Public Function ReadyCard(value As Integer)
        CardStack(0, value, 5) = 0
        CardStack(0, value, 3) = 0
        Return 0
    End Function

    Public Function ResetDeck()
        Dim WorkCounter As Integer
        For WorkCounter = 0 To Masterdeckcount Step 1
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
        Next
        Return 0
    End Function

    Public Function ReadyDeck() As Boolean
        ReadyDeck = False
        If Deckstate = 0 Then
            ResetDeck()
            If Pcanthologies = True Then
                ReadyCards(1, 86)
                CardStack(0, 4, 3) = 5 ''Aeropolis Flag for 10 Counters Walks Away
                CardStack(0, 0, 3) = 7 ''Mount Keralia Damage on Exit Reminder/Reset
                CardStack(0, 43, 3) = 6 ''Naar Isle Counter Reset on Exit
                CardStack(0, 53, 3) = 9 ''Pools of Becoming Triple Draw Chaos
                CardStack(0, 65, 3) = 11 ''Stairs to Infinity Scry Planar Deck Chaos
            End If
            If Expmeamon = True Then ReadyCards(87, 91)
            If Expmefiora = True Then ReadyCards(92, 96)
            If Expmeixalan = True Then ReadyCards(224, 227)
            If Expmekaladesh = True Then ReadyCards(228, 232)
            If Expmeextra = True Then ReadyCards(233, 239)
            If Expmephenoms = True Then ReadyCards(240, 243)
            If Expmetarkir = True Then ReadyCards(244, 248)
            If Expmetheros = True Then ReadyCards(249, 253)
            If Expixalan = True Then ReadyCards(97, 110)
            If Expgeekscape1 = True Then ReadyCards(111, 140)
            If ExpPC2019 = True Then
                ReadyCards(141, 183)
                CardStack(0, 145, 5) = -1
                CardStack(0, 149, 5) = -1
                If ExpPC2019ixgame = True Then 'Trigger for c156 makes you play a game of Explorers of Ixalan
                    CardStack(0, 156, 3) = 156
                Else
                    CardStack(0, 156, 5) = -1
                End If
                CardStack(0, 164, 5) = -1
                CardStack(0, 166, 5) = -1
                CardStack(0, 167, 5) = -1
                CardStack(0, 168, 5) = -1
                If ExpPC2019commander = False Then CardStack(0, 170, 5) = -1
                If ExpPC2019throne = False Then CardStack(0, 176, 5) = -1
                If ExpPC2019workshop = False Then CardStack(0, 173, 5) = -1
            End If
            If ExpPC2017 = True Then
                ReadyCards(184, 223)
                CardStack(0, 190, 5) = -1
                CardStack(0, 191, 5) = -1
                CardStack(0, 197, 5) = -1
                CardStack(0, 208, 5) = -1
                CardStack(0, 209, 5) = -1
                CardStack(0, 211, 5) = -1
                CardStack(0, 219, 5) = -1
                CardStack(0, 220, 5) = -1
            End If
			If ExpMoC = True Then
				ReadyCards(254, 278)
                CardStack(0, 257, 3) = 257 'The Fertile Lands of Saulvinia Reveal Plane Chaos
                CardStack(0, 267, 3) = 267 'Norn's Seedcore Reveal Plane Chaos
		CardStack(0, 267, 5) = -1 'Disable norn's seedcore until proper implementation
			End If
            PhenomInitalize()
            StackDeck()
            Deckstate = 1
            Shuffle()
            ReadyDeck = True
        End If
        Return ReadyDeck
    End Function

    Public Function StackDeck()
        Dim WorkCounter As Integer
        For WorkCounter = 1 To Masterdeckcount Step 1
            If CardStack(0, WorkCounter, 3) > -1 AndAlso CardStack(0, WorkCounter, 5) >= 0 Then
                CardStack(0, WorkCounter, 0) = Deckcounter + 1
                Deckcounter += 1
                CardLookup(Deckcounter) = WorkCounter
                CardStack(0, WorkCounter, 5) = 1
            End If
        Next
        Return 0
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
        Phenomdecksize = 0
        ReDim Phenomdeck(-1)
        If Phenomsupport = True Then
            ReDim Phenomdeck(0)
            Phenomdeck(0) = -1
            If Pcanthologies = True Then
                CardStack(0, 9, 3) = 21 ''Chaotic Aether
                CardStack(0, 26, 3) = 22 ''Interplanar Tunnel
                CardStack(0, 39, 3) = 23 ''Morphic Tide
                CardStack(0, 42, 3) = 24 ''Mutual Epiphany
                CardStack(0, 52, 3) = 25 ''Planewide Disaster
                CardStack(0, 57, 3) = 26 ''Reality Shaping
                CardStack(0, 64, 3) = 27 ''Spatial Merging
                CardStack(0, 80, 3) = 28 ''Time Distortion
                AddPhenomToActive(8, {-1, 80, 64, 57, 52, 42, 39, 26, 9})
            Else
                CardStack(0, 9, 3) = -1
                CardStack(0, 26, 3) = -1
                CardStack(0, 39, 3) = -1
                CardStack(0, 42, 3) = -1
                CardStack(0, 52, 3) = -1
                CardStack(0, 57, 3) = -1
                CardStack(0, 64, 3) = -1
                CardStack(0, 80, 3) = -1
            End If
            If Expixalan = True Then
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
            Else
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
            If Expmephenoms = True Then
                CardStack(0, 240, 3) = 240
                CardStack(0, 241, 3) = 241
                CardStack(0, 242, 3) = 242
                CardStack(0, 243, 3) = 243
                AddPhenomToActive(4, {-1, 240, 241, 242, 243})
            Else
                CardStack(0, 97, 3) = -1
                CardStack(0, 98, 3) = -1
                CardStack(0, 99, 3) = -1
                CardStack(0, 101, 3) = -1
            End If
            If ExpPC2019commander = True Then
                CardStack(0, 145, 3) = 145
                AddPhenomToActive(1, {-1, 145})
            Else
                CardStack(0, 145, 3) = -1
            End If
            If ExpPC2019 = True Then
                CardStack(0, 172, 3) = 172
                AddPhenomToActive(1, {-1, 172})
            Else
                CardStack(0, 172, 3) = -1
            End If
            If ExpPC2017 = True Then
                CardStack(0, 190, 3) = 190
                CardStack(0, 191, 3) = 191
                CardStack(0, 197, 3) = 197
                CardStack(0, 208, 3) = 208
                CardStack(0, 209, 3) = 209
                CardStack(0, 211, 3) = 211
                CardStack(0, 219, 3) = 219
                CardStack(0, 220, 3) = 220
                AddPhenomToActive(8, {-1, 190, 191, 197, 208, 209, 211, 219, 220})
            Else
                CardStack(0, 190, 3) = -1
                CardStack(0, 191, 3) = -1
                CardStack(0, 197, 3) = -1
                CardStack(0, 208, 3) = -1
                CardStack(0, 209, 3) = -1
                CardStack(0, 211, 3) = -1
                CardStack(0, 219, 3) = -1
                CardStack(0, 220, 3) = -1
            End If
        End If
        Return 0
    End Function

    Function AddPhenomToActive(APTAamount As Integer, APTAarray() As Integer)
        Phenomdecksize += APTAamount
        ReDim Preserve Phenomdeck(Phenomdecksize)
        Dim WorkCounter As Integer
        Dim InjectionCounter As Integer = APTAamount
        For WorkCounter = ((Phenomdecksize - APTAamount) + 1) To Phenomdeck.GetUpperBound(0) Step 1
            Phenomdeck(WorkCounter) = APTAarray(InjectionCounter)
            InjectionCounter -= 1
        Next
        Return 0
    End Function

    Function PickRandomPhenom() As Integer
        If Phenomdecksize > 0 Then
555:
            Randomize()
            Dim RandomPhenomRoll As Integer = Int((Phenomdecksize * Rnd()) + 1)
            PickRandomPhenom = Phenomdeck(RandomPhenomRoll)
            If Deckcounter < 5 Then
                If RandomPhenomRoll = 26 Then GoTo 555
            ElseIf Deckcounter < 2 Then
                If RandomPhenomRoll = 26 Then GoTo 555
                If RandomPhenomRoll = 64 Then GoTo 555
            Else
                ''Nothing Needed
            End If
        Else
            PickRandomPhenom = -1
        End If
    End Function

    Public Function UnreadyDeck() As Boolean
        For WorkCounter = 0 To Masterdeckcount Step 1
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
        Deckcounter = 0
        Deckstate = 0
        Return 0
    End Function

    Public Function Shuffle()
#Disable Warning CA1814 ' Prefer jagged arrays over multidimensional
        Dim ShuffleTracker(Masterdeckcount, 1) As Integer
#Enable Warning CA1814 ' Prefer jagged arrays over multidimensional
        Dim ShufflePosCounter As Integer = Deckcounter
        Dim WorkCounter As Integer
        Randomize()
        If Deckstate = 1 Or 2 Then
            For WorkCounter = 1 To Deckcounter Step 1
500:
                Dim ShuffleRandomVal As Integer = Rnd() * Deckcounter
                Dim CheckCounter As Integer
                For CheckCounter = 1 To Deckcounter Step 1
                    If ShuffleRandomVal = ShuffleTracker(CheckCounter, 1) Then
                        Randomize()
                        GoTo 500
                    End If
                Next
                ShuffleTracker(WorkCounter, 0) = CardLookup(ShufflePosCounter)
                ShuffleTracker(WorkCounter, 1) = ShuffleRandomVal
                ShufflePosCounter -= 1
            Next
            For WorkCounter = 1 To Deckcounter Step 1
                CardStack(0, CardLookup(WorkCounter), 0) = ShuffleTracker(WorkCounter, 1)
                CardLookup(ShuffleTracker(WorkCounter, 1)) = ShuffleTracker(WorkCounter, 0)
            Next
            Return True
        Else Return False
        End If
    End Function

    Public Function DrawCard() As Integer
        If Deckstate = 1 OrElse Deckstate = 2 OrElse Deckstate = 5 Then
            Drawbuffer(0) = CardLookup(Deckcounter)
            CardStack(0, CardLookup(Deckcounter), 5) = 2
            CardStack(0, CardLookup(Deckcounter), 0) = 0
            CardStack(0, CardLookup(Deckcounter), 1) = vbNull
            CardStack(0, CardLookup(Deckcounter), 2) = vbNull
            CardLookup(Deckcounter) = 0
            Deckcounter -= 1
            Return Drawbuffer(0)
        ElseIf Deckstate = 4 OrElse Deckstate = 6 OrElse Deckstate = 3 Then ''dont update draw buffer
            DrawCard = CardLookup(Deckcounter)
            CardStack(0, CardLookup(Deckcounter), 5) = 2
            CardStack(0, CardLookup(Deckcounter), 0) = 0
            CardStack(0, CardLookup(Deckcounter), 1) = vbNull
            CardStack(0, CardLookup(Deckcounter), 2) = vbNull
            CardLookup(Deckcounter) = 0
            Deckcounter -= 1
            Return DrawCard
        Else Return -1
        End If
    End Function

    Public Function PlayCard(CardNumber As Integer, ToState As Integer, XPos As Integer, YPos As Integer) As Boolean
        If ToState = 1 AndAlso CardStack(0, CardNumber, 5) = 2 Then 'to deck
            Dim workcounter As Integer
            For workcounter = Deckcounter To 1 Step -1
                Dim currentcard As Integer = CardLookup(workcounter)
                CardStack(0, CardLookup(workcounter), 0) += 1
                CardLookup(workcounter + 1) = currentcard
            Next
            CardStack(0, CardNumber, 0) = 1
            CardStack(0, CardNumber, 5) = 1
            CardStack(0, CardNumber, 1) = 0
            CardStack(0, CardNumber, 2) = 0
            Deckcounter += 1
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
        For workcounter = 1 To Masterdeckcount Step 1
            If CardDeckPos = CardStack(0, workcounter, 0) AndAlso CardDeckPos > 0 Then
                DeckCheck += 1
                CheckPosition = False
            ElseIf CardDeckPos <= 0 AndAlso CardStack(0, workcounter, 5) = 3 Then
                If CardStack(0, workcounter, 1) = CardxPos AndAlso CardStack(0, workcounter, 2) = CardyPos Then
                    XyCheck += 1
                    CheckPosition = False
                End If
            Else
                ''Nothing Needed
            End If
            If DeckCheck = 0 AndAlso XyCheck = 1 Then
                CheckPosition = True
            ElseIf DeckCheck = 1 AndAlso XyCheck = 0 Then
                CheckPosition = True
            Else
                ''Nothing Needed
            End If
        Next
        Return CheckPosition
    End Function

    Public Function ReturnCard(CardNumber As Integer) As Boolean
        ReturnCard = False
        Dim workcounter As Integer
        If CardStack(0, CardNumber, 5) = 3 Or 2 Then 'if card being returned is on board then
            For workcounter = Deckcounter To 1 Step -1 'for every card in deck counting down
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
            If Resetonreturn = True Then CardStack(0, CardNumber, 4) = 0
            CardLookup(1) = CardNumber
            Deckcounter += 1
            ReturnCard = True
        Else
            MsgBox("Error Returning Card", MsgBoxStyle.Critical, "ReturnCard Failure")
        End If
    End Function

    Public Function TranslateBoard(XChange As Integer, YChange As Integer) As Boolean
        Dim workcounter As Integer
        If Pretranslatereset = True Then CardStack(0, Currentplane, 4) = 0 ''need to be refactored after phenoms
        If Deckstate = 2 OrElse Deckstate = 4 OrElse Deckstate = 5 Then
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    CardStack(0, workcounter, 1) += XChange
                    CardStack(0, workcounter, 2) += YChange
                End If
            Next
            PopulateBoard()
            If Distancereset = True Then CleanDReset()
            PollAndSetCurrentPlane()
            CullBoard()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function PollAndSetCurrentPlane()
        Dim workcounter As Integer
        For workcounter = 1 To Masterdeckcount Step 1
            If CardStack(0, workcounter, 1) = 0 AndAlso CardStack(0, workcounter, 2) = 0 Then
                If CheckPosition(workcounter) = True Then ''set currentplane if single
                    Currentplane = workcounter
                Else
                    ''insert logic here
                End If
            End If
        Next
        Return 0
    End Function

    Public Function CleanDReset()
        Dim workcounter As Integer
        For workcounter = 1 To Masterdeckcount Step 1
            Dim distancecounter As Integer
            distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
            If distancecounter > 3 AndAlso CardStack(0, workcounter, 5) = 3 Then
                CardStack(0, workcounter, 4) = 0
            End If
        Next
        Return 0
    End Function

    Public Function CullBoard() As Boolean
        Dim workcounter As Integer
        CullBoard = False
        If Infiniteplane = False AndAlso Deckstate = 2 Then
            For workcounter = 1 To Masterdeckcount Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(0, workcounter, 1)) + Math.Abs(CardStack(0, workcounter, 2))
                If distancecounter > 3 AndAlso CardStack(0, workcounter, 5) = 3 Then
                    ReturnCard(workcounter)
                End If
            Next
            For workcounter = 1 To Masterdeckcount Step 1
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
            For workcounter = 1 To Masterdeckcount Step 1
                If CardStack(0, workcounter, 5) = 3 Then
                    If CardStack(0, workcounter, 1) = 0 AndAlso CardStack(0, workcounter, 2) = 1 Then
                        NPopulateCheck = False
                    ElseIf CardStack(0, workcounter, 1) = 0 AndAlso CardStack(0, workcounter, 2) = -1 Then
                        SPopulateCheck = False
                    ElseIf CardStack(0, workcounter, 1) = 1 AndAlso CardStack(0, workcounter, 2) = 0 Then
                        EPopulateCheck = False
                    ElseIf CardStack(0, workcounter, 1) = -1 AndAlso CardStack(0, workcounter, 2) = 0 Then
                        WPopulateCheck = False
                    Else
                        ''Nothing Needed
                    End If
                End If
            Next
            If NPopulateCheck = True AndAlso Deckcounter > 0 Then
                If PlayCard(DrawCard, 3, 0, 1) = True Then PopulateBoard = True
            End If
            If SPopulateCheck = True AndAlso Deckcounter > 0 Then
                If PlayCard(DrawCard, 3, 0, -1) = True Then PopulateBoard = True
            End If
            If EPopulateCheck = True AndAlso Deckcounter > 0 Then
                If PlayCard(DrawCard, 3, 1, 0) = True Then PopulateBoard = True
            End If
            If WPopulateCheck = True AndAlso Deckcounter > 0 Then
                If PlayCard(DrawCard, 3, -1, 0) = True Then PopulateBoard = True
            End If
        End If
    End Function

End Module
