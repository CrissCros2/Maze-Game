Imports System.IO
Public Class Loaded_Maze
    Inherits Graph
    Private FileName As String
    Private ShortestPath As Integer

    Public Sub New(ByVal file As String, ByVal checked As Boolean)
        FileName = file
        IsChecked = checked
    End Sub

    Public Function LoadMaze() 'Loads the maze
        Try
            Dim path As String
            path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & FileName
            Dim br As New BinaryReader(New FileStream(path, FileMode.Open))
            For x = 0 To 38
                For y = 0 To 39
                    Maze(x, y) = br.ReadChar
                Next
            Next
            ShortestPath = br.ReadInt32
            br.Close()
        Catch ex As Exception 'Runs if there is an error
            MsgBox("Can't find file")
            MazeLoad.Show()
            PlayLoadedMaze.Close()
        End Try
        Return Maze
    End Function

    Public Overrides Function GetShortestPath() 'Returns the shortest path (This overrides a function as this shortest path is stored in the file and does not need to be caluclated)
        Return ShortestPath
    End Function
End Class
