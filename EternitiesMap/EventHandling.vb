Module EventHandling

    Public EventCardInPlay As Integer
    Public EventXloc As Integer = Nothing
    Public EventYloc As Integer = Nothing

    Function Phenom64Resolve()
        ''Spatial Merging
        CardStack(1, Drawbuffer(0), 0) = 1
        CardStack(1, Drawbuffer(1), 0) = 1
        CardStack(1, Drawbuffer(0), 1) = 64
        CardStack(1, Drawbuffer(1), 1) = 64
        CardStack(1, Drawbuffer(1), 2) = 0
        CardStack(1, Drawbuffer(0), 2) = 0
        CardStack(1, Drawbuffer(1), 3) = Drawbuffer(0)
        CardStack(1, Drawbuffer(0), 3) = Drawbuffer(1)
        MoveEventCheck()
        TranslateBoard(InvertCoord(EventXloc), InvertCoord(EventYloc))
        Deckstate = 1
        PlayCard(Drawbuffer(0), 3, 0, 0)
        PlayCard(Drawbuffer(1), 3, 0, 0)
        PBWalk_Click(Nothing, Nothing)
        PBWalk_Click(Nothing, Nothing)
        Return 0
    End Function

    Function Phenom64Event(phenomnumber As Integer, xloc As Integer, yloc As Integer)
        EventCardInPlay = phenomnumber
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
        Return 0
    End Function

    Function Phenom26Resolve()
        ''Interplanar Tunnel
        Dim eventdistance = Math.Abs(EventXloc) + Math.Abs(EventYloc)
        If eventdistance = 2 Then PlayCard(DrawCard, 3, EventXloc, EventYloc)
        MoveEventCheck()
        TranslateBoard(InvertCoord(EventXloc), InvertCoord(EventYloc))
        Deckstate = 1
        PBWalk_Click(Nothing, Nothing)
        PBWalk_Click(Nothing, Nothing)
        Return 0
    End Function

    Function Phenom26Event(phenomnumber As Integer, xloc As Integer, yloc As Integer)
        EventCardInPlay = phenomnumber
        Deckstate = 4
        Drawbuffer(0) = DrawCard()
        Drawbuffer(1) = DrawCard()
        Drawbuffer(2) = DrawCard()
        Drawbuffer(3) = DrawCard()
        Drawbuffer(4) = DrawCard()
        PickDisplay(26, Drawbuffer(0), Drawbuffer(1), Drawbuffer(2), Drawbuffer(3), Drawbuffer(4))
        MsgBox("Select one Plane to go ontop of Planar Deck" & vbCrLf & "Click on Plane of your Selection to Resolve Interplanar Tunnel", MsgBoxStyle.Information, "Interplanar Tunnel")
        Return 0
    End Function
    ''Function Phenom172Event(phenomnumber As Integer, xloc As Integer, yloc As Integer)
    ''Return 0
    ''End Function
    Function PhenomEvent(phenomnumber As Integer, xloc As Integer, yloc As Integer)
        EventXloc = xloc
        EventYloc = yloc
        If phenomnumber = 26 Then
            Phenom26Event(phenomnumber, xloc, yloc)
        ElseIf phenomnumber = 64 Then
            Phenom64Event(phenomnumber, xloc, yloc)
            ''REWORK 1.x OF PHENOM EVENT AND DISPLAY SYSTEM
            ''ElseIf phenomnumber = 172 Then
            ''Phenom172Resolve(phenomnumber, xloc, yloc)
        Else
            StdPhenomEvent(phenomnumber, xloc, yloc)
        End If
        Return 0
    End Function

    Function StdPhenomEvent(phenomnumber As Integer, xloc As Integer, yloc As Integer)
        EventCardInPlay = phenomnumber
        Deckstate = 4
        DisplayZoom(phenomnumber)
        Dim eventdistance = Math.Abs(xloc) + Math.Abs(yloc)
        If eventdistance = 2 Then PlayCard(DrawCard, 3, xloc, yloc)
        MoveEventCheck()
        TranslateBoard(InvertCoord(xloc), InvertCoord(yloc))
        Return 0
    End Function

    Function ResolvePhenom(phenomnumber As Integer)
        ResolvePhenom = True
        Dim PersistPhenomDisplay As Boolean = False
        If phenomnumber = 9 Then PersistPhenomDisplay = True
        If phenomnumber = 97 Then PersistPhenomDisplay = True
        If phenomnumber = 98 Then PersistPhenomDisplay = True
        If phenomnumber = 108 Then PersistPhenomDisplay = True
        If phenomnumber = 172 Then PersistPhenomDisplay = True ''Will need to be removed with rework of phenom/event system
        If phenomnumber = 208 Then PersistPhenomDisplay = True
        If phenomnumber = 220 Then PersistPhenomDisplay = True
        ''this is where you set the phenom to persist on screen
        ''only need special handlers with additon of generic handler with persistdisplayoptionstuff
        If phenomnumber = 26 Then
            Phenom26Resolve()
        ElseIf phenomnumber = 64 Then
            Phenom64Resolve()
        Else
            ''generic handler
            Deckstate = 1
            If PersistPhenomDisplay = True Then
                GameBoard.PCardSelect6.BringToFront()
                GameBoard.PCardSelect6.Visible = True
                GameBoard.PCardSelect6.Image = CardImage(phenomnumber)
            End If
        End If
        UpdateArrays()
    End Function

    Public Function PhenomMoveChanceCheck() As Boolean
        If Phenommovechance > 0 And Phenomsupport = True Then
            PhenomMoveChanceCheck = False
            Dim randomroll As Integer = Int((100 * Rnd()) + 1)
            If randomroll <= Phenommovechance Then PhenomMoveChanceCheck = True
        Else
            PhenomMoveChanceCheck = False
        End If
    End Function

    Public Function PhenomHellMoveChanceCheck() As Boolean
        If Phenomhelljchance > 0 And Phenomsupport = True Then
            PhenomHellMoveChanceCheck = False
            Dim randomroll As Integer = Int((100 * Rnd()) + 1)
            If randomroll <= Phenomhelljchance Then PhenomHellMoveChanceCheck = True
        Else
            PhenomHellMoveChanceCheck = False
        End If
    End Function

    Function MoveEventCheck()
        GameBoard.PCardSelect6.SendToBack()
        GameBoard.PCardSelect6.Visible = False
        GameBoard.PCardSelect6.Image = Nothing
        If CardStack(0, Currentplane, 3) = 5 Then
            ''Aeropolis Flag for 10 Counters Walks Away
            If CardStack(0, Currentplane, 4) >= Aretcounter And Aretresetmove = True Then CardStack(0, Currentplane, 4) = 0
        ElseIf CardStack(0, Currentplane, 3) = 6 Then
            ''Naar Isle Counter Reset on Exit if reset is true
            If Naarreset = True Then CardStack(0, Currentplane, 4) = 0
        ElseIf (CardStack(0, Currentplane, 3) = 7 And CardStack(0, Currentplane, 4) > 0) Then
            ''Mount Keralia Damage on Exit Reminder/Reset
            MsgBox("Mount Keralia Deals " & CardStack(0, Currentplane, 4) & " Damage to Each Creature and Each Planeswalker", MsgBoxStyle.Exclamation, "Mount Keralia Erupts!")
            CardStack(0, Currentplane, 4) = 0
        Else
            ''nothing happens no event
        End If
        Return 0
    End Function
End Module