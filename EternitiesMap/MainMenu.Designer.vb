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
        Me.ChkNaarReset = New System.Windows.Forms.CheckBox()
        Me.ChkPreTransReset = New System.Windows.Forms.CheckBox()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MTG Planechase Eternities Map v1"
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
        Me.CHKInfinite.Location = New System.Drawing.Point(3, 16)
        Me.CHKInfinite.Name = "CHKInfinite"
        Me.CHKInfinite.Size = New System.Drawing.Size(754, 17)
        Me.CHKInfinite.TabIndex = 5
        Me.CHKInfinite.Text = "Finite Mode (Planes never get removed from board)"
        Me.CHKInfinite.UseVisualStyleBackColor = True
        '
        'gbOptions
        '
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
        'ChkNaarReset
        '
        Me.ChkNaarReset.AutoSize = True
        Me.ChkNaarReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkNaarReset.Location = New System.Drawing.Point(3, 33)
        Me.ChkNaarReset.Name = "ChkNaarReset"
        Me.ChkNaarReset.Size = New System.Drawing.Size(754, 17)
        Me.ChkNaarReset.TabIndex = 6
        Me.ChkNaarReset.Text = "Reset Naar Island When Planeswalk Away"
        Me.ChkNaarReset.UseVisualStyleBackColor = True
        '
        'ChkPreTransReset
        '
        Me.ChkPreTransReset.AutoSize = True
        Me.ChkPreTransReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChkPreTransReset.Location = New System.Drawing.Point(3, 50)
        Me.ChkPreTransReset.Name = "ChkPreTransReset"
        Me.ChkPreTransReset.Size = New System.Drawing.Size(754, 17)
        Me.ChkPreTransReset.TabIndex = 7
        Me.ChkPreTransReset.Text = "Reset All Counters When Walking Away"
        Me.ChkPreTransReset.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
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
End Class
