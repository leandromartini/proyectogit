<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaDeudas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAltaDeuda = New System.Windows.Forms.Button()
        Me.txtIdentificador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cboTposDeudas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAltaDeuda
        '
        Me.btnAltaDeuda.Location = New System.Drawing.Point(527, 46)
        Me.btnAltaDeuda.Name = "btnAltaDeuda"
        Me.btnAltaDeuda.Size = New System.Drawing.Size(95, 30)
        Me.btnAltaDeuda.TabIndex = 0
        Me.btnAltaDeuda.Text = "Alta"
        Me.btnAltaDeuda.UseVisualStyleBackColor = True
        '
        'txtIdentificador
        '
        Me.txtIdentificador.Location = New System.Drawing.Point(125, 34)
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.ReadOnly = True
        Me.txtIdentificador.Size = New System.Drawing.Size(165, 20)
        Me.txtIdentificador.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Identificador."
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(125, 106)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(165, 20)
        Me.txtMonto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TpoDeuda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 184)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(90, 28)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'cboTposDeudas
        '
        Me.cboTposDeudas.FormattingEnabled = True
        Me.cboTposDeudas.Location = New System.Drawing.Point(125, 71)
        Me.cboTposDeudas.Name = "cboTposDeudas"
        Me.cboTposDeudas.Size = New System.Drawing.Size(165, 21)
        Me.cboTposDeudas.TabIndex = 8
        '
        'frmAltaDeudas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 224)
        Me.Controls.Add(Me.cboTposDeudas)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdentificador)
        Me.Controls.Add(Me.btnAltaDeuda)
        Me.Name = "frmAltaDeudas"
        Me.Text = "frmAltaDeudas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAltaDeuda As Button
    Friend WithEvents txtIdentificador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents cboTposDeudas As ComboBox
End Class
