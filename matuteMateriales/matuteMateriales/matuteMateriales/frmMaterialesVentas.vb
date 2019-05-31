Public Class frmMaterialesVentas
    Private TitulosDoc As String = "LISTA DE MATERIALES VENDIDOS "
    Private rdCheckForma As String
    Dim objImprimir As New imprimir
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarComboMateriales()
        Catch ex As Exception
            agregar_error(ex, "loadfrmVentas")
        End Try
    End Sub

    Private Sub cargarComboMateriales()
        Try
            Dim objWflProd As New wflProductos 'Ojo se instancia tambienn al guardar productos
            Dim objDS As New DataSet
            objDS = objWflProd.obtenerProductos(-1)
            If Not IsNothing(objDS) Then
                cboMateriales.DataSource = objDS.Tables(0)
                cboMateriales.DisplayMember = "nombre"
                cboMateriales.SelectedIndex = -1
                cboMateriales.Text = "Seleccionar un producto"
                cboMateriales.ValueMember = "id_prod"
            End If
        Catch ex As Exception
            agregar_error(ex, "cargarComboMateriales")
        End Try
    End Sub

    Private Sub cboMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMateriales.SelectedIndexChanged
        Dim objProductos As New producto
        Dim objProdCant As New productoCantidad
        Dim DSprod As New DataSet
        Try
            If cboMateriales.ValueMember = "" Then
                Exit Sub
            End If
            If cboMateriales.SelectedValue > 0 Then
                DSprod = objProductos.obtenerProductos(cboMateriales.SelectedValue)
                If Not DSprod.Tables.Count = 0 Then
                    objProdCant.agregarMateriales(DSprod.Tables(0).Rows(0).Item(1), DSprod.Tables(0).Rows(0).Item(3), DSprod.Tables(0).Rows(0).Item(2),
                                          DSprod.Tables(0).Rows(0).Item(4), 1)
                    lbUnidad.Text = objProdCant.obtenerUnidad
                    txtPrecioUnidad.Text = objProdCant.verPrecio
                End If
            End If
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objComun As New Comun
        Try
            If Not validarAgregarProducto() Then
                Exit Sub
            End If
            Dim item As ListViewItem = New ListViewItem(CStr(cboMateriales.Text))
            item.SubItems.Add(numCantidad.Value)
            item.SubItems.Add(txtPrecioUnidad.Text)
            item.SubItems.Add(objComun.totalProduc(lbUnidad.Text, txtPrecioUnidad.Text, numCantidad.Value))
            item.SubItems.Add(rdCheckForma)
            item.SubItems.Add(cboMateriales.SelectedValue)
            listaMateriales.Items.Add(item)

            limpiarControles()
            cboMateriales.ValueMember = Nothing
            cargarComboMateriales()
            cboMateriales.Focus()
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        For Each item As ListViewItem In listaMateriales.SelectedItems
            item.Remove()
        Next
        cboMateriales.ValueMember = Nothing
        cargarComboMateriales()
        cboMateriales.Focus()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        listaMateriales.Items.Clear()
        cboMateriales.ValueMember = Nothing
        cargarComboMateriales()
        cboMateriales.Focus()
    End Sub
    Function validarAgregarProducto()
        validarAgregarProducto = True

        If cboMateriales.SelectedIndex = -1 Then
            'If DirectCast(cboProgramas.SelectedItem, Data.DataRowView).Item("IdPrograma") = -1 Then
            MsgBox("Seleccione un producto.", MsgBoxStyle.OkOnly, "Aviso")
            cboMateriales.Focus()
            Return False
        End If

        If numCantidad.Value = 0 Then
            MsgBox("Seleccione la cantidad.", MsgBoxStyle.OkOnly, "Aviso")
            cboMateriales.Focus()
            Return False
        End If

        If txtPrecioUnidad.Text = "0,00" Then
            MsgBox("Agregue un precio.", MsgBoxStyle.OkOnly, "Aviso")
            cboMateriales.Focus()
            Return False
        End If
        Dim check As Boolean = False
        For Each radio As RadioButton In grupoAgregarProducto.Controls.OfType(Of RadioButton)
            If radio.Checked Then
                check = True
                rdCheckForma = radio.Text
            End If
        Next
        If Not check Then
            MsgBox("Debe seleccionar una forma de pago.", MsgBoxStyle.OkOnly, "Aviso")
            Return False
        End If

    End Function
    Sub limpiarControles()
        txtPrecioUnidad.Text = "0,00"
        txtPrecioUnidad.Enabled = False
        numCantidad.Value = 0
        lbUnidad.Text = ""
        rdCheckForma = ""
        desCheckAgrega(False)
    End Sub
    Sub desCheckAgrega(check)
        For Each radio As RadioButton In grupoAgregarProducto.Controls.OfType(Of RadioButton)
            radio.Checked = check
        Next
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        objImprimir.imprimirListaProductos(listaMateriales, TitulosDoc)
    End Sub

    Private Sub btnVistaPevia_Click(sender As Object, e As EventArgs) Handles btnVistaPevia.Click
        objImprimir.VistaListaProductos(listaMateriales, TitulosDoc)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objcftProd As New wflProductos

        If listaMateriales.Items.Count = 0 Then
            MsgBox("No hay productos en la lista.")
            Exit Sub
        End If
        For Each item As ListViewItem In listaMateriales.Items
            objcftProd.AgregarProductodeListaVentas(item)
        Next
        MsgBox("Se guardaron las ventas a la fecha: " & Date.Now & " hs.")
        listaMateriales.Items.Clear()
        cboMateriales.ValueMember = Nothing
        cargarComboMateriales()
        cboMateriales.Focus()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class