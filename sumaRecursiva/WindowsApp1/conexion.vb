Imports System
Imports System.Data
Imports System.Data.SqlClient
Module conexion
    Dim sConnectionString As String _
            = "Initial Catalog=pruebas; Data Source=localhost ; Integrated Security=SSPI;"
    Dim objConn As New SqlConnection(sConnectionString)

    Sub conn()
        Try
            objConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub disconect()
        Try
            objConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CreateCommand(ByVal queryString As String)
        Try
            Dim command As New SqlCommand(queryString, objConn)
            command.Connection.Open()
            command.ExecuteNonQuery()
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
