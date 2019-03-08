<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCobranzas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCobranzas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPersonaCargar = New System.Windows.Forms.Button()
        Me.btnPersonaGuardar = New System.Windows.Forms.Button()
        Me.btnPersonaActualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.btnImputar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgHistorico = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboConsorcio = New System.Windows.Forms.ComboBox()
        Me.cboPropietario = New System.Windows.Forms.ComboBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPersonaCargar)
        Me.GroupBox1.Controls.Add(Me.btnPersonaGuardar)
        Me.GroupBox1.Controls.Add(Me.btnPersonaActualizar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(548, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la persona"
        '
        'btnPersonaCargar
        '
        Me.btnPersonaCargar.Image = CType(resources.GetObject("btnPersonaCargar.Image"), System.Drawing.Image)
        Me.btnPersonaCargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPersonaCargar.Location = New System.Drawing.Point(320, 170)
        Me.btnPersonaCargar.Name = "btnPersonaCargar"
        Me.btnPersonaCargar.Size = New System.Drawing.Size(67, 52)
        Me.btnPersonaCargar.TabIndex = 14
        Me.btnPersonaCargar.Text = "Cargar"
        Me.btnPersonaCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPersonaCargar.UseVisualStyleBackColor = True
        '
        'btnPersonaGuardar
        '
        Me.btnPersonaGuardar.Image = CType(resources.GetObject("btnPersonaGuardar.Image"), System.Drawing.Image)
        Me.btnPersonaGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPersonaGuardar.Location = New System.Drawing.Point(185, 170)
        Me.btnPersonaGuardar.Name = "btnPersonaGuardar"
        Me.btnPersonaGuardar.Size = New System.Drawing.Size(67, 52)
        Me.btnPersonaGuardar.TabIndex = 13
        Me.btnPersonaGuardar.Text = "Guardar"
        Me.btnPersonaGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPersonaGuardar.UseVisualStyleBackColor = True
        '
        'btnPersonaActualizar
        '
        Me.btnPersonaActualizar.Image = CType(resources.GetObject("btnPersonaActualizar.Image"), System.Drawing.Image)
        Me.btnPersonaActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPersonaActualizar.Location = New System.Drawing.Point(74, 170)
        Me.btnPersonaActualizar.Name = "btnPersonaActualizar"
        Me.btnPersonaActualizar.Size = New System.Drawing.Size(67, 52)
        Me.btnPersonaActualizar.TabIndex = 12
        Me.btnPersonaActualizar.Text = "Actualizar"
        Me.btnPersonaActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPersonaActualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(74, 141)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(179, 23)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(73, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(179, 23)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(74, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 23)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 23)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(274, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRecibo)
        Me.GroupBox2.Controls.Add(Me.btnImputar)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Obligaciones"
        '
        'btnRecibo
        '
        Me.btnRecibo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibo.Image = CType(resources.GetObject("btnRecibo.Image"), System.Drawing.Image)
        Me.btnRecibo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRecibo.Location = New System.Drawing.Point(458, 169)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(55, 52)
        Me.btnRecibo.TabIndex = 1
        Me.btnRecibo.Text = "Recibo"
        Me.btnRecibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecibo.UseVisualStyleBackColor = True
        '
        'btnImputar
        '
        Me.btnImputar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImputar.Image = CType(resources.GetObject("btnImputar.Image"), System.Drawing.Image)
        Me.btnImputar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImputar.Location = New System.Drawing.Point(397, 169)
        Me.btnImputar.Name = "btnImputar"
        Me.btnImputar.Size = New System.Drawing.Size(55, 52)
        Me.btnImputar.TabIndex = 0
        Me.btnImputar.Text = "Imputar"
        Me.btnImputar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImputar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgHistorico)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(971, 223)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historia "
        '
        'dgHistorico
        '
        Me.dgHistorico.AllowUserToAddRows = False
        Me.dgHistorico.AllowUserToDeleteRows = False
        Me.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHistorico.Location = New System.Drawing.Point(6, 22)
        Me.dgHistorico.Name = "dgHistorico"
        Me.dgHistorico.ReadOnly = True
        Me.dgHistorico.Size = New System.Drawing.Size(953, 195)
        Me.dgHistorico.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Volver"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboConsorcio
        '
        Me.cboConsorcio.FormattingEnabled = True
        Me.cboConsorcio.Location = New System.Drawing.Point(12, 12)
        Me.cboConsorcio.Name = "cboConsorcio"
        Me.cboConsorcio.Size = New System.Drawing.Size(121, 21)
        Me.cboConsorcio.TabIndex = 4
        '
        'cboPropietario
        '
        Me.cboPropietario.FormattingEnabled = True
        Me.cboPropietario.Location = New System.Drawing.Point(149, 12)
        Me.cboPropietario.Name = "cboPropietario"
        Me.cboPropietario.Size = New System.Drawing.Size(121, 21)
        Me.cboPropietario.TabIndex = 5
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(291, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(92, 22)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'FrmCobranzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(996, 562)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.cboPropietario)
        Me.Controls.Add(Me.cboConsorcio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCobranzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobranzas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cboConsorcio As ComboBox
    Friend WithEvents cboPropietario As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnImputar As Button
    Friend WithEvents btnRecibo As Button
    Friend WithEvents dgHistorico As DataGridView
    Friend WithEvents btnPersonaActualizar As Button
    Friend WithEvents btnPersonaGuardar As Button
    Friend WithEvents btnPersonaCargar As Button
End Class
