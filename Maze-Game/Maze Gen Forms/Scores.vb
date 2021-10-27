Imports MySql.Data.MySqlClient

Public Class Scores
    Private Mode As Integer
    Private Stats As New Statistics
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click 'Retrieves and displays all of the data between two dates
        lblData.Hide()
        lblGmeMode.Hide()
        lblDates.Hide()
        Dim db As New Database
        If dtpStart.Value > dtpEnd.Value Then
            lblDates.Show()
        Else
            Dim startdate As String = dtpStart.Value.ToString("yyyy-MM-dd") 'Converts the inputed dates to formats SQL can use
            Dim enddate As String = dtpEnd.Value.ToString("yyyy-MM-dd")
            If chk10game.Checked = False And chk5game.Checked = False And chk3Game.Checked = False Then
                lblGmeMode.Show()
            Else
                Try
                    db.GetUserData(User.GetUID, chk3Game.Checked, chk5game.Checked, chk10game.Checked, startdate, enddate, dgvScores) 'Gets the users data
                    If chk3Game.Checked = True Then 'Gets the leaderboard data
                        db.GetLeaderDataThree(startdate, enddate, dgvLeader3)
                    End If
                    If chk5game.Checked = True Then
                        db.GetLeaderDataFive(startdate, enddate, dgvLeader5)
                    End If
                    If chk10game.Checked = True Then
                        db.GetLeaderDataTen(startdate, enddate, dgvLeader10)
                    End If
                Catch InvalidOperationException As Exception
                    lblData.Show()
                End Try
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Exits the form
        Close()
    End Sub

    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Displays some stats about the scores in the database
        Dim db As New Database
        Dim result As MySqlDataReader
        Dim count As Integer
        Dim Scores As List(Of Decimal)
        Dim variance As Decimal
        db.GetThreeGameData(result, count) 'Gets the data from the three game leaderboard
        Scores = Stats.MakeList(result, count) 'Makes the data into a list for later use
        Try 'Has to be in a try incase of errors caused by there being no data
            variance = Stats.CalculateVariance(Scores, Scores.Average)
            txt3gameMean.Text = Scores.Average
        Catch ex As Exception
            variance = 0
            txt3gameMean.Text = 0
        End Try
        txt3gameVariance.Text = variance
        txt3gameSD.Text = Math.Sqrt(variance)
        db.CloseDatabase()
        Scores.Clear()
        db.GetFiveGameData(result, count)
        Scores = Stats.MakeList(result, count)
        Try
            variance = Stats.CalculateVariance(Scores, Scores.Average)
            txt5gameMean.Text = Scores.Average
        Catch ex As Exception
            variance = 0
            txt5gameMean.Text = 0
        End Try
        txt5gameVariance.Text = variance
        txt5gameSD.Text = Math.Sqrt(variance)
        db.CloseDatabase()
        Scores.Clear()
        db.GetTenGameData(result, count)
        Scores = Stats.MakeList(result, count)
        Try
            variance = Stats.CalculateVariance(Scores, Scores.Average)
            txt10GameMean.Text = Scores.Average
        Catch ex As Exception
            variance = 0
            txt10GameMean.Text = 0
        End Try
        txt10GameVariance.Text = variance
        txt10GameSD.Text = Math.Sqrt(variance)
        db.CloseDatabase()
        Scores.Clear()
    End Sub

    Private Sub dgvLeader3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeader3.CellClick 'When a row in the data grid is selected the Z score of that score is calculated
        If CInt(txt3gameSD.Text) <> 0 Then
            Dim Row As DataGridViewRow
            If e.RowIndex >= 0 Then
                Row = dgvLeader3.Rows(e.RowIndex)
                Dim score As Integer = Row.Cells(1).Value
                txt3gameZ.Text = stats.CalcZScore(CDec(txt3gameMean.Text), CDec(txt3gameSD.Text), score)
            End If
        Else
            txt3gameZ.Text = "Cannot calculate Z score"
        End If
    End Sub

    Private Sub dgvLeader5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeader5.CellClick
        If CInt(txt5gameSD.Text) <> 0 Then
            Dim Row As DataGridViewRow
            If e.RowIndex >= 0 Then
                Row = dgvLeader5.Rows(e.RowIndex)
                Dim score As Integer = Row.Cells(1).Value
                txt5gameZ.Text = stats.CalcZScore(CDec(txt5gameMean.Text), CDec(txt5gameSD.Text), score)
            End If
        Else
            txt5gameZ.Text = "Cannot calculate Z score"
        End If
    End Sub

    Private Sub dgvLeader10_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeader10.CellClick
        If CInt(txt10GameSD.Text) <> 0 Then
            Dim Row As DataGridViewRow
            If e.RowIndex >= 0 Then
                Row = dgvLeader10.Rows(e.RowIndex)
                Dim score As Integer = Row.Cells(1).Value
                txt10gameZ.Text = stats.CalcZScore(CDec(txt10GameMean.Text), CDec(txt10GameSD.Text), score)
            End If
        Else
            txt10gameZ.Text = "Cannot calculate Z score"
        End If
    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click 'Shows the form that contains the charts
        lblGmeMode2.Hide()
        If Mode <> 0 Then
            Charts.Show()
        Else
            lblGmeMode2.Show()
        End If
    End Sub

    'Subroutines here mean only one box can be checked at a time
    Private Sub chk3GmeChrt_CheckedChanged(sender As Object, e As EventArgs) Handles chk3GmeChrt.Click
        chk10GmeChrt.Checked = False
        chk5GmeChrt.Checked = False
        Mode = 1
        If chk3GmeChrt.Checked = False And chk5GmeChrt.Checked = False And chk10GmeChrt.Checked = False Then
            Mode = 0
        End If
    End Sub

    Private Sub chk5GmeChrt_CheckedChanged(sender As Object, e As EventArgs) Handles chk5GmeChrt.Click
        chk10GmeChrt.Checked = False
        chk3GmeChrt.Checked = False
        Mode = 2
        If chk3GmeChrt.Checked = False And chk5GmeChrt.Checked = False And chk10GmeChrt.Checked = False Then
            Mode = 0
        End If
    End Sub

    Private Sub chk10GmeChrt_CheckedChanged(sender As Object, e As EventArgs) Handles chk10GmeChrt.Click
        chk3GmeChrt.Checked = False
        chk5GmeChrt.Checked = False
        Mode = 3
        If chk3GmeChrt.Checked = False And chk5GmeChrt.Checked = False And chk10GmeChrt.Checked = False Then
            Mode = 0
        End If
    End Sub
End Class