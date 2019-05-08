Imports System.Data.SqlClient
Module conexion
    Private transaction As SqlTransaction
    Private sConnectionString As String _
        = "Initial Catalog=MatuteMateriales; Data Source=localhost ; Integrated Security=SSPI;"
    Public objConn As New SqlConnection(sConnectionString)
    Sub conn()
        Try
            objConn.Open()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Sub disconect()
        Try
            objConn.Close()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Sub beginTran()
        Try
            transaction = objConn.BeginTransaction()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Sub commitTran()
        Try
            transaction.Commit()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Sub disposeTran()
        transaction.Dispose()
    End Sub
    Function esTran()
        Return transaction.Connection
    End Function
End Module
