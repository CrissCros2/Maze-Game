<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PassReset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassReset))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFPass = New System.Windows.Forms.TextBox()
        Me.txtSPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblInvInp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Reset:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Retype Password:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(211, 21)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUpdate.Size = New System.Drawing.Size(75, 46)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update Password"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(9, 87)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(277, 20)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFPass
        '
        Me.txtFPass.Location = New System.Drawing.Point(105, 22)
        Me.txtFPass.Name = "txtFPass"
        Me.txtFPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtFPass.Size = New System.Drawing.Size(100, 20)
        Me.txtFPass.TabIndex = 0
        '
        'txtSPass
        '
        Me.txtSPass.Location = New System.Drawing.Point(105, 47)
        Me.txtSPass.Name = "txtSPass"
        Me.txtSPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSPass.Size = New System.Drawing.Size(100, 20)
        Me.txtSPass.TabIndex = 1
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.ForeColor = System.Drawing.Color.Red
        Me.lblPass.Location = New System.Drawing.Point(101, 71)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(123, 13)
        Me.lblPass.TabIndex = 5
        Me.lblPass.Text = "Passwords do not match"
        Me.lblPass.Visible = False
        '
        'lblInvInp
        '
        Me.lblInvInp.AutoSize = True
        Me.lblInvInp.ForeColor = System.Drawing.Color.Red
        Me.lblInvInp.Location = New System.Drawing.Point(101, 71)
        Me.lblInvInp.Name = "lblInvInp"
        Me.lblInvInp.Size = New System.Drawing.Size(64, 13)
        Me.lblInvInp.TabIndex = 6
        Me.lblInvInp.Text = "Invalid input"
        Me.lblInvInp.Visible = False
        '
        'PassReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 112)
        Me.Controls.Add(Me.lblInvInp)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtSPass)
        Me.Controls.Add(Me.txtFPass)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PassReset"
        Me.Text = "Password Reset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFPass As TextBox
    Friend WithEvents txtSPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblInvInp As Label
End Class
