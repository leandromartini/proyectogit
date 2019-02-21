Imports brl
Public Class PwiIngresos
    Dim objIngresos As New brlIngresos
    Public Function obtenerIngresosMes() As DataSet
        Try
            obtenerIngresosMes = objIngresos.obtenerIngresosMes
        Catch ex As Exception
            obtenerIngresosMes = Nothing
        End Try

    End Function
End Class
