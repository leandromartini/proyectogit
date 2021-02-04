Imports Microsoft.Office.Interop
Public Class DalExcel
    Private _ExcelApplication As Excel.Application 'Exception.application
    Private _ExcelWorkBook As Excel.Workbook
    Private _ExcelWorkSheet As Excel.Worksheet
    Private FechaInicioProceso As Date
    Private _ExcelFunction As Excel.XlConsolidationFunction

    Public Overloads Sub AbrirLibro(ByVal strRuta As String)
        Try

            Me._ExcelWorkBook = Me._ExcelApplication.Workbooks.Open(strRuta)
            Me._ExcelWorkSheet = Me._ExcelWorkBook.ActiveSheet
        Catch ex As Exception

            Throw ex
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

            Throw ex
        End Try
    End Function
End Class
