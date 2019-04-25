Public Class MaterialesAgrega
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        If Not validarDatos() Then
            Exit Sub
        End If

        Dim item As ListViewItem = New ListViewItem(CStr(cboMateriales.SelectedItem))
        item.SubItems.Add(numCantidad.Value)
        item.SubItems.Add(txtPrecioUnidad.Text)
        item.SubItems.Add(CDbl(txtPrecioUnidad.Text * numCantidad.Value))
        listaMateriales.Items.Add(item)
        limpiarControles()

    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        For Each item As ListViewItem In listaMateriales.SelectedItems
            item.Remove()
        Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        listaMateriales.Items.Clear()
    End Sub
    Private Sub btnModificaPrecio_Click(sender As Object, e As EventArgs) Handles btnModificaPrecio.Click
        txtPrecioUnidad.Enabled = True
        txtPrecioUnidad.Text = ""
        txtPrecioUnidad.Focus()
    End Sub
    Function validarDatos()
        validarDatos = True

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


    End Function

    Sub limpiarControles()
        cboMateriales.SelectedIndex = -1
        txtPrecioUnidad.Text = "0,00"
        txtPrecioUnidad.Enabled = False
        numCantidad.Value = 0
    End Sub
    Sub limpiaProductos()
        txtNombreProd.Text = ""
        txtPrecioProd.Text = ""
        txtProdDescrip.Text = ""
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiaProductos()
        Dim obj As Control
        For Each obj In grupoNuevoProducto.Controls
            obj.Enabled = True
        Next
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        limpiaProductos()
        Dim obj As Control
        For Each obj In grupoNuevoProducto.Controls
            If Not obj.Name = "BtnNuevo" Then
                obj.Enabled = False
            End If
        Next
    End Sub

    Private Sub btnProdGuardar_Click(sender As Object, e As EventArgs) Handles btnProdGuardar.Click
        Dim obj As Control
        For Each obj In grupoNuevoProducto.Controls
            If Not obj.Name = "BtnNuevo" Then
                obj.Enabled = False
            End If
        Next
        cboMateriales.Focus()
    End Sub
End Class
