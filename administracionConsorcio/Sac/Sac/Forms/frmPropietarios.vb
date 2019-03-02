Public Class frmPropietarios
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        For Each tb As TextBox In Me.tabPropietarios.SelectedTab.Controls.OfType(Of TextBox)()
            tb.Text = ""
        Next
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'limpiar todo
        Me.Close()
    End Sub
End Class