﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialesIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialesIngreso))
        Me.listaMateriales = New System.Windows.Forms.ListView()
        Me.Col_Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_ProductoCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_PrecioTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Identificador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grupoAgregarProducto = New System.Windows.Forms.GroupBox()
        Me.lbUnidad = New System.Windows.Forms.Label()
        Me.grupoNuevoProducto = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.btnProdGuardar = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numTransp = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbEfec = New System.Windows.Forms.RadioButton()
        Me.rbCheq = New System.Windows.Forms.RadioButton()
        Me.col_Pago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_transporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grupoAgregarProducto.SuspendLayout()
        Me.grupoNuevoProducto.SuspendLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTransp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaMateriales
        '
        Me.listaMateriales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Producto, Me.Col_Precio, Me.Col_ProductoCantidad, Me.col_PrecioTotal, Me.col_transporte, Me.col_Pago, Me.col_Identificador})
        Me.listaMateriales.Location = New System.Drawing.Point(389, 19)
        Me.listaMateriales.Name = "listaMateriales"
        Me.listaMateriales.Size = New System.Drawing.Size(399, 337)
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
        '
        'Col_Precio
        '
        Me.Col_Precio.Text = "Precio"
        '
        'col_PrecioTotal
        '
        Me.col_PrecioTotal.Text = "Total"
        '
        'col_Identificador
        '
        Me.col_Identificador.Text = "Id"
        Me.col_Identificador.Width = 30
        '
        'grupoAgregarProducto
        '
        Me.grupoAgregarProducto.Controls.Add(Me.rbCheq)
        Me.grupoAgregarProducto.Controls.Add(Me.rbEfec)
        Me.grupoAgregarProducto.Controls.Add(Me.Label6)
        Me.grupoAgregarProducto.Controls.Add(Me.numTransp)
        Me.grupoAgregarProducto.Controls.Add(Me.Label7)
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
        Me.grupoAgregarProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grupoAgregarProducto.Location = New System.Drawing.Point(12, 12)
        Me.grupoAgregarProducto.Name = "grupoAgregarProducto"
        Me.grupoAgregarProducto.Size = New System.Drawing.Size(796, 369)
        Me.grupoAgregarProducto.TabIndex = 1
        Me.grupoAgregarProducto.TabStop = False
        Me.grupoAgregarProducto.Text = "Agregar a la lista"
        '
        'lbUnidad
        '
        Me.lbUnidad.AutoSize = True
        Me.lbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnidad.Location = New System.Drawing.Point(159, 49)
        Me.lbUnidad.Name = "lbUnidad"
        Me.lbUnidad.Size = New System.Drawing.Size(0, 15)
        Me.lbUnidad.TabIndex = 11
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
        Me.grupoNuevoProducto.Location = New System.Drawing.Point(9, 136)
        Me.grupoNuevoProducto.Name = "grupoNuevoProducto"
        Me.grupoNuevoProducto.Size = New System.Drawing.Size(319, 220)
        Me.grupoNuevoProducto.TabIndex = 10
        Me.grupoNuevoProducto.TabStop = False
        Me.grupoNuevoProducto.Text = "Nuevo Producto"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton4.Location = New System.Drawing.Point(254, 46)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(53, 19)
        Me.RadioButton4.TabIndex = 30
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "[Uni.]"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'btnProdGuardar
        '
        Me.btnProdGuardar.Enabled = False
        Me.btnProdGuardar.Image = Global.matuteMateriales.My.Resources.Resources.save
        Me.btnProdGuardar.Location = New System.Drawing.Point(264, 170)
        Me.btnProdGuardar.Name = "btnProdGuardar"
        Me.btnProdGuardar.Size = New System.Drawing.Size(45, 40)
        Me.btnProdGuardar.TabIndex = 18
        Me.btnProdGuardar.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(206, 46)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton3.TabIndex = 29
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "[m²]"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Image = Global.matuteMateriales.My.Resources.Resources.cancel
        Me.BtnBorrar.Location = New System.Drawing.Point(188, 170)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(45, 40)
        Me.BtnBorrar.TabIndex = 17
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(161, 46)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton2.TabIndex = 28
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "[m]"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.matuteMateriales.My.Resources.Resources.add
        Me.BtnNuevo.Location = New System.Drawing.Point(112, 170)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(45, 40)
        Me.BtnNuevo.TabIndex = 16
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(112, 46)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "[kg]"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(34, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Drescripcion"
        '
        'txtProdDescrip
        '
        Me.txtProdDescrip.Enabled = False
        Me.txtProdDescrip.Location = New System.Drawing.Point(112, 109)
        Me.txtProdDescrip.Multiline = True
        Me.txtProdDescrip.Name = "txtProdDescrip"
        Me.txtProdDescrip.Size = New System.Drawing.Size(197, 49)
        Me.txtProdDescrip.TabIndex = 14
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Enabled = False
        Me.txtPrecioProd.Location = New System.Drawing.Point(112, 77)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(71, 23)
        Me.txtPrecioProd.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(50, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Precio ($)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombre Producto"
        '
        'txtNombreProd
        '
        Me.txtNombreProd.Enabled = False
        Me.txtNombreProd.Location = New System.Drawing.Point(112, 16)
        Me.txtNombreProd.Name = "txtNombreProd"
        Me.txtNombreProd.Size = New System.Drawing.Size(197, 23)
        Me.txtNombreProd.TabIndex = 0
        '
        'btnModificaPrecio
        '
        Me.btnModificaPrecio.Image = Global.matuteMateriales.My.Resources.Resources.edit
        Me.btnModificaPrecio.Location = New System.Drawing.Point(289, 53)
        Me.btnModificaPrecio.Name = "btnModificaPrecio"
        Me.btnModificaPrecio.Size = New System.Drawing.Size(39, 39)
        Me.btnModificaPrecio.TabIndex = 9
        Me.btnModificaPrecio.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Image = Global.matuteMateriales.My.Resources.Resources.refresh
        Me.btnReset.Location = New System.Drawing.Point(336, 208)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(45, 40)
        Me.btnReset.TabIndex = 8
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.matuteMateriales.My.Resources.Resources.undo
        Me.btnQuitar.Location = New System.Drawing.Point(336, 151)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(45, 40)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.matuteMateriales.My.Resources.Resources.redo
        Me.btnAgregar.Location = New System.Drawing.Point(336, 95)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 40)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecioUnidad
        '
        Me.txtPrecioUnidad.Enabled = False
        Me.txtPrecioUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnidad.Location = New System.Drawing.Point(200, 70)
        Me.txtPrecioUnidad.Multiline = True
        Me.txtPrecioUnidad.Name = "txtPrecioUnidad"
        Me.txtPrecioUnidad.Size = New System.Drawing.Size(85, 19)
        Me.txtPrecioUnidad.TabIndex = 5
        Me.txtPrecioUnidad.Text = "0,00"
        Me.txtPrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(197, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio de venta"
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(104, 69)
        Me.numCantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(85, 23)
        Me.numCantidad.TabIndex = 3
        Me.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(106, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad"
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Location = New System.Drawing.Point(10, 18)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(318, 23)
        Me.cboMateriales.TabIndex = 1
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.matuteMateriales.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 387)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.matuteMateriales.My.Resources.Resources.save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(706, 387)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.matuteMateriales.My.Resources.Resources.print
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.Location = New System.Drawing.Point(605, 387)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 40)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVistaPevia
        '
        Me.btnVistaPevia.Image = Global.matuteMateriales.My.Resources.Resources.print_preview
        Me.btnVistaPevia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVistaPevia.Location = New System.Drawing.Point(501, 387)
        Me.btnVistaPevia.Name = "btnVistaPevia"
        Me.btnVistaPevia.Size = New System.Drawing.Size(98, 40)
        Me.btnVistaPevia.TabIndex = 9
        Me.btnVistaPevia.Text = "Vista Previa"
        Me.btnVistaPevia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVistaPevia.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(5, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gasto transporte"
        '
        'numTransp
        '
        Me.numTransp.Location = New System.Drawing.Point(9, 69)
        Me.numTransp.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numTransp.Name = "numTransp"
        Me.numTransp.Size = New System.Drawing.Size(85, 23)
        Me.numTransp.TabIndex = 13
        Me.numTransp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(7, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Forma de pago:"
        '
        'rbEfec
        '
        Me.rbEfec.AutoSize = True
        Me.rbEfec.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbEfec.Location = New System.Drawing.Point(101, 105)
        Me.rbEfec.Name = "rbEfec"
        Me.rbEfec.Size = New System.Drawing.Size(67, 19)
        Me.rbEfec.TabIndex = 31
        Me.rbEfec.TabStop = True
        Me.rbEfec.Text = "Efectivo"
        Me.rbEfec.UseVisualStyleBackColor = True
        '
        'rbCheq
        '
        Me.rbCheq.AutoSize = True
        Me.rbCheq.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbCheq.Location = New System.Drawing.Point(166, 105)
        Me.rbCheq.Name = "rbCheq"
        Me.rbCheq.Size = New System.Drawing.Size(66, 19)
        Me.rbCheq.TabIndex = 32
        Me.rbCheq.TabStop = True
        Me.rbCheq.Text = "Cheque"
        Me.rbCheq.UseVisualStyleBackColor = True
        '
        'col_Pago
        '
        Me.col_Pago.Text = "Pago"
        Me.col_Pago.Width = 65
        '
        'col_transporte
        '
        Me.col_transporte.Text = "Transporte"
        Me.col_transporte.Width = 68
        '
        'frmMaterialesAgrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 433)
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
        CType(Me.numTransp, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents col_Identificador As ColumnHeader
    Friend WithEvents numTransp As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbCheq As RadioButton
    Friend WithEvents rbEfec As RadioButton
    Friend WithEvents col_transporte As ColumnHeader
    Friend WithEvents col_Pago As ColumnHeader
End Class
