Public Class DoubleChk
    'This form is just a way to double checking if the user really wants to delete their account
    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click 'Opens the delete account form
        DeleteAcc.Show()
        Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Closes this form and goes back
        PlayMenu.Show()
        Close()
    End Sub
End Class