Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class personas

    Public Shared Function ActualizarRegistroPersonas(ByVal idPersona As Integer, ByVal name As String, ByVal ape As String, ByVal fec As String, ByVal ciudad As Long) As Integer
        Try
            Dim sProdString As String = "[dbo].[persona_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", idPersona)
                command.Parameters.AddWithValue("@nombre", name)
                command.Parameters.AddWithValue("@apellido", ape)
                command.Parameters.AddWithValue("@fecNac", fec)
                command.Parameters.AddWithValue("@ciudad", ciudad)
                conn()
                ActualizarRegistroPersonas = command.ExecuteNonQuery()

            End With
            disconect()
        Catch ex As Exception
            ActualizarRegistroPersonas = 0
            MsgBox(ex.Message)
        End Try
    End Function
    Public Shared Function obtenerListaPersonas() As DataSet
        Try

            Dim sProdString As String = "[dbo].[persona_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerListaPersonas = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerListaPersonas = Nothing
        End Try
    End Function
    Public Shared Function eliminarRegistroPersonas(ByVal idusuario As String) As Integer
        Try

            Dim sProdString As String = "[dbo].[persona_eliminarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", idusuario)
                conn()
            End With
            eliminarRegistroPersonas = command.ExecuteNonQuery()
            disconect()

        Catch ex As Exception
            MsgBox(ex.Message)
            eliminarRegistroPersonas = 0
        End Try
    End Function
End Class
