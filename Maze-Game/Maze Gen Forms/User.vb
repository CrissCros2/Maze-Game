Public Class User
    'This object is used to store the data about the currently logged in user
    Private Shared Username As String
    Private Shared Userid As Integer
    Private Shared Email As String
    'Shared variables allows for any form to access the data without creating another object

    Public Sub New(ByVal id As Integer, ByVal un As String, ByVal em As String)
        'Constructor
        Username = un
        Userid = id
        Email = em
    End Sub

    Shared Function GetUName()
        'Getter that returns the username
        Return Username
    End Function

    Shared Function GetUID()
        'Getter that returns the user id
        Return Userid
    End Function

    Shared Function GetEmail()
        'Getter that returns the email of the user
        Return Email
    End Function
End Class
