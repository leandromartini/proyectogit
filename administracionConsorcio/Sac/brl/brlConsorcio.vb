Imports dtl
Public Class brlConsorcio
    Public Function obtenerListaConsorcio(Optional ByVal id_cons As Long = -1) As DataSet
        Try
            Dim objConsorcio As New dtlConsorcio

            obtenerListaConsorcio = objConsorcio.obtenerListaConsorcio(id_cons)

        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerListaConsorcio = Nothing
        End Try
    End Function
End Class
