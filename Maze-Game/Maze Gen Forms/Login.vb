Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class Login
    Private db As New Database
    Private rgxusr As New Regex("^[A-Za-z0-9]*$")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click 'Checks if a user with the username and password as stated exists
        If txtUsername.Text = "" Or txtPassword.Text = "" Or rgxusr.IsMatch(txtUsername.Text) = False Then
            lblWrUP.Show()
        Else
            Try
                Dim result As MySqlDataReader = db.Login(txtUsername.Text, txtPassword.Text)
                If result.HasRows Then 'If the user exists
                    lblWrUP.Hide()
                    result.Read()
                    Dim UDetails As New User(result.GetInt16(0), result.GetString(1), result.GetString(2))
                    PlayMenu.Show() 'Logs in
                    Hide()
                Else
                    lblInvInp.Hide()
                    lblWrUP.Show()
                End If
            Catch ex As Exception 'Displays if an error occurs
                lblWrUP.Hide()
                lblInvInp.Show()
            End Try
            db.CloseDatabase()
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click 'Shows the registration form
        Hide()
        Register.Show()
    End Sub

    Private Sub btnForgPass_Click(sender As Object, e As EventArgs) Handles btnForgPass.Click 'Shows the forgotten password form
        ForgPassword.Show()
        Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'When the form loads the database is created if it does not already exist
        db.CreateDatabase()
        db.CreateTables()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Exits the form and program
        Close()
    End Sub
End Class
