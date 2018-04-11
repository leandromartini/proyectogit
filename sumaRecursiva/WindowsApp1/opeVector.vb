Public Class opeVector
    Sub mayor(a, i, n, ByRef aux)
        If Not (i < n) Then
            aux = a(i)
        Else
            mayor(a, i + 1, n, aux)
            If a(i) > aux Then
                aux = a(i)
            End If
        End If
    End Sub

    Function sumar(a, i, n) As Integer
        If Not (i < n) Then
            sumar = 0
        Else
            sumar = a(i) + sumar(a, i + 1, n)
        End If
    End Function
    Sub iguales(a, i, n, ByRef cant)
        If Not i = n Then
            iguales(a, i + 1, n, cant)
            For j = 1 To i
                If a(i) = a(j) And i <> j Then
                    cant = cant + 1
                End If
            Next
        End If
    End Sub

    Function leerVector(a)
        a(1) = frmCargaVector.TextBox1.Text
        a(2) = frmCargaVector.TextBox2.Text
        a(3) = frmCargaVector.TextBox3.Text
        a(4) = frmCargaVector.TextBox4.Text
        a(5) = frmCargaVector.TextBox5.Text
        a(6) = frmCargaVector.TextBox6.Text
        a(7) = frmCargaVector.TextBox7.Text
        'For i = 1 To a.count
        '    a(i) = tex
        'Next
        leerVector = a
    End Function
End Class
