Public Class pwiComun
    Public Shared Function llenarCboLocalidades() As DataSet
        llenarCboLocalidades = conexion.obtenerLocalidades
    End Function
    Public Sub actulizarPersonas()

    End Sub
End Class
