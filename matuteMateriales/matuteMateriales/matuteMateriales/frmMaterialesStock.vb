Imports System.Drawing.Printing

Public Class frmMaterialesStock
    Dim objImprimir As New imprimir
    Private TitulosDoc As String = "CONTROL DE INVENTARIO "
    Private Sub frmMaterialesStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarComboMateriales()
            cargardgMaterialesStock()
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
    Private Sub cargardgMaterialesStock()
        Try
            Dim objWflProd As New wflProductos 'Ojo se instancia tambienn al guardar productos
            Dim objDSGrid As New DataSet
            Dim costo As Double = 0
            objDSGrid = objWflProd.obtenerProductosInventario(-1)
            If Not IsNothing(objDSGrid) Then
                dgMaterialesStock.DataSource = objDSGrid.Tables(0)
                For Each item As DataGridViewRow In dgMaterialesStock.Rows
                    ' crear caso para que calcule el valor de cada producto segun la unidad de medida
                    'costo = (costo + (item.Cells(2).Value) * (item.Cells(3).Value))
                    If IsDBNull(item.Cells(3).Value) Then
                        item.Cells(3).Value = 0
                    End If
                Next
                lblcanprod.Text = dgMaterialesStock.Rows.Count
                lblCostoInventario.Text = costo
            End If
        Catch ex As Exception
            agregar_error(ex)
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
            dgMaterialesStock.DataSource = Nothing
            dgMaterialesStock = Nothing
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Close()
    End Sub


End Class
