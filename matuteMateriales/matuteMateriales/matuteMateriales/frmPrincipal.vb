Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        frmMaterialesAgrega.ShowDialog()
    End Sub
    Private Sub EnStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnStockToolStripMenuItem.Click
        frmMaterialesStock.ShowDialog()
    End Sub
    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        frmVentas.ShowDialog()
    End Sub
    Private Sub GastosVariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosVariosToolStripMenuItem.Click

    End Sub
End Class