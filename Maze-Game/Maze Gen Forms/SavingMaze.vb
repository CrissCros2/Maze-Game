Public Class SavingMaze 'Just used to save the maze to a file
    Private Shared ListOfMazes As New List(Of Graph)
    Public Shared Sub AddMaze(ByVal g As Graph) 'Adds a new graph object to the list of mazes
        ListOfMazes.Add(g)
    End Sub

    Shared Function GetLength()
        Return ListOfMazes.Count
    End Function

    Shared Function GetList()
        Return ListOfMazes
    End Function

    Shared Sub ClearList()
        ListOfMazes.Clear()
    End Sub

End Class
