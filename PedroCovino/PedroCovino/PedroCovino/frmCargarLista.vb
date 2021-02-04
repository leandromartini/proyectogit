Public Class frmCargarLista
    Dim objDalExcel As New DalExcel
    Private Sub frmCargarLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objDalExcel.AbrirLibro("C:\Users\leandro.lacrouts\Desktop\primeraHoja.xls")

        objDalExcel.ExisteHoja("encontrame")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog = New OpenFileDialog()
        openFileDialog.ShowDialog()
        If openFileDialog.CheckFileExists Then
            MsgBox("existe")
        End If

        MsgBox(openFileDialog.FileName)
        openFileDialog.OpenFile()


    End Sub
End Class