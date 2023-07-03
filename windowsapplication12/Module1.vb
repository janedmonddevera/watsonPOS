Imports System.Data.SqlClient

Module Module1
    Public n As Integer = 999999999
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As DataTable
    Public Sql As String
    Public Sub ConnecDatabase()
        Try
            con = New SqlConnection
            con.ConnectionString = "Data Source=(localdb)\Projects;Initial Catalog=system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
            con.Open()
        Catch ex As Exception
        End Try
    End Sub

End Module


