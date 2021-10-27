Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Database 'Database class is used to interact with the database
    Private database As String = "mazegame_db"
    Private user As String = "root"
    Private host As String = "localhost"
    Private password As String = ""
    Private conn As New MySqlConnection

    Public Sub New() 'Constructor
        conn = New MySqlConnection("database=" & database & ";data source=" & host & ";user id=" & user & ";password=" & password & "")
    End Sub

    Public Sub CreateDatabase() 'Creates the database when the program is run for the first time
        Dim conStr As String = "Server=localhost;Database=;user id=root;password="
        Dim objCon As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim strSQL As String
        Try
            objCon.Open() 'Opens a connetion
            obj = objCon.CreateCommand()
            strSQL = "CREATE DATABASE IF NOT EXISTS mazegame_db"
            obj.CommandText = strSQL
            obj.ExecuteNonQuery() 'Executes the create database command
        Catch ex As Exception
            MsgBox("Database failed to be made") 'If an error occurs a message box appears
        End Try
    End Sub

    Public Sub CreateTables() 'This creates the tables that the database uses
        Try 'Creates the four tables
            conn.Open()
            Dim com As MySqlCommand
            com = conn.CreateCommand()
            com.CommandText = "CREATE TABLE IF NOT EXISTS users_tbl(userid integer(20) AUTO_INCREMENT PRIMARY KEY NOT NULL, username varchar(20) NOT NULL, password varchar(64) NOT NULL, firstname varchar(20) NOT NULL, email varchar(40) NOT NULL, passwordreset varchar(20), salt varchar(64) NOT NULL)"
            com.ExecuteNonQuery()
            com.CommandText = "CREATE TABLE IF NOT EXISTS threegamescores_tbl(scoreid integer(20) NOT NULL PRIMARY KEY AUTO_INCREMENT, userid integer(20) NOT NULL, score integer(20) NOT NULL, scoredate date NOT NULL, FOREIGN KEY (userid) REFERENCES users_tbl(userid))"
            com.ExecuteNonQuery()
            com.CommandText = "CREATE TABLE IF NOT EXISTS fivegamescores_tbl(scoreid integer(20) NOT NULL PRIMARY KEY AUTO_INCREMENT, userid integer(20) NOT NULL, score integer(20) NOT NULL, scoredate date NOT NULL, FOREIGN KEY (userid) REFERENCES users_tbl(userid))"
            com.ExecuteNonQuery()
            com.CommandText = "CREATE TABLE IF NOT EXISTS tengamescores_tbl(scoreid integer(20) NOT NULL PRIMARY KEY AUTO_INCREMENT, userid integer(20) NOT NULL, score integer(20) NOT NULL, scoredate date NOT NULL, FOREIGN KEY (userid) REFERENCES users_tbl(userid))"
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Tables failed to be made")
        End Try
        conn.Close()
    End Sub

    Public Sub NewUser(username, hashedpassword, firstname, email) 'This inserts a new user into the database
        Dim salt, saltedpass As String
        hashedpassword = GenerateSHA256Hash(hashedpassword) 'Generates a hash of the origianal password
        salt = GenerateSHA256Hash(GenPassResetCode) 'Takes a randomly generated string, in this case I use the same random generator for the password reset codes, and generates a hash of it
        saltedpass = GenSaltedPass(salt, hashedpassword) 'Combines the salt and the hash
        saltedpass = GenerateSHA256Hash(saltedpass) 'Generates a hash of the combined string
        Dim com As MySqlCommand
        com = conn.CreateCommand()
        com.CommandText = "INSERT INTO users_tbl (username, password, firstname, email, salt) VALUES (@username, @saltedpass, @firstname, @email, @salt)"
        com.Parameters.AddWithValue("@username", username)
        com.Parameters.AddWithValue("@saltedpass", saltedpass)
        com.Parameters.AddWithValue("@firstname", firstname)
        com.Parameters.AddWithValue("@email", email)
        com.Parameters.AddWithValue("@salt", salt)
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Function GenSaltedPass(ByVal salt As String, ByVal hashedpassword As String) 'Takes the salt and the hash of the password and generates the salted password
        Dim saltedpass As String = ""
        If salt <> "" Then
            Dim temp As Integer
            For x = 0 To Len(hashedpassword) - 1
                temp = Asc(hashedpassword(x)) + Asc(salt(x)) 'Adds the ascii value of the two input strings for each character
                saltedpass = saltedpass + Chr(temp)
            Next
        End If
        Return saltedpass
    End Function


    Public Sub NewScore(userid, score, gamemode) 'Adds new scores to the database
        Dim com As MySqlCommand
        Dim reader As MySqlDataReader
        conn.Open()
        com = conn.CreateCommand()
        com.Parameters.AddWithValue("@userid", userid)
        com.Parameters.AddWithValue("@score", score)
        Select Case gamemode 'Selects which gamemode was selected and adds to the appropriate table
            'To avoid duplicated data the program checks if the score has been acheived by that user on the same day and if so doesn't write it to the database
            Case 3
                com.CommandText = "SELECT score FROM threegamescores_tbl WHERE userid = @userid AND score = @score AND scoredate = CURDATE()"
                reader = com.ExecuteReader()
                If reader.HasRows = False Then
                    com.CommandText = "INSERT INTO threegamescores_tbl(userid, score, scoredate) VALUES (@userid, @score,  CURDATE())"
                End If
                reader.Close()
            Case 5
                com.CommandText = "SELECT score FROM fivegamescores_tbl WHERE userid = @userid AND score = @score AND scoredate = CURDATE()"
                reader = com.ExecuteReader()
                If reader.HasRows = False Then
                    com.CommandText = "INSERT INTO fivegamescores_tbl(userid, score, scoredate) VALUES (@userid, @score,  CURDATE())"
                End If
                reader.Close()
            Case 10
                com.CommandText = "SELECT score FROM tengamescores_tbl WHERE userid = @userid AND score = @score AND scoredate = CURDATE()"
                reader = com.ExecuteReader()
                If reader.HasRows = False Then
                    com.CommandText = "INSERT INTO tengamescores_tbl(userid, score, scoredate) VALUES (@userid, @score,  CURDATE())"
                End If
                reader.Close()
        End Select
        com.ExecuteNonQuery() 'Executes the commands
        conn.Close()
    End Sub

    Public Sub GetUserData(userid, threegame, fivegame, tengame, startdate, enddate, ByRef datagrid) 'Retrieves the data from the tables
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        Dim com As String = ""
        conn.Open()
        If threegame = True Then 'The if statements construct the SQL query based on the tick boxes from the scores form
            com = com & ("SELECT users_tbl.username, threegamescores_tbl.score, threegamescores_tbl.scoredate from users_tbl INNER JOIN threegamescores_tbl ON users_tbl.userid = threegamescores_tbl.userid where users_tbl.userid = @userid AND threegamescores_tbl.scoredate >= @startdate AND threegamescores_tbl.scoredate <= @enddate")
        End If
        If fivegame = True And com = "" Then
            com = com & ("SELECT users_tbl.username, fivegamescores_tbl.score, fivegamescores_tbl.scoredate from users_tbl INNER JOIN fivegamescores_tbl ON users_tbl.userid = fivegamescores_tbl.userid where users_tbl.userid =  @userid AND fivegamescores_tbl.scoredate >= @startdate AND fivegamescores_tbl.scoredate <= @enddate")
        ElseIf fivegame = True Then
            com = com & (" UNION SELECT users_tbl.username, fivegamescores_tbl.score, fivegamescores_tbl.scoredate from users_tbl INNER JOIN fivegamescores_tbl ON users_tbl.userid = fivegamescores_tbl.userid where users_tbl.userid = @userid AND fivegamescores_tbl.scoredate >= @startdate AND fivegamescores_tbl.scoredate <= @enddate")
        End If
        If tengame = True And com = "" Then
            com = com & ("SELECT users_tbl.username, tengamescores_tbl.score, tengamescores_tbl.scoredate from users_tbl INNER JOIN tengamescores_tbl ON users_tbl.userid = tengamescores_tbl.userid where users_tbl.userid = @userid AND tengamescores_tbl.scoredate >= @startdate AND tengamescores_tbl.scoredate <= @enddate")
        ElseIf tengame = True Then
            com = com & (" UNION SELECT users_tbl.username, tengamescores_tbl.score, tengamescores_tbl.scoredate from users_tbl INNER JOIN tengamescores_tbl ON users_tbl.userid = tengamescores_tbl.userid where users_tbl.userid = @userid AND tengamescores_tbl.scoredate >= @startdate AND tengamescores_tbl.scoredate <= @enddate")
        End If
        cmd = New MySqlCommand(com, conn)
        cmd.Parameters.AddWithValue("@userid", userid)
        cmd.Parameters.AddWithValue("@startdate", startdate)
        cmd.Parameters.AddWithValue("@enddate", enddate)
        da = New MySqlDataAdapter(cmd)
        da.Fill(ds, "users_tbl") 'Fill the data grids
        da.Fill(ds, "threegamescores_tbl")
        da.Fill(ds, "fivegamescores_tbl")
        da.Fill(ds, "tengamescores_tbl")
        datagrid.datasource = ds.Tables("users_tbl")
        conn.Close()
    End Sub

    Public Sub GetLeaderDataThree(startdate, enddate, ByRef datagrid) 'Retrieves the data from the tables
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        cmd = New MySqlCommand("SELECT users_tbl.username, threegamescores_tbl.score, threegamescores_tbl.scoredate from users_tbl INNER JOIN threegamescores_tbl ON users_tbl.userid = threegamescores_tbl.userid where threegamescores_tbl.scoredate >= @startdate AND threegamescores_tbl.scoredate <= @enddate ORDER BY threegamescores_tbl.score ASC", conn)
        cmd.Parameters.AddWithValue("@startdate", startdate)
        cmd.Parameters.AddWithValue("@enddate", enddate)
        da = New MySqlDataAdapter(cmd)
        da.Fill(ds, "users_tbl")
        da.Fill(ds, "threegamescores_tbl")
        datagrid.datasource = ds.Tables("users_tbl")
    End Sub
    Public Sub GetLeaderDataFive(startdate, enddate, ByRef datagrid) 'Retrieves the data from the tables
        Dim cmd As New MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        cmd = New MySqlCommand("SELECT users_tbl.username, fivegamescores_tbl.score, fivegamescores_tbl.scoredate from users_tbl INNER JOIN fivegamescores_tbl ON users_tbl.userid = fivegamescores_tbl.userid where fivegamescores_tbl.scoredate >= @startdate AND fivegamescores_tbl.scoredate <= @enddate ORDER BY fivegamescores_tbl.score ASC", conn)
        cmd.Parameters.AddWithValue("@startdate", startdate)
        cmd.Parameters.AddWithValue("@enddate", enddate)
        da = New MySqlDataAdapter(cmd)
        da.Fill(ds, "users_tbl")
        da.Fill(ds, "fivegamescores_tbl")
        datagrid.datasource = ds.Tables("users_tbl")
    End Sub
    Public Sub GetLeaderDataTen(startdate, enddate, ByRef datagrid) 'Retrieves the data from the tables
        Dim cmd As New MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        cmd = New MySqlCommand("SELECT users_tbl.username, tengamescores_tbl.score, tengamescores_tbl.scoredate from users_tbl INNER JOIN tengamescores_tbl ON users_tbl.userid = tengamescores_tbl.userid where tengamescores_tbl.scoredate >= @startdate AND tengamescores_tbl.scoredate <= @enddate ORDER BY tengamescores_tbl.score ASC", conn)
        cmd.Parameters.AddWithValue("@startdate", startdate)
        cmd.Parameters.AddWithValue("@enddate", enddate)
        da = New MySqlDataAdapter(cmd)
        da.Fill(ds, "users_tbl")
        da.Fill(ds, "tengamescores_tbl")
        datagrid.datasource = ds.Tables("users_tbl")
    End Sub

    Public Sub UpdatePassword(username, password) 'If the user resets their password
        Dim hashedpassword As String = GenerateSHA256Hash(password)
        Dim salt As String = GenerateSHA256Hash(GenPassResetCode())
        Dim saltedpassword As String = GenSaltedPass(salt, hashedpassword)
        saltedpassword = GenerateSHA256Hash(saltedpassword)
        Dim com As MySqlCommand
        conn.Open()
        com = conn.CreateCommand()
        com.Parameters.AddWithValue("@saltedpassword", saltedpassword)
        com.Parameters.AddWithValue("@username", username)
        com.Parameters.AddWithValue("@salt", salt)
        com.CommandText = "UPDATE users_tbl SET password = @saltedpassword WHERE username = @username"
        com.ExecuteNonQuery()
        com.CommandText = "UPDATE users_tbl SET salt = @salt WHERE username = @username"
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub DeleteUser(userid) 'If a user wants to delete their account this removes their account
        Dim com As New MySqlCommand
        conn.Open()
        com = conn.CreateCommand()
        com.Parameters.AddWithValue("@userid", userid)
        com.CommandText = "DELETE FROM threegamescores_tbl where userid = @userid"
        com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM fivegamescores_tbl where userid = @userid"
        com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM tengamescores_tbl where userid = @userid"
        com.ExecuteNonQuery()
        com.CommandText = "DELETE FROM users_tbl where userid = @userid"
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub CloseDatabase() 'Used in some circumstances if a connection needs to be closed
        conn.Close()
    End Sub

    Private Function GenerateSHA256Hash(ByVal inputString As String) 'Takes an input usually a password and generates the SHA256 hash of that input string
        Dim stringBuilder As New StringBuilder()
        Dim hash As Byte() = SHA256Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(inputString))
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next
        Return stringBuilder.ToString()
    End Function

    Public Function Login(ByVal username As String, ByVal password As String) 'Returns the details of a user if the details are correct
        Dim hash As String = GenerateSHA256Hash(password)
        Dim salt As String = GetSalt(username)
        Dim saltedpass As String = GenSaltedPass(salt, hash)
        Dim reader As MySqlDataReader
        saltedpass = GenerateSHA256Hash(saltedpass)
        Dim Query As String = ("SELECT userid, username, email  FROM users_tbl WHERE username= @username AND password = @saltedpass")
        Dim cmd As MySqlCommand = New MySqlCommand(Query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@saltedpass", saltedpass)
        reader = cmd.ExecuteReader()
        Return reader
    End Function

    Public Sub StoreCode(ByVal resetcode As String, ByVal userid As Integer) 'This stores a password reset code in the database
        Dim com As MySqlCommand
        conn.Open()
        com = conn.CreateCommand()
        com.CommandText = "UPDATE users_tbl SET passwordreset = @resetcode WHERE userid = @userid"
        com.Parameters.AddWithValue("@userid", userid)
        com.Parameters.AddWithValue("@resetcode", resetcode)
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function ReturnEmailUID(ByVal username As String) 'This returns the email and user id of a user from the user name (Used during password reset)
        conn.Open()
        Dim Query As String = ("SELECT email, userid FROM users_tbl WHERE username= @username")
        Dim cmd As MySqlCommand = New MySqlCommand(Query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Return reader
    End Function

    Public Function IsCodeValid(ByVal username As String, ByVal resetcode As String) 'Checks if a password reset code is valid
        conn.Open()
        Dim Query As String = ("SELECT passwordreset FROM users_tbl WHERE username= @username")
        Dim cmd As MySqlCommand = New MySqlCommand(Query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Read()
        If reader.GetString(0) = resetcode Then
            conn.Close()
            Return True
        Else
            conn.Close()
            Return False
        End If
    End Function

    Public Function GenNewUser(ByVal username As String) 'Gets the data to update the user object
        conn.Open()
        Dim Query As String = ("SELECT userid, username, email  FROM users_tbl WHERE username= @username")
        Dim cmd As MySqlCommand = New MySqlCommand(Query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Return reader
    End Function

    Public Sub RemoveResetCode(ByVal uid As String) 'After a password is reset the code is deleted
        Dim com As MySqlCommand
        conn.Open()
        com = conn.CreateCommand()
        com.Parameters.AddWithValue("@uid", uid)
        com.CommandText = "UPDATE users_tbl SET passwordreset = NULL WHERE userid = @uid"
        com.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function CheckPass(ByVal password As String, ByVal username As String) 'Checks if the password the user inputs is the one associated with the account logged in for deleting an account
        Dim hash As String = GenerateSHA256Hash(password)
        Dim salt As String = GetSalt(username)
        Dim saltedpassword As String = GenSaltedPass(salt, hash)
        saltedpassword = GenerateSHA256Hash(saltedpassword)
        Dim query As String = ("SELECT userid FROM users_tbl WHERE password= @saltedpassword AND username = @username")
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@saltedpassword", saltedpassword)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            conn.Close()
            Return True
        Else
            conn.Close()
            Return False
        End If
    End Function

    Public Sub GetThreeGameData(ByRef reader As MySqlDataReader, ByRef count As Integer) 'Gets some data from a table for some statstics to be caluclated
        conn.Open()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT Count(*) FROM threegamescores_tbl", conn)
        count = cmd.ExecuteScalar
        cmd = New MySqlCommand("SELECT score from threegamescores_tbl", conn)
        reader = cmd.ExecuteReader
    End Sub
    Public Sub GetFiveGameData(ByRef reader As MySqlDataReader, ByRef count As Integer) 'Gets some data from a table for some statstics to be caluclated
        conn.Open()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT Count(*) FROM fivegamescores_tbl", conn)
        count = cmd.ExecuteScalar
        cmd = New MySqlCommand("SELECT score from fivegamescores_tbl", conn)
        reader = cmd.ExecuteReader
    End Sub
    Public Sub GetTenGameData(ByRef reader As MySqlDataReader, ByRef count As Integer) 'Gets some data from a table for some statstics to be caluclated
        conn.Open()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT Count(*) FROM tengamescores_tbl", conn)
        count = cmd.ExecuteScalar
        cmd = New MySqlCommand("SELECT score from tengamescores_tbl", conn)
        reader = cmd.ExecuteReader
    End Sub

    Public Function GenPassResetCode() 'Generates a new code for the password reset code
        Dim value As Integer
        Dim code As String = ""
        Randomize()
        For x = 0 To 14
            value = CStr(CInt(9 * Rnd()))
            code = code & value
        Next
        Return code
    End Function

    Private Function GetSalt(ByVal username As String) 'Retrieves the salt used when checking passwords
        conn.Open()
        Dim cmd As MySqlCommand
        Dim salt As String = ""
        cmd = New MySqlCommand("SELECT salt FROM users_tbl WHERE username = @username", conn)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read() Then
            salt = reader.GetString(0)
        End If
        reader.Close()
        Return salt
    End Function

End Class
