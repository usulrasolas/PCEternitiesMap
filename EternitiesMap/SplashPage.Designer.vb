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
        Me.BCloseSplash = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BCloseSplash
        '
        Me.BCloseSplash.Location = New System.Drawing.Point(371, 385)
        Me.BCloseSplash.Name = "BCloseSplash"
        Me.BCloseSplash.Size = New System.Drawing.Size(75, 23)
        Me.BCloseSplash.TabIndex = 0
        Me.BCloseSplash.Text = "Yeet"
        Me.BCloseSplash.UseVisualStyleBackColor = True
        '
        'SplashPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BCloseSplash)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashPage"
        Me.Text = "Welcome to Planeschase Eternities Map"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BCloseSplash As Button
End Class
