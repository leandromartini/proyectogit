Imports System.Data.SqlClient
Public Class ccdIngresos
    Public Function actualizarIngresos(ByVal id_prod As Integer, precio As Double, cant As Double, ByVal total As Double, ByVal fec As Date) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[ingresos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_con", id_prod)
                command.Parameters.AddWithValue("@precio", precio)
                command.Parameters.AddWithValue("@cant", cant)
                command.Parameters.AddWithValue("@total", total)
                command.Parameters.AddWithValue("@fec", fec)
                conn()
                actualizarIngresos = command.ExecuteScalar()
            End With
            disconect()
        Catch ex As Exception
            disconect()
            actualizarIngresos = 0
            agregar_error(ex, "actualizarEgresos")
        End Try
    End Function
End Class



