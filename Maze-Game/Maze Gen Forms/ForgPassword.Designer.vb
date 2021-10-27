<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgPassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInvInp = New System.Windows.Forms.Label()
        Me.lblIncUser = New System.Windows.Forms.Label()
        Me.lblIncCod = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter your username:"
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(118, 25)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(75, 20)
        Me.btnEmail.TabIndex = 1
        Me.btnEmail.Text = "Send Email"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 25)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 0
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(12, 51)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(100, 20)
        Me.TxtCode.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(118, 51)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 20)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Submit Code"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 50)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "A code will be sent to the email " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "address associated with the account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enter thi" &
    "s code and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press ""Submit Code"""
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(115, 120)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 20)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInvInp
        '
        Me.lblInvInp.AutoSize = True
        Me.lblInvInp.ForeColor = System.Drawing.Color.Red
        Me.lblInvInp.Location = New System.Drawing.Point(9, 74)
        Me.lblInvInp.Name = "lblInvInp"
        Me.lblInvInp.Size = New System.Drawing.Size(65, 13)
        Me.lblInvInp.TabIndex = 6
        Me.lblInvInp.Text = "Invalid Input"
        Me.lblInvInp.Visible = False
        '
        'lblIncUser
        '
        Me.lblIncUser.AutoSize = True
        Me.lblIncUser.ForeColor = System.Drawing.Color.Red
        Me.lblIncUser.Location = New System.Drawing.Point(9, 74)
        Me.lblIncUser.Name = "lblIncUser"
        Me.lblIncUser.Size = New System.Drawing.Size(100, 13)
        Me.lblIncUser.TabIndex = 7
        Me.lblIncUser.Text = "Incorrect Username"
        Me.lblIncUser.Visible = False
        '
        'lblIncCod
        '
        Me.lblIncCod.AutoSize = True
        Me.lblIncCod.ForeColor = System.Drawing.Color.Red
        Me.lblIncCod.Location = New System.Drawing.Point(9, 74)
        Me.lblIncCod.Name = "lblIncCod"
        Me.lblIncCod.Size = New System.Drawing.Size(77, 13)
        Me.lblIncCod.TabIndex = 8
        Me.lblIncCod.Text = "Incorrect Code"
        Me.lblIncCod.Visible = False
        '
        'ForgPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 148)
        Me.Controls.Add(Me.lblIncCod)
        Me.Controls.Add(Me.lblIncUser)
        Me.Controls.Add(Me.lblInvInp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgPassword"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmail As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInvInp As Label
    Friend WithEvents lblIncUser As Label
    Friend WithEvents lblIncCod As Label
End Class
