Public Class frmVentas
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
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class