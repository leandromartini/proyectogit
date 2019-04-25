<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialesAgrega
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
        Me.listaMateriales = New System.Windows.Forms.ListView()
        Me.Col_Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_ProductoCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_PrecioTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grupoAgregarProducto = New System.Windows.Forms.GroupBox()
        Me.txtPrecioUnidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.grupoNuevoProducto = New System.Windows.Forms.GroupBox()
        Me.txtNombreProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.txtProdDescrip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnProdGuardar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificaPrecio = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grupoAgregarProducto.SuspendLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoNuevoProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaMateriales
        '
        Me.listaMateriales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Producto, Me.Col_ProductoCantidad, Me.Col_Precio, Me.col_PrecioTotal})
        Me.listaMateriales.Location = New System.Drawing.Point(391, 19)
        Me.listaMateriales.Name = "listaMateriales"
        Me.listaMateriales.Size = New System.Drawing.Size(379, 299)
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
        Me.Col_ProductoCantidad.Width = 62
        '
        'Col_Precio
        '
        Me.Col_Precio.Text = "Precio Unidad"
        Me.Col_Precio.Width = 88
        '
        'col_PrecioTotal
        '
        Me.col_PrecioTotal.Text = "Total"
        '
        'grupoAgregarProducto
        '
        Me.grupoAgregarProducto.Controls.Add(Me.grupoNuevoProducto)
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
        Me.grupoAgregarProducto.Location = New System.Drawing.Point(12, 12)
        Me.grupoAgregarProducto.Name = "grupoAgregarProducto"
        Me.grupoAgregarProducto.Size = New System.Drawing.Size(776, 337)
        Me.grupoAgregarProducto.TabIndex = 1
        Me.grupoAgregarProducto.TabStop = False
        Me.grupoAgregarProducto.Text = "Agregar Productos"
        '
        'txtPrecioUnidad
        '
        Me.txtPrecioUnidad.Enabled = False
        Me.txtPrecioUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnidad.Location = New System.Drawing.Point(196, 70)
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
        Me.Label2.Location = New System.Drawing.Point(153, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(61, 69)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(52, 20)
        Me.numCantidad.TabIndex = 3
        Me.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad"
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Items.AddRange(New Object() {"Arena", "Cal", "Cementa"})
        Me.cboMateriales.Location = New System.Drawing.Point(6, 19)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(305, 21)
        Me.cboMateriales.TabIndex = 1
        '
        'grupoNuevoProducto
        '
        Me.grupoNuevoProducto.Controls.Add(Me.btnProdGuardar)
        Me.grupoNuevoProducto.Controls.Add(Me.BtnBorrar)
        Me.grupoNuevoProducto.Controls.Add(Me.BtnNuevo)
        Me.grupoNuevoProducto.Controls.Add(Me.Label5)
        Me.grupoNuevoProducto.Controls.Add(Me.txtProdDescrip)
        Me.grupoNuevoProducto.Controls.Add(Me.txtPrecioProd)
        Me.grupoNuevoProducto.Controls.Add(Me.Label4)
        Me.grupoNuevoProducto.Controls.Add(Me.Label3)
        Me.grupoNuevoProducto.Controls.Add(Me.txtNombreProd)
        Me.grupoNuevoProducto.Location = New System.Drawing.Point(9, 122)
        Me.grupoNuevoProducto.Name = "grupoNuevoProducto"
        Me.grupoNuevoProducto.Size = New System.Drawing.Size(302, 196)
        Me.grupoNuevoProducto.TabIndex = 10
        Me.grupoNuevoProducto.TabStop = False
        Me.grupoNuevoProducto.Text = "Nuevo Producto"
        '
        'txtNombreProd
        '
        Me.txtNombreProd.Enabled = False
        Me.txtNombreProd.Location = New System.Drawing.Point(99, 24)
        Me.txtNombreProd.Name = "txtNombreProd"
        Me.txtNombreProd.Size = New System.Drawing.Size(193, 20)
        Me.txtNombreProd.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombre Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(36, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Precio ($)"
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Enabled = False
        Me.txtPrecioProd.Location = New System.Drawing.Point(99, 55)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(71, 20)
        Me.txtPrecioProd.TabIndex = 13
        '
        'txtProdDescrip
        '
        Me.txtProdDescrip.Enabled = False
        Me.txtProdDescrip.Location = New System.Drawing.Point(99, 88)
        Me.txtProdDescrip.Multiline = True
        Me.txtProdDescrip.Name = "txtProdDescrip"
        Me.txtProdDescrip.Size = New System.Drawing.Size(193, 49)
        Me.txtProdDescrip.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(27, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Drescripcion"
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.listView.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 355)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.listView.My.Resources.Resources.save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(693, 355)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnProdGuardar
        '
        Me.btnProdGuardar.Enabled = False
        Me.btnProdGuardar.Image = Global.listView.My.Resources.Resources.save1
        Me.btnProdGuardar.Location = New System.Drawing.Point(247, 146)
        Me.btnProdGuardar.Name = "btnProdGuardar"
        Me.btnProdGuardar.Size = New System.Drawing.Size(45, 40)
        Me.btnProdGuardar.TabIndex = 18
        Me.btnProdGuardar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Image = Global.listView.My.Resources.Resources.cancel
        Me.BtnBorrar.Location = New System.Drawing.Point(172, 146)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(45, 40)
        Me.BtnBorrar.TabIndex = 17
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.listView.My.Resources.Resources.add
        Me.BtnNuevo.Location = New System.Drawing.Point(99, 146)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(45, 40)
        Me.BtnNuevo.TabIndex = 16
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificaPrecio
        '
        Me.btnModificaPrecio.Image = Global.listView.My.Resources.Resources.edit
        Me.btnModificaPrecio.Location = New System.Drawing.Point(272, 61)
        Me.btnModificaPrecio.Name = "btnModificaPrecio"
        Me.btnModificaPrecio.Size = New System.Drawing.Size(39, 36)
        Me.btnModificaPrecio.TabIndex = 9
        Me.btnModificaPrecio.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Image = Global.listView.My.Resources.Resources.refresh
        Me.btnReset.Location = New System.Drawing.Point(331, 197)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(45, 40)
        Me.btnReset.TabIndex = 8
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.listView.My.Resources.Resources.undo
        Me.btnQuitar.Location = New System.Drawing.Point(331, 140)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(45, 40)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.listView.My.Resources.Resources.redo
        Me.btnAgregar.Location = New System.Drawing.Point(331, 84)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 40)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'MaterialesAgrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 407)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grupoAgregarProducto)
        Me.Name = "MaterialesAgrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Materiales"
        Me.grupoAgregarProducto.ResumeLayout(False)
        Me.grupoAgregarProducto.PerformLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoNuevoProducto.ResumeLayout(False)
        Me.grupoNuevoProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaMateriales As Windows.Forms.ListView
    Friend WithEvents Col_Producto As ColumnHeader
    Friend WithEvents Col_ProductoCantidad As ColumnHeader
    Friend WithEvents Col_Precio As ColumnHeader
    Friend WithEvents grupoAgregarProducto As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPrecioUnidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents col_PrecioTotal As ColumnHeader
    Friend WithEvents btnModificaPrecio As Button
    Friend WithEvents grupoNuevoProducto As GroupBox
    Friend WithEvents btnProdGuardar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdDescrip As TextBox
    Friend WithEvents txtPrecioProd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreProd As TextBox
End Class
