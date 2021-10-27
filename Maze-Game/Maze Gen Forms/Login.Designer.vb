<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnForgPass = New System.Windows.Forms.Button()
        Me.lblWrUP = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInvInp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(183, 24)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(77, 27)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(77, 53)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Login"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(183, 53)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 23)
        Me.btnReg.TabIndex = 4
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'btnForgPass
        '
        Me.btnForgPass.Location = New System.Drawing.Point(183, 81)
        Me.btnForgPass.Margin = New System.Windows.Forms.Padding(2)
        Me.btnForgPass.Name = "btnForgPass"
        Me.btnForgPass.Size = New System.Drawing.Size(75, 37)
        Me.btnForgPass.TabIndex = 5
        Me.btnForgPass.Text = "Forgot Password"
        Me.btnForgPass.UseVisualStyleBackColor = True
        '
        'lblWrUP
        '
        Me.lblWrUP.AutoSize = True
        Me.lblWrUP.ForeColor = System.Drawing.Color.Red
        Me.lblWrUP.Location = New System.Drawing.Point(31, 76)
        Me.lblWrUP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWrUP.Name = "lblWrUP"
        Me.lblWrUP.Size = New System.Drawing.Size(146, 13)
        Me.lblWrUP.TabIndex = 0
        Me.lblWrUP.Text = "Wrong Username or Pasword"
        Me.lblWrUP.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(8, 96)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 22)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInvInp
        '
        Me.lblInvInp.AutoSize = True
        Me.lblInvInp.ForeColor = System.Drawing.Color.Red
        Me.lblInvInp.Location = New System.Drawing.Point(31, 76)
        Me.lblInvInp.Name = "lblInvInp"
        Me.lblInvInp.Size = New System.Drawing.Size(65, 13)
        Me.lblInvInp.TabIndex = 10
        Me.lblInvInp.Text = "Invalid Input"
        Me.lblInvInp.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(63, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "If you are a new user" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "please register first"
        Me.Label4.Visible = False
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 126)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblInvInp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWrUP)
        Me.Controls.Add(Me.btnForgPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReg As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnForgPass As Button
    Friend WithEvents lblWrUP As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInvInp As Label
    Friend WithEvents Label4 As Label
End Class
