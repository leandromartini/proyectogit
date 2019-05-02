Imports System.Drawing.Printing
Public Class imprimir
    Private WithEvents PrintDocument1 As New PrintDocument
    Private WithEvents PrintPreviewButton As Button
    Private printPreviewDialog1 As New PrintPreviewDialog
    Private TituloDocumento As String
    Private datagrid As DataGridView

    Sub imprimir(ByVal dgAux As DataGridView, ByVal TitulosDoc As String)
        Try
            datagrid = dgAux
            TituloDocumento = TitulosDoc
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox("Error en debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
        End Try
    End Sub
    Sub imprimirVistaPrevia(ByVal dgAux As DataGridView, ByVal TitulosDoc As String)
        Try
            datagrid = dgAux
            TituloDocumento = TitulosDoc
            printPreviewDialog1.Document = PrintDocument1
            printPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox("Error en debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim rowfont As New Font("Arial", 11, FontStyle.Bold)
            Dim blackPen As New Pen(Color.Black, 1)
            Dim point1 As New PointF(40, 100)
            Dim point2 As New PointF(784, 100) ' Dimension hoja A4 - 8,25 x 11,75 Pulgadas
            Dim xpos As Integer = 50
            Dim ypos As Integer = 100


            e.Graphics.DrawString(TituloDocumento & Date.Now, rowfont, Brushes.Black, 230, 40)

            For Each nombreColum As DataGridViewColumn In datagrid.Columns
                If nombreColum.DisplayIndex <> 0 Then
                    xpos = 150
                End If
                e.Graphics.DrawString(nombreColum.Name, rowfont, Brushes.Black, xpos + (xpos * nombreColum.DisplayIndex), ypos - 20)
                e.Graphics.DrawLine(blackPen, point1, point2)
            Next

            For i As Integer = 0 To datagrid.RowCount - 1

                'material = material & dgMaterialesStock(0, i).Value & vbTab
                'cantidad = cantidad & dgMaterialesStock(1, i).Value & vbTab

                For j As Integer = 0 To datagrid.ColumnCount - 1
                    e.Graphics.DrawString(datagrid(j, i).Value, rowfont, Brushes.Black, xpos + (xpos * j), ypos + (ypos * i))
                    'banderapos = True

                    'material = ""
                    'cantidad = 0
                    'contadorregistros = contadorregistros + 1
                Next
                ' e.Graphics.DrawLine(blackPen, point1, point2)

            Next
            'If (contadorregistros < dgMaterialesStock.RowCount - 1) Then
            '    e.HasMorePages = True
            'Else
            '    e.HasMorePages = False
            'End If
        Catch ex As Exception
            MsgBox("Error en debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
        End Try
    End Sub

End Class
