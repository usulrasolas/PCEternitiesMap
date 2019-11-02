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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.ChkPhenomSupport = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TBPhenomHJChance = New System.Windows.Forms.TrackBar()
        Me.LBLHJChance = New System.Windows.Forms.Label()
        Me.TBPhenomMoveChance = New System.Windows.Forms.TrackBar()
        Me.LBLMoveChance = New System.Windows.Forms.Label()
        Me.TabSettingMenu.SuspendLayout()
        Me.TabPageModes.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePhenom.SuspendLayout()
        CType(Me.TBPhenomHJChance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPhenomMoveChance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MTG Planechase Eternities Map Experimental"
        '
        'BNewGame
        '
        Me.BNewGame.BackColor = System.Drawing.Color.Silver
        Me.BNewGame.ForeColor = System.Drawing.Color.Black
        Me.BNewGame.Location = New System.Drawing.Point(122, 502)
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
        Me.BExit.Location = New System.Drawing.Point(600, 501)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(75, 23)
        Me.BExit.TabIndex = 2
        Me.BExit.Text = "Exit Game"
        Me.BExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 539)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Magic: The Gathering, MTG, and Planechase are Copyright Wizard of The Coast LLC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "This software and its code are distributed and licensed GNU GPL v3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 507)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(390, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "This program is unofficial and is in no way endorsed by Wizards of The Coast LLC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "All Rights to Cards, Art, and Assets Reserved by Original Owners"
        '
        'TabSettingMenu
        '
        Me.TabSettingMenu.Controls.Add(Me.TabPageModes)
        Me.TabSettingMenu.Controls.Add(Me.TabPageSettings)
        Me.TabSettingMenu.Controls.Add(Me.TabPagePhenom)
        Me.TabSettingMenu.Location = New System.Drawing.Point(6, 51)
        Me.TabSettingMenu.Name = "TabSettingMenu"
        Me.TabSettingMenu.SelectedIndex = 0
        Me.TabSettingMenu.ShowToolTips = True
        Me.TabSettingMenu.Size = New System.Drawing.Size(775, 445)
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
        Me.TabPageModes.Size = New System.Drawing.Size(767, 419)
        Me.TabPageModes.TabIndex = 0
        Me.TabPageModes.Text = "Game Modes"
        '
        'CHKInfinite
        '
        Me.CHKInfinite.AutoSize = True
        Me.CHKInfinite.Dock = System.Windows.Forms.DockStyle.Top
        Me.CHKInfinite.ForeColor = System.Drawing.Color.Transparent
        Me.CHKInfinite.Location = New System.Drawing.Point(3, 3)
        Me.CHKInfinite.Name = "CHKInfinite"
        Me.CHKInfinite.Size = New System.Drawing.Size(761, 17)
        Me.CHKInfinite.TabIndex = 6
        Me.CHKInfinite.Text = "Finite Mode"
        Me.ToolTip1.SetToolTip(Me.CHKInfinite, resources.GetString("CHKInfinite.ToolTip"))
        Me.CHKInfinite.UseVisualStyleBackColor = True
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
        Me.TabPageSettings.Size = New System.Drawing.Size(767, 419)
        Me.TabPageSettings.TabIndex = 1
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'NumAretMax
        '
        Me.NumAretMax.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumAretMax.ForeColor = System.Drawing.Color.Black
        Me.NumAretMax.Location = New System.Drawing.Point(195, 88)
        Me.NumAretMax.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumAretMax.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumAretMax.Name = "NumAretMax"
        Me.NumAretMax.Size = New System.Drawing.Size(569, 20)
        Me.NumAretMax.TabIndex = 13
        Me.NumAretMax.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Maximum  Scroll Counters on Aretopolis"
        '
        'ChkAertReset
        '
        Me.ChkAertReset.AutoSize = True
        Me.ChkAertReset.BackColor = System.Drawing.Color.Black
        Me.ChkAertReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkAertReset.ForeColor = System.Drawing.Color.Transparent
        Me.ChkAertReset.Location = New System.Drawing.Point(3, 71)
        Me.ChkAertReset.Name = "ChkAertReset"
        Me.ChkAertReset.Size = New System.Drawing.Size(761, 17)
        Me.ChkAertReset.TabIndex = 12
        Me.ChkAertReset.Text = "Does Aretopolis reset when its ability triggers?"
        Me.ToolTip1.SetToolTip(Me.ChkAertReset, resources.GetString("ChkAertReset.ToolTip"))
        Me.ChkAertReset.UseVisualStyleBackColor = False
        '
        'ChkNaarReset
        '
        Me.ChkNaarReset.AutoSize = True
        Me.ChkNaarReset.BackColor = System.Drawing.Color.Black
        Me.ChkNaarReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkNaarReset.ForeColor = System.Drawing.Color.Transparent
        Me.ChkNaarReset.Location = New System.Drawing.Point(3, 54)
        Me.ChkNaarReset.Name = "ChkNaarReset"
        Me.ChkNaarReset.Size = New System.Drawing.Size(761, 17)
        Me.ChkNaarReset.TabIndex = 11
        Me.ChkNaarReset.Text = "Does ONLY Naar Isle reset when Planeswalking away?"
        Me.ToolTip1.SetToolTip(Me.ChkNaarReset, resources.GetString("ChkNaarReset.ToolTip"))
        Me.ChkNaarReset.UseVisualStyleBackColor = False
        '
        'ChkDistanceReset
        '
        Me.ChkDistanceReset.AutoSize = True
        Me.ChkDistanceReset.BackColor = System.Drawing.Color.Black
        Me.ChkDistanceReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkDistanceReset.ForeColor = System.Drawing.Color.Transparent
        Me.ChkDistanceReset.Location = New System.Drawing.Point(3, 37)
        Me.ChkDistanceReset.Name = "ChkDistanceReset"
        Me.ChkDistanceReset.Size = New System.Drawing.Size(761, 17)
        Me.ChkDistanceReset.TabIndex = 10
        Me.ChkDistanceReset.Text = "Do Counters reset when no longer visable?"
        Me.ToolTip1.SetToolTip(Me.ChkDistanceReset, resources.GetString("ChkDistanceReset.ToolTip"))
        Me.ChkDistanceReset.UseVisualStyleBackColor = False
        '
        'ChkResetReturn
        '
        Me.ChkResetReturn.AutoSize = True
        Me.ChkResetReturn.BackColor = System.Drawing.Color.Black
        Me.ChkResetReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkResetReturn.ForeColor = System.Drawing.Color.Transparent
        Me.ChkResetReturn.Location = New System.Drawing.Point(3, 20)
        Me.ChkResetReturn.Name = "ChkResetReturn"
        Me.ChkResetReturn.Size = New System.Drawing.Size(761, 17)
        Me.ChkResetReturn.TabIndex = 9
        Me.ChkResetReturn.Text = "Do Counters reset when they are returned to the deck?"
        Me.ToolTip1.SetToolTip(Me.ChkResetReturn, resources.GetString("ChkResetReturn.ToolTip"))
        Me.ChkResetReturn.UseVisualStyleBackColor = False
        '
        'ChkPreTransReset
        '
        Me.ChkPreTransReset.AutoSize = True
        Me.ChkPreTransReset.BackColor = System.Drawing.Color.Black
        Me.ChkPreTransReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPreTransReset.ForeColor = System.Drawing.Color.White
        Me.ChkPreTransReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkPreTransReset.Location = New System.Drawing.Point(3, 3)
        Me.ChkPreTransReset.Name = "ChkPreTransReset"
        Me.ChkPreTransReset.Size = New System.Drawing.Size(761, 17)
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
        Me.TabPagePhenom.Size = New System.Drawing.Size(767, 419)
        Me.TabPagePhenom.TabIndex = 2
        Me.TabPagePhenom.Text = "Phenomemon"
        Me.TabPagePhenom.UseVisualStyleBackColor = True
        '
        'ChkPhenomSupport
        '
        Me.ChkPhenomSupport.AutoSize = True
        Me.ChkPhenomSupport.BackColor = System.Drawing.Color.Black
        Me.ChkPhenomSupport.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPhenomSupport.ForeColor = System.Drawing.Color.White
        Me.ChkPhenomSupport.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkPhenomSupport.Location = New System.Drawing.Point(3, 3)
        Me.ChkPhenomSupport.Name = "ChkPhenomSupport"
        Me.ChkPhenomSupport.Size = New System.Drawing.Size(761, 17)
        Me.ChkPhenomSupport.TabIndex = 13
        Me.ChkPhenomSupport.Text = "Enable Phenomenon Support"
        Me.ChkPhenomSupport.UseVisualStyleBackColor = False
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
        'TBPhenomHJChance
        '
        Me.TBPhenomHJChance.BackColor = System.Drawing.Color.Black
        Me.TBPhenomHJChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.TBPhenomHJChance.Location = New System.Drawing.Point(3, 20)
        Me.TBPhenomHJChance.Maximum = 100
        Me.TBPhenomHJChance.Name = "TBPhenomHJChance"
        Me.TBPhenomHJChance.Size = New System.Drawing.Size(761, 45)
        Me.TBPhenomHJChance.TabIndex = 14
        Me.TBPhenomHJChance.TickFrequency = 5
        Me.TBPhenomHJChance.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.TBPhenomHJChance, "Percent Chance of A Random Phenomenon on Helljump")
        '
        'LBLHJChance
        '
        Me.LBLHJChance.AutoSize = True
        Me.LBLHJChance.BackColor = System.Drawing.Color.Black
        Me.LBLHJChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLHJChance.Location = New System.Drawing.Point(3, 65)
        Me.LBLHJChance.Name = "LBLHJChance"
        Me.LBLHJChance.Size = New System.Drawing.Size(309, 13)
        Me.LBLHJChance.TabIndex = 15
        Me.LBLHJChance.Text = "50% Chance of A Random Phenomenon on Helljump Movement"
        '
        'TBPhenomMoveChance
        '
        Me.TBPhenomMoveChance.BackColor = System.Drawing.Color.Black
        Me.TBPhenomMoveChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.TBPhenomMoveChance.Location = New System.Drawing.Point(3, 78)
        Me.TBPhenomMoveChance.Maximum = 100
        Me.TBPhenomMoveChance.Name = "TBPhenomMoveChance"
        Me.TBPhenomMoveChance.Size = New System.Drawing.Size(761, 45)
        Me.TBPhenomMoveChance.TabIndex = 16
        Me.TBPhenomMoveChance.TickFrequency = 5
        Me.TBPhenomMoveChance.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.TBPhenomMoveChance, "Percent Chance of A Random Phenomenon on Helljump")
        '
        'LBLMoveChance
        '
        Me.LBLMoveChance.AutoSize = True
        Me.LBLMoveChance.BackColor = System.Drawing.Color.Black
        Me.LBLMoveChance.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLMoveChance.Location = New System.Drawing.Point(3, 123)
        Me.LBLMoveChance.Name = "LBLMoveChance"
        Me.LBLMoveChance.Size = New System.Drawing.Size(309, 13)
        Me.LBLMoveChance.TabIndex = 17
        Me.LBLMoveChance.Text = "50% Chance of A Random Phenomenon on Helljump Movement"
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabSettingMenu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        CType(Me.TBPhenomHJChance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPhenomMoveChance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BNewGame As Button
    Friend WithEvents BExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
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
End Class
