
Public Class frmIngresos
    Dim objDS As DataSet
    Dim objPwiIngresos As New PwiIngresos
    Dim objPwiComun As New pwiComun

    Enum CampoTotal
        expMes = 1
        expExt = 2
        MantEdif = 3
    End Enum

    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fecha As Date = Date.Now

            setearControles()

            If Not Format(fecha, "dd") = 1 Then
                abrirFormulario(Format(fecha, "MM"), Format(fecha, "yyyy"), -1)

            Else
                If vbYes = MsgBox("Desea cargar la tabla de ingresos del mes de " & Format(fecha, "MMMM"), vbYesNo, "status") Then

                    NuevoIngresos()
                    abrirFormulario(Format(fecha, "MM"), Format(fecha, "yyyy"), -1)
                Else

                    abrirFormulario(Format(fecha, "MM"), (Format(fecha, "yyyy")) - 1, -1)
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub

    Sub abrirFormulario(ByVal mes As String, ByVal año As String, ByVal id_uf As Long)
        Try
            verIngresos(mes, año, id_uf)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub verIngresos(ByVal mes As Long, ByVal año As Long, ByVal id_uf As Long)
        Try

            objDS = objPwiIngresos.obtenerIngresosMes(mes, año, id_uf)
            If objDS Is Nothing Then
                MsgBox("Error Dataset es nothing")
                Exit Sub
            End If

            If Not objDS.Tables Is Nothing Then
                dgIngresos.DataSource = objDS.Tables(0)
                dgIngresos.Columns("dpto").Width = 115
                dgIngresos.Columns("coef").Width = 115
                dgIngresos.Columns("expMes").Width = 88
                dgIngresos.Columns("expExtra").Width = 88
                dgIngresos.Columns("mantEdif").Width = 88
                dgIngresos.Columns("subTotal").Width = 88
                dgIngresos.Columns("redondeo").Width = 88
                dgIngresos.Columns("total").Width = 88
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub NuevoIngresos()
        Try
            Dim lngNuevo As Long
            lngNuevo = objPwiIngresos.actualizarIngresosMes(dgIngresos)
            If lngNuevo Then
                MsgBox("Se guardaron con exito los cambios.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Las variables o controles que haya que limpiar
        controlesNuevoIngreso(False)
        Me.Close()
    End Sub

    Private Sub btnNuevoIngreso_Click(sender As Object, e As EventArgs) Handles btnNuevoIngreso.Click
        Try
            Dim objNuevoIngreso As DataSet
            controlesNuevoIngreso(True)

            objNuevoIngreso = objPwiIngresos.NuevoIngresoMes()
            If objDS Is Nothing Then
                MsgBox("Error Dataset es nothing")
                Exit Sub
            End If

            If Not objDS.Tables Is Nothing Then
                dgIngresos.DataSource = objNuevoIngreso.Tables(0)
                dgIngresos.Columns("id_uf").Visible = False
                dgIngresos.Columns("descrip").Visible = False
                dgIngresos.Columns("dpto").Width = 115
                dgIngresos.Columns("coef").Width = 115
                dgIngresos.Columns("expMes").Width = 87
                dgIngresos.Columns("expExtra").Width = 87
                dgIngresos.Columns("mantEdif").Width = 87
                dgIngresos.Columns("subTotal").Width = 87
                dgIngresos.Columns("redondeo").Width = 87
                dgIngresos.Columns("total").Width = 87

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        controlesNuevoIngreso(False)
        nuevoIngresos()

    End Sub
    Sub controlesNuevoIngreso(ByVal bool As Boolean)
        btnNuevoIngreso.Visible = Not bool
        btnGuardar.Visible = bool
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Enabled = bool
            tb.Clear()
            tb.Text = "00.0"
        Next
        TextBox1.Focus()
        TextBox4.ReadOnly = bool
        TextBox5.ReadOnly = bool
        TextBox6.ReadOnly = bool

    End Sub
    Sub setearControles()
        ''DtpMesIngreso.Value = Date.Now
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Try
                If Not objPwiComun.ValidarNumericoDecimal(CStr(TextBox1.Text)) Then
                MsgBox("Debe ingresar un importe valido.")
                TextBox1.Clear()
                TextBox1.Focus()
                Exit Sub
            End If
            objPwiIngresos.MontoExp(TextBox1.Text, CampoTotal.expMes)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        Try
                If Not objPwiComun.ValidarNumericoDecimal(CStr(TextBox2.Text)) Then
                MsgBox("Debe ingresar un importe valido.")
                TextBox2.Clear()
                TextBox2.Focus()
                Exit Sub
            End If
            objPwiIngresos.MontoExp(TextBox2.Text, CampoTotal.expExt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        Try
            If Not objPwiComun.ValidarNumericoDecimal(CStr(TextBox3.Text)) Then
                MsgBox("Debe ingresar un importe valido.")
                TextBox3.Clear()
                TextBox3.Focus()
                Exit Sub
            End If
            objPwiIngresos.MontoExp(TextBox3.Text, CampoTotal.MantEdif)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub totales() Handles TextBox1.LostFocus, TextBox2.LostFocus, TextBox3.LostFocus
        ''Probar con subtotal y buscar una lugar donde instanciar la suma para los campos de totales
        TextBox4.Text = objPwiComun.SumarColumnaDatagrid(dgIngresos, "subTotal")
        TextBox5.Text = objPwiComun.SumarColumnaDatagrid(dgIngresos, "redondeo")
        TextBox6.Text = objPwiComun.SumarColumnaDatagrid(dgIngresos, "total")
    End Sub
End Class