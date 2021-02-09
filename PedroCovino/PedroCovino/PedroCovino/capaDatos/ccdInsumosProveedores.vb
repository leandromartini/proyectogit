Imports System.Data.SqlClient
Public Class ccdInsumosProveedores
    Friend Function obtenerInsumosProv(idprov As Integer) As DataSet
        Try
            Dim sProdString As String = "[dbo].[insumosProveedores_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.Parameters.AddWithValue("@idprov", idprov)
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerInsumosProv = dataset
        Catch ex As Exception
            disconect()
            agregar_error(ex, "obtenerInsumosProv")
            obtenerInsumosProv = Nothing
        End Try
    End Function
End Class
