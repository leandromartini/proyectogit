
Public Class frmInventario
    Dim objImprimir As New imprimir
    Private TitulosDoc As String = "CONTROL DE INVENTARIO "
    Private Sub frmMaterialesStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarComboInsumos()
            cargardgInsumosStock(-1)
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Private Sub cargarComboInsumos()
        Try
            Dim objWflProd As New wflInsumos 'Ojo se instancia tambienn al guardar productos
            Dim objDS As New DataSet
            objDS = objWflProd.obtenerInsumosDescrip(-1)
            If Not IsNothing(objDS) Then
                cboInsumos.DataSource = objDS.Tables(0)
                cboInsumos.DisplayMember = "descrip"
                cboInsumos.SelectedIndex = -1
                cboInsumos.Text = "Seleccionar un producto"
                cboInsumos.ValueMember = "codigo"
            End If
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Private Sub cargardgInsumosStock(codigo)
        Try

            Dim objWflProd As New wflInsumos 'Ojo se instancia tambienn al guardar productos
            Dim objDSGrid As New DataSet
            Dim objComun As New Comun
            Dim costoInv As Double = 0
            objDSGrid = objWflProd.obtenerInsumosDetalle(codigo)
            If Not IsNothing(objDSGrid) Then
                dgMaterialesStock.DataSource = objDSGrid.Tables(0)
                'For Each item As DataGridViewRow In dgMaterialesStock.Rows
                '    costoInv = costoInv + objComun.totalProduc(item.Cells(1).Value, item.Cells(2).Value, IIf(IsDBNull(item.Cells(3).Value), 0, item.Cells(3).Value))
                '    If IsDBNull(item.Cells(3).Value) Then
                '        item.Cells(3).Value = 0
                '    End If
                'Next
                'lblcanprod.Text = dgMaterialesStock.Rows.Count
                'lblCostoInventario.Text = costoInv
            End If
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        objImprimir.imprimirVistaPrevia(dgMaterialesStock, TitulosDoc)
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        objImprimir.imprimir(dgMaterialesStock, TitulosDoc)
    End Sub
    Private Sub limpiar()
        Try
            cboInsumos.DataSource = Nothing
            cboInsumos.ValueMember = Nothing
            dgMaterialesStock.DataSource = Nothing
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Close()
    End Sub

    Private Sub cboMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInsumos.SelectedIndexChanged
        Dim objProductos As New producto
        'Dim objProdCant As New productoCantidad
        Dim DSprod As New DataSet
        Try
            If cboInsumos.ValueMember = "" Then
                Exit Sub
            End If
            If cboInsumos.SelectedValue > 0 Then
                cargardgInsumosStock(cboInsumos.SelectedValue)
            End If
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            cboInsumos.Enabled = False
        Else
            cboInsumos.Enabled = True
        End If
        ' cargardgMaterialesStock(-1)
    End Sub
End Class
