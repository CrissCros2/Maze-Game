Public Class Vertex
    Public payload, xcoord, ycoord As Integer 'I use public variables here rather than getters as it decreases the loading time for generating mazes considerably
    'Payload: Contains the number of the vertex
    'Xcoord: Contains the x coordinate of the vertex on the maze array
    'Ycoord: Contains the y coordinate of the vertex on the maze array
    Public Sub New(ByVal number As Integer, ByVal x As Integer, ByVal y As Integer)
        payload = number
        xcoord = x
        ycoord = y
    End Sub
End Class
