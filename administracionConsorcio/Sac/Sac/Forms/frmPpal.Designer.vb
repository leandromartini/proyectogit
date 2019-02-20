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
        Me.btnIngresos = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIngresos
        '
        Me.btnIngresos.Location = New System.Drawing.Point(179, 174)
        Me.btnIngresos.Name = "btnIngresos"
        Me.btnIngresos.Size = New System.Drawing.Size(110, 32)
        Me.btnIngresos.TabIndex = 0
        Me.btnIngresos.Text = "Ingresos"
        Me.btnIngresos.UseVisualStyleBackColor = True
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(326, 174)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(110, 32)
        Me.btnInformes.TabIndex = 1
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'frmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 399)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.btnIngresos)
        Me.Name = "frmPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngresos As Button
    Friend WithEvents btnInformes As Button
End Class
