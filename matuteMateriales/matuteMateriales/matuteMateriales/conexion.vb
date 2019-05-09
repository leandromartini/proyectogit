Imports System.Data.SqlClient
Imports System.Configuration
Module conexion
    Private transaction As SqlTransaction
    Dim sConnectionString = ConfigurationManager.ConnectionStrings(Environment.MachineName).ConnectionString
    Public objConn As New SqlConnection(sConnectionString)
    Sub conn()
        Try
            objConn.Open()
        Catch ex As Exception
            agregar_error(ex, "conexion conn")
        End Try
    End Sub
    Sub disconect()
        Try
            objConn.Close()
        Catch ex As Exception
            agregar_error(ex, "conexion disconect")
        End Try
    End Sub
    Sub beginTran()
        Try
            transaction = objConn.BeginTransaction()
        Catch ex As Exception
            agregar_error(ex, "conexion beginTran")
        End Try
    End Sub
    Sub commitTran()
        Try
            transaction.Commit()
        Catch ex As Exception
            agregar_error(ex, "conexion commitTran")
        End Try
    End Sub
    Sub disposeTran()
        transaction.Dispose()
    End Sub
    Function esTran()
        Return transaction.Connection
    End Function
End Module
