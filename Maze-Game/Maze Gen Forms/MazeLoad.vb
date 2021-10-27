Public Class MazeLoad
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click 'Initiates the process to load the maze
        Try
            If txtFilename.Text = "" Then
                MsgBox("Please enter a filename")
            Else
                lblFlNFod.Hide()
                PlayLoadedMaze.Show()
            End If
        Catch ex As Exception
            lblFlNFod.Show()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Closes the form
        Close()
    End Sub
End Class