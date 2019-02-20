<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresos
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
        Me.dgIngresos = New System.Windows.Forms.DataGridView()
        Me.DtpMesIngreso = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgIngresos
        '
        Me.dgIngresos.AllowUserToAddRows = False
        Me.dgIngresos.AllowUserToDeleteRows = False
        Me.dgIngresos.AllowUserToOrderColumns = True
        Me.dgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIngresos.Location = New System.Drawing.Point(12, 58)
        Me.dgIngresos.Name = "dgIngresos"
        Me.dgIngresos.ReadOnly = True
        Me.dgIngresos.Size = New System.Drawing.Size(776, 308)
        Me.dgIngresos.TabIndex = 0
        '
        'DtpMesIngreso
        '
        Me.DtpMesIngreso.CustomFormat = "MMMM"
        Me.DtpMesIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpMesIngreso.Location = New System.Drawing.Point(12, 21)
        Me.DtpMesIngreso.Name = "DtpMesIngreso"
        Me.DtpMesIngreso.Size = New System.Drawing.Size(74, 20)
        Me.DtpMesIngreso.TabIndex = 1
        '
        'frmIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DtpMesIngreso)
        Me.Controls.Add(Me.dgIngresos)
        Me.Name = "frmIngresos"
        Me.Text = "Ingresos"
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgIngresos As DataGridView
    Friend WithEvents DtpMesIngreso As DateTimePicker
End Class
