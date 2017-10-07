Imports System.Data.SqlClient
Module Module1
    'This dims the value as a date.'
    Public BirthDate As Date
    'I public these variables to that I can access the database and use it for creating a new dataset or retrieving data from the database.'
    Public dbProvider As String
    'dbsource is used to find the location fo the database.'
    Public dbsource As String
    'con will be used to connect to the database.'
    Public dbconn As New SqlConnection
    'ds acts as the datasets which will make it easier to search through records and data.'
    Public ds As New DataSet
    'da acts as a data adaptor which communicates between the database and the program to bring information into the program.'
    Public da As New SqlDataAdapter
    'this is to display all available members and records on form load.'
    Public Sql As String
    'This is used to count the records and data within the dataset.'
    Public count As Integer
    'Makes sure that all records are 0 so that records can be loaded and retrieved later.'
    Public Inc As Integer = 0
    'This will make sure the staff that logs in remains an integer for the rest of the program.'
    Public LogMember As Integer
    'Publics all fields so they can be validated.'
    Public AllFieldsValid As Boolean
    'This declares source of the database.'
    Public connect_string As String
    'Where the database is being stored.'
    Public filepath As String
    'This is used to identify the logged in user as an integer ID.'
    Public DentistID As Integer

    Public Sub Connect()
        'This sub routine is used to connect to the database.'
        'This is the location pathway for the database.'
        filepath = "N:\Test_DB\test_db.mdf;"
        connect_string = "data Source=.\SQLEXPRESS;"
        connect_string += "AttachDBFilename=" & filepath
        connect_string += "Integrated Security = True;"
        connect_string += "Connect Timeout = 30;"
        connect_string += "User Instance = True;"
        connect_string += "Trusted_connection = Yes;"
        dbconn.ConnectionString = connect_string
        dbconn = New SqlConnection(connect_string)
        dbconn.Open()


    End Sub


End Module
