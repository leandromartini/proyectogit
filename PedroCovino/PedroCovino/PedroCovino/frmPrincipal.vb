Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        frmNuevoInsumo.ShowDialog()
    End Sub
    Private Sub EnStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnStockToolStripMenuItem.Click
        frmInventario.ShowDialog()
    End Sub

    Private Sub CargarNuevaListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarNuevaListaToolStripMenuItem.Click
        frmCargarLista.ShowDialog()
    End Sub
End Class