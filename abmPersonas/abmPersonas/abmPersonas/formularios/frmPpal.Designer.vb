<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPpal
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
        Me.btnPersonas = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPersonas
        '
        Me.btnPersonas.Location = New System.Drawing.Point(146, 101)
        Me.btnPersonas.Name = "btnPersonas"
        Me.btnPersonas.Size = New System.Drawing.Size(128, 28)
        Me.btnPersonas.TabIndex = 0
        Me.btnPersonas.Text = "Altas Personas"
        Me.btnPersonas.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Location = New System.Drawing.Point(313, 101)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(123, 27)
        Me.btnCobrar.TabIndex = 1
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'frmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 261)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.btnPersonas)
        Me.Name = "frmPpal"
        Me.Text = "frmPpal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPersonas As Button
    Friend WithEvents btnCobrar As Button
End Class
