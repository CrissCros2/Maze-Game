Imports System.IO
Public Class PlayLoadedMaze
    Private g As Loaded_Maze
    Private numofmoves As Integer
    Private Score As Integer
    Private Loaded As Boolean = False
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

    Public Sub EndGame() 'Add ability to save mazes
        Score = g.GenerateScore(Score, numofmoves)
        MsgBox("Your Score was: " & Score)
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Runs when the form is started
        g = New Loaded_Maze(MazeLoad.txtFilename.Text, PlayMenu.ChkHighlight.Checked)
        MazeLoad.Close()
        Start()
    End Sub

    Private Sub Start() 'Starts the game
        Loaded = True
        numofmoves = 0
        g.LoadMaze()
        g.SetupBoard(Me, True)
        CurrentX = 0
        CurrentY = g.GetEntranceValue
        Previousbox = CurrentY + 1
    End Sub

    Public Function IsLoaded()
        Return Loaded
    End Function
End Class