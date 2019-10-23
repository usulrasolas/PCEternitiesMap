Module PlanarDeck
    Public deckState As Integer = 0 ''0 Not Ready, 1 Ready, 2 Moving
    Private DeckCounter As Integer = 0
    Public CardLookup(86) As Integer
    Public CardStack(86, 5) As Integer '' DeckPos,XPos,YPos,Flag,Counter,State
    Public DrawBuffer As Integer
    Public InfinitePlane As Boolean = False

    Public Function ReadyDeck() As Boolean
        Dim DeckRndCounter As Integer = Int(Rnd() * 10)
        Dim WorkCounter As Integer
        If deckState = 0 Then
            For WorkCounter = 0 To 86 Step 1
                CardStack(WorkCounter, 5) = 0 'Set All State To Inactive -1Disabled 0Inactive 1InDeck 2InHand 3OnBoard
                CardStack(WorkCounter, 4) = 0 'Counters
                CardStack(WorkCounter, 3) = 0 'Flags
                CardStack(WorkCounter, 2) = 0 'ypos
                CardStack(WorkCounter, 1) = 0 'xPos
                CardStack(WorkCounter, 0) = 0 'DeckPos
            Next
            CardStack(4, 3) = 5 ''Aeropolis Flag for 10 Counters Walks Away
            CardStack(40, 3) = 7 ''Mount Keralia Damage on Exit Reminder/Reset
            CardStack(43, 3) = 6 ''Naar Isle Counter Reset on Exit
            CardStack(53, 3) = 9 ''Pools of Becoming Triple Draw on Exit
            CardStack(65, 3) = 11 ''Stairs to Infinity Scry Planar Deck
            ''Temporary Disable Phenoms Via Flag and State
            CardStack(9, 3) = -1
            CardStack(26, 3) = -1
            CardStack(39, 3) = -1
            CardStack(42, 3) = -1
            CardStack(52, 3) = -1
            CardStack(57, 3) = -1
            CardStack(64, 3) = -1
            CardStack(80, 3) = -1
            CardStack(9, 5) = -1
            CardStack(26, 5) = -1
            CardStack(39, 5) = -1
            CardStack(42, 5) = -1
            CardStack(52, 5) = -1
            CardStack(57, 5) = -1
            CardStack(64, 5) = -1
            CardStack(80, 5) = -1
            For WorkCounter = 1 To 86 Step 1
                If CardStack(WorkCounter, 3) > -1 Then
                    CardStack(WorkCounter, 0) = DeckCounter + 1
                    DeckCounter += 1
                    CardLookup(DeckCounter) = WorkCounter
                    CardStack(WorkCounter, 5) = 1
                End If
            Next
            Shuffle()
            deckState = 1
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
        deckState = 0
    End Function

    Public Function Shuffle()
        Dim ShuffleTracker(86, 1) As Integer
        Dim ShufflePosCounter As Integer = DeckCounter
        Dim WorkCounter As Integer
        Randomize()
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
    End Function

    Public Function DrawCard() As Integer
        DrawBuffer = CardLookup(DeckCounter)
        CardStack(CardLookup(DeckCounter), 5) = 2
        CardStack(CardLookup(DeckCounter), 0) = 0
        CardStack(CardLookup(DeckCounter), 1) = 0
        CardStack(CardLookup(DeckCounter), 2) = 0
        CardLookup(DeckCounter) = 0
        DeckCounter -= 1
        Return DrawBuffer
    End Function

    Public Function PlayCard(CardNumber As Integer, ToState As Integer, DeckPos As Integer, XPos As Integer, YPos As Integer) As Boolean
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

    End Function

    Public Function ReturnCard(CardNumber As Integer)
        If CardStack(CardNumber, 5) = 3 Then
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
            Return True
        Else Return False
        End If
    End Function
    Public Function TranslateBoard(XChange As Integer, YChange As Integer) As Boolean
        Dim workcounter As Integer
        For workcounter = 1 To 86 Step 1
            If CardStack(workcounter, 5) = 3 Then
                CardStack(workcounter, 1) += XChange
                CardStack(workcounter, 2) += YChange
            End If
        Next
        PopulateBoard()
        CullBoard()
        Return True
    End Function
    Public Function CullBoard() As Boolean
        Dim workcounter As Integer
        If InfinitePlane = False Then

            For workcounter = 1 To 86 Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(workcounter, 1)) + Math.Abs(CardStack(workcounter, 2))
                If distancecounter > 3 And CardStack(workcounter, 5) = 3 Then
                    ReturnCard(workcounter)

                End If
            Next
            Return True
            For workcounter = 1 To 86 Step 1
                Dim distancecounter As Integer
                distancecounter = Math.Abs(CardStack(workcounter, 1)) + Math.Abs(CardStack(workcounter, 2))
                If distancecounter > 3 And CardStack(workcounter, 5) = 3 Then
                    Return False
                End If

            Next

            Shuffle()
        End If
    End Function
    Public Function PopulateBoard() As Boolean
        Dim workcounter As Integer
        Dim NPopulateCheck As Boolean = True
        Dim SPopulateCheck As Boolean = True
        Dim EPopulateCheck As Boolean = True
        Dim WPopulateCheck As Boolean = True
        PopulateBoard = False
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

        If NPopulateCheck = True Then
            If PlayCard(DrawCard, 3, 0, 0, 1) = True Then PopulateBoard = True
        End If
        If SPopulateCheck = True Then
            If PlayCard(DrawCard, 3, 0, 0, -1) = True Then PopulateBoard = True
        End If
        If EPopulateCheck = True Then
            If PlayCard(DrawCard, 3, 0, 1, 0) = True Then PopulateBoard = True
        End If
        If WPopulateCheck = True Then
            If PlayCard(DrawCard, 3, 0, -1, 0) = True Then PopulateBoard = True
        End If
    End Function
End Module
