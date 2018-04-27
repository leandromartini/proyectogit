Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports abmPersonas.conexion
Public Class personas

    Public Function ActualizarLista(ByVal name As String, ByVal ape As String, ByVal fec As String, ByVal ciudad As Long) As Integer
        Try
            Dim sProdString As String = "[dbo].[persona_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", -1)
                command.Parameters.AddWithValue("@nombre", name)
                command.Parameters.AddWithValue("@apellido", ape)
                command.Parameters.AddWithValue("@fecNac", fec)
                command.Parameters.AddWithValue("@ciudad", ciudad)
                conn()
                ActualizarLista = command.ExecuteNonQuery()

            End With
            disconect()
        Catch ex As Exception
            ActualizarLista = 0
            MsgBox(ex.Message)
        End Try
    End Function
End Class
