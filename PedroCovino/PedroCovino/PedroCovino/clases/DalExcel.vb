Imports Microsoft.Office.Interop
Public Class DalExcel
    Implements IDisposable
    Private _ExcelApplication As New Excel.Application
    Private _ExcelWorkBook As Excel.Workbook
    Private _ExcelWorkSheet As Excel.Worksheet

    Private Sub init(ByVal visible As Boolean)
        Try
            If Me._ExcelApplication Is Nothing Then
                Me._ExcelApplication = New Excel.Application
                Me._ExcelApplication.Visible = visible
            End If
        Catch ex As Exception
            agregar_error(ex, "DalExcel init")
        End Try
    End Sub

    Public Overloads Sub AbrirLibro(ByRef Interror As Integer, strRuta As String)

        Try
            If Me._ExcelApplication Is Nothing Then init(False)

            _ExcelWorkBook = Me._ExcelApplication.Workbooks.Open(strRuta)
            _ExcelWorkSheet = Me._ExcelWorkBook.Sheets("lista")

        Catch ex As Exception
            agregar_error(ex, "DalExcel AbrirLibro")
            Interror = 10000
        End Try
    End Sub

    Public Function ExisteHoja(ByVal NombreHoja As String) As Boolean
        Try
            If Me._ExcelApplication Is Nothing Then init(True)
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

    Public Overloads Sub SeleccionarRango(ByVal arrErrores() As String, ByVal FilaDesde As Integer,
 ByVal FilaHasta As Integer, ByVal ColumnaDesde As Integer, ByVal ColumnaHasta As Integer, ByVal worksheetName As String)
        Me._ExcelWorkBook.Worksheets(worksheetName).Range(Me._ExcelWorkSheet.Cells(FilaDesde, ColumnaDesde), Me._ExcelWorkSheet.Cells(FilaHasta, ColumnaHasta)).Select()
    End Sub

    Public Sub close()

        _ExcelWorkSheet = Nothing
        _ExcelWorkBook = Nothing
        _ExcelApplication.Quit()
        _ExcelApplication = Nothing


    End Sub
    Public Sub Dispose() Implements System.IDisposable.Dispose
    End Sub
End Class
