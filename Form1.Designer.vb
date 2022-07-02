<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Plane = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShoot = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Plane
        '
        Me.Plane.Image = Global.feri_banaako.My.Resources.Resource1.player
        Me.Plane.Location = New System.Drawing.Point(219, 533)
        Me.Plane.Name = "Plane"
        Me.Plane.Size = New System.Drawing.Size(71, 57)
        Me.Plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Plane.TabIndex = 0
        Me.Plane.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(13, 13)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(70, 25)
        Me.ScoreLabel.TabIndex = 1
        Me.ScoreLabel.Text = "Score:"
        '
        'tmrRight
        '
        '
        'tmrLeft
        '
        '
        'tmrEnemey
        '
        '
        'tmrShoot
        '
        Me.tmrShoot.Interval = 1
        '
        'ScoreTimer
        '
        Me.ScoreTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(540, 602)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Plane)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximumSize = New System.Drawing.Size(558, 649)
        Me.MinimumSize = New System.Drawing.Size(558, 649)
        Me.Name = "Form1"
        Me.Text = "Space Shooter"
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Plane As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrEnemey As Timer
    Friend WithEvents tmrShoot As Timer
    Friend WithEvents ScoreTimer As Timer
End Class
