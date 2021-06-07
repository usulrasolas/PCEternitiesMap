<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashPage))
        Me.BCloseSplash = New System.Windows.Forms.Button()
        Me.RTBSplashIntro = New System.Windows.Forms.RichTextBox()
        Me.lblSplashgreeting = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BCloseSplash
        '
        Me.BCloseSplash.BackColor = System.Drawing.Color.White
        Me.BCloseSplash.ForeColor = System.Drawing.Color.Black
        Me.BCloseSplash.Location = New System.Drawing.Point(350, 400)
        Me.BCloseSplash.Name = "BCloseSplash"
        Me.BCloseSplash.Size = New System.Drawing.Size(100, 25)
        Me.BCloseSplash.TabIndex = 0
        Me.BCloseSplash.Text = "OK"
        Me.BCloseSplash.UseVisualStyleBackColor = False
        '
        'RTBSplashIntro
        '
        Me.RTBSplashIntro.BackColor = System.Drawing.Color.Black
        Me.RTBSplashIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBSplashIntro.ForeColor = System.Drawing.Color.White
        Me.RTBSplashIntro.Location = New System.Drawing.Point(100, 185)
        Me.RTBSplashIntro.Name = "RTBSplashIntro"
        Me.RTBSplashIntro.ReadOnly = True
        Me.RTBSplashIntro.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTBSplashIntro.Size = New System.Drawing.Size(600, 200)
        Me.RTBSplashIntro.TabIndex = 1
        Me.RTBSplashIntro.Text = resources.GetString("RTBSplashIntro.Text")
        '
        'lblSplashgreeting
        '
        Me.lblSplashgreeting.AutoSize = True
        Me.lblSplashgreeting.BackColor = System.Drawing.Color.Transparent
        Me.lblSplashgreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashgreeting.Location = New System.Drawing.Point(27, 9)
        Me.lblSplashgreeting.Name = "lblSplashgreeting"
        Me.lblSplashgreeting.Size = New System.Drawing.Size(751, 37)
        Me.lblSplashgreeting.TabIndex = 2
        Me.lblSplashgreeting.Text = "Welcome to the Planeschase: Eternities Map for PC"
        '
        'SplashPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.EternitiesMap.My.Resources.Resources.splashart
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSplashgreeting)
        Me.Controls.Add(Me.RTBSplashIntro)
        Me.Controls.Add(Me.BCloseSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashPage"
        Me.Text = "Planeschase Eternities Map for PC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCloseSplash As Button
    Friend WithEvents RTBSplashIntro As RichTextBox
    Friend WithEvents lblSplashgreeting As Label
End Class
