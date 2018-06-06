Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class deudas
    Public Function actualizarRegistroDeudas(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer
        Try

            Dim sProdString As String = "[dbo].[deudas_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", idPersona)
                command.Parameters.AddWithValue("@tpodeuda ", tpoDeuda)
                command.Parameters.AddWithValue("@importe", importe)
                command.Parameters.AddWithValue("@fecEmision", fecEmision)
                conn()
                actualizarRegistroDeudas = command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarRegistroDeudas = 0
        End Try
    End Function
End Class
