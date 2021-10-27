Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class Register
    Private rgxusr As New Regex("^[A-Za-z0-9]*$") 'Standard expressions to validate user inputs
    Private rgxnme As New Regex("^[A-Za-z]*$")
    Private rgxemail As New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z]+\.[A-Za-z]{2,}$")

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Login.Show()
        Close()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        lblBlank.Hide()
        lblEmail.Hide()
        lblfn.Hide()
        lbluser.Hide()
        lblPass.Hide()
        lblExistUser.Hide()
        Dim db As New Database
        Dim valid As Boolean = True
        Dim reader As MySqlDataReader = db.GenNewUser(txtUsrname.Text)
        If reader.HasRows = False Then 'Checks if a user with the inputed username exists
            reader.Close()
            If txtPass.Text = txtRePass.Text Then 'Checks both passwords match
                'A selection of if statements that check that the users inputs are valid
                If txtPass.Text = "" Or txtUsrname.Text = "" Or txtFN.Text = "" Or txtemail.Text = "" Or txtRePass.Text = "" Then
                    lblBlank.Show()
                    valid = False
                ElseIf rgxusr.IsMatch(txtUsrname.Text) = False Then
                    lbluser.Show()
                    valid = False
                ElseIf rgxnme.IsMatch(txtFN.Text) = False Then
                    lblfn.Show()
                    valid = False
                ElseIf rgxemail.IsMatch(txtemail.Text) = False Then
                    lblEmail.Show()
                    valid = False
                End If
                If valid Then 'If all of the inputs are valid
                    db.NewUser(txtUsrname.Text, txtPass.Text, txtFN.Text, txtemail.Text)
                    MsgBox("Registration Successful")
                    Login.Show()
                    Close()
                End If
            Else
                lblPass.Show()
            End If
        Else
            lblExistUser.Show()
        End If
    End Sub
End Class