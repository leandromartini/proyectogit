Imports Errores.errores
Public Class frmCargaVector
    Dim a(7) As Integer
    Private objopvec As New opeVector
    Private nonNumberEntered As Boolean = False
    Dim sstring As String
    Dim ModError As New Errores.errores

    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        objopvec.leerVector(a)
        Label2.Text = "La suma del vector es: " & objopvec.sumar(a, 1, 8)
        Label2.Visible = True
    End Sub

    Private Sub Mayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        Dim aux As Integer
        objopvec.leerVector(a)
        objopvec.mayor(a, 1, 7, aux)
        Label2.Text = "El mayor valor del vector es: " & aux
        Label2.Visible = True
    End Sub
    Private Sub btnIguales_Click(sender As Object, e As EventArgs) Handles btnIguales.Click
        Dim cant As Integer
        objopvec.leerVector(a)

        objopvec.iguales(a, 1, 8, cant)
        Label2.Text = "Se encontraron: " & cant & " repetidos"
        Label2.Visible = True
    End Sub

    Function validarllenos() As Boolean
        Dim controlcito As Control
        For Each controlcito In Me.Controls
            If TypeOf controlcito Is TextBox Then
                If controlcito.Text = "" Then
                    Return False
                End If
            End If
        Next
        validarllenos = True
    End Function
    Sub muestraoculta(muestra As Boolean)
        If muestra Then
            btnMayor.Visible = True
            btnSumar.Visible = True
            btnIguales.Visible = True
            btnLimpiar.Visible = True

        Else
            btnMayor.Visible = False
            btnSumar.Visible = False
            btnIguales.Visible = False
            btnLimpiar.Visible = False
            Label2.Visible = False
        End If
    End Sub
    Private Sub cajitas_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        '' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If

    End Sub
    Private Sub cajitas_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            ' Initialize the flag to false.
            nonNumberEntered = False
            ' Determine whether the keystroke is a number from the top of the keyboard.
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' Determine whether the keystroke is a backspace.
                    If e.KeyCode <> Keys.Back Then
                        ' A non-numerical keystroke was pressed. 
                        ' Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = True
                    End If
                End If
            End If
            'If shift key was pressed, it's not a number.
            If Control.ModifierKeys = Keys.Shift Then
                nonNumberEntered = True
            End If

        Catch ex As Exception
            MsgBox("Se encontro el siguiente error: " & ex.Message)
        End Try
    End Sub
    Private Sub cajitas_Keyup(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        muestraoculta(validarllenos())
    End Sub

    Sub limpiar()
        Dim controlcito As Control
        For Each controlcito In Me.Controls
            If TypeOf controlcito Is TextBox Then
                controlcito.Text = ""
            End If
        Next

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        muestraoculta(False)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
        muestraoculta(False)
        Me.Close()
    End Sub

    Private Sub frmCargaVector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim textBoxes = Me.Controls.OfType(Of TextBox)()
            For Each txt In textBoxes
                AddHandler txt.KeyPress, AddressOf cajitas_KeyPress
                AddHandler txt.KeyUp, AddressOf cajitas_Keyup
                AddHandler txt.KeyDown, AddressOf cajitas_Keydown
            Next

        Catch ex As Exception
            sstring = ex.Message
            imprimir(sstring)
            MsgBox("Se encontro el siguiente error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        ReDim a(a.Count + 1)

    End Sub
End Class