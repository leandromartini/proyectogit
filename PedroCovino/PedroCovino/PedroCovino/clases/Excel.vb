Imports Microsoft.Office.Interop
Public Class DalExcel
    Private _ExcelApplication As New Excel.Application 'Exception.application
    Private _ExcelWorkBook As Excel.Workbook
    Private _ExcelWorkSheet As Excel.Worksheet
    Private FechaInicioProceso As Date
    Private _ExcelFunction As Excel.XlConsolidationFunction

    Public Overloads Sub AbrirLibro(ByVal strRuta As String)
        Try

            _ExcelWorkBook = Me._ExcelApplication.Workbooks.Open(strRuta)
            _ExcelWorkSheet = Me._ExcelWorkBook.Sheets("lista")

        Catch ex As Exception
            agregar_error(ex, "DalExcel AbrirLibro")
        End Try
    End Sub

    Public Function ExisteHoja(ByVal NombreHoja As String) As Boolean
        Try
            Dim i As Integer
            ExisteHoja = False
            For i = 1 To Me._ExcelApplication.Sheets.Count
                If Me._ExcelApplication.Sheets(i).Name = NombreHoja Then
                    ExisteHoja = True
                    Exit Function
                End If
            Next
        Catch ex As Exception
            agregar_error(ex, "DalExcel ExisteHoja")
            ExisteHoja = False
        End Try
    End Function

    Public Function TomarValorCelda(ByVal row As Integer, ByVal col As Integer) As Object
        Try
            TomarValorCelda = Me._ExcelWorkSheet.Range(Me._ExcelWorkSheet.Cells(row, col), Me._ExcelWorkSheet.Cells(row, col)).Value
        Catch ex As Exception
            agregar_error(ex, "DalExcel TomarValorCelda")
        End Try
    End Function

    Public Sub MatarApp()
        Dim proceso As System.Diagnostics.Process()
        proceso = System.Diagnostics.Process.GetProcessesByName("EXCEL")

        For Each opro As System.Diagnostics.Process In proceso
            'antes de iniciar el proceso obtengo la fecha en que inicie el 
            'proceso para detener todos los procesos que excel que inicio
            'mi código durante el proceso
            'If opro.StartTime >= fechaInicioProceso Then
            opro.Kill()
            'End If
        Next
    End Sub
End Class
