<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MazeLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MazeLoad))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFlNFod = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Name:"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(15, 25)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(100, 20)
        Me.txtFilename.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(121, 25)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 21)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(15, 51)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(181, 21)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFlNFod
        '
        Me.lblFlNFod.AutoSize = True
        Me.lblFlNFod.ForeColor = System.Drawing.Color.Red
        Me.lblFlNFod.Location = New System.Drawing.Point(122, 9)
        Me.lblFlNFod.Name = "lblFlNFod"
        Me.lblFlNFod.Size = New System.Drawing.Size(76, 13)
        Me.lblFlNFod.TabIndex = 5
        Me.lblFlNFod.Text = "File Not Found"
        Me.lblFlNFod.Visible = False
        '
        'MazeLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 78)
        Me.Controls.Add(Me.lblFlNFod)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MazeLoad"
        Me.Text = "Load Maze"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFlNFod As Label
End Class
