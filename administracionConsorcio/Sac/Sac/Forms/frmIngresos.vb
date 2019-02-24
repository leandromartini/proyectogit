
Public Class frmIngresos
    Dim objDS As DataSet
    Dim objPwiIngresos As New PwiIngresos
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

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub nuevoIngresos()

        Dim lngNuevo As Long
        lngNuevo = objPwiIngresos.actualizarIngresosMes(dgIngresos)

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Las variables o controles que haya que limpiar
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
                dgIngresos.Columns("mes").Visible = False
                dgIngresos.Columns("anio").Visible = False
                dgIngresos.Columns("id_uf").Visible = False
                dgIngresos.Columns("descrip").Visible = False

            End If
        Catch ex As Exception

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
        Next
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        objPwiIngresos.montoExp(TextBox1.Text, CampoTotal.expMes)
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        objPwiIngresos.montoExp(TextBox2.Text, CampoTotal.expExt)
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave

        objPwiIngresos.montoExp(TextBox3.Text, CampoTotal.MantEdif)
    End Sub
End Class