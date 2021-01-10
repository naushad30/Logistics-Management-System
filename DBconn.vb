Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization

Module DBconn
    Public strCon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\logistics_ms\Logistic.accdb;"
    Public con As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public DS As DataSet
    Public DA As OleDbDataAdapter
    Public BS As BindingSource
    Public DR As OleDbDataReader
    Public DT As DataTable
    Public sql As String
    Public sql1 As String

End Module
