Public Class DeleteAcc
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'To exit the form
        PlayMenu.Show()
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Initiates the process to delete a users account
        Dim db As New Database
        If db.CheckPass(txtPass.Text, User.GetUName) Then
            lblWrPss.Hide()
            db.DeleteUser(User.GetUID)
            Login.Show()
            Close()
        Else
            lblWrPss.Show()
        End If
    End Sub
End Class