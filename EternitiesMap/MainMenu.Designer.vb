<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ChkPhenomDealIn = New System.Windows.Forms.CheckBox()
        Me.ChkPhenomSupport = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ChkPreTransReset = New System.Windows.Forms.CheckBox()
        Me.ChkResetReturn = New System.Windows.Forms.CheckBox()
        Me.ChkDistanceReset = New System.Windows.Forms.CheckBox()
        Me.ChkNaarReset = New System.Windows.Forms.CheckBox()
        Me.ChkAertReset = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumAretMax = New System.Windows.Forms.NumericUpDown()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CHKInfinite = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 51)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(775, 445)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.ChkPhenomSupport)
        Me.TabPage3.Controls.Add(Me.ChkPhenomDealIn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(767, 419)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Phenomemon"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ChkPhenomDealIn
        '
        Me.ChkPhenomDealIn.AutoSize = True
        Me.ChkPhenomDealIn.BackColor = System.Drawing.Color.Black
        Me.ChkPhenomDealIn.ForeColor = System.Drawing.Color.White
        Me.ChkPhenomDealIn.Location = New System.Drawing.Point(0, 23)
        Me.ChkPhenomDealIn.Name = "ChkPhenomDealIn"
        Me.ChkPhenomDealIn.Size = New System.Drawing.Size(199, 17)
        Me.ChkPhenomDealIn.TabIndex = 14
        Me.ChkPhenomDealIn.Text = "Deal in Phenomenon to Planar Deck"
        Me.ChkPhenomDealIn.UseVisualStyleBackColor = False
        '
        'ChkPhenomSupport
        '
        Me.ChkPhenomSupport.AutoSize = True
        Me.ChkPhenomSupport.BackColor = System.Drawing.Color.Black
        Me.ChkPhenomSupport.ForeColor = System.Drawing.Color.White
        Me.ChkPhenomSupport.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkPhenomSupport.Location = New System.Drawing.Point(0, 0)
        Me.ChkPhenomSupport.Name = "ChkPhenomSupport"
        Me.ChkPhenomSupport.Size = New System.Drawing.Size(165, 17)
        Me.ChkPhenomSupport.TabIndex = 13
        Me.ChkPhenomSupport.Text = "Enable Phenomenon Support"
        Me.ChkPhenomSupport.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.NumAretMax)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.ChkAertReset)
        Me.TabPage2.Controls.Add(Me.ChkNaarReset)
        Me.TabPage2.Controls.Add(Me.ChkDistanceReset)
        Me.TabPage2.Controls.Add(Me.ChkResetReturn)
        Me.TabPage2.Controls.Add(Me.ChkPreTransReset)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(767, 419)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(59, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Maximum  Scroll Counters on Aretopolis"
        '
        'NumAretMax
        '
        Me.NumAretMax.Dock = System.Windows.Forms.DockStyle.Left
        Me.NumAretMax.ForeColor = System.Drawing.Color.Black
        Me.NumAretMax.Location = New System.Drawing.Point(3, 88)
        Me.NumAretMax.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumAretMax.Name = "NumAretMax"
        Me.NumAretMax.Size = New System.Drawing.Size(50, 20)
        Me.NumAretMax.TabIndex = 13
        Me.NumAretMax.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.main_menu_art
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.CHKInfinite)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(767, 419)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Game Modes"
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
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CHKInfinite As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents NumAretMax As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ChkAertReset As CheckBox
    Friend WithEvents ChkNaarReset As CheckBox
    Friend WithEvents ChkDistanceReset As CheckBox
    Friend WithEvents ChkResetReturn As CheckBox
    Friend WithEvents ChkPreTransReset As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ChkPhenomSupport As CheckBox
    Friend WithEvents ChkPhenomDealIn As CheckBox
End Class
