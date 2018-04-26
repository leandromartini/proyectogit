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

    Public Sub CreateCommand(ByVal name As String, ByVal ape As String, ByVal fec As String, ByVal ciudad As Long)
        Try
            Dim sProdString As String = "[dbo].[persona_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim cantidad As Integer
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", -1)
                command.Parameters.AddWithValue("@nombre", name)
                command.Parameters.AddWithValue("@apellido", ape)
                command.Parameters.AddWithValue("@fecNac", fec)
                command.Parameters.AddWithValue("@ciudad", ciudad)
                conn()
                cantidad = command.ExecuteNonQuery()

            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function obtenerLocalidades() As DataSet
        Try

            Dim sProdString As String = "[dbo].[localidades_ObtenerRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerLocalidades = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerLocalidades = Nothing
        End Try
    End Function
End Module
