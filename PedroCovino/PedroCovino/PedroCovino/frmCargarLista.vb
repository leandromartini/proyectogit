Public Class frmCargarLista
    Dim objDalExcel As New DalExcel
    Dim objComun As New Comun
    Private url As String = "C:\proyectosgit\PedroCovino\resources\"
    Private urlXLSDestino As String
    Private openFileDialog = New OpenFileDialog()
    Private Sub frmCargarLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estadoBotones(True)

    End Sub
    Public Sub ChooseFolder()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        ChooseFolder()
    End Sub
    Private Sub BtnCargarXLS_Click(sender As Object, e As EventArgs) Handles BtnCargarXLS.Click

        Try

            openFileDialog.ShowDialog()

            urlXLSDestino = url + openFileDialog.SafeFileName

            System.IO.File.Copy(openFileDialog.FileName, urlXLSDestino)

            estadoBotones(False)

        Catch ex As Exception
            agregar_error(ex, "frmCargarLista BtnCargarXLS")
            objDalExcel.MatarApp()
        End Try

    End Sub

    Private Sub BtnSubirXLS_Click(sender As Object, e As EventArgs) Handles BtnSubirXLS.Click

        Dim objCodigos As DataSet
        Dim c As Cursor = Me.Cursor

        Try

            Me.Cursor = Cursors.WaitCursor

            objDalExcel.AbrirLibro(urlXLSDestino)


            objCodigos = objComun.obtenerCodInsumos(-1)

            Dim codi As Integer = 15

            For rowTable = 0 To objCodigos.Tables(0).Rows.Count - 1

                For row = codi To 6693

                    If objDalExcel.TomarValorCelda(row, 1) = objCodigos.Tables(0).Rows(rowTable).Item(0) Then

                        Me.actulizarRegistroXCodigo(row)

                        codi = row

                        Exit For

                    End If

                Next row


            Next rowTable


            MsgBox("La lista se actualizo EXITO!")

            BtnSubirXLS.Visible = False

            objDalExcel.MatarApp()

            Me.Close()

        Catch ex As Exception
            agregar_error(ex, "frmCargarLista BtnSubirXLS_Click")
            objDalExcel.MatarApp()
        Finally
            Me.Cursor = c
        End Try

    End Sub

    Private Sub actulizarRegistroXCodigo(row)


        Try
            objComun.ActualizarInsumo(objDalExcel.TomarValorCelda(row, 1), objDalExcel.TomarValorCelda(row, 2))

            objComun.ActualizarInsumoPrecios(objDalExcel.TomarValorCelda(row, 1), Math.Round(objDalExcel.TomarValorCelda(row, 3), 2, MidpointRounding.ToEven), CStr(Math.Round(objDalExcel.TomarValorCelda(row, 7), 2, MidpointRounding.ToEven)), CStr(Math.Round(objDalExcel.TomarValorCelda(row, 8))))


            If Not objComun.grabarInsumo() Then
                MsgBox("Error al grabar! Consulte al desarrollador")
                Exit Sub
            End If

        Catch ex As Exception
            agregar_error(ex, "frmCargarLista actulizarRegistroXCodigo")
            objDalExcel.MatarApp()
        End Try
        'codigo = objDalExcel.TomarValorCelda(row, 1)
        'desc = objDalExcel.TomarValorCelda(row, 2)
        'costosiva = objDalExcel.TomarValorCelda(row, 3)
        'costociva = objDalExcel.TomarValorCelda(row, 7)
        'valorPub = objDalExcel.TomarValorCelda(row, 8)
        'MsgBox(CStr(codigo) + " " + desc + " " + CStr(Math.Round(costosiva, 2, MidpointRounding.ToEven)) + " " + CStr(Math.Round(costociva, 2, MidpointRounding.ToEven)) + " " + CStr(Math.Round(valorPub)))
    End Sub

    Private Sub estadoBotones(estado As Boolean)
        BtnCargarXLS.Visible = estado
        BtnSubirXLS.Visible = Not estado
    End Sub


End Class