Imports System.Text.RegularExpressions

Public Class pwiComun
    Public Function ValidarNumericoDecimal(ByVal number As String) As Boolean
        If String.IsNullOrWhiteSpace(number) Then
            Return False
        End If
        Return Regex.IsMatch(CStr(number),
                  "^[0-9]+(\.[0-9]{1,2})?$")
    End Function
    Public Function SumarColumnaDatagrid(ByVal DataGrid As DataGridView, ByVal NombreColumna As String) As Double
        Try
            SumarColumnaDatagrid = 0
            For Each row As DataGridViewRow In DataGrid.Rows
                If Not IsDBNull(row.Cells(NombreColumna).Value) Then
                    SumarColumnaDatagrid = SumarColumnaDatagrid + CDec(row.Cells(NombreColumna).Value)
                End If
            Next
        Catch ex As Exception
            SumarColumnaDatagrid = 0
            MsgBox(ex.Message)
        End Try
    End Function
End Class
