Imports System.Data.SqlClient
Public Class dtlConsorcio
    Public Function obtenerListaConsorcio(Optional ByVal id_cons As Long = -1) As DataSet
        Try

            Dim sProdString As String = "[dbo].[consorcio_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerListaConsorcio = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerListaConsorcio = Nothing
        End Try
    End Function
End Class
