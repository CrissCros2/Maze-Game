Imports System.IO
Public Class Dijkstra
    Private UnvisitedVertices As New List(Of Integer)
    'Dynamic list of all unvisited vertices as the size of this cannot be determined until the maze is generated
    Private ShortestDistancesToCells() As Integer
    'This is a list of the shortest distances to any cell on the maze
    Private VisitedVertices() As Integer
    'List of all visited vertices it's filled in as the algorithm runs
    Private num, numofcells As Integer
    Private AdjacencyMatrix(,) As Integer
    'The adjacency matrix of the maze

    Public Sub New(ByVal numofverts As Integer, ByVal adjmat(,) As Integer)
        'This is the constructor for the Dijkstra Class
        numofcells = numofverts
        ReDim ShortestDistancesToCells(numofcells)
        ReDim VisitedVertices(numofcells)
        ReDim AdjacencyMatrix(numofcells, numofcells)
        AdjacencyMatrix = adjmat
    End Sub

    Public Sub GenerateShortestPath(StartVertex As Integer)
        For i = 1 To numofcells
            UnvisitedVertices.Add(i)
            'Each cell is added to the list of unvisited vertices
            ShortestDistancesToCells(i - 1) = 999999999
            'Every vertex is originally given a distance of a very large number
        Next
        ShortestDistancesToCells(StartVertex) = 0
        'The start vertex distance to the start vertex is 0
        While UnvisitedVertices.Count > 0
            'While there are unvisited vertices
            num = ChooseVertex()
            'Chooses a cell that is next to the current cell
            For num2 = 0 To numofcells
                If AdjacencyMatrix(num, num2) = 1 Then
                    'Checks if there is a connection between the cells
                    If ShortestDistancesToCells(num2) > ShortestDistancesToCells(num) + 1 Then
                        'If the new distance is shorter than the old one
                        ShortestDistancesToCells(num2) = ShortestDistancesToCells(num) + 1
                        'Changes the current shortest route to a new one
                        VisitedVertices(num2) = num
                    End If
                End If
            Next
        End While
    End Sub

    Private Function ChooseVertex()
        Dim min As Integer = 999999999
        Dim vertex As Integer = -1
        For Each n As Integer In UnvisitedVertices
            'Searches through the whole of the unvisited vertices list
            If ShortestDistancesToCells(n) <= min Then
                'If the distance to a cell is less than the default big number
                min = ShortestDistancesToCells(n)
                'That cell is selected for the algorithm to find the shortest path to
                vertex = n
            End If
        Next
        UnvisitedVertices.Remove(vertex)
        'Removes the selected vertex from the list of unvisited ones
        Return vertex
    End Function

    Public Function GetShortestDistances()
        'Getter used to return the list of shortest distances
        Return ShortestDistancesToCells
    End Function
End Class
