Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class ForgPassword
    Private db As New Database
    Private rgxusr As New Regex("^[A-Za-z0-9]{0,}$") 'Regular expression used to validate the user input before searching the database
    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click 'Sends an email to the users email with a reset code
        lblIncCod.Hide()
        lblIncUser.Hide()
        lblInvInp.Hide()
        If rgxusr.IsMatch(txtUser.Text) = True Then
            Try
                Dim result As MySqlDataReader = db.GenNewUser(txtUser.Text)
                result.Read()
                Dim UDetails As New User(result.GetInt16(0), result.GetString(1), result.GetString(2))
                Dim em As New Email(User.GetEmail, User.GetUID, db.GenPassResetCode)
                result.Close()
                db.CloseDatabase()
                em.SendResetEmail()
            Catch ex As Exception
                lblInvInp.Show()
            End Try
        Else
            lblIncUser.Show()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click 'Starts the process to reset the password after a valid 
        lblIncCod.Hide()
        lblIncUser.Hide()
        lblInvInp.Hide()
        Dim Valid As Boolean
        Try
            Valid = db.IsCodeValid(txtUser.Text, TxtCode.Text)
            If Valid = True Then
                PassReset.Show()
                Close()
            Else
                lblIncCod.Show()
            End If
        Catch ex As Exception
            lblInvInp.Show()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Exits the form
        Login.Show()
        Close()
    End Sub
End Class