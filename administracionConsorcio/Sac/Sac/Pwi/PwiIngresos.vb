Imports brl
Imports System.Math
Public Class PwiIngresos
    Dim objAuxIngresos As DataSet

    Public Function obtenerIngresosMes(ByVal id_cons As Long, ByVal mes As Long, ByVal año As Long, ByVal id_uf As Long) As DataSet
        Try
            Dim brlIngresos As New brlIngresos
            obtenerIngresosMes = brlIngresos.obtenerIngresosMes(id_cons, mes, año, id_uf)
        Catch ex As Exception
            obtenerIngresosMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function NuevoIngresoMes() As DataSet

        Dim brlCoef As New brlUf
        Dim objCoef As New DataSet
        objAuxIngresos = New DataSet
        Dim objIngresos As New DataSet

        Try

            objCoef = brlCoef.obtenerListaUf(-1)

            objIngresos = obtenerIngresosMes(-1, -1, -1, -1)
            For i = 0 To 2
                objIngresos.Tables(0).Columns.RemoveAt(0)
            Next
            Dim column As DataColumn
            objAuxIngresos.Merge(objCoef)

            For Each columns As DataColumn In objIngresos.Tables(0).Columns
                column = New DataColumn
                With column
                    .ColumnName = columns.ColumnName
                    .DataType = System.Type.GetType("System.Double")
                    .DefaultValue = 0
                    objAuxIngresos.Tables(0).Columns.Add(column)
                End With
            Next

            NuevoIngresoMes = objAuxIngresos

            '4. Una vez cargada la tabla recorrer hacer el alta de datos y visualizar.
        Catch ex As Exception
            NuevoIngresoMes = Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function actualizarIngresosMes(ByVal auxDatagid As DataGridView, ByVal id_cons As Long, ByVal mes As Long, ByVal año As Long) As Boolean

        Dim brlIngresos As New brlIngresos
        actualizarIngresosMes = False

        Try

            If auxDatagid.Rows.Count = 0 Then
                actualizarIngresosMes = False
                Exit Function
            End If

            For Each row As DataGridViewRow In auxDatagid.Rows
                actualizarIngresosMes = brlIngresos.actualizarIngresosMes(row.Cells("id_uf").Value, id_cons, mes, año, row.Cells("expMes").Value, row.Cells("expExtra").Value, row.Cells("mantEdif").Value, row.Cells("subTotal").Value, row.Cells("redondeo").Value, row.Cells("total").Value)

            Next

        Catch ex As Exception
            actualizarIngresosMes = False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub MontoExp(ByVal importe As Integer, ByRef intDefine As Integer)

        For Each row As DataRow In objAuxIngresos.Tables(0).Rows()

            Select Case intDefine

                Case 1
                    row("expMes") = importe * row("coef")

                Case 2
                    If row("coef") > 0.03 Then
                        row("expExtra") = importe / 15
                    Else
                        row("expExtra") = 0
                    End If
                Case 3
                    row("mantEdif") = importe / 20
            End Select

            row("subTotal") = Decimal.Round(row("expMes") + row("expExtra") + row("mantEdif"), 1)
            row("redondeo") = IIf(Decimal.Round(row("subTotal")) - CDec(row("subTotal")) = -0.5, 0.5, Decimal.Round(row("subTotal")) - CDec(row("subTotal")))
            row("total") = Decimal.Round(row("subTotal") + row("redondeo"), 1)

        Next

    End Sub

End Class
