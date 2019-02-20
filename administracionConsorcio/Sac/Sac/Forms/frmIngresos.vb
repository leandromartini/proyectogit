
Public Class frmIngresos
    Dim objDS As DataSet
    Dim objPwiIngresos As New PwiIngresos

    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            setearControles()

            If Format(Date.Now, "dd") = 20 Then

                If vbYes = MsgBox("Desea cargar la tabla de ingresos del mes de " & Format(Date.Now, "MMMM"), vbYesNo, "status") Then
                    'Cargar los nuevos valores para el mes entrante
                Else
                    'Visualizar en el datagrid el mes aterior ya que no existe nuevos valores
                End If

            End If
            abrirFormulario()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub abrirFormulario()
        Try
            cargarIngresos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub setearControles()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DtpMesIngreso.ValueChanged

    End Sub

    Sub cargarIngresos()
        Try

            objDS = objPwiIngresos.obtenerIngresosMes()
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