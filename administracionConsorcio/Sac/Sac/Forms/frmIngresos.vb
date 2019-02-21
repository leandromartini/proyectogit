
Public Class frmIngresos
    Dim objDS As DataSet
    Dim objPwiIngresos As New PwiIngresos

    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fecha As Date = Date.Now

            setearControles()

            If Not Format(fecha, "dd") = 1 Then
                abrirFormulario(Format(fecha, "MM"), Format(fecha, "YY"))

            Else
                If vbYes = MsgBox("Desea cargar la tabla de ingresos del mes de " & Format(fecha, "MMMM"), vbYesNo, "status") Then



                Else

                    abrirFormulario(Format(fecha, "MM"), (Format(fecha, "YY")) - 1)
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub abrirFormulario(ByVal mes As Long, ByVal año As Long)
        Try
            verIngresos(mes, año)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub setearControles()
        'Codigo solo para el load
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DtpMesIngreso.ValueChanged

    End Sub

    Sub verIngresos(ByVal mes As Long, ByVal año As Long)
        Try

            objDS = objPwiIngresos.obtenerIngresosMes(mes, año)
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
End Class