
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
            Dim objWfIns As New wflInsumos 'Ojo se instancia tambienn al guardar productos
            Dim objDS As New DataSet
            objDS = objWfIns.obtenerInsumosDescrip(-1)
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

            Dim objWflIns As New wflInsumos 'Ojo se instancia tambienn al guardar productos
            Dim objDSGrid As New DataSet
            Dim objComun As New Comun
            Dim costoInv As Double = 0
            objDSGrid = objWflIns.obtenerInsumosDetalle(codigo)
            If Not IsNothing(objDSGrid) Then
                dgInsumosDetalle.DataSource = objDSGrid.Tables(0)
                'For Each item As DataGridViewRow In dgMaterialesStock.Rows
                '    costoInv = costoInv + objComun.totalProduc(item.Cells(1).Value, item.Cells(2).Value, IIf(IsDBNull(item.Cells(3).Value), 0, item.Cells(3).Value))
                '    If IsDBNull(item.Cells(3).Value) Then
                '        item.Cells(3).Value = 0
                '    End If
                'Next
                'lblcanprod.Text = dgMaterialesStock.Rows.Count
                'lblCostoInventario.Text = costoInv
            End If
            cargarStock()
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub

    Private Sub cboInsumos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInsumos.SelectedIndexChanged

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
    Private Sub CbVerTodo_CheckedChanged(sender As Object, e As EventArgs) Handles CbVerTodo.CheckedChanged
        If CbVerTodo.Checked Then
            cboInsumos.Enabled = False
        Else
            cboInsumos.Enabled = True
        End If
        cargardgInsumosStock(-1)
    End Sub

    Private Sub dgInsumosDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInsumosDetalle.CellClick
        cargarStock()
    End Sub


    Private Sub dgInsumosDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgInsumosDetalle.CellValueChanged
        Dim objComun As New Comun
        Try
            'Preguntar si es es la columna stock, sino mensaje no puede modificar demas columnas
            If dgInsumosDetalle.Columns(e.ColumnIndex).Name <> "stock" Then
                MsgBox("Solo se puede modificar el Stock")
                Exit Sub
            End If

            objComun.ActualizarInsumoStock(dgInsumosDetalle.Item(0, dgInsumosDetalle.CurrentRow.Index).Value, dgInsumosDetalle.CurrentCell.Value, txtStockMin.Text, txtStockMax.Text)

            If objComun.grabarInsumo() Then
                MsgBox("El cambio se grabo con exito!")
            End If
            cargardgInsumosStock(-1)
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub

    Sub cargarStock()
        txtStockDisp.Text = dgInsumosDetalle.Item(5, dgInsumosDetalle.CurrentRow.Index).Value
        txtStockMin.Text = dgInsumosDetalle.Item(6, dgInsumosDetalle.CurrentRow.Index).Value
        txtStockMax.Text = dgInsumosDetalle.Item(7, dgInsumosDetalle.CurrentRow.Index).Value
        txtFecAct.Text = dgInsumosDetalle.Item(8, dgInsumosDetalle.CurrentRow.Index).Value
    End Sub

    Private Sub limpiar()
        Try
            cboInsumos.DataSource = Nothing
            cboInsumos.ValueMember = Nothing
            dgInsumosDetalle.DataSource = Nothing
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Close()
    End Sub
    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        objImprimir.imprimirVistaPrevia(dgInsumosDetalle, TitulosDoc)
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        objImprimir.imprimir(dgInsumosDetalle, TitulosDoc)
    End Sub


End Class
