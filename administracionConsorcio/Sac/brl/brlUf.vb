Imports dtl
Public Class brlUf
    Public Function obtenerListaUf(Optional ByVal id_uf As Long = -1) As DataSet
        Try
            Dim objIngresos As New dtlUF

            obtenerListaUf = objIngresos.obtenerListaUf(id_uf)


        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerListaUf = Nothing
        End Try
    End Function
End Class
