Imports System.Drawing.Printing

Public Class frmMaterialesStock
    Private WithEvents PrintDocument1 As New PrintDocument
    Private WithEvents printPreviewButton As Button
    Private printPreviewDialog1 As New PrintPreviewDialog

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        PrintDocument1.Print()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub limpiar()
        dgMaterialesStock.DataSource = Nothing
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim rowfont As New Font("Arial", 11, FontStyle.Bold)
            Dim blackPen As New Pen(Color.Black, 3)
            Dim point1 As New PointF(100.0F, 100.0F)
            Dim point2 As New PointF(500.0F, 100.0F)
            Dim xpos As Integer = 80
            Dim ypos As Integer = 40

            For Each nombreColum As DataGridViewColumn In dgMaterialesStock.Columns

                e.Graphics.DrawString(nombreColum.Name, rowfont, Brushes.Black, xpos + (xpos * nombreColum.DisplayIndex), ypos - 25)
            Next

            For i As Integer = 0 To dgMaterialesStock.RowCount - 1

                'material = material & dgMaterialesStock(0, i).Value & vbTab
                'cantidad = cantidad & dgMaterialesStock(1, i).Value & vbTab

                For j As Integer = 0 To dgMaterialesStock.ColumnCount - 1
                    e.Graphics.DrawString(dgMaterialesStock(j, i).Value, rowfont, Brushes.Black, xpos + (xpos * j), ypos + (ypos * i))
                    'banderapos = True

                    'material = ""
                    'cantidad = 0
                    'contadorregistros = contadorregistros + 1
                Next
                e.Graphics.DrawLine(blackPen, point1, point2)

            Next
            'If (contadorregistros < dgMaterialesStock.RowCount - 1) Then
            '    e.HasMorePages = True
            'Else
            '    e.HasMorePages = False
            'End If
        Catch ex As Exception
            MsgBox("Error en debido a: " & ex.Message, MsgBoxStyle.Exclamation, "Advertencia!!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printPreviewDialog1.Document = PrintDocument1
        printPreviewDialog1.ShowDialog()
    End Sub
End Class
