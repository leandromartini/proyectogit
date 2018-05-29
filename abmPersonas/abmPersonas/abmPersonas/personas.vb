Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class personas

    Public Function ActualizarRegistro(ByVal idPersona As Integer, ByVal name As String, ByVal ape As String, ByVal fec As String, ByVal ciudad As Long) As Integer
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
                ActualizarRegistro = command.ExecuteNonQuery()

            End With
            disconect()
        Catch ex As Exception
            ActualizarRegistro = 0
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function obtenerPersonas() As DataSet
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
            obtenerPersonas = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerPersonas = Nothing
        End Try
    End Function
    Public Function eliminarPersonas(ByVal idusuario As String) As Integer
        Try

            Dim sProdString As String = "[dbo].[persona_EliminarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", idusuario)
                conn()
            End With
            eliminarPersonas = command.ExecuteNonQuery()
            disconect()

        Catch ex As Exception
            MsgBox(ex.Message)
            eliminarPersonas = 0
        End Try
    End Function
End Class
