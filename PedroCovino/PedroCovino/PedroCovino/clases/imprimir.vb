Imports System.Drawing.Printing
Public Class imprimir
    Private WithEvents PrintDocument1 As New PrintDocument
    Private WithEvents PrintDocument2 As New PrintDocument
    Private WithEvents PrintPreviewButton As Button
    Private printPreviewDialog1 As New PrintPreviewDialog
    Private printPreviewDialog2 As New PrintPreviewDialog
    Private TituloDocumento As String
    Private datagrid As DataGridView
    Private auxlista As Windows.Forms.ListView
    Private rowfont As New Font("Arial", 11, FontStyle.Bold)

    Sub imprimir(dgAux As DataGridView, ByVal TitulosDoc As String)
        Try
            datagrid = dgAux
            TituloDocumento = TitulosDoc
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox("Error de impresion debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
            guardar(ex, "imprimir imprimir")
        End Try
    End Sub
    Sub imprimirVistaPrevia(dgAux As DataGridView, ByVal TitulosDoc As String)
        Try
            datagrid = dgAux
            TituloDocumento = TitulosDoc
            printPreviewDialog1.Document = PrintDocument1
            printPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox("Error de impresion debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
            guardar(ex, "imprimir imprimirVistaPrevia")
        End Try
    End Sub
    Friend Sub imprimirListaProductos(listaMateriales As Windows.Forms.ListView, ByVal TitulosDoc As String)
        Try
            auxlista = listaMateriales
            TituloDocumento = TitulosDoc
            PrintDocument2.Print()
        Catch ex As Exception
            MsgBox("Error de impresion debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
            guardar(ex, "imprimir imprimirListaProductos")
        End Try
    End Sub
    Friend Sub VistaListaProductos(listaMateriales As Windows.Forms.ListView, titulosDoc As String)
        Try
            auxlista = listaMateriales
            TituloDocumento = titulosDoc
            printPreviewDialog2.Document = PrintDocument2
            printPreviewDialog2.ShowDialog()
        Catch ex As Exception
            MsgBox("Error de impresion debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
            guardar(ex, "imprimir VistaListaProductos")
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try

            Dim blackPen As New Pen(Color.Black, 1)
            Dim point1 As New PointF(40, 100)
            Dim point2 As New PointF(784, 100) ' Dimension hoja A4 - 8,25 x 11,75 Pulgadas
            Dim xpos As Integer = 50
            Dim ypos As Integer = 100

            e.Graphics.DrawString(TituloDocumento & Date.Now, rowfont, Brushes.Black, 230, 40)

            For Each nombreColum As DataGridViewColumn In datagrid.Columns
                If nombreColum.DisplayIndex <> 0 Then
                    xpos = 100
                End If
                e.Graphics.DrawString(nombreColum.Name, rowfont, Brushes.Black, xpos + (xpos * nombreColum.DisplayIndex), ypos - 20)
                e.Graphics.DrawLine(blackPen, point1, point2)
            Next

            For i As Integer = 0 To datagrid.RowCount - 1
                xpos = 50
                For j As Integer = 0 To datagrid.ColumnCount - 1
                    If j <> 0 Then
                        xpos = 100
                    End If
                    e.Graphics.DrawString(datagrid(j, i).Value, rowfont, Brushes.Black, xpos + (xpos * j), ypos + (25 * i))
                Next
            Next

        Catch ex As Exception
            MsgBox("Error de impresion debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
            guardar(ex, "imprimir PrintDocument1_PrintPage")
        End Try
    End Sub
    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Try

            Dim blackPen As New Pen(Color.Black, 1)
            Dim point1 As New PointF(40, 100)
            Dim point2 As New PointF(784, 100) ' Dimension hoja A4 - 8,25 x 11,75 Pulgadas
            Dim xpos As Integer = 50
            Dim ypos As Integer = 100
            Dim fila As Integer = 0

            e.Graphics.DrawString(TituloDocumento & Date.Now, rowfont, Brushes.Black, 230, 40)

            For i = 0 To auxlista.Columns.Count - 1
                If i <> 0 Then
                    xpos = 100
                End If
                e.Graphics.DrawString(auxlista.Columns.Item(i).Text, rowfont, Brushes.Black, xpos + (xpos * i), ypos - 20)
                e.Graphics.DrawLine(blackPen, point1, point2)
            Next

            For Each item As ListViewItem In auxlista.Items
                xpos = 50
                For j = 0 To item.SubItems.Count - 1
                    If j <> 0 Then
                        xpos = 100
                    End If
                    e.Graphics.DrawString(item.SubItems(j).Text, rowfont, Brushes.Black, xpos + (xpos * j), ypos + (25 * fila))
                Next
                fila += 1
            Next

        Catch ex As Exception
            MsgBox("Error de impresion debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
            guardar(ex, "imprimir PrintDocument2_PrintPage")
        End Try
    End Sub


End Class
