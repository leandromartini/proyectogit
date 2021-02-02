Imports System.Data.SqlClient
Public Class ccdProductoPrecioHist
    Public Function actualizarPrecioHist(ByVal id_prod As Integer, ByVal precio As Double, ByVal precioIVA As Double, fecAct As Date) As Integer
        Try
            'DECLARE @MyDate date
            'set @MyDate = GETDATE()
            'Print(Convert(varchar,@MyDate, 3))
            Dim sProdString As String = "[dbo].[productosPrecioHist_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@precio", precio)
                command.Parameters.AddWithValue("@precioiva", precioIVA)
                command.Parameters.AddWithValue("@fecAct", fecAct)
                conn()
                actualizarPrecioHist = command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex, "ccdProductoPrecioHist")
            actualizarPrecioHist = 0
        End Try
    End Function
End Class
