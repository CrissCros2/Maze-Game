Public Class PlayGeneratedMaze
    Private g As New Generated_Maze(PlayMenu.ChkHighlight.Checked)
    Private numofmoves As Integer
    Private MazeNum As Integer
    Private Score As Integer
    Private CurrentX As Integer
    Private CurrentY As Integer
    Private Previousbox As Integer
    Private Sub Form1_Keydown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown 'This sub runs whenever a key is pressed down
        Dim Finished As Boolean
        Previousbox = (40 * CurrentX) + CurrentY + 1
        Select Case e.KeyCode 'Checks which arrow key is pressed down
            Case Keys.Right 'Runs if the right key is pressed
                g.MoveRight(CurrentX, CurrentY, Previousbox, numofmoves, Me, Finished)
                If Finished = True Then
                    EndGame()
                End If
            Case Keys.Left 'Runs if the left key is pressed
                g.MoveLeft(CurrentX, CurrentY, Previousbox, numofmoves, Me)
            Case Keys.Down 'Runs if the down key is pressed
                g.MoveDown(CurrentX, CurrentY, Previousbox, numofmoves, Me)
            Case Keys.Up 'Runs if the up key is pressed
                g.MoveUp(CurrentX, CurrentY, Previousbox, numofmoves, Me)
        End Select
    End Sub


    Public Sub EndGame() 'Run when the player finishes a maze
        Dim Win As Boolean = True
        MazeNum += 1
        Score = g.GenerateScore(Score, numofmoves)
        If MazeNum = 3 And PlayMenu.Difficulty = 1 Then
            Dim db As New Database
            db.NewScore(User.GetUID, Score, 3)
        ElseIf MazeNum = 5 And PlayMenu.Difficulty = 2 Then
            Dim db As New Database
            db.NewScore(User.GetUID, Score, 5)
        ElseIf MazeNum = 10 And PlayMenu.Difficulty = 3 Then
            Dim db As New Database
            db.NewScore(User.GetUID, Score, 10)
        Else
            Win = False
            Start() 'Runs the maze gen algorithm again
        End If
        If Win = True Then
            MsgBox("Your score was: " & Score) 'Displays the score to the user
            SelectMaze.Show()
            Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Runs when the form is started
        SavingMaze.ClearList()
        Start()
    End Sub

    Private Sub Start() 'Starts the process of generating a new maze
        numofmoves = 0
        Randomize()
        g = New Generated_Maze(PlayMenu.ChkHighlight.Checked) 'Creates new maze object
        g.CreateMaze() 'Generates a new maze
        g.SetupBoard(Me, True) 'Displays the board on the screen
        SavingMaze.AddMaze(g) 'Adds the maze to the list of mazes so they can be saved later
        CurrentX = 0
        CurrentY = g.GetEntranceValue
        Previousbox = CurrentY + 1
    End Sub
End Class


