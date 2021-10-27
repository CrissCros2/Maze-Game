Structure Neighbour 'Custom data structure to contain everything needed about neighbour vertices
    Public Payload As Integer
    Public Direction As Integer
End Structure
Public Class Generated_Maze
    Inherits Graph

    Public Sub New(ByVal checked As Boolean)
        IsChecked = checked
    End Sub
    Public Sub CreateMaze() 'ByRef reachedend As Boolean, ByVal stuck As Boolean)
        Dim UnvisitedVertices, VisitedVertices, DepletedVertices As New List(Of Integer)
        For ycoord = 0 To 39
            For xcoord = 0 To 38
                If ycoord = 0 Or ycoord = 39 Or xcoord = 0 Or xcoord = 38 Then
                    Maze(xcoord, ycoord) = "X"
                ElseIf xcoord Mod 2 = 1 And ycoord Mod 2 = 1 Then
                    Maze(xcoord, ycoord) = "."
                Else
                    Maze(xcoord, ycoord) = "X"
                End If
            Next
        Next
        Maze(0, RandomEntranceValue) = "." 'These points are manually designated to be open
        Maze(1, RandomEntranceValue) = "."
        Maze(1, RandomEntranceValue - 1) = "."
        Maze(1, RandomEntranceValue + 1) = "."
        Maze(37, RandomExitValue) = "."
        Maze(38, RandomExitValue) = "."
        Maze(1, 2) = "."
        For ycoord = 0 To 39 'This loop creates a vertex for every open space in the maze
            For xcoord = 0 To 38
                If Maze(xcoord, ycoord) = "." Then
                    AddVertex(xcoord, ycoord)
                End If
            Next
        Next
        For n = 1 To vertices.Count + 1
            UnvisitedVertices.Add(n)
        Next 'Loop adds all vertices to the unvisited vertices list
        CreateMazeRecursive(FindVertexPayload(1, RandomEntranceValue), UnvisitedVertices, VisitedVertices, DepletedVertices)
        vertices.Clear()
        numofverts = 0
        For ycoord = 0 To 39 'This loop creates a vertex for every open space in the maze
            For xcoord = 0 To 38
                If Maze(xcoord, ycoord) = "." Then
                    AddVertex(xcoord, ycoord)
                End If
            Next
        Next
        CreateMatrix() 'This subroutine creates the adjacency matrix
        For y = 1 To 38 'These loops add an edge between every vertex that borders another vertex
            For x = 0 To 38
                If CheckVertex(x, y) = True Then
                    AddEdge(x, y)
                End If
            Next
        Next
        Maze(0, RandomEntranceValue) = "C" 'The entrance and exit are set a different colour
        Maze(38, RandomExitValue) = "E"
    End Sub

    Private Sub CreateMazeRecursive(ByVal CurrentCell As Integer, ByRef UnvisitedVertices As List(Of Integer), ByRef VisitedVertices As List(Of Integer), ByRef DepletedVertices As List(Of Integer))
        'A recursive algorithm that generates a maze
        Dim X As Integer = FindX(CurrentCell)
        Dim Y As Integer = FindY(CurrentCell)
        Dim NeighbourVert As Neighbour
        Dim NeighbourVertices As New List(Of Neighbour)
        Dim randomvalue, NextCell As Integer
        CurrentCell = FindVertexPayload(X, Y) 'Gets the payload of the current vertex
        If UnvisitedVertices.Contains(CurrentCell) Then 'Checks if the current vertex has yet to be visited
            VisitedVertices.Add(CurrentCell) 'If they haven't it is added to the list of visited vertices and removed from the list of unvisted ones
            UnvisitedVertices.Remove(CurrentCell)
        End If
        For n = 0 To UnvisitedVertices.Count - 1 'This loop checks if the current vertex has any unvisited neighbours
            Select Case UnvisitedVertices(n)
                Case FindVertexPayload(X + 2, Y)
                    NeighbourVert.Payload = FindVertexPayload(X + 2, Y)
                    NeighbourVert.Direction = 0
                    NeighbourVertices.Add(NeighbourVert)
                Case FindVertexPayload(X, Y + 2)
                    NeighbourVert.Payload = FindVertexPayload(X, Y + 2)
                    NeighbourVert.Direction = 1
                    NeighbourVertices.Add(NeighbourVert)
                Case FindVertexPayload(X - 2, Y)
                    NeighbourVert.Payload = FindVertexPayload(X - 2, Y)
                    NeighbourVert.Direction = 2
                    NeighbourVertices.Add(NeighbourVert)
                Case FindVertexPayload(X, Y - 2)
                    NeighbourVert.Payload = FindVertexPayload(X, Y - 2)
                    NeighbourVert.Direction = 3
                    NeighbourVertices.Add(NeighbourVert)
            End Select
        Next
        While NeighbourVertices.Count > 0 'Runs while the cell has unvisited neighbours
            Randomize()
            randomvalue = CInt(Math.Floor(NeighbourVertices.Count * Rnd()))
            NeighbourVert = NeighbourVertices(randomvalue)
            Select Case NeighbourVert.Direction
                Case 0 'Right
                    If UnvisitedVertices.Contains(NeighbourVert.Payload) Then
                        NextCell = NeighbourVert.Payload
                        Maze(X + 1, Y) = "." 'Changes the wall between the cells to a gap
                    End If
                    NeighbourVertices.Remove(NeighbourVert)
                Case 1 'Down
                    If UnvisitedVertices.Contains(NeighbourVert.Payload) Then
                        NextCell = NeighbourVert.Payload
                        Maze(X, Y + 1) = "." 'Changes the wall between the cells to a gap
                    End If
                    NeighbourVertices.Remove(NeighbourVert)
                Case 2 'Left
                    If UnvisitedVertices.Contains(NeighbourVert.Payload) Then
                        NextCell = NeighbourVert.Payload
                        Maze(X - 1, Y) = "." 'Changes the wall between the cells to a gap
                    End If
                    NeighbourVertices.Remove(NeighbourVert)
                Case 3 'Up
                    If UnvisitedVertices.Contains(NeighbourVert.Payload) Then
                        NextCell = NeighbourVert.Payload
                        Maze(X, Y - 1) = "." 'Changes the wall between the cells to a gap
                    End If
                    NeighbourVertices.Remove(NeighbourVert)
            End Select
            If NextCell = NeighbourVert.Payload Then 'Only runs if the algorithm has moved onto another cell
                CreateMazeRecursive(NextCell, UnvisitedVertices, VisitedVertices, DepletedVertices) 'The algorithm runs recursively until all possible cells have beem visited
            End If
        End While
        'If the cell has no more unvisited neighbours it is considered depleted and removed from future consideration
        VisitedVertices.Remove(CurrentCell)
        DepletedVertices.Add(CurrentCell)
    End Sub
    Private Function FindX(ByVal Payload As Integer)
        Dim temp As Integer
        temp = vertices.Find(Function(n) n.payload = Payload).xcoord
        Return temp
        'Returns the x value of a vertex of any given payload
    End Function

    Private Function FindY(ByVal Payload As Integer)
        Dim temp As Integer
        temp = vertices.Find(Function(n) n.payload = Payload).ycoord
        Return temp
        'Returns the y value of a vertex of any given payload
    End Function

End Class
