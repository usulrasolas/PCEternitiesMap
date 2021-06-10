Module BoardHandling

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

End Module