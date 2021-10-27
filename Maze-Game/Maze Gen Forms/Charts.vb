Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Charts
    Private DataSource As New List(Of QuantOfScore)
    Private Sub Charts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As MySqlDataReader
        Dim db As New Database
        Dim count As Integer
        Dim Stats As New Statistics
        Dim og As New Color
        og = Color.Goldenrod
        If Scores.chk3GmeChrt.Checked Then 'Checks which tick boxes are selected
            db.GetThreeGameData(reader, count)
        ElseIf Scores.chk5GmeChrt.Checked Then
            db.GetFiveGameData(reader, count)
        ElseIf Scores.chk10GmeChrt.Checked Then
            db.GetTenGameData(reader, count)
        End If
        Dim ListScores As List(Of Decimal) = Stats.MakeList(reader, count) 'Converts the results of the SQL query to a list
        Dim dp As DataPoint
        Stats.MakeDataSource(ListScores) 'Converts the list to data that can be used in the charts
        DataSource = Stats.GetDataSource
        ChrtScore.Series.Add("Scores")
        For x = 0 To DataSource.Count - 1 'Adds the data to the chart
            dp = New DataPoint
            dp.SetValueXY(DataSource(x).getScore, DataSource(x).getQuantity)
            ChrtScore.Series("Scores").Points.Add(dp)
        Next
        ChrtScore.Titles.Add("Scores") 'Adds a title to the charts
        ChrtScore.Series("Scores").Color = og 'Sets the colour of the data
    End Sub
End Class