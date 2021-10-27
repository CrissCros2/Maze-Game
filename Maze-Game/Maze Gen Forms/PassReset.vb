Public Class PassReset
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Closes the form and sends the user back to the login form
        Login.Show()
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click 'Updates the password for the user
        If txtFPass.Text = txtSPass.Text Then
            Try
                Dim db As New Database
                db.UpdatePassword(User.GetUName, txtFPass.Text)
                db.RemoveResetCode(User.GetUID)
                MsgBox("Password changed")
                Login.Show()
                Close()
            Catch ex As Exception
                lblPass.Hide()
                lblInvInp.Show()
            End Try
        Else
            lblInvInp.Hide()
            lblPass.Show()
        End If
    End Sub
End Class