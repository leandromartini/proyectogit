<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialesInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialesInventario))
        Me.gbMateriales = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcanprod = New System.Windows.Forms.Label()
        Me.lblCostoInventario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.dgMaterialesStock = New System.Windows.Forms.DataGridView()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.gbMateriales.SuspendLayout()
        CType(Me.dgMaterialesStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMateriales
        '
        Me.gbMateriales.Controls.Add(Me.CheckBox1)
        Me.gbMateriales.Controls.Add(Me.Label5)
        Me.gbMateriales.Controls.Add(Me.lblcanprod)
        Me.gbMateriales.Controls.Add(Me.lblCostoInventario)
        Me.gbMateriales.Controls.Add(Me.Label2)
        Me.gbMateriales.Controls.Add(Me.Label1)
        Me.gbMateriales.Controls.Add(Me.cboMateriales)
        Me.gbMateriales.Controls.Add(Me.dgMaterialesStock)
        Me.gbMateriales.Location = New System.Drawing.Point(12, 12)
        Me.gbMateriales.Name = "gbMateriales"
        Me.gbMateriales.Size = New System.Drawing.Size(776, 376)
        Me.gbMateriales.TabIndex = 0
        Me.gbMateriales.TabStop = False
        Me.gbMateriales.Text = "Materiales "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(360, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "$"
        '
        'lblcanprod
        '
        Me.lblcanprod.AutoSize = True
        Me.lblcanprod.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblcanprod.Location = New System.Drawing.Point(610, 47)
        Me.lblcanprod.Name = "lblcanprod"
        Me.lblcanprod.Size = New System.Drawing.Size(18, 20)
        Me.lblcanprod.TabIndex = 6
        Me.lblcanprod.Text = "0"
        '
        'lblCostoInventario
        '
        Me.lblCostoInventario.AutoSize = True
        Me.lblCostoInventario.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostoInventario.Location = New System.Drawing.Point(374, 47)
        Me.lblCostoInventario.Name = "lblCostoInventario"
        Me.lblCostoInventario.Size = New System.Drawing.Size(42, 20)
        Me.lblCostoInventario.TabIndex = 5
        Me.lblCostoInventario.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad de Productos en Inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Costo de Inventario"
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Items.AddRange(New Object() {"Arena", "Cal", "Cemento"})
        Me.cboMateriales.Location = New System.Drawing.Point(6, 16)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(287, 21)
        Me.cboMateriales.TabIndex = 2
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
        Me.btnVistaPrevia.Image = Global.matuteMateriales.My.Resources.Resources.print_preview
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
        Me.btnImprimir.Image = Global.matuteMateriales.My.Resources.Resources.print
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
        Me.btnVolver.Image = Global.matuteMateriales.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 394)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
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
        'frmMaterialesStock
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
        Me.Name = "frmMaterialesStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock de Materiales"
        Me.gbMateriales.ResumeLayout(False)
        Me.gbMateriales.PerformLayout()
        CType(Me.dgMaterialesStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMateriales As GroupBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents dgMaterialesStock As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcanprod As Label
    Friend WithEvents lblCostoInventario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnVistaPrevia As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
