Imports System.Data.SqlClient
Public Class ccdEgresos
    Public Function actualizarEgresos(id_prod As Integer, precio As Double, cant As Double, total As Double, fec As Date) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[egresos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_con", id_prod)
                command.Parameters.AddWithValue("@precio", precio)
                command.Parameters.AddWithValue("@cant", cant)
                command.Parameters.AddWithValue("@total", total)
                command.Parameters.AddWithValue("@fec", fec)
                conn()
                actualizarEgresos = command.ExecuteScalar()
            End With
            disconect()
        Catch ex As Exception
            disconect()
            actualizarEgresos = 0
            agregar_error(ex, "actualizarEgresos")
        End Try
    End Function

    Friend Function ObtenerEgresos(id_concepto As Integer, fecDede As Date, fecHasta As Date) As DataSet
        Try
            Dim sProdString As String = "[dbo].[egresos_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.Parameters.AddWithValue("@id_con", id_concepto)
                command.Parameters.AddWithValue("@fecDesde", fecDede)
                command.Parameters.AddWithValue("@fecHasta", fecHasta)
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            ObtenerEgresos = dataset
        Catch ex As Exception
            disconect()
            agregar_error(ex, "ObtenerEgreso")
            ObtenerEgresos = Nothing
        End Try
    End Function
End Class
