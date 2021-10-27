Public Class SelectMaze 'Form allows the user to view the mazes select on and save it with a given file name
    Private listofmazes As List(Of Graph) = SavingMaze.GetList
    Private Sub SelectMaze_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Changes some things in the mazes so they are displayed in the correct format
        nudMazeSelect.Maximum = SavingMaze.GetLength()
        For num = 0 To nudMazeSelect.Maximum - 1
            Dim Maze(,) As Char
            For y = 1 To 38
                Maze = listofmazes(num).GetMaze
                If Maze(0, y) = "." Then
                    Maze(0, y) = "C"
                End If
                If Maze(38, y) = "C" Then
                    Maze(38, y) = "E"
                End If
            Next
        Next
        listofmazes((nudMazeSelect.Value) - 1).SetupBoard(Me, False)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        listofmazes((nudMazeSelect.Value) - 1).SetupBoard(Me, False) 'Displays the maze on the screen
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Exits the form
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Saves the maze to a file
        lblFilename.Hide()
        Try
            listofmazes((nudMazeSelect.Value) - 1).SaveMaze(txtFilename.Text)
        Catch ex As Exception
            lblFilename.Show()
        End Try
    End Sub
End Class