Public Class PlayMenu
    Public Difficulty As Integer = 0
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk3Game.Click 'If a checkbox is checked it sets every other check box to unchecked as only one can be checked at once
        Chk5Games.Checked = False
        Chk10Games.Checked = False
        Difficulty = 1
        If Chk3Game.Checked = False And Chk5Games.Checked = False And Chk10Games.Checked = False Then
            Difficulty = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk5Games.Click
        Chk3Game.Checked = False
        Chk10Games.Checked = False
        Difficulty = 2
        If Chk3Game.Checked = False And Chk5Games.Checked = False And Chk10Games.Checked = False Then
            Difficulty = 0
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Chk10Games.Click
        Chk5Games.Checked = False
        Chk3Game.Checked = False
        Difficulty = 3
        If Chk3Game.Checked = False And Chk5Games.Checked = False And Chk10Games.Checked = False Then
            Difficulty = 0
        End If
    End Sub

    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click 'Checks if a mode box is checked and if so runs the game
        If Difficulty = 0 Then
            lblSlcMod.Show()
        Else
            lblSlcMod.Hide()
            PlayGeneratedMaze.Show()
        End If
    End Sub

    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Generates a welcome message
        Label2.Text = "Welcome " & User.GetUName
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click 'Shows the score window
        Scores.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click 'Logs the user out
        Login.Show()
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Opens a window so the user can double check if they really want to delete their account
        DoubleChk.Show()
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click 'Opens the form for the user to input a file name
        MazeLoad.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("To start playing press the play button." & vbNewLine & "To load a maze press the load maze button." & vbNewLine & "To view the leaderboards press the scores button." & vbNewLine & "To delete your account press the delete account button." & vbNewLine & "To log out press the log out button.")
    End Sub
End Class