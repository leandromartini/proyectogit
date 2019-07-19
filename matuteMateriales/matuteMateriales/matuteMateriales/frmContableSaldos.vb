Imports System.ComponentModel

Public Class frmContableSaldos

    Private Sub frmSaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDesde.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        cargardgSaldos(dtpDesde.Value, Date.Now)
    End Sub
    Private Sub cargardgSaldos(fecDesde, fedHasta)
        Try
            Dim objWflProd As New wflContable
            Dim objDSGrid As New DataSet
            Dim objComun As New Comun
            Dim costoInv As Double = 0
            objDSGrid = objWflProd.obtenerSaldos(fecDesde, fedHasta)
            If Not IsNothing(objDSGrid) Then
                objDSGrid.Tables(0).Columns.Add("Ingreso (+)")
                objDSGrid.Tables(0).Columns.Add("Egreso (-)")
                dgBalance.DataSource = objDSGrid.Tables(0)
                operarColumnas(dgBalance)
                dgBalance.Sort(dgBalance.Columns(0), ListSortDirection.Ascending)
                dgBalance.Columns("tipoTran").Visible = False
                dgBalance.Columns("id_con").Visible = False
                dgBalance.Columns("concepto").Width = 238
            End If

        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        cargardgSaldos(dtpDesde.Value, dtpHasta.Value)
    End Sub

    Sub operarColumnas(objDSGrid)
        Try
            For Each item As DataGridViewRow In dgBalance.Rows
                item.Cells("cant").Value = Math.Round(item.Cells("cant").Value)
                If item.Cells("tipoTran").Value = "I" Then
                    item.Cells("Ingreso (+)").Value = Math.Round(item.Cells("precio").Value * item.Cells("cant").Value)
                    item.Cells("Egreso (-)").Value = 0
                Else
                    item.Cells("Ingreso (+)").Value = 0
                    item.Cells("Egreso (-)").Value = Math.Round(item.Cells("precio").Value * item.Cells("cant").Value)
                End If
            Next
            Dim Ingresos As Double
            Dim Egresos As Double

            For Each row As DataGridViewRow In objDSGrid.Rows
                Ingresos += Val(row.Cells("Ingreso (+)").Value)
                Egresos += Val(row.Cells("Egreso (-)").Value)
            Next
            txtIngresos.Text = Ingresos
            txtEgresos.Text = Egresos
            txtSaldoFinal.Text = Ingresos - Egresos
        Catch ex As Exception
            agregar_error(ex, Name)
        End Try

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()

    End Sub
End Class