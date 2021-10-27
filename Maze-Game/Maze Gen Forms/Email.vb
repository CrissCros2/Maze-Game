Imports System.Net.Mail

Public Class Email 'This class is used to send emails allowing users to reset their password
    Private Email As String
    Private Message As String
    Private smtp As New SmtpClient("smtp.gmail.com", 587) 'Connect to the gmail smtp server
    Private mail As New MailMessage()
    Public Sub New(DatabEmail As String, UserId As Integer, Resetcode As String)
        Email = DatabEmail
        Dim db As New Database
        db.StoreCode(Resetcode, UserId)
        Message = "Your password reset code is " & Resetcode
        mail.From = New MailAddress("mazegamerecovery@gmail.com") 'Email it will be sent from
    End Sub

    Public Function SendResetEmail()
        Try
            mail.To.Add(Email) 'The recipients email
            mail.Subject = "Maze Game Password Reset" 'Subject of the email
            mail.Body = Message ' The message in the email
            smtp.Credentials = New Net.NetworkCredential("mazegamerecovery@gmail.com", "<=MSWL~X:9BebP:") 'Login details for the account sending the email
            smtp.EnableSsl = True
            smtp.Send(mail) 'Sends the email
            MsgBox("Email sent")
            Return True 'Tells the calling subroutine it has finished
        Catch ex As Exception
            MsgBox("Error: Email failed to send") 'Displays a message if the email fails to send for any reason
            Return False
        End Try
    End Function
End Class
