<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsrname = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.txtRePass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblfn = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblBlank = New System.Windows.Forms.Label()
        Me.lblExistUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'txtUsrname
        '
        Me.txtUsrname.Location = New System.Drawing.Point(64, 14)
        Me.txtUsrname.Name = "txtUsrname"
        Me.txtUsrname.Size = New System.Drawing.Size(100, 20)
        Me.txtUsrname.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(64, 40)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 1
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(64, 92)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(100, 20)
        Me.txtFN.TabIndex = 3
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(64, 117)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 4
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(170, 14)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(146, 46)
        Me.btnReg.TabIndex = 5
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(170, 92)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(146, 45)
        Me.btnX.TabIndex = 6
        Me.btnX.Text = "Exit"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'txtRePass
        '
        Me.txtRePass.Location = New System.Drawing.Point(64, 66)
        Me.txtRePass.Name = "txtRePass"
        Me.txtRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePass.Size = New System.Drawing.Size(100, 20)
        Me.txtRePass.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Re-Type"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.Color.Red
        Me.lblEmail.Location = New System.Drawing.Point(3, 140)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(106, 13)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email must be a valid"
        Me.lblEmail.Visible = False
        '
        'lblfn
        '
        Me.lblfn.AutoSize = True
        Me.lblfn.ForeColor = System.Drawing.Color.Red
        Me.lblfn.Location = New System.Drawing.Point(3, 140)
        Me.lblfn.Name = "lblfn"
        Me.lblfn.Size = New System.Drawing.Size(167, 13)
        Me.lblfn.TabIndex = 15
        Me.lblfn.Text = "First name can only contain letters"
        Me.lblfn.Visible = False
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.ForeColor = System.Drawing.Color.Red
        Me.lbluser.Location = New System.Drawing.Point(3, 140)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(251, 13)
        Me.lbluser.TabIndex = 16
        Me.lbluser.Text = "The username can only contain letters and numbers"
        Me.lbluser.Visible = False
        '
        'lblBlank
        '
        Me.lblBlank.AutoSize = True
        Me.lblBlank.ForeColor = System.Drawing.Color.Red
        Me.lblBlank.Location = New System.Drawing.Point(3, 140)
        Me.lblBlank.Name = "lblBlank"
        Me.lblBlank.Size = New System.Drawing.Size(114, 13)
        Me.lblBlank.TabIndex = 17
        Me.lblBlank.Text = "Fields cannot be blank"
        Me.lblBlank.Visible = False
        '
        'lblExistUser
        '
        Me.lblExistUser.AutoSize = True
        Me.lblExistUser.ForeColor = System.Drawing.Color.Red
        Me.lblExistUser.Location = New System.Drawing.Point(3, 140)
        Me.lblExistUser.Name = "lblExistUser"
        Me.lblExistUser.Size = New System.Drawing.Size(195, 13)
        Me.lblExistUser.TabIndex = 18
        Me.lblExistUser.Text = "A user with that username already exists"
        Me.lblExistUser.Visible = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.ForeColor = System.Drawing.Color.Red
        Me.lblPass.Location = New System.Drawing.Point(3, 140)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(115, 13)
        Me.lblPass.TabIndex = 19
        Me.lblPass.Text = "Passwords must match"
        Me.lblPass.Visible = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 157)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblExistUser)
        Me.Controls.Add(Me.lblBlank)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblfn)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRePass)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsrname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsrname As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents btnX As Button
    Friend WithEvents txtRePass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblfn As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lblBlank As Label
    Friend WithEvents lblExistUser As Label
    Friend WithEvents lblPass As Label
End Class
