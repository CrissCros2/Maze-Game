<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayMenu))
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Chk3Game = New System.Windows.Forms.CheckBox()
        Me.Chk5Games = New System.Windows.Forms.CheckBox()
        Me.Chk10Games = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblSlcMod = New System.Windows.Forms.Label()
        Me.ChkHighlight = New System.Windows.Forms.CheckBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(9, 148)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(122, 42)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Chk3Game
        '
        Me.Chk3Game.AutoSize = True
        Me.Chk3Game.Location = New System.Drawing.Point(265, 22)
        Me.Chk3Game.Name = "Chk3Game"
        Me.Chk3Game.Size = New System.Drawing.Size(68, 17)
        Me.Chk3Game.TabIndex = 5
        Me.Chk3Game.Text = "3 Games"
        Me.Chk3Game.UseVisualStyleBackColor = True
        '
        'Chk5Games
        '
        Me.Chk5Games.AutoSize = True
        Me.Chk5Games.Location = New System.Drawing.Point(265, 44)
        Me.Chk5Games.Name = "Chk5Games"
        Me.Chk5Games.Size = New System.Drawing.Size(68, 17)
        Me.Chk5Games.TabIndex = 6
        Me.Chk5Games.Text = "5 Games"
        Me.Chk5Games.UseVisualStyleBackColor = True
        '
        'Chk10Games
        '
        Me.Chk10Games.AutoSize = True
        Me.Chk10Games.Location = New System.Drawing.Point(265, 67)
        Me.Chk10Games.Name = "Chk10Games"
        Me.Chk10Games.Size = New System.Drawing.Size(74, 17)
        Me.Chk10Games.TabIndex = 7
        Me.Chk10Games.Text = "10 Games"
        Me.Chk10Games.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mode"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(136, 53)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(119, 88)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(9, 9)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(122, 38)
        Me.btnScores.TabIndex = 1
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Welcome"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(136, 148)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 42)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Account"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(136, 9)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(119, 38)
        Me.btnLoad.TabIndex = 8
        Me.btnLoad.Text = "Load Maze"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblSlcMod
        '
        Me.lblSlcMod.AutoSize = True
        Me.lblSlcMod.ForeColor = System.Drawing.Color.Red
        Me.lblSlcMod.Location = New System.Drawing.Point(300, 6)
        Me.lblSlcMod.Name = "lblSlcMod"
        Me.lblSlcMod.Size = New System.Drawing.Size(67, 13)
        Me.lblSlcMod.TabIndex = 9
        Me.lblSlcMod.Text = "Select Mode"
        Me.lblSlcMod.Visible = False
        '
        'ChkHighlight
        '
        Me.ChkHighlight.AutoSize = True
        Me.ChkHighlight.Checked = True
        Me.ChkHighlight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkHighlight.Location = New System.Drawing.Point(265, 90)
        Me.ChkHighlight.Name = "ChkHighlight"
        Me.ChkHighlight.Size = New System.Drawing.Size(90, 17)
        Me.ChkHighlight.TabIndex = 10
        Me.ChkHighlight.Text = "Highlight Trail"
        Me.ChkHighlight.UseVisualStyleBackColor = True
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(299, 172)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(68, 20)
        Me.txtBlue.TabIndex = 12
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(299, 130)
        Me.txtRed.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(68, 20)
        Me.txtRed.TabIndex = 13
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(299, 151)
        Me.txtGreen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(68, 20)
        Me.txtGreen.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Red"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Green"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Blue"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(9, 103)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(122, 38)
        Me.btnHelp.TabIndex = 18
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Trail Colour (0-255):"
        '
        'PlayMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 200)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.ChkHighlight)
        Me.Controls.Add(Me.lblSlcMod)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk10Games)
        Me.Controls.Add(Me.Chk5Games)
        Me.Controls.Add(Me.Chk3Game)
        Me.Controls.Add(Me.btnLogOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PlayMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents Chk3Game As CheckBox
    Friend WithEvents Chk5Games As CheckBox
    Friend WithEvents Chk10Games As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblSlcMod As Label
    Friend WithEvents ChkHighlight As CheckBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents Label6 As Label
End Class
