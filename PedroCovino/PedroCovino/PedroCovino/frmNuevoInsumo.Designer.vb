<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoInsumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoInsumo))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtboxStockMax = New System.Windows.Forms.TextBox()
        Me.txtBoxStockMin = New System.Windows.Forms.TextBox()
        Me.txtBoxStock = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBoxPrecioPub = New System.Windows.Forms.TextBox()
        Me.txtBoxPrecioCiva = New System.Windows.Forms.TextBox()
        Me.txtBoxPrecioSiva = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBoxDescrip = New System.Windows.Forms.TextBox()
        Me.txtBoxCodigo = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.PedroCovino.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(12, 416)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 403)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Producto"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtboxStockMax)
        Me.GroupBox4.Controls.Add(Me.txtBoxStockMin)
        Me.GroupBox4.Controls.Add(Me.txtBoxStock)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 242)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(508, 99)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock"
        '
        'txtboxStockMax
        '
        Me.txtboxStockMax.Location = New System.Drawing.Point(262, 19)
        Me.txtboxStockMax.Name = "txtboxStockMax"
        Me.txtboxStockMax.Size = New System.Drawing.Size(100, 20)
        Me.txtboxStockMax.TabIndex = 6
        '
        'txtBoxStockMin
        '
        Me.txtBoxStockMin.Location = New System.Drawing.Point(67, 63)
        Me.txtBoxStockMin.Name = "txtBoxStockMin"
        Me.txtBoxStockMin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxStockMin.TabIndex = 5
        '
        'txtBoxStock
        '
        Me.txtBoxStock.Location = New System.Drawing.Point(67, 19)
        Me.txtBoxStock.Name = "txtBoxStock"
        Me.txtBoxStock.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxStock.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBoxPrecioPub)
        Me.GroupBox3.Controls.Add(Me.txtBoxPrecioCiva)
        Me.GroupBox3.Controls.Add(Me.txtBoxPrecioSiva)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 99)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Costos "
        '
        'txtBoxPrecioPub
        '
        Me.txtBoxPrecioPub.Location = New System.Drawing.Point(262, 19)
        Me.txtBoxPrecioPub.Name = "txtBoxPrecioPub"
        Me.txtBoxPrecioPub.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPrecioPub.TabIndex = 3
        '
        'txtBoxPrecioCiva
        '
        Me.txtBoxPrecioCiva.Location = New System.Drawing.Point(67, 55)
        Me.txtBoxPrecioCiva.Name = "txtBoxPrecioCiva"
        Me.txtBoxPrecioCiva.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPrecioCiva.TabIndex = 2
        '
        'txtBoxPrecioSiva
        '
        Me.txtBoxPrecioSiva.Location = New System.Drawing.Point(67, 19)
        Me.txtBoxPrecioSiva.Name = "txtBoxPrecioSiva"
        Me.txtBoxPrecioSiva.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPrecioSiva.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBoxDescrip)
        Me.GroupBox2.Controls.Add(Me.txtBoxCodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 99)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre Descripcion"
        '
        'txtBoxDescrip
        '
        Me.txtBoxDescrip.Location = New System.Drawing.Point(67, 57)
        Me.txtBoxDescrip.Name = "txtBoxDescrip"
        Me.txtBoxDescrip.Size = New System.Drawing.Size(350, 20)
        Me.txtBoxDescrip.TabIndex = 1
        '
        'txtBoxCodigo
        '
        Me.txtBoxCodigo.Location = New System.Drawing.Point(67, 19)
        Me.txtBoxCodigo.Name = "txtBoxCodigo"
        Me.txtBoxCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxCodigo.TabIndex = 0
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.PedroCovino.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(479, 347)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 41)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'frmNuevoInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNuevoInsumo"
        Me.Text = "Nuevo Ingreso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtboxStockMax As TextBox
    Friend WithEvents txtBoxStockMin As TextBox
    Friend WithEvents txtBoxStock As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBoxPrecioPub As TextBox
    Friend WithEvents txtBoxPrecioCiva As TextBox
    Friend WithEvents txtBoxPrecioSiva As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBoxDescrip As TextBox
    Friend WithEvents txtBoxCodigo As TextBox
    Friend WithEvents BtnGuardar As Button
End Class
