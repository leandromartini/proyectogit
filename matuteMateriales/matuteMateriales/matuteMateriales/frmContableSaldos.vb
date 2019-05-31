Public Class frmContableSaldos
    Private Sub frmSaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardgSaldos("2019-05-31", "2019-05-31")
    End Sub
    Private Sub cargardgSaldos(fecDesde, fedHasta)
        Try
            Dim objWflProd As New wflContable
            Dim objDSGrid As New DataSet
            Dim objComun As New Comun
            Dim costoInv As Double = 0
            objDSGrid = objWflProd.obtenerSaldos(fecDesde, fedHasta)
            If Not IsNothing(objDSGrid) Then
                dgBalance.DataSource = objDSGrid.Tables(0)
            End If

        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub



    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()

    End Sub
End Class