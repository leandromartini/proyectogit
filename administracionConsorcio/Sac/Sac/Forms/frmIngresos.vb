
Public Class frmIngresos
    Dim objDS As DataSet
    Dim objPwiIngresos As New PwiIngresos

    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fecha As Date = Date.Now

            setearControles()

            If Not Format(fecha, "dd") = 1 Then
                abrirFormulario(Format(fecha, "MM"), Format(fecha, "yyyy"))

            Else
                If vbYes = MsgBox("Desea cargar la tabla de ingresos del mes de " & Format(fecha, "MMMM"), vbYesNo, "status") Then

                    NuevoIngresos()
                    abrirFormulario(Format(fecha, "MM"), Format(fecha, "yyyy"))
                Else

                    abrirFormulario(Format(fecha, "MM"), (Format(fecha, "yyyy")) - 1)
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub abrirFormulario(ByVal mes As String, ByVal año As String)
        Try
            verIngresos(mes, año)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub setearControles()
        DtpMesIngreso.Value = Date.Now
    End Sub


    Sub verIngresos(ByVal mes As Long, ByVal año As Long)
        Try

            objDS = objPwiIngresos.obtenerIngresosMes(mes, año)
            If objDS Is Nothing Then
                MsgBox("Error Dataset es nothing")
                Exit Sub
            End If

            If Not objDS.Tables Is Nothing Then
                dgIngresos.DataSource = objDS.Tables(0)
                'dgIngresos.Columns("idUsuario").Visible = False
                'dgIngresos.Columns("ciudad").Visible = False
                'dgIngresos.Columns("descrip").HeaderText = "Ciudad"
                'dgIngresos.Columns("nombre").HeaderText = "Nombre"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub nuevoIngresos()

        Dim lngNuevo As Long
        'lngNuevo = objPwiIngresos.actualizarIngresosMes(dgIngresos)

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Las variables o controles que haya que limpiar
        Me.Close()
    End Sub
End Class