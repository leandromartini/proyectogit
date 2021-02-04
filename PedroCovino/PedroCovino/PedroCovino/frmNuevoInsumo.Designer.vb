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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtboxStockMax = New System.Windows.Forms.TextBox()
        Me.txtBoxStockMin = New System.Windows.Forms.TextBox()
        Me.txtBoxStock = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxPrecioPub = New System.Windows.Forms.TextBox()
        Me.txtBoxPrecioCiva = New System.Windows.Forms.TextBox()
        Me.txtBoxPrecioSiva = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxDescrip = New System.Windows.Forms.TextBox()
        Me.txtBoxCodigo = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 381)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Producto"
        '
        'Button1
        '
        Me.Button1.Image = Global.PedroCovino.My.Resources.Resources.refresh
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(424, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 41)
        Me.Button1.TabIndex = 13
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtboxStockMax)
        Me.GroupBox4.Controls.Add(Me.txtBoxStockMin)
        Me.GroupBox4.Controls.Add(Me.txtBoxStock)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(508, 99)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Stock Máx"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Stock Mín"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Stock"
        '
        'txtboxStockMax
        '
        Me.txtboxStockMax.Location = New System.Drawing.Point(295, 48)
        Me.txtboxStockMax.Name = "txtboxStockMax"
        Me.txtboxStockMax.Size = New System.Drawing.Size(100, 20)
        Me.txtboxStockMax.TabIndex = 6
        Me.txtboxStockMax.Text = "0"
        '
        'txtBoxStockMin
        '
        Me.txtBoxStockMin.Location = New System.Drawing.Point(295, 19)
        Me.txtBoxStockMin.Name = "txtBoxStockMin"
        Me.txtBoxStockMin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxStockMin.TabIndex = 5
        Me.txtBoxStockMin.Text = "0"
        '
        'txtBoxStock
        '
        Me.txtBoxStock.Location = New System.Drawing.Point(89, 19)
        Me.txtBoxStock.Name = "txtBoxStock"
        Me.txtBoxStock.Size = New System.Drawing.Size(85, 20)
        Me.txtBoxStock.TabIndex = 4
        Me.txtBoxStock.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtBoxPrecioPub)
        Me.GroupBox3.Controls.Add(Me.txtBoxPrecioCiva)
        Me.GroupBox3.Controls.Add(Me.txtBoxPrecioSiva)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 99)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Costos "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Costo Publico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Costo Con IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Costo Sin IVA"
        '
        'txtBoxPrecioPub
        '
        Me.txtBoxPrecioPub.Location = New System.Drawing.Point(295, 19)
        Me.txtBoxPrecioPub.Name = "txtBoxPrecioPub"
        Me.txtBoxPrecioPub.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPrecioPub.TabIndex = 3
        Me.txtBoxPrecioPub.Text = "0.00"
        '
        'txtBoxPrecioCiva
        '
        Me.txtBoxPrecioCiva.Location = New System.Drawing.Point(89, 52)
        Me.txtBoxPrecioCiva.Name = "txtBoxPrecioCiva"
        Me.txtBoxPrecioCiva.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPrecioCiva.TabIndex = 2
        Me.txtBoxPrecioCiva.Text = "0.00"
        '
        'txtBoxPrecioSiva
        '
        Me.txtBoxPrecioSiva.Location = New System.Drawing.Point(89, 19)
        Me.txtBoxPrecioSiva.Name = "txtBoxPrecioSiva"
        Me.txtBoxPrecioSiva.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPrecioSiva.TabIndex = 1
        Me.txtBoxPrecioSiva.Text = "0.00"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtBoxDescrip)
        Me.GroupBox2.Controls.Add(Me.txtBoxCodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 92)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo"
        '
        'txtBoxDescrip
        '
        Me.txtBoxDescrip.Location = New System.Drawing.Point(89, 45)
        Me.txtBoxDescrip.Name = "txtBoxDescrip"
        Me.txtBoxDescrip.Size = New System.Drawing.Size(380, 20)
        Me.txtBoxDescrip.TabIndex = 1
        '
        'txtBoxCodigo
        '
        Me.txtBoxCodigo.Location = New System.Drawing.Point(89, 19)
        Me.txtBoxCodigo.Name = "txtBoxCodigo"
        Me.txtBoxCodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtBoxCodigo.TabIndex = 0
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.PedroCovino.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(479, 327)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 41)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Image = Global.PedroCovino.My.Resources.Resources.back
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(13, 394)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 40)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmNuevoInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNuevoInsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
