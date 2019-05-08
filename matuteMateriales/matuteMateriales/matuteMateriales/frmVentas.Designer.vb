<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.grupoAgregarProducto = New System.Windows.Forms.GroupBox()
        Me.lbUnidad = New System.Windows.Forms.Label()
        Me.btnModificaPrecio = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecioUnidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.listaMateriales = New System.Windows.Forms.ListView()
        Me.Col_Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_ProductoCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_PrecioTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Identificador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoPago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVistaPevia = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grupoAgregarProducto.SuspendLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoAgregarProducto
        '
        Me.grupoAgregarProducto.Controls.Add(Me.RadioButton3)
        Me.grupoAgregarProducto.Controls.Add(Me.RadioButton2)
        Me.grupoAgregarProducto.Controls.Add(Me.RadioButton1)
        Me.grupoAgregarProducto.Controls.Add(Me.lbUnidad)
        Me.grupoAgregarProducto.Controls.Add(Me.btnModificaPrecio)
        Me.grupoAgregarProducto.Controls.Add(Me.btnReset)
        Me.grupoAgregarProducto.Controls.Add(Me.btnQuitar)
        Me.grupoAgregarProducto.Controls.Add(Me.btnAgregar)
        Me.grupoAgregarProducto.Controls.Add(Me.txtPrecioUnidad)
        Me.grupoAgregarProducto.Controls.Add(Me.Label2)
        Me.grupoAgregarProducto.Controls.Add(Me.numCantidad)
        Me.grupoAgregarProducto.Controls.Add(Me.Label1)
        Me.grupoAgregarProducto.Controls.Add(Me.cboMateriales)
        Me.grupoAgregarProducto.Controls.Add(Me.listaMateriales)
        Me.grupoAgregarProducto.Location = New System.Drawing.Point(9, 12)
        Me.grupoAgregarProducto.Name = "grupoAgregarProducto"
        Me.grupoAgregarProducto.Size = New System.Drawing.Size(779, 344)
        Me.grupoAgregarProducto.TabIndex = 2
        Me.grupoAgregarProducto.TabStop = False
        Me.grupoAgregarProducto.Text = "Agregar a la lista"
        '
        'lbUnidad
        '
        Me.lbUnidad.AutoSize = True
        Me.lbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnidad.Location = New System.Drawing.Point(117, 57)
        Me.lbUnidad.Name = "lbUnidad"
        Me.lbUnidad.Size = New System.Drawing.Size(28, 15)
        Me.lbUnidad.TabIndex = 11
        Me.lbUnidad.Text = "[Kg]"
        '
        'btnModificaPrecio
        '
        Me.btnModificaPrecio.Image = Global.listView.My.Resources.Resources.edit
        Me.btnModificaPrecio.Location = New System.Drawing.Point(289, 48)
        Me.btnModificaPrecio.Name = "btnModificaPrecio"
        Me.btnModificaPrecio.Size = New System.Drawing.Size(39, 36)
        Me.btnModificaPrecio.TabIndex = 9
        Me.btnModificaPrecio.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Image = Global.listView.My.Resources.Resources.refresh
        Me.btnReset.Location = New System.Drawing.Point(337, 210)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(45, 40)
        Me.btnReset.TabIndex = 8
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.listView.My.Resources.Resources.undo
        Me.btnQuitar.Location = New System.Drawing.Point(337, 153)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(45, 40)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.listView.My.Resources.Resources.redo
        Me.btnAgregar.Location = New System.Drawing.Point(337, 97)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 40)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecioUnidad
        '
        Me.txtPrecioUnidad.Enabled = False
        Me.txtPrecioUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnidad.Location = New System.Drawing.Point(215, 56)
        Me.txtPrecioUnidad.Multiline = True
        Me.txtPrecioUnidad.Name = "txtPrecioUnidad"
        Me.txtPrecioUnidad.Size = New System.Drawing.Size(70, 19)
        Me.txtPrecioUnidad.TabIndex = 5
        Me.txtPrecioUnidad.Text = "0,00"
        Me.txtPrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(64, 55)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(52, 20)
        Me.numCantidad.TabIndex = 3
        Me.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad"
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Location = New System.Drawing.Point(10, 19)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(318, 21)
        Me.cboMateriales.TabIndex = 1
        '
        'listaMateriales
        '
        Me.listaMateriales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Producto, Me.Col_ProductoCantidad, Me.Col_Precio, Me.col_PrecioTotal, Me.TipoPago, Me.col_Identificador})
        Me.listaMateriales.Location = New System.Drawing.Point(391, 19)
        Me.listaMateriales.Name = "listaMateriales"
        Me.listaMateriales.Size = New System.Drawing.Size(381, 317)
        Me.listaMateriales.TabIndex = 0
        Me.listaMateriales.UseCompatibleStateImageBehavior = False
        Me.listaMateriales.View = System.Windows.Forms.View.Details
        '
        'Col_Producto
        '
        Me.Col_Producto.Text = "Producto"
        Me.Col_Producto.Width = 174
        '
        'Col_ProductoCantidad
        '
        Me.Col_ProductoCantidad.Text = "Cantidad"
        Me.Col_ProductoCantidad.Width = 76
        '
        'Col_Precio
        '
        Me.Col_Precio.Text = "Precio"
        Me.Col_Precio.Width = 88
        '
        'col_PrecioTotal
        '
        Me.col_PrecioTotal.Text = "Total"
        '
        'col_Identificador
        '
        Me.col_Identificador.DisplayIndex = 4
        Me.col_Identificador.Text = "Identificador"
        '
        'TipoPago
        '
        Me.TipoPago.DisplayIndex = 5
        Me.TipoPago.Text = "col_TipoPago"
        '
        'btnVistaPevia
        '
        Me.btnVistaPevia.Image = Global.listView.My.Resources.Resources.print_preview
        Me.btnVistaPevia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVistaPevia.Location = New System.Drawing.Point(487, 362)
        Me.btnVistaPevia.Name = "btnVistaPevia"
        Me.btnVistaPevia.Size = New System.Drawing.Size(98, 40)
        Me.btnVistaPevia.TabIndex = 15
        Me.btnVistaPevia.Text = "Vista Previa"
        Me.btnVistaPevia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVistaPevia.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.listView.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.Location = New System.Drawing.Point(592, 362)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 40)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.listView.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(9, 362)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.listView.My.Resources.Resources.save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(693, 362)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 40)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(145, 143)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton3.TabIndex = 32
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Cheque"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(81, 143)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 31
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Tarjeta"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(10, 143)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton1.TabIndex = 30
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Contado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 409)
        Me.Controls.Add(Me.btnVistaPevia)
        Me.Controls.Add(Me.grupoAgregarProducto)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.grupoAgregarProducto.ResumeLayout(False)
        Me.grupoAgregarProducto.PerformLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grupoAgregarProducto As GroupBox
    Friend WithEvents lbUnidad As Label
    Friend WithEvents btnModificaPrecio As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPrecioUnidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents listaMateriales As Windows.Forms.ListView
    Friend WithEvents Col_Producto As ColumnHeader
    Friend WithEvents Col_ProductoCantidad As ColumnHeader
    Friend WithEvents Col_Precio As ColumnHeader
    Friend WithEvents col_PrecioTotal As ColumnHeader
    Friend WithEvents TipoPago As ColumnHeader
    Friend WithEvents col_Identificador As ColumnHeader
    Friend WithEvents btnVistaPevia As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
