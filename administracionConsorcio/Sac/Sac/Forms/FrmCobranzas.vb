Public Class FrmCobranzas
    Dim objDS As New DataSet
    Dim objPwiComun As New pwiComun
    Sub abrirFormulario()
        objDS = objPwiComun.obtenerListaUf(-1)
        If Not objDS.Tables Is Nothing Then
            cboPropietario.DataSource = objDS.Tables(0)
            cboPropietario.DisplayMember = "descrip"
            cboPropietario.ValueMember = "id_uf"
            cboPropietario.SelectedIndex = -1
            cboPropietario.Text = "Seleccine una UF"
        End If
        verIngresos(-1, -1, 1)
    End Sub
    Private Sub FrmCobranzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirFormulario()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgHistorico.DataSource = Nothing
        Me.Close()
    End Sub

    Sub verIngresos(ByVal mes As Long, ByVal año As Long, ByVal id_uf As Long)

        Dim objDS As New DataSet
        Dim objPwiIngresos As New PwiIngresos
        Try

            objDS = objPwiIngresos.obtenerIngresosMes(mes, año, id_uf)
            If objDS Is Nothing Then
                MsgBox("Error Dataset es nothing")
                Exit Sub
            End If

            If Not objDS.Tables Is Nothing Then
                dgHistorico.DataSource = objDS.Tables(0)
                dgHistorico.Columns("dpto").Width = 115
                dgHistorico.Columns("coef").Width = 115
                dgHistorico.Columns("expMes").Width = 87
                dgHistorico.Columns("expExtra").Width = 87
                dgHistorico.Columns("mantEdif").Width = 87
                dgHistorico.Columns("subTotal").Width = 87
                dgHistorico.Columns("redondeo").Width = 87
                dgHistorico.Columns("total").Width = 87
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class