Imports System.Text.RegularExpressions

Public Class pwiComun
    Public Function ValidarNumericoDecimal(ByVal number As String) As Boolean
        If String.IsNullOrWhiteSpace(number) Then
            Return False
        End If
        Return Regex.IsMatch(CStr(number),
                  "^[0-9]+(\.[0-9]{1,2})?$")
    End Function
End Class
