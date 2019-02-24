Imports brl
Public Class PwiIngresos
    Dim brlIngresos As New brlIngresos
    Dim brlCoef As New brlUf
    Dim objCoef As New DataSet
    Public Function obtenerIngresosMes(ByVal mes As Long, ByVal año As Long) As DataSet
        Try
            obtenerIngresosMes = BRLIngresos.obtenerIngresosMes(mes, año)
        Catch ex As Exception
            obtenerIngresosMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function NuevoIngresoMes() As DataSet
        Try

            objCoef.Clear()

            objCoef = brlCoef.obtenerListaUf(-1)
            Dim column As DataColumn


            objCoef.Tables(0).Columns.Add("mes")
            objCoef.Tables(0).Columns.Add("anio")
            objCoef.Tables(0).Columns.Add("expMes")
            objCoef.Tables(0).Columns.Add("expExtra")
            objCoef.Tables(0).Columns.Add("mantEdif")
            column = New DataColumn
            With column
                .ColumnName = "subTotal"
                .DataType = System.Type.GetType("System.Int32")
                .DefaultValue = 0
                objCoef.Tables(0).Columns.Add(column)
            End With
            column = New DataColumn
            With column
                .ColumnName = "reondeo"
                .DefaultValue = 0
            End With
            objCoef.Tables(0).Columns.Add(column)
            column = New DataColumn
            With column
                .ColumnName = "total"
                .DataType = System.Type.GetType("System.Int32")
                .DefaultValue = 0
                objCoef.Tables(0).Columns.Add(column)
            End With


            NuevoIngresoMes = objCoef
            '3. Calcular los valores, segun el importe exp. mes y cargarlos junto a exp extra mant edif total redonde total
            '3.1 Pedi valores de exp mes exp extra y mant edif.
            '3.2 desarrollar la funcion redonde.
            '3.3 sumar totales.
            '4. Una vez cargada la tabla recorrer hacer el alta de datos y visualizar.
        Catch ex As Exception
            NuevoIngresoMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    'Public Function actualizarIngresosMes(ByVal id_uf As Long, ByVal mes As Long, ByVal año As Long, ByVal expMes As Double, ByVal expExtra As Double,
    '                                           ByVal mantEdif As Double, ByVal subTotal As Double, ByVal redondeo As Double, ByVal total As Double) As Integer

    Public Function actualizarIngresosMes(ByVal auxDatagid As DataGridView)

        Try

            If auxDatagid.Rows.Count = 0 Then
                Exit Function
            End If

            For Each row As DataGridViewRow In auxDatagid.Rows
                actualizarIngresosMes = brlIngresos.actualizarIngresosMes(row.Cells(1).Value, 2, 2019, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value)

            Next



        Catch ex As Exception
            actualizarIngresosMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub montoExp(ByVal importe As Integer, ByRef intDefine As Integer)

        For Each row As DataRow In objCoef.Tables(0).Rows()

            Select Case intDefine

                Case 1
                    row.Item(6) = importe * row(2)
                Case 2
                    If row(2) > 0.03 Then
                        row.Item(7) = importe / 15
                    Else
                        row.Item(7) = 0
                    End If
                Case 3
                    row.Item(8) = importe / 20
            End Select

            row.Item(9) = CInt(row.Item(6)) + CInt(row.Item(7)) + CInt(row.Item(8))

            'row.Item(10) = 0
            'row.Item(11) = 0
        Next

    End Sub

End Class
