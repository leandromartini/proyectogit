<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevoIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoIngreso))
        Me.btnVolver = New System.Windows.Forms.Button()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Producto = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DomainUpDown3 = New System.Windows.Forms.DomainUpDown()
        Me.grupoNuevoProducto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.PedroCovino.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 412)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'grupoNuevoProducto
        '
        Me.grupoNuevoProducto.Controls.Add(Me.GroupBox2)
        Me.grupoNuevoProducto.Controls.Add(Me.GroupBox1)
        Me.grupoNuevoProducto.Controls.Add(Me.btnProdGuardar)
        Me.grupoNuevoProducto.Controls.Add(Me.BtnBorrar)
        Me.grupoNuevoProducto.Controls.Add(Me.BtnNuevo)
        Me.grupoNuevoProducto.Controls.Add(Me.Label5)
        Me.grupoNuevoProducto.Controls.Add(Me.txtProdDescrip)
        Me.grupoNuevoProducto.Controls.Add(Me.Label3)
        Me.grupoNuevoProducto.Controls.Add(Me.txtNombreProd)
        Me.grupoNuevoProducto.Controls.Add(Me.Producto)
        Me.grupoNuevoProducto.Location = New System.Drawing.Point(12, 12)
        Me.grupoNuevoProducto.Name = "grupoNuevoProducto"
        Me.grupoNuevoProducto.Size = New System.Drawing.Size(538, 394)
        Me.grupoNuevoProducto.TabIndex = 11
        Me.grupoNuevoProducto.TabStop = False
        Me.grupoNuevoProducto.Text = "Nuevo Ingreso"
        '
        'btnProdGuardar
        '
        Me.btnProdGuardar.Enabled = False
        Me.btnProdGuardar.Image = Global.PedroCovino.My.Resources.Resources.save
        Me.btnProdGuardar.Location = New System.Drawing.Point(486, 340)
        Me.btnProdGuardar.Name = "btnProdGuardar"
        Me.btnProdGuardar.Size = New System.Drawing.Size(45, 40)
        Me.btnProdGuardar.TabIndex = 18
        Me.btnProdGuardar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Image = Global.PedroCovino.My.Resources.Resources.cancel
        Me.BtnBorrar.Location = New System.Drawing.Point(410, 340)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(45, 40)
        Me.BtnBorrar.TabIndex = 17
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.PedroCovino.My.Resources.Resources.add
        Me.BtnNuevo.Location = New System.Drawing.Point(334, 340)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(45, 40)
        Me.BtnNuevo.TabIndex = 16
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(34, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Drescripcion"
        '
        'txtProdDescrip
        '
        Me.txtProdDescrip.Enabled = False
        Me.txtProdDescrip.Location = New System.Drawing.Point(112, 68)
        Me.txtProdDescrip.Multiline = True
        Me.txtProdDescrip.Name = "txtProdDescrip"
        Me.txtProdDescrip.Size = New System.Drawing.Size(395, 38)
        Me.txtProdDescrip.TabIndex = 14
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Enabled = False
        Me.txtPrecioProd.Location = New System.Drawing.Point(108, 22)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(91, 20)
        Me.txtPrecioProd.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Costo sin IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(61, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Codigo"
        '
        'txtNombreProd
        '
        Me.txtNombreProd.Enabled = False
        Me.txtNombreProd.Location = New System.Drawing.Point(112, 41)
        Me.txtNombreProd.Name = "txtNombreProd"
        Me.txtNombreProd.Size = New System.Drawing.Size(75, 20)
        Me.txtNombreProd.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(108, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Costo con IVA"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(327, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(91, 20)
        Me.TextBox2.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(245, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Venta Publico"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPrecioProd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 98)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costos"
        '
        'Producto
        '
        Me.Producto.Location = New System.Drawing.Point(16, 25)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(516, 98)
        Me.Producto.TabIndex = 23
        Me.Producto.TabStop = False
        Me.Producto.Text = "Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DomainUpDown3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DomainUpDown2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 98)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(313, 25)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 0
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(231, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Mínimo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(231, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Máximo"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.Location = New System.Drawing.Point(313, 52)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown2.TabIndex = 25
        Me.DomainUpDown2.Text = "DomainUpDown2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Ingrese cantidad"
        '
        'DomainUpDown3
        '
        Me.DomainUpDown3.Location = New System.Drawing.Point(108, 26)
        Me.DomainUpDown3.Name = "DomainUpDown3"
        Me.DomainUpDown3.Size = New System.Drawing.Size(91, 20)
        Me.DomainUpDown3.TabIndex = 27
        Me.DomainUpDown3.Text = "DomainUpDown3"
        '
        'frmNuevoIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 464)
        Me.Controls.Add(Me.grupoNuevoProducto)
        Me.Controls.Add(Me.btnVolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNuevoIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Insumos"
        Me.grupoNuevoProducto.ResumeLayout(False)
        Me.grupoNuevoProducto.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As Button
    Friend WithEvents grupoNuevoProducto As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecioProd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProdGuardar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdDescrip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreProd As TextBox
    Friend WithEvents Producto As GroupBox
    Friend WithEvents DomainUpDown3 As DomainUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DomainUpDown1 As DomainUpDown
End Class
