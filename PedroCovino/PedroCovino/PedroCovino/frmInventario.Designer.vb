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
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStockMax = New System.Windows.Forms.TextBox()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.txtFecAct = New System.Windows.Forms.TextBox()
        Me.txtStockDisp = New System.Windows.Forms.TextBox()
        Me.CbVerTodo = New System.Windows.Forms.CheckBox()
        Me.cboInsumos = New System.Windows.Forms.ComboBox()
        Me.dgInsumosDetalle = New System.Windows.Forms.DataGridView()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbMateriales.SuspendLayout()
        CType(Me.dgInsumosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMateriales
        '
        Me.gbMateriales.Controls.Add(Me.cboProveedores)
        Me.gbMateriales.Controls.Add(Me.Label4)
        Me.gbMateriales.Controls.Add(Me.Label3)
        Me.gbMateriales.Controls.Add(Me.Label2)
        Me.gbMateriales.Controls.Add(Me.Label1)
        Me.gbMateriales.Controls.Add(Me.txtStockMax)
        Me.gbMateriales.Controls.Add(Me.txtStockMin)
        Me.gbMateriales.Controls.Add(Me.txtFecAct)
        Me.gbMateriales.Controls.Add(Me.txtStockDisp)
        Me.gbMateriales.Controls.Add(Me.CbVerTodo)
        Me.gbMateriales.Controls.Add(Me.cboInsumos)
        Me.gbMateriales.Controls.Add(Me.dgInsumosDetalle)
        Me.gbMateriales.Location = New System.Drawing.Point(12, 12)
        Me.gbMateriales.Name = "gbMateriales"
        Me.gbMateriales.Size = New System.Drawing.Size(776, 376)
        Me.gbMateriales.TabIndex = 0
        Me.gbMateriales.TabStop = False
        Me.gbMateriales.Text = "Insumos"
        '
        'cboProveedores
        '
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(6, 16)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(247, 21)
        Me.cboProveedores.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(632, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Stock Máx."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Stock Mín."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fecha Atualizacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Stock Disponible"
        '
        'txtStockMax
        '
        Me.txtStockMax.Location = New System.Drawing.Point(695, 49)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.ReadOnly = True
        Me.txtStockMax.Size = New System.Drawing.Size(69, 20)
        Me.txtStockMax.TabIndex = 12
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(695, 19)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.ReadOnly = True
        Me.txtStockMin.Size = New System.Drawing.Size(69, 20)
        Me.txtStockMin.TabIndex = 11
        '
        'txtFecAct
        '
        Me.txtFecAct.Location = New System.Drawing.Point(548, 49)
        Me.txtFecAct.Name = "txtFecAct"
        Me.txtFecAct.ReadOnly = True
        Me.txtFecAct.Size = New System.Drawing.Size(69, 20)
        Me.txtFecAct.TabIndex = 10
        '
        'txtStockDisp
        '
        Me.txtStockDisp.Location = New System.Drawing.Point(548, 19)
        Me.txtStockDisp.Name = "txtStockDisp"
        Me.txtStockDisp.ReadOnly = True
        Me.txtStockDisp.Size = New System.Drawing.Size(69, 20)
        Me.txtStockDisp.TabIndex = 9
        '
        'CbVerTodo
        '
        Me.CbVerTodo.AutoSize = True
        Me.CbVerTodo.Location = New System.Drawing.Point(361, 47)
        Me.CbVerTodo.Name = "CbVerTodo"
        Me.CbVerTodo.Size = New System.Drawing.Size(70, 17)
        Me.CbVerTodo.TabIndex = 8
        Me.CbVerTodo.Text = "Ver Todo"
        Me.CbVerTodo.UseVisualStyleBackColor = True
        '
        'cboInsumos
        '
        Me.cboInsumos.FormattingEnabled = True
        Me.cboInsumos.Items.AddRange(New Object() {"Arena", "Cal", "Cemento"})
        Me.cboInsumos.Location = New System.Drawing.Point(6, 44)
        Me.cboInsumos.Name = "cboInsumos"
        Me.cboInsumos.Size = New System.Drawing.Size(349, 21)
        Me.cboInsumos.TabIndex = 2
        '
        'dgInsumosDetalle
        '
        Me.dgInsumosDetalle.AllowUserToAddRows = False
        Me.dgInsumosDetalle.AllowUserToDeleteRows = False
        Me.dgInsumosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInsumosDetalle.Location = New System.Drawing.Point(6, 92)
        Me.dgInsumosDetalle.Name = "dgInsumosDetalle"
        Me.dgInsumosDetalle.Size = New System.Drawing.Size(764, 278)
        Me.dgInsumosDetalle.TabIndex = 0
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
        CType(Me.dgInsumosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMateriales As GroupBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents dgInsumosDetalle As DataGridView
    Friend WithEvents cboInsumos As ComboBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnVistaPrevia As Button
    Friend WithEvents CbVerTodo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStockMax As TextBox
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents txtFecAct As TextBox
    Friend WithEvents txtStockDisp As TextBox
    Friend WithEvents cboProveedores As ComboBox
End Class
