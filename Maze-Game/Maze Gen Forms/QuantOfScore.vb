Public Class QuantOfScore 'This is really just a data structure that is used to store data about the scores
    Private Score As Integer
    Private Quantitiy As Integer

    Public Sub New(ByVal SCR As Integer, ByVal Quant As Integer)
        Score = SCR
        Quantitiy = Quant
    End Sub

    Public Function getScore()
        Return Score
    End Function

    Public Function getQuantity()
        Return Quantitiy
    End Function

End Class
