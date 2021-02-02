Public Class Comun
    Function totalProduc(unidad, precio, cantidad) As Double
        Select Case unidad ' creo esta funcion por si hay que agregar algun calculo
            Case "[Uni.]"
                Return precio * cantidad
            Case "[kg]"
                Return (precio * cantidad) / 1000
            Case "[m]"
                Return precio * cantidad
            Case "[m²]"
                Return precio * cantidad
            Case "[tran]"
                Return precio * cantidad
            Case Else
                Return 0
        End Select
    End Function
End Class
