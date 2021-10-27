<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteAcc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteAcc))
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWrPss = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(10, 24)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(116, 24)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 20)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete Account"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter your password below:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(10, 66)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(198, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWrPss
        '
        Me.lblWrPss.AutoSize = True
        Me.lblWrPss.ForeColor = System.Drawing.Color.Red
        Me.lblWrPss.Location = New System.Drawing.Point(12, 50)
        Me.lblWrPss.Name = "lblWrPss"
        Me.lblWrPss.Size = New System.Drawing.Size(88, 13)
        Me.lblWrPss.TabIndex = 4
        Me.lblWrPss.Text = "Wrong Password"
        Me.lblWrPss.Visible = False
        '
        'DeleteAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 94)
        Me.Controls.Add(Me.lblWrPss)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteAcc"
        Me.Text = "Delete Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWrPss As Label
End Class
