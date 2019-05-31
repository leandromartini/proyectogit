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

    Friend Function ObtenerIngresos(id_ingreso As Integer, fecDede As Date, fecHasta As Date) As DataSet
        Try
            Dim sProdString As String = "[dbo].[ingresos_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.Parameters.AddWithValue("@id_egreso", id_ingreso)
                command.Parameters.AddWithValue("@fecDede", fecDede)
                command.Parameters.AddWithValue("@fecHasta", fecHasta)
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            ObtenerIngresos = dataset
        Catch ex As Exception
            disconect()
            agregar_error(ex, "ObtenerEgreso")
            ObtenerIngresos = Nothing
        End Try
    End Function
End Class



