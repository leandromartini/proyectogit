Public Class frmPpal
    Dim fechayhora As Date = Date.Now
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    lblfechahora.Text = fechayhora.ToString("dddd dd 'de' MMMM ") + TimeOfDay
    'End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        frmIngresos.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
