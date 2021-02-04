Imports System.Data.SqlClient
Public Class ccdInsumosStock
    Public Function actualizarInsumoStock(ByVal codigo As Integer, ByVal stock As Integer,
                                         ByVal stockMin As Integer, ByVal stockMax As Integer, ByVal fecAct As Date) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[insumosStock_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@stock", stock)
                command.Parameters.AddWithValue("@stockMin", stockMin)
                command.Parameters.AddWithValue("@stockMax", stockMax)
                command.Parameters.AddWithValue("@fecAct", fecAct)
                conn()
                actualizarInsumoStock = CInt(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex, "actualizarInsumoStock")
            actualizarInsumoStock = -1
        End Try
    End Function
End Class
