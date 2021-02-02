<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.gbMateriales = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cboInsumos = New System.Windows.Forms.ComboBox()
        Me.dgMaterialesStock = New System.Windows.Forms.DataGridView()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbMateriales.SuspendLayout()
        CType(Me.dgMaterialesStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMateriales
        '
        Me.gbMateriales.Controls.Add(Me.CheckBox1)
        Me.gbMateriales.Controls.Add(Me.cboInsumos)
        Me.gbMateriales.Controls.Add(Me.dgMaterialesStock)
        Me.gbMateriales.Location = New System.Drawing.Point(12, 12)
        Me.gbMateriales.Name = "gbMateriales"
        Me.gbMateriales.Size = New System.Drawing.Size(776, 376)
        Me.gbMateriales.TabIndex = 0
        Me.gbMateriales.TabStop = False
        Me.gbMateriales.Text = "Insumos"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 51)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Ver Todo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cboInsumos
        '
        Me.cboInsumos.FormattingEnabled = True
        Me.cboInsumos.Items.AddRange(New Object() {"Arena", "Cal", "Cemento"})
        Me.cboInsumos.Location = New System.Drawing.Point(6, 16)
        Me.cboInsumos.Name = "cboInsumos"
        Me.cboInsumos.Size = New System.Drawing.Size(764, 21)
        Me.cboInsumos.TabIndex = 2
        '
        'dgMaterialesStock
        '
        Me.dgMaterialesStock.AllowUserToAddRows = False
        Me.dgMaterialesStock.AllowUserToDeleteRows = False
        Me.dgMaterialesStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMaterialesStock.Location = New System.Drawing.Point(6, 92)
        Me.dgMaterialesStock.Name = "dgMaterialesStock"
        Me.dgMaterialesStock.ReadOnly = True
        Me.dgMaterialesStock.Size = New System.Drawing.Size(764, 278)
        Me.dgMaterialesStock.TabIndex = 0
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Image = Global.PedroCovino.My.Resources.Resources.print_preview
        Me.btnVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVistaPrevia.Location = New System.Drawing.Point(580, 394)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(98, 40)
        Me.btnVistaPrevia.TabIndex = 8
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.PedroCovino.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.Location = New System.Drawing.Point(690, 394)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(98, 40)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.PedroCovino.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 394)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 446)
        Me.Controls.Add(Me.btnVistaPrevia)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gbMateriales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        Me.gbMateriales.ResumeLayout(False)
        Me.gbMateriales.PerformLayout()
        CType(Me.dgMaterialesStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMateriales As GroupBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents dgMaterialesStock As DataGridView
    Friend WithEvents cboInsumos As ComboBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnVistaPrevia As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
