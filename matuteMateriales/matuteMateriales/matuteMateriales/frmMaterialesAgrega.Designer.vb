﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialesAgrega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialesAgrega))
        Me.listaMateriales = New System.Windows.Forms.ListView()
        Me.Col_Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_ProductoCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_PrecioTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grupoAgregarProducto = New System.Windows.Forms.GroupBox()
        Me.grupoNuevoProducto = New System.Windows.Forms.GroupBox()
        Me.btnProdGuardar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProdDescrip = New System.Windows.Forms.TextBox()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreProd = New System.Windows.Forms.TextBox()
        Me.btnModificaPrecio = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecioUnidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVistaPevia = New System.Windows.Forms.Button()
        Me.lbUnidad = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.grupoAgregarProducto.SuspendLayout()
        Me.grupoNuevoProducto.SuspendLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaMateriales
        '
        Me.listaMateriales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Producto, Me.Col_ProductoCantidad, Me.Col_Precio, Me.col_PrecioTotal})
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
        Me.grupoAgregarProducto.Controls.Add(Me.lbUnidad)
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
        Me.grupoAgregarProducto.Size = New System.Drawing.Size(779, 348)
        Me.grupoAgregarProducto.TabIndex = 1
        Me.grupoAgregarProducto.TabStop = False
        Me.grupoAgregarProducto.Text = "Agregar a la lista"
        '
        'grupoNuevoProducto
        '
        Me.grupoNuevoProducto.Controls.Add(Me.RadioButton4)
        Me.grupoNuevoProducto.Controls.Add(Me.btnProdGuardar)
        Me.grupoNuevoProducto.Controls.Add(Me.RadioButton3)
        Me.grupoNuevoProducto.Controls.Add(Me.BtnBorrar)
        Me.grupoNuevoProducto.Controls.Add(Me.RadioButton2)
        Me.grupoNuevoProducto.Controls.Add(Me.BtnNuevo)
        Me.grupoNuevoProducto.Controls.Add(Me.RadioButton1)
        Me.grupoNuevoProducto.Controls.Add(Me.Label5)
        Me.grupoNuevoProducto.Controls.Add(Me.txtProdDescrip)
        Me.grupoNuevoProducto.Controls.Add(Me.txtPrecioProd)
        Me.grupoNuevoProducto.Controls.Add(Me.Label4)
        Me.grupoNuevoProducto.Controls.Add(Me.Label3)
        Me.grupoNuevoProducto.Controls.Add(Me.txtNombreProd)
        Me.grupoNuevoProducto.Location = New System.Drawing.Point(9, 97)
        Me.grupoNuevoProducto.Name = "grupoNuevoProducto"
        Me.grupoNuevoProducto.Size = New System.Drawing.Size(319, 239)
        Me.grupoNuevoProducto.TabIndex = 10
        Me.grupoNuevoProducto.TabStop = False
        Me.grupoNuevoProducto.Text = "Nuevo Producto"
        '
        'btnProdGuardar
        '
        Me.btnProdGuardar.Enabled = False
        Me.btnProdGuardar.Image = Global.listView.My.Resources.Resources.save
        Me.btnProdGuardar.Location = New System.Drawing.Point(264, 187)
        Me.btnProdGuardar.Name = "btnProdGuardar"
        Me.btnProdGuardar.Size = New System.Drawing.Size(45, 40)
        Me.btnProdGuardar.TabIndex = 18
        Me.btnProdGuardar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Image = Global.listView.My.Resources.Resources.cancel
        Me.BtnBorrar.Location = New System.Drawing.Point(188, 187)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(45, 40)
        Me.BtnBorrar.TabIndex = 17
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.listView.My.Resources.Resources.add
        Me.BtnNuevo.Location = New System.Drawing.Point(112, 187)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(45, 40)
        Me.BtnNuevo.TabIndex = 16
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Drescripcion"
        '
        'txtProdDescrip
        '
        Me.txtProdDescrip.Enabled = False
        Me.txtProdDescrip.Location = New System.Drawing.Point(112, 126)
        Me.txtProdDescrip.Multiline = True
        Me.txtProdDescrip.Name = "txtProdDescrip"
        Me.txtProdDescrip.Size = New System.Drawing.Size(193, 49)
        Me.txtProdDescrip.TabIndex = 14
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Enabled = False
        Me.txtPrecioProd.Location = New System.Drawing.Point(112, 94)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(71, 20)
        Me.txtPrecioProd.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Precio ($)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombre Producto"
        '
        'txtNombreProd
        '
        Me.txtNombreProd.Enabled = False
        Me.txtNombreProd.Location = New System.Drawing.Point(112, 31)
        Me.txtNombreProd.Name = "txtNombreProd"
        Me.txtNombreProd.Size = New System.Drawing.Size(197, 20)
        Me.txtNombreProd.TabIndex = 0
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
        Me.txtPrecioUnidad.Location = New System.Drawing.Point(213, 57)
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
        Me.Label2.Location = New System.Drawing.Point(168, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(67, 56)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(52, 20)
        Me.numCantidad.TabIndex = 3
        Me.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad"
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Items.AddRange(New Object() {"Arena", "Cal", "Cemento"})
        Me.cboMateriales.Location = New System.Drawing.Point(10, 19)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(318, 21)
        Me.cboMateriales.TabIndex = 1
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.listView.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 368)
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
        Me.btnGuardar.Location = New System.Drawing.Point(693, 368)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.listView.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.Location = New System.Drawing.Point(592, 368)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 40)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVistaPevia
        '
        Me.btnVistaPevia.Image = Global.listView.My.Resources.Resources.print_preview
        Me.btnVistaPevia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVistaPevia.Location = New System.Drawing.Point(487, 368)
        Me.btnVistaPevia.Name = "btnVistaPevia"
        Me.btnVistaPevia.Size = New System.Drawing.Size(98, 40)
        Me.btnVistaPevia.TabIndex = 9
        Me.btnVistaPevia.Text = "Vista Previa"
        Me.btnVistaPevia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVistaPevia.UseVisualStyleBackColor = True
        '
        'lbUnidad
        '
        Me.lbUnidad.AutoSize = True
        Me.lbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnidad.Location = New System.Drawing.Point(121, 58)
        Me.lbUnidad.Name = "lbUnidad"
        Me.lbUnidad.Size = New System.Drawing.Size(27, 15)
        Me.lbUnidad.TabIndex = 11
        Me.lbUnidad.Text = "[un]"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(112, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "[kg]"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(161, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 28
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "[m]"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(206, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton3.TabIndex = 29
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "[m²]"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Location = New System.Drawing.Point(254, 64)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton4.TabIndex = 30
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Unidad"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'frmMaterialesAgrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 418)
        Me.Controls.Add(Me.btnVistaPevia)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grupoAgregarProducto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaterialesAgrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Materiales"
        Me.grupoAgregarProducto.ResumeLayout(False)
        Me.grupoAgregarProducto.PerformLayout()
        Me.grupoNuevoProducto.ResumeLayout(False)
        Me.grupoNuevoProducto.PerformLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnVistaPevia As Button
    Friend WithEvents lbUnidad As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class