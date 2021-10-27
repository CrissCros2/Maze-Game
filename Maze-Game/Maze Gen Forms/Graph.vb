Imports System.IO
Public Class Graph
    Protected vertices As New List(Of Vertex)
    Private AdjacencyMatrix(,) As Integer
    Protected Maze(38, 39) As Char
    Protected RandomEntranceValue, RandomExitValue, numofverts As Integer
    Private ShortestPath As Integer
    Protected IsChecked As Boolean
    Private Blue As Integer
    Private Red As Integer
    Private Green As Integer
    Dim pr As New Pen(Color.Purple, 4)
    Dim pw As New Pen(Color.White, 4)
    Dim pp As Pen

    'AdjacencyMatrix: This is an array of 1s and 0s that shows if there is a connection between any two node
    Public Sub New()
        RandomEntranceValue = ((CInt(Math.Floor((19 - 1 + 1) * Rnd())) + 1) * 2) - 1
        If RandomEntranceValue = 1 Then
            RandomEntranceValue += 2
        End If
        RandomExitValue = ((CInt(Math.Floor((19 - 1 + 1) * Rnd())) + 1) * 2) - 1
        Try
            Blue = Int(PlayMenu.txtBlue.Text)
            Red = Int(PlayMenu.txtRed.Text)
            Green = Int(PlayMenu.txtGreen.Text)
        Catch ex As Exception
            Blue = 0
            Red = 0
            Green = 0
        End Try
        pp = New Pen(Color.FromArgb(255, Red, Green, Blue), 4)
    End Sub

    Public Function GetEntranceValue() 'Returns the y value of the entran
        Return RandomEntranceValue
    End Function

    Public Sub CreateMatrix() 'Initialises the matrix with only 0s
        ReDim AdjacencyMatrix(vertices.Count + 1, vertices.Count + 1)
        Dim x, y As Integer
        For x = 0 To vertices.Count
            For y = 0 To vertices.Count
                AdjacencyMatrix(x, y) = 0
            Next
        Next
    End Sub

    Public Sub AddVertex(ByVal xcoord As Integer, ByVal ycoord As Integer)
        vertices.Add(New Vertex(numofverts, xcoord, ycoord))
        numofverts += 1
        'When a vertex is created it is added to the vertices list for use in the path finding algorithms
    End Sub

    Public Sub AddEdge(ByVal x As Integer, ByVal y As Integer)
        'Adding an edge means editing the adjacency matrix to show a 1 at the x coordinate of the start vertex and the y coordinate of the end vertex and vice versa
        Dim StartVertex, EndVertex As Integer
        Dim left, up As Boolean
        left = CheckVertex(x - 1, y) 'These check if there is a vertex present
        up = CheckVertex(x, y - 1) 'Up and left are used as the loop runs left to right top to bottom
        If left = True Then
            StartVertex = FindVertexPayload(x, y) 'These find the payload of the vertices to edit the adjacency matrix
            EndVertex = FindVertexPayload(x - 1, y)
            AdjacencyMatrix(StartVertex, EndVertex) = 1 'These edit the matrix
            AdjacencyMatrix(EndVertex, StartVertex) = 1
        End If
        If up = True Then
            StartVertex = FindVertexPayload(x, y)
            EndVertex = FindVertexPayload(x, y - 1)
            AdjacencyMatrix(StartVertex, EndVertex) = 1
            AdjacencyMatrix(EndVertex, StartVertex) = 1
        End If
    End Sub

    Protected Function CheckVertex(ByVal x As Integer, ByVal y As Integer)
        Dim vert As Vertex = vertices.Find(Function(n) n.xcoord = x And n.ycoord = y)
        Return vertices.Contains(vert)
        'This function checks if a vertex exists at given x and y coordinates
    End Function

    Public Function FindVertexPayload(ByVal X1 As Integer, ByVal Y1 As Integer)
        Dim StartVertex As Integer
        Dim Vert As Vertex = vertices.Find(Function(x) x.xcoord = X1 And x.ycoord = Y1)
        If vertices.Contains(Vert) Then
            StartVertex = Vert.payload
        End If
        Return StartVertex
        'This returns the payload value of a vertex at any given x and y coordinates
    End Function

    Public Overridable Function GetShortestPath() 'Gets the shortest path list
        Dim Paths As New Dijkstra(numofverts, AdjacencyMatrix)
        Paths.GenerateShortestPath(FindVertexPayload(0, RandomEntranceValue))
        Return Paths.GetShortestDistances
    End Function

    Public Function GenerateScore(ByVal CurrentScore As Integer, ByVal numofmoves As Integer) 'Generates the score and adds it to the current score
        Dim MazeScore, i As Integer
        Dim paths() As Integer
        If PlayLoadedMaze.IsLoaded = True Then
            ShortestPath = GetShortestPath()
        Else
            i = FindVertexPayload(38, RandomExitValue)
            paths = GetShortestPath()
            ShortestPath = paths(i)
        End If
        MazeScore = numofmoves - ShortestPath
        CurrentScore = MazeScore + CurrentScore 'The value of the score for that maze
        Return CurrentScore
    End Function

    Public Sub SetupBoard(ByRef window As Form, ByVal Playable As Boolean) 'Displays the board on the screen
        Dim picboxnum As Integer
        Dim pc As New Pen(Color.White, 25)
        Dim rect As New Rectangle
        rect.Height = 25
        rect.Width = 25
        For count = 0 To 38 'These loops run through each picture box then colour it the required colour depending on the maze array
            For count2 = 0 To 39
                picboxnum = (40 * count) + count2 + 1
                If Maze(count, count2) = "X" Then
                    DirectCast(window.Controls("PictureBox" & picboxnum.ToString), PictureBox).BackColor = Color.FromArgb(0, 0, 0)
                ElseIf Maze(count, count2) = "." Then
                    DirectCast(window.Controls("PictureBox" & picboxnum.ToString), PictureBox).BackColor = Color.FromArgb(255, 255, 255)
                    DirectCast(window.Controls("PictureBox" & picboxnum.ToString), PictureBox).CreateGraphics.DrawRectangle(pc, rect)
                ElseIf Maze(count, count2) = "C" Then
                    DirectCast(window.Controls("PictureBox" & picboxnum.ToString), PictureBox).BackColor = Color.FromArgb(255, 0, 0)
                    DirectCast(window.Controls("PictureBox" & picboxnum.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, 5, 5, 5)
                ElseIf Maze(count, count2) = "E" Then
                    DirectCast(window.Controls("PictureBox" & picboxnum.ToString), PictureBox).BackColor = Color.FromArgb(0, 0, 255)
                    If Playable Then
                        Maze(count, count2) = "."
                    End If
                End If
            Next
        Next
    End Sub

    Public Function MoveRight(ByRef xcoord As Integer, ByRef ycoord As Integer, ByVal previousbox As Integer, ByRef numofmoves As Integer, ByRef window As Form, ByRef Finished As Boolean) 'Moves the player right
        Dim secondbox As Integer = -9
        If Maze(xcoord + 1, ycoord) = "." Then 'These "if" statements check if the player can move into that space
            For count = 5 To 15 Step 4
                If xcoord = 0 Then 'This runs if the player is just starting the maze
                    Threading.Thread.Sleep(2)
                    If IsChecked = True Then
                        DirectCast(window.Controls("PictureBox" & previousbox + 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, secondbox, 5, 5, 5)
                    End If
                ElseIf xcoord = 38 Then 'This runs if the player is at the end of the maze
                    DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, count, 5, 5, 5)
                    Threading.Thread.Sleep(2)
                    If IsChecked = True Then
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, count, 5, 5, 5)
                    End If
                Else 'This runs for all other possiblities
                    DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, count, 5, 5, 5)
                    'These commands move the player smoothly between boxes rather than just jumping
                    DirectCast(window.Controls("PictureBox" & previousbox + 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, secondbox, 5, 5, 5)
                    If IsChecked = True Then
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, count, 5, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox + 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, secondbox, 5, 5, 5)
                    Else
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, count, 5, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox + 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, secondbox, 5, 5, 5)
                    End If
                End If
                secondbox += 4
            Next
            numofmoves += 1
            If xcoord <> 38 Then
                DirectCast(window.Controls("PictureBox" & previousbox + 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, 5, 5, 5)
            End If
            Maze(xcoord, ycoord) = "." 'Changes the values in the array to change their posistion
            Maze(xcoord + 1, ycoord) = "C"
            If xcoord = 37 Then 'Checks to see if the maze has been solved
                Maze(xcoord, ycoord) = "."
                Finished = True
            End If
            xcoord += 1
        End If
        Return Finished
    End Function
    Public Sub MoveLeft(ByRef xcoord As Integer, ByRef ycoord As Integer, ByVal previousbox As Integer, ByRef numofmoves As Integer, ByRef window As Form) 'Moves the player left
        Dim secondbox2 As Integer = 19
        If xcoord = 0 Then 'Checks if the user is trying to move out of the maze
            MsgBox("Cannot move outside of the maze")
        Else
            If Maze(xcoord - 1, ycoord) = "." Then
                If xcoord <> 0 Then
                    For count = 5 To -9 Step -4
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, count, 5, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox - 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, secondbox2, 5, 5, 5)
                        If IsChecked = True Then
                            DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, count, 5, 5, 5)
                            DirectCast(window.Controls("PictureBox" & previousbox - 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, secondbox2, 5, 5, 5)
                        Else
                            DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, count, 5, 5, 5)
                            DirectCast(window.Controls("PictureBox" & previousbox - 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, secondbox2, 5, 5, 5)
                        End If
                        secondbox2 -= 4
                    Next
                    DirectCast(window.Controls("PictureBox" & previousbox - 40.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, 5, 5, 5)
                    Maze(xcoord - 1, ycoord) = "C"
                    Maze(xcoord, ycoord) = "."
                    numofmoves += 1
                End If
                xcoord -= 1
            End If
        End If
    End Sub
    Public Sub MoveUp(ByRef xcoord As Integer, ByRef ycoord As Integer, ByVal previousbox As Integer, ByRef numofmoves As Integer, ByRef window As Form) 'Moves the player up
        Dim secondbox2 As Integer = 19
        If Maze(xcoord, ycoord - 1) = "." Then
            If xcoord <> 0 Then
                For count = 5 To -9 Step -4
                    DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, count, 5, 5)
                    DirectCast(window.Controls("PictureBox" & previousbox - 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, secondbox2, 5, 5)
                    If IsChecked = True Then
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, 5, count, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox - 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, 5, secondbox2, 5, 5)
                    Else
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, 5, count, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox - 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, 5, secondbox2, 5, 5)
                    End If
                    secondbox2 -= 4
                Next
                DirectCast(window.Controls("PictureBox" & previousbox - 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, 5, 5, 5)
                Maze(xcoord, ycoord - 1) = "C"
                Maze(xcoord, ycoord) = "."
                numofmoves += 1
            End If
            ycoord -= 1
        End If
    End Sub
    Public Sub MoveDown(ByRef xcoord As Integer, ByRef ycoord As Integer, ByVal previousbox As Integer, ByRef numofmoves As Integer, ByRef window As Form) 'Moves the player down
        Dim secondbox As Integer = -9
        If Maze(xcoord, ycoord + 1) = "." Then
            If xcoord <> 0 Then
                For count = 5 To 15 Step 4
                    DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, count, 5, 5)
                    DirectCast(window.Controls("PictureBox" & previousbox + 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, secondbox, 5, 5)
                    If IsChecked = True Then
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, 5, count, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox + 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pp, 5, secondbox, 5, 5)
                    Else
                        DirectCast(window.Controls("PictureBox" & previousbox.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, 5, count, 5, 5)
                        DirectCast(window.Controls("PictureBox" & previousbox + 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pw, 5, secondbox, 5, 5)
                    End If
                    secondbox += 4
                Next
                DirectCast(window.Controls("PictureBox" & previousbox + 1.ToString), PictureBox).CreateGraphics.DrawEllipse(pr, 5, 5, 5, 5)
                Maze(xcoord, ycoord + 1) = "C"
                Maze(xcoord, ycoord) = "."
                numofmoves += 1
            End If
            ycoord += 1
        End If
    End Sub

    Public Function GetExitValue() 'Returns the y coordinate of the exit of the maze
        Return RandomExitValue
    End Function

    Public Sub SaveMaze(ByVal filename As String) 'Saves a maze as a binary file to the documents folder on the users computer
        Dim filepath As String
        filepath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, filename)
        Dim bw As New BinaryWriter(New FileStream(filepath, FileMode.Create))
        For x = 0 To 38
            For y = 0 To 39
                bw.Write(Maze(x, y))
            Next
        Next
        bw.Write(ShortestPath)
        bw.Close()
        MsgBox("Your maze has been saved to your documents folder")
    End Sub

    Public Function GetMaze() 'Returns the maze array
        Return Maze
    End Function
End Class

