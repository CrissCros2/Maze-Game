<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chk3Game = New System.Windows.Forms.CheckBox()
        Me.chk5game = New System.Windows.Forms.CheckBox()
        Me.chk10game = New System.Windows.Forms.CheckBox()
        Me.dgvScores = New System.Windows.Forms.DataGridView()
        Me.dgvLeader3 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvLeader5 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvLeader10 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt3gameMean = New System.Windows.Forms.TextBox()
        Me.txt3gameVariance = New System.Windows.Forms.TextBox()
        Me.txt3gameSD = New System.Windows.Forms.TextBox()
        Me.txt5gameMean = New System.Windows.Forms.TextBox()
        Me.txt5gameVariance = New System.Windows.Forms.TextBox()
        Me.txt5gameSD = New System.Windows.Forms.TextBox()
        Me.txt10GameSD = New System.Windows.Forms.TextBox()
        Me.txt10GameVariance = New System.Windows.Forms.TextBox()
        Me.txt10GameMean = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt3gameZ = New System.Windows.Forms.TextBox()
        Me.txt5gameZ = New System.Windows.Forms.TextBox()
        Me.txt10gameZ = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.chk10GmeChrt = New System.Windows.Forms.CheckBox()
        Me.chk5GmeChrt = New System.Windows.Forms.CheckBox()
        Me.chk3GmeChrt = New System.Windows.Forms.CheckBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblGmeMode = New System.Windows.Forms.Label()
        Me.lblGmeMode2 = New System.Windows.Forms.Label()
        Me.lblDates = New System.Windows.Forms.Label()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLeader3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLeader5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLeader10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End Date"
        '
        'dtpStart
        '
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpStart.CustomFormat = "yyyy/MM/dd"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(70, 9)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpStart.Size = New System.Drawing.Size(83, 20)
        Me.dtpStart.TabIndex = 0
        Me.dtpStart.Value = New Date(2021, 1, 15, 18, 28, 47, 0)
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy/MM/dd"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(70, 32)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(83, 20)
        Me.dtpEnd.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(159, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 63)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chk3Game
        '
        Me.chk3Game.AutoSize = True
        Me.chk3Game.Location = New System.Drawing.Point(261, 9)
        Me.chk3Game.Name = "chk3Game"
        Me.chk3Game.Size = New System.Drawing.Size(68, 17)
        Me.chk3Game.TabIndex = 5
        Me.chk3Game.Text = "3 Games"
        Me.chk3Game.UseVisualStyleBackColor = True
        '
        'chk5game
        '
        Me.chk5game.AutoSize = True
        Me.chk5game.Location = New System.Drawing.Point(261, 32)
        Me.chk5game.Name = "chk5game"
        Me.chk5game.Size = New System.Drawing.Size(68, 17)
        Me.chk5game.TabIndex = 6
        Me.chk5game.Text = "5 Games"
        Me.chk5game.UseVisualStyleBackColor = True
        '
        'chk10game
        '
        Me.chk10game.AutoSize = True
        Me.chk10game.Location = New System.Drawing.Point(261, 55)
        Me.chk10game.Name = "chk10game"
        Me.chk10game.Size = New System.Drawing.Size(74, 17)
        Me.chk10game.TabIndex = 7
        Me.chk10game.Text = "10 Games"
        Me.chk10game.UseVisualStyleBackColor = True
        '
        'dgvScores
        '
        Me.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScores.Location = New System.Drawing.Point(12, 131)
        Me.dgvScores.Name = "dgvScores"
        Me.dgvScores.Size = New System.Drawing.Size(312, 331)
        Me.dgvScores.TabIndex = 8
        '
        'dgvLeader3
        '
        Me.dgvLeader3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeader3.Location = New System.Drawing.Point(332, 131)
        Me.dgvLeader3.Name = "dgvLeader3"
        Me.dgvLeader3.Size = New System.Drawing.Size(312, 331)
        Me.dgvLeader3.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Your Scores:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "3 Game Leaderboard:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(756, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "5 Game Leaderboard:"
        '
        'dgvLeader5
        '
        Me.dgvLeader5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeader5.Location = New System.Drawing.Point(650, 131)
        Me.dgvLeader5.Name = "dgvLeader5"
        Me.dgvLeader5.Size = New System.Drawing.Size(312, 331)
        Me.dgvLeader5.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1072, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "10 Game Leaderboard:"
        '
        'dgvLeader10
        '
        Me.dgvLeader10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeader10.Location = New System.Drawing.Point(968, 131)
        Me.dgvLeader10.Name = "dgvLeader10"
        Me.dgvLeader10.Size = New System.Drawing.Size(312, 331)
        Me.dgvLeader10.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(335, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 63)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Location = New System.Drawing.Point(636, 9)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(49, 13)
        Me.lblStats.TabIndex = 16
        Me.lblStats.Text = "Statistics"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(746, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "3 Game Scores:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(896, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "5 Game Scores:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1046, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "10 Game Scores:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(636, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Mean:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(637, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Variance:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(636, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Standard Deviation:"
        '
        'txt3gameMean
        '
        Me.txt3gameMean.Location = New System.Drawing.Point(749, 25)
        Me.txt3gameMean.Name = "txt3gameMean"
        Me.txt3gameMean.ReadOnly = True
        Me.txt3gameMean.Size = New System.Drawing.Size(100, 20)
        Me.txt3gameMean.TabIndex = 28
        '
        'txt3gameVariance
        '
        Me.txt3gameVariance.Location = New System.Drawing.Point(749, 51)
        Me.txt3gameVariance.Name = "txt3gameVariance"
        Me.txt3gameVariance.ReadOnly = True
        Me.txt3gameVariance.Size = New System.Drawing.Size(100, 20)
        Me.txt3gameVariance.TabIndex = 29
        '
        'txt3gameSD
        '
        Me.txt3gameSD.Location = New System.Drawing.Point(749, 75)
        Me.txt3gameSD.Name = "txt3gameSD"
        Me.txt3gameSD.ReadOnly = True
        Me.txt3gameSD.Size = New System.Drawing.Size(100, 20)
        Me.txt3gameSD.TabIndex = 30
        '
        'txt5gameMean
        '
        Me.txt5gameMean.Location = New System.Drawing.Point(899, 25)
        Me.txt5gameMean.Name = "txt5gameMean"
        Me.txt5gameMean.ReadOnly = True
        Me.txt5gameMean.Size = New System.Drawing.Size(100, 20)
        Me.txt5gameMean.TabIndex = 31
        '
        'txt5gameVariance
        '
        Me.txt5gameVariance.Location = New System.Drawing.Point(899, 51)
        Me.txt5gameVariance.Name = "txt5gameVariance"
        Me.txt5gameVariance.ReadOnly = True
        Me.txt5gameVariance.Size = New System.Drawing.Size(100, 20)
        Me.txt5gameVariance.TabIndex = 32
        '
        'txt5gameSD
        '
        Me.txt5gameSD.Location = New System.Drawing.Point(899, 75)
        Me.txt5gameSD.Name = "txt5gameSD"
        Me.txt5gameSD.ReadOnly = True
        Me.txt5gameSD.Size = New System.Drawing.Size(100, 20)
        Me.txt5gameSD.TabIndex = 33
        '
        'txt10GameSD
        '
        Me.txt10GameSD.Location = New System.Drawing.Point(1049, 75)
        Me.txt10GameSD.Name = "txt10GameSD"
        Me.txt10GameSD.ReadOnly = True
        Me.txt10GameSD.Size = New System.Drawing.Size(100, 20)
        Me.txt10GameSD.TabIndex = 36
        '
        'txt10GameVariance
        '
        Me.txt10GameVariance.Location = New System.Drawing.Point(1049, 51)
        Me.txt10GameVariance.Name = "txt10GameVariance"
        Me.txt10GameVariance.ReadOnly = True
        Me.txt10GameVariance.Size = New System.Drawing.Size(100, 20)
        Me.txt10GameVariance.TabIndex = 35
        '
        'txt10GameMean
        '
        Me.txt10GameMean.Location = New System.Drawing.Point(1049, 25)
        Me.txt10GameMean.Name = "txt10GameMean"
        Me.txt10GameMean.ReadOnly = True
        Me.txt10GameMean.Size = New System.Drawing.Size(100, 20)
        Me.txt10GameMean.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(469, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Z Score:"
        '
        'txt3gameZ
        '
        Me.txt3gameZ.Location = New System.Drawing.Point(390, 481)
        Me.txt3gameZ.Name = "txt3gameZ"
        Me.txt3gameZ.ReadOnly = True
        Me.txt3gameZ.Size = New System.Drawing.Size(200, 20)
        Me.txt3gameZ.TabIndex = 40
        '
        'txt5gameZ
        '
        Me.txt5gameZ.Location = New System.Drawing.Point(708, 481)
        Me.txt5gameZ.Name = "txt5gameZ"
        Me.txt5gameZ.ReadOnly = True
        Me.txt5gameZ.Size = New System.Drawing.Size(200, 20)
        Me.txt5gameZ.TabIndex = 41
        '
        'txt10gameZ
        '
        Me.txt10gameZ.Location = New System.Drawing.Point(1026, 481)
        Me.txt10gameZ.Name = "txt10gameZ"
        Me.txt10gameZ.ReadOnly = True
        Me.txt10gameZ.Size = New System.Drawing.Size(200, 20)
        Me.txt10gameZ.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(785, 466)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Z Score:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1101, 466)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Z Score:"
        '
        'btnGraph
        '
        Me.btnGraph.Location = New System.Drawing.Point(442, 7)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(96, 63)
        Me.btnGraph.TabIndex = 45
        Me.btnGraph.Text = "Graphs"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'chk10GmeChrt
        '
        Me.chk10GmeChrt.AutoSize = True
        Me.chk10GmeChrt.Location = New System.Drawing.Point(544, 55)
        Me.chk10GmeChrt.Name = "chk10GmeChrt"
        Me.chk10GmeChrt.Size = New System.Drawing.Size(74, 17)
        Me.chk10GmeChrt.TabIndex = 48
        Me.chk10GmeChrt.Text = "10 Games"
        Me.chk10GmeChrt.UseVisualStyleBackColor = True
        '
        'chk5GmeChrt
        '
        Me.chk5GmeChrt.AutoSize = True
        Me.chk5GmeChrt.Location = New System.Drawing.Point(544, 32)
        Me.chk5GmeChrt.Name = "chk5GmeChrt"
        Me.chk5GmeChrt.Size = New System.Drawing.Size(68, 17)
        Me.chk5GmeChrt.TabIndex = 47
        Me.chk5GmeChrt.Text = "5 Games"
        Me.chk5GmeChrt.UseVisualStyleBackColor = True
        '
        'chk3GmeChrt
        '
        Me.chk3GmeChrt.AutoSize = True
        Me.chk3GmeChrt.Location = New System.Drawing.Point(544, 9)
        Me.chk3GmeChrt.Name = "chk3GmeChrt"
        Me.chk3GmeChrt.Size = New System.Drawing.Size(68, 17)
        Me.chk3GmeChrt.TabIndex = 46
        Me.chk3GmeChrt.Text = "3 Games"
        Me.chk3GmeChrt.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ForeColor = System.Drawing.Color.Red
        Me.lblData.Location = New System.Drawing.Point(156, 73)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(103, 13)
        Me.lblData.TabIndex = 49
        Me.lblData.Text = "Cannot retrieve data"
        Me.lblData.Visible = False
        '
        'lblGmeMode
        '
        Me.lblGmeMode.AutoSize = True
        Me.lblGmeMode.ForeColor = System.Drawing.Color.Red
        Me.lblGmeMode.Location = New System.Drawing.Point(156, 73)
        Me.lblGmeMode.Name = "lblGmeMode"
        Me.lblGmeMode.Size = New System.Drawing.Size(128, 13)
        Me.lblGmeMode.TabIndex = 50
        Me.lblGmeMode.Text = "Must select a game mode"
        Me.lblGmeMode.Visible = False
        '
        'lblGmeMode2
        '
        Me.lblGmeMode2.AutoSize = True
        Me.lblGmeMode2.ForeColor = System.Drawing.Color.Red
        Me.lblGmeMode2.Location = New System.Drawing.Point(439, 73)
        Me.lblGmeMode2.Name = "lblGmeMode2"
        Me.lblGmeMode2.Size = New System.Drawing.Size(128, 13)
        Me.lblGmeMode2.TabIndex = 51
        Me.lblGmeMode2.Text = "Must select a game mode"
        Me.lblGmeMode2.Visible = False
        '
        'lblDates
        '
        Me.lblDates.AutoSize = True
        Me.lblDates.ForeColor = System.Drawing.Color.Red
        Me.lblDates.Location = New System.Drawing.Point(12, 58)
        Me.lblDates.Name = "lblDates"
        Me.lblDates.Size = New System.Drawing.Size(86, 13)
        Me.lblDates.TabIndex = 52
        Me.lblDates.Text = "Dates are invalid"
        Me.lblDates.Visible = False
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 514)
        Me.Controls.Add(Me.lblDates)
        Me.Controls.Add(Me.lblGmeMode2)
        Me.Controls.Add(Me.lblGmeMode)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.chk10GmeChrt)
        Me.Controls.Add(Me.chk5GmeChrt)
        Me.Controls.Add(Me.chk3GmeChrt)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt10gameZ)
        Me.Controls.Add(Me.txt5gameZ)
        Me.Controls.Add(Me.txt3gameZ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt10GameSD)
        Me.Controls.Add(Me.txt10GameVariance)
        Me.Controls.Add(Me.txt10GameMean)
        Me.Controls.Add(Me.txt5gameSD)
        Me.Controls.Add(Me.txt5gameVariance)
        Me.Controls.Add(Me.txt5gameMean)
        Me.Controls.Add(Me.txt3gameSD)
        Me.Controls.Add(Me.txt3gameVariance)
        Me.Controls.Add(Me.txt3gameMean)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvLeader10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvLeader5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvLeader3)
        Me.Controls.Add(Me.dgvScores)
        Me.Controls.Add(Me.chk10game)
        Me.Controls.Add(Me.chk5game)
        Me.Controls.Add(Me.chk3Game)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Scores"
        Me.Text = "Scores"
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLeader3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLeader5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLeader10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents chk3Game As CheckBox
    Friend WithEvents chk5game As CheckBox
    Friend WithEvents chk10game As CheckBox
    Friend WithEvents dgvScores As DataGridView
    Friend WithEvents dgvLeader3 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvLeader5 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvLeader10 As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStats As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt3gameMean As TextBox
    Friend WithEvents txt3gameVariance As TextBox
    Friend WithEvents txt3gameSD As TextBox
    Friend WithEvents txt5gameMean As TextBox
    Friend WithEvents txt5gameVariance As TextBox
    Friend WithEvents txt5gameSD As TextBox
    Friend WithEvents txt10GameSD As TextBox
    Friend WithEvents txt10GameVariance As TextBox
    Friend WithEvents txt10GameMean As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt3gameZ As TextBox
    Friend WithEvents txt5gameZ As TextBox
    Friend WithEvents txt10gameZ As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnGraph As Button
    Friend WithEvents chk10GmeChrt As CheckBox
    Friend WithEvents chk5GmeChrt As CheckBox
    Friend WithEvents chk3GmeChrt As CheckBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblGmeMode As Label
    Friend WithEvents lblGmeMode2 As Label
    Friend WithEvents lblDates As Label
End Class
