Imports System.Data.SqlClient
Public Class dtlIngresos
    Public Function obtenerIngresosMes(ByVal id_cons As Long, ByVal mes As Long, ByVal año As Long, Optional ByVal id_uf As Long = -1) As DataSet
        Try

            Dim sProdString As String = "[dbo].[ingresos_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_cons", id_cons)
                command.Parameters.AddWithValue("@mes", mes)
                command.Parameters.AddWithValue("@anio", año)
                command.Parameters.AddWithValue("@id_uf", id_uf)
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
    Public Function actualizarRegistroIngresos(ByVal id_uf As Integer, ByVal id_cons As Long, ByVal mes As Long, ByVal año As Long, ByVal expMes As Double, ByVal expExtra As Double,
                                               ByVal mantEdif As Double, ByVal subTotal As Double, ByVal redondeo As Double, ByVal total As Double) As Integer
        Try

            Dim sProdString As String = "[dbo].[ingresos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_uf", id_uf)
                command.Parameters.AddWithValue("@id_cons", id_cons)
                command.Parameters.AddWithValue("@mes", mes)
                command.Parameters.AddWithValue("@anio", año)
                command.Parameters.AddWithValue("@expMes", expMes)
                command.Parameters.AddWithValue("@expExtra", expExtra)
                command.Parameters.AddWithValue("@mantEdif", mantEdif)
                command.Parameters.AddWithValue("@subTotal", subTotal)
                command.Parameters.AddWithValue("@redondeo", redondeo)
                command.Parameters.AddWithValue("@total", total)
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
