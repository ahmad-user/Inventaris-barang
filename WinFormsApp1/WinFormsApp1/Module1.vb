Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader

    Public mydb As String
    Public Sub koneksi()
        mydb = "driver={mysql odbc 8.0 Unicode driver};database=karyawan;server=localhost;uid=root"
        conn = New OdbcConnection(mydb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
