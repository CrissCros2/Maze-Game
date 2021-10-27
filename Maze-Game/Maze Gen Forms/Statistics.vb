Imports MySql.Data.MySqlClient
Public Class Statistics
    Private DataSource As New List(Of QuantOfScore)
    Public Function MakeList(ByVal SQLScores As MySqlDataReader, ByVal count As Integer) 'Makes a list out of the retrieved data from the database
        Dim Scores As New List(Of Decimal)
        For n = 0 To count - 1
            SQLScores.Read()
            Scores.Add(SQLScores.GetDecimal(0))
        Next
        Return Scores
    End Function

    Public Function CalculateVariance(ByVal Scores As List(Of Decimal), ByVal Mean As Decimal) 'Calculates the variance of the scores
        Dim temp As New List(Of Decimal)
        Dim variance As Decimal
        For n = 0 To Scores.Count - 1
            temp.Add((Scores(n) - Mean) ^ 2)
        Next
        variance = temp.Sum / Scores.Count
        Return variance
    End Function

    Public Function CalcZScore(ByVal mean As Decimal, ByVal sd As Decimal, ByVal score As Integer) 'The number of standard deviations a score is from the mean
        Dim zscore As Decimal
        zscore = (score - mean) / sd
        Return zscore
    End Function
    Public Sub MakeDataSource(ByVal Scores As List(Of Decimal)) 'Takes the list of scores and turns them into the data needed to construct the charts
        Dim CheckedScores As New List(Of Integer)
        Dim count As Integer
        For n = 0 To Scores.Count - 1
            count = 0
            If CheckedScores.Contains(Scores(n)) = False Then
                CheckedScores.Add(Scores(n))
                For x = 0 To Scores.Count - 1
                    If Scores(x) = Scores(n) Then
                        count += 1
                    End If
                Next
                Dim temp As New QuantOfScore(Scores(n), count)
                DataSource.Add(temp)
            End If
        Next
    End Sub

    Public Function GetDataSource()
        Return DataSource
    End Function
End Class
