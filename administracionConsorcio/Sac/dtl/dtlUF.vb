Imports System.Data.SqlClient
Public Class dtlUF
    Public Function obtenerListaUf(Optional ByVal id_uf As Long = -1) As DataSet
        Try

            Dim sProdString As String = "[dbo].[Uf_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerListaUf = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerListaUf = Nothing
        End Try
    End Function
End Class
