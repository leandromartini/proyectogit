Public Class frmPpal
    Dim fechayhora As Date = Date.Now
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblfechahora.Text = fechayhora.ToString("dddd dd 'de' MMMM ") + TimeOfDay
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        frmIngresos.ShowDialog()
    End Sub

    Private Sub CobranzasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobranzasToolStripMenuItem.Click
        FrmCobranzas.ShowDialog()
    End Sub

    Private Sub frmPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        frmPropietarios.ShowDialog()
    End Sub

    Private Sub VerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem1.Click

    End Sub
End Class
