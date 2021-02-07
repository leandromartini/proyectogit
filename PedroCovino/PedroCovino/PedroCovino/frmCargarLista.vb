Public Class frmCargarLista
    Dim objDalExcel As New DalExcel
    Private url As String = "C:\proyectogit\PedroCovino\resources\"
    Private urlXLSDestino As String
    Private openFileDialog = New OpenFileDialog()
    Private Sub frmCargarLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estadoBotones(True)

    End Sub

    Private Sub BtnCargarXLS_Click(sender As Object, e As EventArgs) Handles BtnCargarXLS.Click

        Try

            openFileDialog.ShowDialog()

            urlXLSDestino = url + openFileDialog.SafeFileName

            System.IO.File.Copy(openFileDialog.FileName, urlXLSDestino)

            estadoBotones(False)

        Catch ex As Exception
            agregar_error(ex, "frmCargarLista BtnCargarXLS")
        End Try

    End Sub

    Private Sub BtnSubirXLS_Click(sender As Object, e As EventArgs) Handles BtnSubirXLS.Click
        Dim codigo As Integer
        Dim desc As String = ""
        Dim costosiva As Double
        Dim costociva As Double
        Dim valorPub As Double

        objDalExcel.AbrirLibro(urlXLSDestino)

        For row = 1 To 71

            codigo = objDalExcel.TomarValorCelda(row, 1)
            desc = objDalExcel.TomarValorCelda(row, 2)
            costosiva = objDalExcel.TomarValorCelda(row, 3)
            costociva = objDalExcel.TomarValorCelda(row, 7)
            valorPub = objDalExcel.TomarValorCelda(row, 8)
            MsgBox(CStr(codigo) + " " + desc + " " + CStr(Math.Round(costosiva, 2, MidpointRounding.ToEven)) + " " + CStr(Math.Round(costociva, 2, MidpointRounding.ToEven)) + " " + CStr(Math.Round(valorPub)))

        Next row

        MsgBox("Los datos se actualizaron con EXITO!")

        BtnSubirXLS.Visible = False

        objDalExcel.MatarApp()

        Me.Close()

    End Sub
    Private Sub estadoBotones(estado As Boolean)
        BtnCargarXLS.Visible = estado
        BtnSubirXLS.Visible = Not estado
    End Sub
End Class