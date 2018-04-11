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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnVector = New System.Windows.Forms.Button()
        Me.btnPersona = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(525, 226)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(108, 23)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnVector
        '
        Me.BtnVector.Location = New System.Drawing.Point(12, 12)
        Me.BtnVector.Name = "BtnVector"
        Me.BtnVector.Size = New System.Drawing.Size(108, 23)
        Me.BtnVector.TabIndex = 2
        Me.BtnVector.Text = "Cargar Vector"
        Me.BtnVector.UseVisualStyleBackColor = True
        '
        'btnPersona
        '
        Me.btnPersona.Location = New System.Drawing.Point(157, 12)
        Me.btnPersona.Name = "btnPersona"
        Me.btnPersona.Size = New System.Drawing.Size(108, 23)
        Me.btnPersona.TabIndex = 3
        Me.btnPersona.Text = "Personas"
        Me.btnPersona.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Leandro Acer!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPersona)
        Me.Controls.Add(Me.BtnVector)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Name = "frmPpal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnVector As Button
    Friend WithEvents btnPersona As Button
    Friend WithEvents Button1 As Button
End Class
