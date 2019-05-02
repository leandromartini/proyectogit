Public Class frmMaterialesAgrega

    Private Sub frmMaterialesAgrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objProd As New productos 'Ojo se instancia tambein al guardar productos
        objProd.obtenerProductos(-1)
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If Not validarAgregarProducto() Then
                Exit Sub
            End If
            Dim item As ListViewItem = New ListViewItem(CStr(cboMateriales.SelectedItem))
            item.SubItems.Add(numCantidad.Value)
            item.SubItems.Add(txtPrecioUnidad.Text)
            item.SubItems.Add(CDbl(txtPrecioUnidad.Text * numCantidad.Value))
            listaMateriales.Items.Add(item)
            limpiarControles()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    End Function

    Private Sub txtPrecioUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioUnidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiaProductos()
        Dim obj As Control
        For Each obj In grupoNuevoProducto.Controls
            obj.Enabled = True
        Next
        BtnNuevo.Enabled = False
        txtNombreProd.Focus()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        limpiaProductos()
        Dim obj As Control
        For Each obj In grupoNuevoProducto.Controls
            If Not obj.Name = "BtnNuevo" Then
                obj.Enabled = False
            End If
        Next
        BtnNuevo.Enabled = True
    End Sub

    Private Sub btnProdGuardar_Click(sender As Object, e As EventArgs) Handles btnProdGuardar.Click
        Dim obj As Control
        Dim objProd As New productos
        Dim objwflProd As New wflProductos

        If Not validarNuevoPoducto() Then
            Exit Sub
        End If
        objProd.NuevoPruducto(txtNombreProd.Text, txtProdDescrip.Text, txtPrecioProd.Text)

        For Each obj In grupoNuevoProducto.Controls
            If Not obj.Name = "BtnNuevo" Then
                obj.Enabled = False
            End If
        Next
        BtnNuevo.Enabled = True

        If objwflProd.ProductoNuevo <> 0 Then

            MsgBox("Se ha guardado el producto: " + objProd.obtenerNombre + " con el precio: " + CStr(objProd.obtenerprecio))
        End If

        objProd.limpiar()
        cboMateriales.Focus()
    End Sub

    Private Function validarNuevoPoducto()
        validarNuevoPoducto = True

        If txtNombreProd.Text = "" Then
            MsgBox("Debe completar el campo nombre.", MsgBoxStyle.OkOnly, "Aviso")
            txtNombreProd.Focus()
            Return False
        End If

        If txtPrecioProd.Text = "" Then
            MsgBox("Debe completar el campo precio.", MsgBoxStyle.OkOnly, "Aviso")
            txtPrecioProd.Focus()
            Return False
        End If

    End Function

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objcftProd As New wflProductos

        For Each item As ListViewItem In listaMateriales.Items
            objcftProd.AgregarProducto(item)
        Next

        'llamar a la capa flujo de trabajo y guardar los nuevos materiales que entraron

    End Sub
End Class
