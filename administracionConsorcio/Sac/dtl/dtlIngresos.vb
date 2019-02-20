Imports System.Data.SqlClient
Public Class dtlIngresos
    Public Function obtenerIngresosMes() As DataSet
        Try

            Dim sProdString As String = "[dbo].[ingresos_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerIngresosMes = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerIngresosMes = Nothing
        End Try
    End Function
    Public Function actualizarRegistroIngresos(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer
        Try

            Dim sProdString As String = "[dbo].[ingresos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@idusuario", idPersona)
                conn()
                actualizarRegistroIngresos = command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarRegistroIngresos = 0
        End Try
    End Function
End Class
