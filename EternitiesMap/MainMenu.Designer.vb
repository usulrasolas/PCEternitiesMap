<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BNewGame = New System.Windows.Forms.Button()
        Me.BExit = New System.Windows.Forms.Button()
        Me.TabSettingMenu = New System.Windows.Forms.TabControl()
        Me.TabPageModes = New System.Windows.Forms.TabPage()
        Me.CHKInfinite = New System.Windows.Forms.CheckBox()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.NumAretMax = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkAertReset = New System.Windows.Forms.CheckBox()
        Me.ChkNaarReset = New System.Windows.Forms.CheckBox()
        Me.ChkDistanceReset = New System.Windows.Forms.CheckBox()
        Me.ChkResetReturn = New System.Windows.Forms.CheckBox()
        Me.ChkPreTransReset = New System.Windows.Forms.CheckBox()
        Me.TabPagePhenom = New System.Windows.Forms.TabPage()
        Me.LBLMoveChance = New System.Windows.Forms.Label()
        Me.TBPhenomMoveChance = New System.Windows.Forms.TrackBar()
        Me.LBLHJChance = New System.Windows.Forms.Label()
        Me.TBPhenomHJChance = New System.Windows.Forms.TrackBar()
        Me.ChkPhenomSupport = New System.Windows.Forms.CheckBox()
        Me.TabPageCardSets = New System.Windows.Forms.TabPage()
        Me.ChkFiora = New System.Windows.Forms.CheckBox()
        Me.ChkAmon = New System.Windows.Forms.CheckBox()
        Me.ChkBxMultiverse = New System.Windows.Forms.CheckBox()
        Me.ChkIxalan = New System.Windows.Forms.CheckBox()
        Me.ChkGeekscape = New System.Windows.Forms.CheckBox()
        Me.ChkBxPC2017 = New System.Windows.Forms.CheckBox()
        Me.ChkBxPC2019CommanderCards = New System.Windows.Forms.CheckBox()
        Me.ChkPC2019 = New System.Windows.Forms.CheckBox()
        Me.ChkPCAnthology = New System.Windows.Forms.CheckBox()
        Me.TabPageCredits = New System.Windows.Forms.TabPage()
        Me.RTBCredits = New System.Windows.Forms.RichTextBox()
        Me.TabPageResources = New System.Windows.Forms.TabPage()
        Me.RTBResources = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChkBxMultiverseIxalan = New System.Windows.Forms.CheckBox()
        Me.ChkbxMultiverseKaladesh = New System.Windows.Forms.CheckBox()
        Me.ChkBxMultiverseTarkir = New System.Windows.Forms.CheckBox()
        Me.ChkBxMultiverseTheros = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ChkBxMultiverseExtras = New System.Windows.Forms.CheckBox()
        Me.ChkBxMultiversePhenom = New System.Windows.Forms.CheckBox()
        Me.TabSettingMenu.SuspendLayout()
        Me.TabPageModes.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePhenom.SuspendLayout()
        CType(Me.TBPhenomMoveChance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPhenomHJChance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCardSets.SuspendLayout()
        Me.TabPageCredits.SuspendLayout()
        Me.TabPageResources.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 117)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MTG Planechase: Eternities Map" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BNewGame
        '
        Me.BNewGame.BackColor = System.Drawing.Color.Silver
        Me.BNewGame.ForeColor = System.Drawing.Color.Black
        Me.BNewGame.Location = New System.Drawing.Point(122, 526)
        Me.BNewGame.Name = "BNewGame"
        Me.BNewGame.Size = New System.Drawing.Size(75, 23)
        Me.BNewGame.TabIndex = 1
        Me.BNewGame.Text = "New Game"
        Me.BNewGame.UseVisualStyleBackColor = False
        '
        'BExit
        '
        Me.BExit.BackColor = System.Drawing.Color.Silver
        Me.BExit.ForeColor = System.Drawing.Color.Black
        Me.BExit.Location = New System.Drawing.Point(601, 526)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(75, 23)
        Me.BExit.TabIndex = 2
        Me.BExit.Text = "Exit Game"
        Me.BExit.UseVisualStyleBackColor = False
        '
        'TabSettingMenu
        '
        Me.TabSettingMenu.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabSettingMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabSettingMenu.Controls.Add(Me.TabPageModes)
        Me.TabSettingMenu.Controls.Add(Me.TabPageSettings)
        Me.TabSettingMenu.Controls.Add(Me.TabPagePhenom)
        Me.TabSettingMenu.Controls.Add(Me.TabPageCardSets)
        Me.TabSettingMenu.Controls.Add(Me.TabPageCredits)
        Me.TabSettingMenu.Controls.Add(Me.TabPageResources)
        Me.TabSettingMenu.Location = New System.Drawing.Point(1, 51)
        Me.TabSettingMenu.Name = "TabSettingMenu"
        Me.TabSettingMenu.SelectedIndex = 0
        Me.TabSettingMenu.ShowToolTips = True
        Me.TabSettingMenu.Size = New System.Drawing.Size(782, 469)
        Me.TabSettingMenu.TabIndex = 15
        '
        'TabPageModes
        '
        Me.TabPageModes.BackColor = System.Drawing.Color.Black
        Me.TabPageModes.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPageModes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageModes.Controls.Add(Me.CHKInfinite)
        Me.TabPageModes.Location = New System.Drawing.Point(4, 22)
        Me.TabPageModes.Name = "TabPageModes"
        Me.TabPageModes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageModes.Size = New System.Drawing.Size(774, 443)
        Me.TabPageModes.TabIndex = 0
        Me.TabPageModes.Text = "Game Modes"
        '
        'CHKInfinite
        '
        Me.CHKInfinite.AutoSize = True
        Me.CHKInfinite.BackColor = System.Drawing.Color.Transparent
        Me.CHKInfinite.Dock = System.Windows.Forms.DockStyle.Top
        Me.CHKInfinite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKInfinite.ForeColor = System.Drawing.Color.Transparent
        Me.CHKInfinite.Location = New System.Drawing.Point(3, 3)
        Me.CHKInfinite.Name = "CHKInfinite"
        Me.CHKInfinite.Size = New System.Drawing.Size(768, 17)
        Me.CHKInfinite.TabIndex = 6
        Me.CHKInfinite.Text = "Finite Mode"
        Me.ToolTip1.SetToolTip(Me.CHKInfinite, resources.GetString("CHKInfinite.ToolTip"))
        Me.CHKInfinite.UseVisualStyleBackColor = False
        '
        'TabPageSettings
        '
        Me.TabPageSettings.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageSettings.Controls.Add(Me.NumAretMax)
        Me.TabPageSettings.Controls.Add(Me.Label4)
        Me.TabPageSettings.Controls.Add(Me.ChkAertReset)
        Me.TabPageSettings.Controls.Add(Me.ChkNaarReset)
        Me.TabPageSettings.Controls.Add(Me.ChkDistanceReset)
        Me.TabPageSettings.Controls.Add(Me.ChkResetReturn)
        Me.TabPageSettings.Controls.Add(Me.ChkPreTransReset)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSettings.Size = New System.Drawing.Size(774, 443)
        Me.TabPageSettings.TabIndex = 1
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.ToolTipText = "This applies to all card sets."
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'NumAretMax
        '
        Me.NumAretMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumAretMax.ForeColor = System.Drawing.Color.Black
        Me.NumAretMax.Location = New System.Drawing.Point(235, 86)
        Me.NumAretMax.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumAretMax.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumAretMax.Name = "NumAretMax"
        Me.NumAretMax.Size = New System.Drawing.Size(36, 20)
        Me.NumAretMax.TabIndex = 13
        Me.NumAretMax.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Maximum Scroll Counters on Aretopolis"
        '
        'ChkAertReset
        '
        Me.ChkAertReset.AutoSize = True
        Me.ChkAertReset.BackColor = System.Drawing.Color.Transparent
        Me.ChkAertReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkAertReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAertReset.ForeColor = System.Drawing.Color.Transparent
        Me.ChkAertReset.Location = New System.Drawing.Point(3, 71)
        Me.ChkAertReset.Name = "ChkAertReset"
        Me.ChkAertReset.Size = New System.Drawing.Size(768, 17)
        Me.ChkAertReset.TabIndex = 12
        Me.ChkAertReset.Text = "Does Aretopolis reset when its ability triggers?"
        Me.ToolTip1.SetToolTip(Me.ChkAertReset, resources.GetString("ChkAertReset.ToolTip"))
        Me.ChkAertReset.UseVisualStyleBackColor = False
        '
        'ChkNaarReset
        '
        Me.ChkNaarReset.AutoSize = True
        Me.ChkNaarReset.BackColor = System.Drawing.Color.Transparent
        Me.ChkNaarReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkNaarReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNaarReset.ForeColor = System.Drawing.Color.Transparent
        Me.ChkNaarReset.Location = New System.Drawing.Point(3, 54)
        Me.ChkNaarReset.Name = "ChkNaarReset"
        Me.ChkNaarReset.Size = New System.Drawing.Size(768, 17)
        Me.ChkNaarReset.TabIndex = 11
        Me.ChkNaarReset.Text = "Does ONLY Naar Isle reset when Planeswalking away?"
        Me.ToolTip1.SetToolTip(Me.ChkNaarReset, resources.GetString("ChkNaarReset.ToolTip"))
        Me.ChkNaarReset.UseVisualStyleBackColor = False
        '
        'ChkDistanceReset
        '
        Me.ChkDistanceReset.AutoSize = True
        Me.ChkDistanceReset.BackColor = System.Drawing.Color.Transparent
        Me.ChkDistanceReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkDistanceReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDistanceReset.ForeColor = System.Drawing.Color.Transparent
        Me.ChkDistanceReset.Location = New System.Drawing.Point(3, 37)
        Me.ChkDistanceReset.Name = "ChkDistanceReset"
        Me.ChkDistanceReset.Size = New System.Drawing.Size(768, 17)
        Me.ChkDistanceReset.TabIndex = 10
        Me.ChkDistanceReset.Text = "Do Counters reset when no longer visable?"
        Me.ToolTip1.SetToolTip(Me.ChkDistanceReset, resources.GetString("ChkDistanceReset.ToolTip"))
        Me.ChkDistanceReset.UseVisualStyleBackColor = False
        '
        'ChkResetReturn
        '
        Me.ChkResetReturn.AutoSize = True
        Me.ChkResetReturn.BackColor = System.Drawing.Color.Transparent
        Me.ChkResetReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkResetReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkResetReturn.ForeColor = System.Drawing.Color.Transparent
        Me.ChkResetReturn.Location = New System.Drawing.Point(3, 20)
        Me.ChkResetReturn.Name = "ChkResetReturn"
        Me.ChkResetReturn.Size = New System.Drawing.Size(768, 17)
        Me.ChkResetReturn.TabIndex = 9
        Me.ChkResetReturn.Text = "Do Counters reset when they are returned to the deck?"
        Me.ToolTip1.SetToolTip(Me.ChkResetReturn, resources.GetString("ChkResetReturn.ToolTip"))
        Me.ChkResetReturn.UseVisualStyleBackColor = False
        '
        'ChkPreTransReset
        '
        Me.ChkPreTransReset.AutoSize = True
        Me.ChkPreTransReset.BackColor = System.Drawing.Color.Transparent
        Me.ChkPreTransReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPreTransReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPreTransReset.ForeColor = System.Drawing.Color.White
        Me.ChkPreTransReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkPreTransReset.Location = New System.Drawing.Point(3, 3)
        Me.ChkPreTransReset.Name = "ChkPreTransReset"
        Me.ChkPreTransReset.Size = New System.Drawing.Size(768, 17)
        Me.ChkPreTransReset.TabIndex = 8
        Me.ChkPreTransReset.Text = "Do Counters reset on the Active Plane when leaving?"
        Me.ToolTip1.SetToolTip(Me.ChkPreTransReset, resources.GetString("ChkPreTransReset.ToolTip"))
        Me.ChkPreTransReset.UseVisualStyleBackColor = False
        '
        'TabPagePhenom
        '
        Me.TabPagePhenom.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPagePhenom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPagePhenom.Controls.Add(Me.LBLMoveChance)
        Me.TabPagePhenom.Controls.Add(Me.TBPhenomMoveChance)
        Me.TabPagePhenom.Controls.Add(Me.LBLHJChance)
        Me.TabPagePhenom.Controls.Add(Me.TBPhenomHJChance)
        Me.TabPagePhenom.Controls.Add(Me.ChkPhenomSupport)
        Me.TabPagePhenom.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePhenom.Name = "TabPagePhenom"
        Me.TabPagePhenom.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePhenom.Size = New System.Drawing.Size(774, 443)
        Me.TabPagePhenom.TabIndex = 2
        Me.TabPagePhenom.Text = "Phenomemon"
        Me.TabPagePhenom.UseVisualStyleBackColor = True
        '
        'LBLMoveChance
        '
        Me.LBLMoveChance.AutoSize = True
        Me.LBLMoveChance.BackColor = System.Drawing.Color.Transparent
        Me.LBLMoveChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLMoveChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMoveChance.Location = New System.Drawing.Point(3, 123)
        Me.LBLMoveChance.Name = "LBLMoveChance"
        Me.LBLMoveChance.Size = New System.Drawing.Size(363, 13)
        Me.LBLMoveChance.TabIndex = 17
        Me.LBLMoveChance.Text = "50% Chance of A Random Phenomenon on Helljump Movement"
        '
        'TBPhenomMoveChance
        '
        Me.TBPhenomMoveChance.BackColor = System.Drawing.Color.Black
        Me.TBPhenomMoveChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.TBPhenomMoveChance.Location = New System.Drawing.Point(3, 78)
        Me.TBPhenomMoveChance.Maximum = 100
        Me.TBPhenomMoveChance.Name = "TBPhenomMoveChance"
        Me.TBPhenomMoveChance.Size = New System.Drawing.Size(768, 45)
        Me.TBPhenomMoveChance.TabIndex = 16
        Me.TBPhenomMoveChance.TickFrequency = 5
        Me.TBPhenomMoveChance.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.TBPhenomMoveChance, "Percent Chance of A Random Phenomenon on Helljump")
        '
        'LBLHJChance
        '
        Me.LBLHJChance.AutoSize = True
        Me.LBLHJChance.BackColor = System.Drawing.Color.Transparent
        Me.LBLHJChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLHJChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHJChance.Location = New System.Drawing.Point(3, 65)
        Me.LBLHJChance.Name = "LBLHJChance"
        Me.LBLHJChance.Size = New System.Drawing.Size(363, 13)
        Me.LBLHJChance.TabIndex = 15
        Me.LBLHJChance.Text = "50% Chance of A Random Phenomenon on Helljump Movement"
        '
        'TBPhenomHJChance
        '
        Me.TBPhenomHJChance.BackColor = System.Drawing.Color.Black
        Me.TBPhenomHJChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.TBPhenomHJChance.Location = New System.Drawing.Point(3, 20)
        Me.TBPhenomHJChance.Maximum = 100
        Me.TBPhenomHJChance.Name = "TBPhenomHJChance"
        Me.TBPhenomHJChance.Size = New System.Drawing.Size(768, 45)
        Me.TBPhenomHJChance.TabIndex = 14
        Me.TBPhenomHJChance.TickFrequency = 5
        Me.TBPhenomHJChance.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.TBPhenomHJChance, "Percent Chance of A Random Phenomenon on Helljump")
        '
        'ChkPhenomSupport
        '
        Me.ChkPhenomSupport.AutoSize = True
        Me.ChkPhenomSupport.BackColor = System.Drawing.Color.Transparent
        Me.ChkPhenomSupport.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPhenomSupport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPhenomSupport.ForeColor = System.Drawing.Color.White
        Me.ChkPhenomSupport.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkPhenomSupport.Location = New System.Drawing.Point(3, 3)
        Me.ChkPhenomSupport.Name = "ChkPhenomSupport"
        Me.ChkPhenomSupport.Size = New System.Drawing.Size(768, 17)
        Me.ChkPhenomSupport.TabIndex = 13
        Me.ChkPhenomSupport.Text = "Enable Phenomenon Support"
        Me.ChkPhenomSupport.UseVisualStyleBackColor = False
        '
        'TabPageCardSets
        '
        Me.TabPageCardSets.BackColor = System.Drawing.Color.Black
        Me.TabPageCardSets.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPageCardSets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageCardSets.Controls.Add(Me.ChkBxMultiversePhenom)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxMultiverseExtras)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxMultiverseTheros)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxMultiverseTarkir)
        Me.TabPageCardSets.Controls.Add(Me.ChkbxMultiverseKaladesh)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxMultiverseIxalan)
        Me.TabPageCardSets.Controls.Add(Me.ChkFiora)
        Me.TabPageCardSets.Controls.Add(Me.ChkAmon)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxMultiverse)
        Me.TabPageCardSets.Controls.Add(Me.ChkIxalan)
        Me.TabPageCardSets.Controls.Add(Me.ChkGeekscape)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxPC2017)
        Me.TabPageCardSets.Controls.Add(Me.ChkBxPC2019CommanderCards)
        Me.TabPageCardSets.Controls.Add(Me.ChkPC2019)
        Me.TabPageCardSets.Controls.Add(Me.ChkPCAnthology)
        Me.TabPageCardSets.ForeColor = System.Drawing.Color.White
        Me.TabPageCardSets.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCardSets.Name = "TabPageCardSets"
        Me.TabPageCardSets.Size = New System.Drawing.Size(774, 443)
        Me.TabPageCardSets.TabIndex = 3
        Me.TabPageCardSets.Text = "Card Sets"
        '
        'ChkFiora
        '
        Me.ChkFiora.AutoSize = True
        Me.ChkFiora.BackColor = System.Drawing.Color.Transparent
        Me.ChkFiora.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkFiora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFiora.ForeColor = System.Drawing.Color.White
        Me.ChkFiora.Location = New System.Drawing.Point(0, 136)
        Me.ChkFiora.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.ChkFiora.Name = "ChkFiora"
        Me.ChkFiora.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkFiora.Size = New System.Drawing.Size(774, 17)
        Me.ChkFiora.TabIndex = 33
        Me.ChkFiora.Text = "Fiora Set (Monarch Centric, Default Off)"
        Me.ChkFiora.UseVisualStyleBackColor = False
        '
        'ChkAmon
        '
        Me.ChkAmon.AutoSize = True
        Me.ChkAmon.BackColor = System.Drawing.Color.Transparent
        Me.ChkAmon.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkAmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAmon.ForeColor = System.Drawing.Color.White
        Me.ChkAmon.Location = New System.Drawing.Point(0, 119)
        Me.ChkAmon.Name = "ChkAmon"
        Me.ChkAmon.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkAmon.Size = New System.Drawing.Size(774, 17)
        Me.ChkAmon.TabIndex = 32
        Me.ChkAmon.Text = "Amonkhet Set (Themed Set, Default Off)"
        Me.ChkAmon.UseVisualStyleBackColor = False
        '
        'ChkBxMultiverse
        '
        Me.ChkBxMultiverse.AutoSize = True
        Me.ChkBxMultiverse.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxMultiverse.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxMultiverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMultiverse.Location = New System.Drawing.Point(0, 102)
        Me.ChkBxMultiverse.Name = "ChkBxMultiverse"
        Me.ChkBxMultiverse.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxMultiverse.TabIndex = 31
        Me.ChkBxMultiverse.Text = "Multiverse Expansion (Default Off)"
        Me.ChkBxMultiverse.UseVisualStyleBackColor = False
        '
        'ChkIxalan
        '
        Me.ChkIxalan.AutoSize = True
        Me.ChkIxalan.BackColor = System.Drawing.Color.Transparent
        Me.ChkIxalan.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkIxalan.Enabled = False
        Me.ChkIxalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIxalan.Location = New System.Drawing.Point(0, 85)
        Me.ChkIxalan.Name = "ChkIxalan"
        Me.ChkIxalan.Size = New System.Drawing.Size(774, 17)
        Me.ChkIxalan.TabIndex = 30
        Me.ChkIxalan.Text = "Ixalan Set (Themed Set, Mostly Phenomenon, Default Off)"
        Me.ChkIxalan.UseVisualStyleBackColor = False
        '
        'ChkGeekscape
        '
        Me.ChkGeekscape.AutoSize = True
        Me.ChkGeekscape.BackColor = System.Drawing.Color.Transparent
        Me.ChkGeekscape.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkGeekscape.Enabled = False
        Me.ChkGeekscape.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGeekscape.Location = New System.Drawing.Point(0, 68)
        Me.ChkGeekscape.Name = "ChkGeekscape"
        Me.ChkGeekscape.Size = New System.Drawing.Size(774, 17)
        Me.ChkGeekscape.TabIndex = 26
        Me.ChkGeekscape.Text = "Geekchase (Non MTG Multiverse Set, Default Off)"
        Me.ChkGeekscape.UseVisualStyleBackColor = False
        '
        'ChkBxPC2017
        '
        Me.ChkBxPC2017.AutoSize = True
        Me.ChkBxPC2017.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxPC2017.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxPC2017.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxPC2017.Location = New System.Drawing.Point(0, 51)
        Me.ChkBxPC2017.Name = "ChkBxPC2017"
        Me.ChkBxPC2017.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxPC2017.TabIndex = 25
        Me.ChkBxPC2017.Text = "Planechase 2017 (Default Off)"
        Me.ChkBxPC2017.UseVisualStyleBackColor = False
        '
        'ChkBxPC2019CommanderCards
        '
        Me.ChkBxPC2019CommanderCards.AccessibleName = "Planechase 2019 Commander Cards"
        Me.ChkBxPC2019CommanderCards.AutoSize = True
        Me.ChkBxPC2019CommanderCards.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxPC2019CommanderCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxPC2019CommanderCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxPC2019CommanderCards.Location = New System.Drawing.Point(0, 34)
        Me.ChkBxPC2019CommanderCards.Name = "ChkBxPC2019CommanderCards"
        Me.ChkBxPC2019CommanderCards.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkBxPC2019CommanderCards.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxPC2019CommanderCards.TabIndex = 17
        Me.ChkBxPC2019CommanderCards.Text = "Planechase 2019 Commander Cards (Default Off)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ChkBxPC2019CommanderCards.UseVisualStyleBackColor = False
        '
        'ChkPC2019
        '
        Me.ChkPC2019.AutoSize = True
        Me.ChkPC2019.BackColor = System.Drawing.Color.Transparent
        Me.ChkPC2019.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPC2019.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPC2019.Location = New System.Drawing.Point(0, 17)
        Me.ChkPC2019.Name = "ChkPC2019"
        Me.ChkPC2019.Size = New System.Drawing.Size(774, 17)
        Me.ChkPC2019.TabIndex = 5
        Me.ChkPC2019.Text = "Planechase 2019 (Themed Set, Default Off)"
        Me.ChkPC2019.UseVisualStyleBackColor = False
        '
        'ChkPCAnthology
        '
        Me.ChkPCAnthology.AutoSize = True
        Me.ChkPCAnthology.BackColor = System.Drawing.Color.Transparent
        Me.ChkPCAnthology.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPCAnthology.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPCAnthology.Location = New System.Drawing.Point(0, 0)
        Me.ChkPCAnthology.Name = "ChkPCAnthology"
        Me.ChkPCAnthology.Size = New System.Drawing.Size(774, 17)
        Me.ChkPCAnthology.TabIndex = 0
        Me.ChkPCAnthology.Text = "Planechase Anthology (Official Set, Default On)"
        Me.ChkPCAnthology.UseVisualStyleBackColor = False
        '
        'TabPageCredits
        '
        Me.TabPageCredits.BackColor = System.Drawing.Color.Black
        Me.TabPageCredits.Controls.Add(Me.RTBCredits)
        Me.TabPageCredits.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCredits.Name = "TabPageCredits"
        Me.TabPageCredits.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCredits.Size = New System.Drawing.Size(774, 443)
        Me.TabPageCredits.TabIndex = 4
        Me.TabPageCredits.Text = "Credits"
        '
        'RTBCredits
        '
        Me.RTBCredits.BackColor = System.Drawing.SystemColors.WindowText
        Me.RTBCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTBCredits.ForeColor = System.Drawing.Color.White
        Me.RTBCredits.Location = New System.Drawing.Point(3, 3)
        Me.RTBCredits.Name = "RTBCredits"
        Me.RTBCredits.ReadOnly = True
        Me.RTBCredits.Size = New System.Drawing.Size(768, 437)
        Me.RTBCredits.TabIndex = 10
        Me.RTBCredits.Text = resources.GetString("RTBCredits.Text")
        '
        'TabPageResources
        '
        Me.TabPageResources.Controls.Add(Me.RTBResources)
        Me.TabPageResources.Location = New System.Drawing.Point(4, 22)
        Me.TabPageResources.Name = "TabPageResources"
        Me.TabPageResources.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageResources.Size = New System.Drawing.Size(774, 443)
        Me.TabPageResources.TabIndex = 5
        Me.TabPageResources.Text = "Resources"
        Me.TabPageResources.UseVisualStyleBackColor = True
        '
        'RTBResources
        '
        Me.RTBResources.BackColor = System.Drawing.SystemColors.WindowText
        Me.RTBResources.ForeColor = System.Drawing.SystemColors.Window
        Me.RTBResources.Location = New System.Drawing.Point(0, 3)
        Me.RTBResources.Name = "RTBResources"
        Me.RTBResources.ReadOnly = True
        Me.RTBResources.Size = New System.Drawing.Size(778, 437)
        Me.RTBResources.TabIndex = 0
        Me.RTBResources.Text = resources.GetString("RTBResources.Text")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolTip1.InitialDelay = 250
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 50
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ChkBxMultiverseIxalan
        '
        Me.ChkBxMultiverseIxalan.AutoSize = True
        Me.ChkBxMultiverseIxalan.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxMultiverseIxalan.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxMultiverseIxalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMultiverseIxalan.ForeColor = System.Drawing.Color.White
        Me.ChkBxMultiverseIxalan.Location = New System.Drawing.Point(0, 153)
        Me.ChkBxMultiverseIxalan.Name = "ChkBxMultiverseIxalan"
        Me.ChkBxMultiverseIxalan.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkBxMultiverseIxalan.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxMultiverseIxalan.TabIndex = 34
        Me.ChkBxMultiverseIxalan.Text = "Ixalan Set (Default Off)"
        Me.ChkBxMultiverseIxalan.UseVisualStyleBackColor = False
        '
        'ChkbxMultiverseKaladesh
        '
        Me.ChkbxMultiverseKaladesh.AutoSize = True
        Me.ChkbxMultiverseKaladesh.BackColor = System.Drawing.Color.Transparent
        Me.ChkbxMultiverseKaladesh.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkbxMultiverseKaladesh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkbxMultiverseKaladesh.ForeColor = System.Drawing.Color.White
        Me.ChkbxMultiverseKaladesh.Location = New System.Drawing.Point(0, 170)
        Me.ChkbxMultiverseKaladesh.Name = "ChkbxMultiverseKaladesh"
        Me.ChkbxMultiverseKaladesh.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkbxMultiverseKaladesh.Size = New System.Drawing.Size(774, 17)
        Me.ChkbxMultiverseKaladesh.TabIndex = 35
        Me.ChkbxMultiverseKaladesh.Text = "Kaladesh Set (Default Off)"
        Me.ChkbxMultiverseKaladesh.UseVisualStyleBackColor = False
        '
        'ChkBxMultiverseTarkir
        '
        Me.ChkBxMultiverseTarkir.AutoSize = True
        Me.ChkBxMultiverseTarkir.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxMultiverseTarkir.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxMultiverseTarkir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMultiverseTarkir.ForeColor = System.Drawing.Color.White
        Me.ChkBxMultiverseTarkir.Location = New System.Drawing.Point(0, 187)
        Me.ChkBxMultiverseTarkir.Name = "ChkBxMultiverseTarkir"
        Me.ChkBxMultiverseTarkir.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkBxMultiverseTarkir.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxMultiverseTarkir.TabIndex = 36
        Me.ChkBxMultiverseTarkir.Text = "Tarkir Set (Default Off)"
        Me.ChkBxMultiverseTarkir.UseVisualStyleBackColor = False
        '
        'ChkBxMultiverseTheros
        '
        Me.ChkBxMultiverseTheros.AutoSize = True
        Me.ChkBxMultiverseTheros.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxMultiverseTheros.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxMultiverseTheros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMultiverseTheros.ForeColor = System.Drawing.Color.White
        Me.ChkBxMultiverseTheros.Location = New System.Drawing.Point(0, 204)
        Me.ChkBxMultiverseTheros.Name = "ChkBxMultiverseTheros"
        Me.ChkBxMultiverseTheros.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkBxMultiverseTheros.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxMultiverseTheros.TabIndex = 37
        Me.ChkBxMultiverseTheros.Text = "Theros Set (Default Off)"
        Me.ChkBxMultiverseTheros.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(353, 531)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(72, 29)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = "Version 1.0"
        '
        'ChkBxMultiverseExtras
        '
        Me.ChkBxMultiverseExtras.AutoSize = True
        Me.ChkBxMultiverseExtras.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxMultiverseExtras.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxMultiverseExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMultiverseExtras.Location = New System.Drawing.Point(0, 221)
        Me.ChkBxMultiverseExtras.Name = "ChkBxMultiverseExtras"
        Me.ChkBxMultiverseExtras.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkBxMultiverseExtras.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxMultiverseExtras.TabIndex = 17
        Me.ChkBxMultiverseExtras.Text = "Extra Planes Set (Default Off)"
        Me.ChkBxMultiverseExtras.UseVisualStyleBackColor = False
        '
        'ChkBxMultiversePhenom
        '
        Me.ChkBxMultiversePhenom.AutoSize = True
        Me.ChkBxMultiversePhenom.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxMultiversePhenom.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkBxMultiversePhenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMultiversePhenom.Location = New System.Drawing.Point(0, 238)
        Me.ChkBxMultiversePhenom.Name = "ChkBxMultiversePhenom"
        Me.ChkBxMultiversePhenom.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ChkBxMultiversePhenom.Size = New System.Drawing.Size(774, 17)
        Me.ChkBxMultiversePhenom.TabIndex = 38
        Me.ChkBxMultiversePhenom.Text = "Phenomenon Set (Default Off)"
        Me.ChkBxMultiversePhenom.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TabSettingMenu)
        Me.Controls.Add(Me.BExit)
        Me.Controls.Add(Me.BNewGame)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.TabSettingMenu.ResumeLayout(False)
        Me.TabPageModes.ResumeLayout(False)
        Me.TabPageModes.PerformLayout()
        Me.TabPageSettings.ResumeLayout(False)
        Me.TabPageSettings.PerformLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePhenom.ResumeLayout(False)
        Me.TabPagePhenom.PerformLayout()
        CType(Me.TBPhenomMoveChance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPhenomHJChance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCardSets.ResumeLayout(False)
        Me.TabPageCardSets.PerformLayout()
        Me.TabPageCredits.ResumeLayout(False)
        Me.TabPageResources.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BNewGame As Button
    Friend WithEvents BExit As Button
    Friend WithEvents TabSettingMenu As TabControl
    Friend WithEvents TabPageModes As TabPage
    Friend WithEvents CHKInfinite As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents NumAretMax As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ChkAertReset As CheckBox
    Friend WithEvents ChkNaarReset As CheckBox
    Friend WithEvents ChkDistanceReset As CheckBox
    Friend WithEvents ChkResetReturn As CheckBox
    Friend WithEvents ChkPreTransReset As CheckBox
    Friend WithEvents TabPagePhenom As TabPage
    Friend WithEvents ChkPhenomSupport As CheckBox
    Friend WithEvents LBLMoveChance As Label
    Friend WithEvents TBPhenomMoveChance As TrackBar
    Friend WithEvents LBLHJChance As Label
    Friend WithEvents TBPhenomHJChance As TrackBar
    Friend WithEvents TabPageCardSets As TabPage
    Friend WithEvents ChkPCAnthology As CheckBox
    Friend WithEvents TabPageCredits As TabPage
    Friend WithEvents ChkPC2019 As CheckBox
    Friend WithEvents RTBCredits As RichTextBox
    Friend WithEvents TabPageResources As TabPage
    Friend WithEvents RTBResources As RichTextBox
    Friend WithEvents ChkIxalan As CheckBox
    Friend WithEvents ChkGeekscape As CheckBox
    Friend WithEvents ChkBxPC2017 As CheckBox
    Friend WithEvents ChkBxPC2019CommanderCards As CheckBox
    Friend WithEvents ChkFiora As CheckBox
    Friend WithEvents ChkAmon As CheckBox
    Friend WithEvents ChkBxMultiverse As CheckBox
    Friend WithEvents ChkBxMultiverseTheros As CheckBox
    Friend WithEvents ChkBxMultiverseTarkir As CheckBox
    Friend WithEvents ChkbxMultiverseKaladesh As CheckBox
    Friend WithEvents ChkBxMultiverseIxalan As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ChkBxMultiversePhenom As CheckBox
    Friend WithEvents ChkBxMultiverseExtras As CheckBox
End Class
