Public Class frmMaterialesAgrega
    Dim objImprimir As New imprimir
    Private rdCheck As String
    Private TitulosDoc As String = "LISTA DE MATERIALES  "
    Private Sub frmMaterialesAgrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarComboMateriales()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub

    Private Sub cargarComboMateriales()
        Try
            Dim objWflProd As New wflProductos 'Ojo se instancia tambienn al guardar productos
            Dim objDS As New DataSet

            objDS = objWflProd.obtenerProductos()
            If Not IsNothing(objDS) Then
                cboMateriales.DataSource = objDS.Tables(0)
                cboMateriales.DisplayMember = "nombre"
                cboMateriales.SelectedIndex = -1
                cboMateriales.Text = "Seleccionar un producto"
                cboMateriales.ValueMember = "id_prod"
            End If
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Not validarAgregarProducto() Then
                Exit Sub
            End If
            Dim item As ListViewItem = New ListViewItem(CStr(cboMateriales.Text))
            item.SubItems.Add(numCantidad.Value)
            item.SubItems.Add(txtPrecioUnidad.Text)
            item.SubItems.Add(totalProduc(lbUnidad.Text, txtPrecioUnidad.Text, numCantidad.Value))
            item.SubItems.Add(cboMateriales.SelectedValue)
            listaMateriales.Items.Add(item)

            limpiarControles()
            cboMateriales.ValueMember = Nothing
            cargarComboMateriales()
            cboMateriales.Focus()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Function totalProduc(unidad, precio, cantidad) As Double
        Select Case unidad ' creo esta funcion por si hay que agregar algun calculo
            Case "Unidad"
                Return CDbl(precio * cantidad)
            Case "[kg]"
                Return CDbl((precio * cantidad) / 1000)
            Case "[m]"
                Return CDbl(precio * cantidad)
            Case "[m²]"
                Return CDbl(precio * cantidad)
        End Select
    End Function
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
    Private Sub SoloImportes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioUnidad.KeyPress, txtPrecioProd.KeyPress
        SoloImportes(e)
    End Sub
    Sub SoloImportes(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(44) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número.", MsgBoxStyle.Exclamation, "Ingreso de importe.")
        End If
    End Sub
    Sub limpiarControles()
        txtPrecioUnidad.Text = "0,00"
        txtPrecioUnidad.Enabled = False
        numCantidad.Value = 0
    End Sub
    Sub limpiaProductos()
        txtNombreProd.Text = ""
        txtPrecioProd.Text = ""
        txtProdDescrip.Text = ""
        desCheck(False)

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

    Sub desCheck(check)
        For Each radio As RadioButton In grupoNuevoProducto.Controls.OfType(Of RadioButton)
            radio.Checked = check
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
        BtnNuevo.Enabled = True
    End Sub

    Private Sub btnProdGuardar_Click(sender As Object, e As EventArgs) Handles btnProdGuardar.Click
        Dim obj As Control
        Dim objwflProd As New wflProductos

        If Not validarNuevoPoducto() Then
            Exit Sub
        End If
        If Not objwflProd.ProductoNuevo(txtNombreProd.Text, rdCheck, txtPrecioProd.Text, txtProdDescrip.Text) = "01/01/1900" Then
            MsgBox("El producto guardo con exito")
        End If
        For Each obj In grupoNuevoProducto.Controls
            If Not obj.Name = "BtnNuevo" Then
                obj.Enabled = False
            End If
        Next
        BtnNuevo.Enabled = True
        cboMateriales.ValueMember = Nothing
        cargarComboMateriales()
        cboMateriales.Focus()

        'MsgBox("Se ha guardado el producto: " + objProd.obtenerNombre + " con el precio: " + CStr(objProd.obtenerprecio))

    End Sub

    Private Function validarNuevoPoducto()
        validarNuevoPoducto = True

        If txtNombreProd.Text = "" Then
            MsgBox("Debe completar el campo nombre.", MsgBoxStyle.OkOnly, "Aviso")
            txtNombreProd.Focus()
            Return False
        End If

        Dim check As Boolean = False
        For Each radio As RadioButton In grupoNuevoProducto.Controls.OfType(Of RadioButton)
            If radio.Checked Then
                check = True
                rdCheck = radio.Text
            End If
        Next
        If Not check Then
            MsgBox("Debe seleccionar una unidad de medida.", MsgBoxStyle.OkOnly, "Aviso")
            Return False
        End If

        If txtPrecioProd.Text = "" Then
            MsgBox("Debe completar el campo precio.", MsgBoxStyle.OkOnly, "Aviso")
            txtPrecioProd.Focus()
            Return False
        End If

    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objcftProd As New wflProductos

        For Each item As ListViewItem In listaMateriales.Items
            objcftProd.AgregarProductodeLista(item)
        Next
        MsgBox("Se guardaron los materiales que ingresaron en la fecha: " & Date.Now & " hs.")
        listaMateriales.Items.Clear()
        cboMateriales.ValueMember = Nothing
        cargarComboMateriales()
        cboMateriales.Focus()

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        objImprimir.imprimirListaProductos(listaMateriales, TitulosDoc)
    End Sub

    Private Sub btnVistaPevia_Click(sender As Object, e As EventArgs) Handles btnVistaPevia.Click
        objImprimir.VistaListaProductos(listaMateriales, TitulosDoc)
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
            agregar_error(ex)
        End Try
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiaProductos()
        limpiarControles()
        listaMateriales.Items.Clear()
        cboMateriales.ValueMember = Nothing
        Close()
    End Sub

End Class
