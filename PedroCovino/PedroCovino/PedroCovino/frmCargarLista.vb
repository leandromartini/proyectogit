Public Class frmCargarLista
    Private url As String
    Private urlXLSDestino As String
    Private openFileDialog = New OpenFileDialog()
    Private objDalExcel As New DalExcel
    Private objComun As New Comun
    Private Sub frmCargarLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estadoBotones(True)
        url = txtPath.Text
    End Sub
    Public Sub ChooseFolder()

        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txtPath.Text = FolderBrowserDialog1.SelectedPath
            End If
            url = txtPath.Text
        Catch ex As Exception
            agregar_error(ex, "frmCargarLista ChooseFolder")
        End Try

    End Sub
    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        ChooseFolder()
    End Sub
    Private Sub BtnCargarXLS_Click(sender As Object, e As EventArgs) Handles BtnCargarXLS.Click
        Dim c As Cursor = Cursor
        Try

            openFileDialog.ShowDialog()

            urlXLSDestino = url + openFileDialog.SafeFileName

            If System.IO.File.Exists(urlXLSDestino) Then
                Dim ask As MsgBoxResult = MsgBox("El archivo seleccionado ya existe en la carpeta! Desea volver a cargarlo?", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.No Then
                    Exit Sub
                Else
                    IO.File.Delete(urlXLSDestino)
                    MsgBox("Se elimino con exito, prosiga subiendo nuevamente el archivo!")
                End If
            End If

            IO.File.Copy(openFileDialog.FileName, urlXLSDestino)

            estadoBotones(False)

        Catch ex As Exception
            agregar_error(ex, "frmCargarLista BtnCargarXLS")
            objDalExcel.MatarApp()
        End Try

    End Sub

    Private Sub BtnSubirXLS_Click(sender As Object, e As EventArgs) Handles BtnSubirXLS.Click
        Dim IntError As Integer = 0
        Dim objCodigos As DataSet
        Dim s As Cursor = Cursor

        Try

            Cursor = Cursors.WaitCursor

            objDalExcel.AbrirLibro(IntError, urlXLSDestino)
            If IntError > 0 Then
                MsgBox("Error al abrir excel. Consulte con el desarrollador")
                Exit Sub
            End If

            objCodigos = objComun.obtenerCodInsumos(-1)

            Dim codi As Integer = 15

            For rowTable = 0 To objCodigos.Tables(0).Rows.Count - 1

                For row = codi To 1664

                    If objDalExcel.TomarValorCelda(row, 1) = objCodigos.Tables(0).Rows(rowTable).Item(0) Then

                        Me.actulizarRegistroXCodigo(row)

                        codi = row

                        Exit For

                    End If

                Next row


            Next rowTable

            Cursor = s

            MsgBox("La lista se actualizo EXITO!")

            BtnSubirXLS.Visible = False

            objDalExcel.close()

        Catch ex As Exception
            agregar_error(ex, "frmCargarLista BtnSubirXLS_Click")
            objDalExcel.MatarApp()
            Cursor = s
        Finally
            Cursor = s
            Me.Close()
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