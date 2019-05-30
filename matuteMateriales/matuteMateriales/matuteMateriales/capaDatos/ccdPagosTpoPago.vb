Imports System.Data.SqlClient
Public Class ccdPagosTpoPago
    Public Sub actualizarpagosTpoPago(ByVal id_egreso As Integer, ByVal formaPago As String, ByVal fec As Date)
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[pagosTpoPago_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_tran", id_egreso)
                command.Parameters.AddWithValue("@formaPago", formaPago)
                command.Parameters.AddWithValue("@fec", fec)

                conn()
                command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            disconect()
            agregar_error(ex, "actualizarProducto")
        End Try
    End Sub
End Class
