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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BNewGame = New System.Windows.Forms.Button()
        Me.BExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CHKInfinite = New System.Windows.Forms.CheckBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumAretMax = New System.Windows.Forms.NumericUpDown()
        Me.ChkAertReset = New System.Windows.Forms.CheckBox()
        Me.ChkDistanceReset = New System.Windows.Forms.CheckBox()
        Me.ChkResetReturn = New System.Windows.Forms.CheckBox()
        Me.ChkPreTransReset = New System.Windows.Forms.CheckBox()
        Me.ChkNaarReset = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkPhenomSupport = New System.Windows.Forms.CheckBox()
        Me.ChkPhenomDealIn = New System.Windows.Forms.CheckBox()
        Me.gbOptions.SuspendLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CHKInfinite
        '
        Me.CHKInfinite.AutoSize = True
        Me.CHKInfinite.Dock = System.Windows.Forms.DockStyle.Top
        Me.CHKInfinite.ForeColor = System.Drawing.Color.White
        Me.CHKInfinite.Location = New System.Drawing.Point(3, 16)
        Me.CHKInfinite.Name = "CHKInfinite"
        Me.CHKInfinite.Size = New System.Drawing.Size(754, 17)
        Me.CHKInfinite.TabIndex = 5
        Me.CHKInfinite.Text = "Finite Mode (Planes never get removed from board)"
        Me.CHKInfinite.UseVisualStyleBackColor = True
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Transparent
        Me.gbOptions.Controls.Add(Me.ChkPhenomDealIn)
        Me.gbOptions.Controls.Add(Me.ChkPhenomSupport)
        Me.gbOptions.Controls.Add(Me.Label4)
        Me.gbOptions.Controls.Add(Me.NumAretMax)
        Me.gbOptions.Controls.Add(Me.ChkAertReset)
        Me.gbOptions.Controls.Add(Me.ChkDistanceReset)
        Me.gbOptions.Controls.Add(Me.ChkResetReturn)
        Me.gbOptions.Controls.Add(Me.ChkPreTransReset)
        Me.gbOptions.Controls.Add(Me.ChkNaarReset)
        Me.gbOptions.Controls.Add(Me.CHKInfinite)
        Me.gbOptions.ForeColor = System.Drawing.Color.LightGray
        Me.gbOptions.Location = New System.Drawing.Point(12, 51)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(760, 444)
        Me.gbOptions.TabIndex = 6
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Settings/Options"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(286, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Maximum Counters of Aretopolis (This or more triggers walk)"
        '
        'NumAretMax
        '
        Me.NumAretMax.Dock = System.Windows.Forms.DockStyle.Left
        Me.NumAretMax.ForeColor = System.Drawing.Color.White
        Me.NumAretMax.Location = New System.Drawing.Point(3, 118)
        Me.NumAretMax.Name = "NumAretMax"
        Me.NumAretMax.Size = New System.Drawing.Size(50, 20)
        Me.NumAretMax.TabIndex = 11
        '
        'ChkAertReset
        '
        Me.ChkAertReset.AutoSize = True
        Me.ChkAertReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkAertReset.ForeColor = System.Drawing.Color.White
        Me.ChkAertReset.Location = New System.Drawing.Point(3, 101)
        Me.ChkAertReset.Name = "ChkAertReset"
        Me.ChkAertReset.Size = New System.Drawing.Size(754, 17)
        Me.ChkAertReset.TabIndex = 10
        Me.ChkAertReset.Text = "Aretopolis Resets Counters When Walking Away with Max or More Counter"
        Me.ChkAertReset.UseVisualStyleBackColor = True
        '
        'ChkDistanceReset
        '
        Me.ChkDistanceReset.AutoSize = True
        Me.ChkDistanceReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkDistanceReset.ForeColor = System.Drawing.Color.White
        Me.ChkDistanceReset.Location = New System.Drawing.Point(3, 84)
        Me.ChkDistanceReset.Name = "ChkDistanceReset"
        Me.ChkDistanceReset.Size = New System.Drawing.Size(754, 17)
        Me.ChkDistanceReset.TabIndex = 9
        Me.ChkDistanceReset.Text = "Reset Counters when Card Moves More than 3 Spaces Away"
        Me.ChkDistanceReset.UseVisualStyleBackColor = True
        '
        'ChkResetReturn
        '
        Me.ChkResetReturn.AutoSize = True
        Me.ChkResetReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkResetReturn.ForeColor = System.Drawing.Color.White
        Me.ChkResetReturn.Location = New System.Drawing.Point(3, 67)
        Me.ChkResetReturn.Name = "ChkResetReturn"
        Me.ChkResetReturn.Size = New System.Drawing.Size(754, 17)
        Me.ChkResetReturn.TabIndex = 8
        Me.ChkResetReturn.Text = "Reset Counters when Card Returns to Deck"
        Me.ChkResetReturn.UseVisualStyleBackColor = True
        '
        'ChkPreTransReset
        '
        Me.ChkPreTransReset.AutoSize = True
        Me.ChkPreTransReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPreTransReset.ForeColor = System.Drawing.Color.White
        Me.ChkPreTransReset.Location = New System.Drawing.Point(3, 50)
        Me.ChkPreTransReset.Name = "ChkPreTransReset"
        Me.ChkPreTransReset.Size = New System.Drawing.Size(754, 17)
        Me.ChkPreTransReset.TabIndex = 7
        Me.ChkPreTransReset.Text = "Reset All Counters When Walking Away"
        Me.ChkPreTransReset.UseVisualStyleBackColor = True
        '
        'ChkNaarReset
        '
        Me.ChkNaarReset.AutoSize = True
        Me.ChkNaarReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkNaarReset.ForeColor = System.Drawing.Color.White
        Me.ChkNaarReset.Location = New System.Drawing.Point(3, 33)
        Me.ChkNaarReset.Name = "ChkNaarReset"
        Me.ChkNaarReset.Size = New System.Drawing.Size(754, 17)
        Me.ChkNaarReset.TabIndex = 6
        Me.ChkNaarReset.Text = "Reset Naar Island When Planeswalk Away"
        Me.ChkNaarReset.UseVisualStyleBackColor = True
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
        'ChkPhenomSupport
        '
        Me.ChkPhenomSupport.AutoSize = True
        Me.ChkPhenomSupport.ForeColor = System.Drawing.Color.White
        Me.ChkPhenomSupport.Location = New System.Drawing.Point(3, 144)
        Me.ChkPhenomSupport.Name = "ChkPhenomSupport"
        Me.ChkPhenomSupport.Size = New System.Drawing.Size(165, 17)
        Me.ChkPhenomSupport.TabIndex = 13
        Me.ChkPhenomSupport.Text = "Enable Phenomenon Support"
        Me.ChkPhenomSupport.UseVisualStyleBackColor = True
        '
        'ChkPhenomDealIn
        '
        Me.ChkPhenomDealIn.AutoSize = True
        Me.ChkPhenomDealIn.ForeColor = System.Drawing.Color.White
        Me.ChkPhenomDealIn.Location = New System.Drawing.Point(3, 167)
        Me.ChkPhenomDealIn.Name = "ChkPhenomDealIn"
        Me.ChkPhenomDealIn.Size = New System.Drawing.Size(199, 17)
        Me.ChkPhenomDealIn.TabIndex = 14
        Me.ChkPhenomDealIn.Text = "Deal in Phenomenon to Planar Deck"
        Me.ChkPhenomDealIn.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbOptions)
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
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.NumAretMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BNewGame As Button
    Friend WithEvents BExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CHKInfinite As CheckBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents ChkNaarReset As CheckBox
    Friend WithEvents ChkPreTransReset As CheckBox
    Friend WithEvents ChkResetReturn As CheckBox
    Friend WithEvents ChkDistanceReset As CheckBox
    Friend WithEvents ChkAertReset As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumAretMax As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkPhenomDealIn As CheckBox
    Friend WithEvents ChkPhenomSupport As CheckBox
End Class
