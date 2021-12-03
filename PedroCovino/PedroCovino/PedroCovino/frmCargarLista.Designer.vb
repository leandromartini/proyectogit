<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarLista))
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.g1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevoInsumoXLS = New System.Windows.Forms.Button()
        Me.BtnCargarXLS = New System.Windows.Forms.Button()
        Me.BtnActualizarXLS = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.g2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.g3 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnSubirXLS = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.g1.SuspendLayout()
        Me.g2.SuspendLayout()
        Me.g3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(19, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(279, 20)
        Me.txtPath.TabIndex = 16
        Me.txtPath.Text = "C:\ProyectoPedro\resources\"
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(319, 11)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(77, 21)
        Me.btnPath.TabIndex = 17
        Me.btnPath.Text = "Examinar"
        Me.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'g1
        '
        Me.g1.Controls.Add(Me.btnNuevoInsumoXLS)
        Me.g1.Controls.Add(Me.BtnCargarXLS)
        Me.g1.Controls.Add(Me.BtnActualizarXLS)
        Me.g1.Location = New System.Drawing.Point(19, 38)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(377, 128)
        Me.g1.TabIndex = 19
        Me.g1.TabStop = False
        Me.g1.Text = "Informacion del Producto"
        '
        'btnNuevoInsumoXLS
        '
        Me.btnNuevoInsumoXLS.Image = Global.PedroCovino.My.Resources.Resources.file_new
        Me.btnNuevoInsumoXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoInsumoXLS.Location = New System.Drawing.Point(133, 50)
        Me.btnNuevoInsumoXLS.Name = "btnNuevoInsumoXLS"
        Me.btnNuevoInsumoXLS.Size = New System.Drawing.Size(40, 41)
        Me.btnNuevoInsumoXLS.TabIndex = 18
        Me.btnNuevoInsumoXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoInsumoXLS.UseVisualStyleBackColor = True
        Me.btnNuevoInsumoXLS.Visible = False
        '
        'BtnCargarXLS
        '
        Me.BtnCargarXLS.Image = Global.PedroCovino.My.Resources.Resources._01_Excel
        Me.BtnCargarXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargarXLS.Location = New System.Drawing.Point(167, 50)
        Me.BtnCargarXLS.Name = "BtnCargarXLS"
        Me.BtnCargarXLS.Size = New System.Drawing.Size(40, 41)
        Me.BtnCargarXLS.TabIndex = 14
        Me.BtnCargarXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargarXLS.UseVisualStyleBackColor = True
        '
        'BtnActualizarXLS
        '
        Me.BtnActualizarXLS.Image = Global.PedroCovino.My.Resources.Resources.import
        Me.BtnActualizarXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizarXLS.Location = New System.Drawing.Point(201, 50)
        Me.BtnActualizarXLS.Name = "BtnActualizarXLS"
        Me.BtnActualizarXLS.Size = New System.Drawing.Size(40, 41)
        Me.BtnActualizarXLS.TabIndex = 15
        Me.BtnActualizarXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizarXLS.UseVisualStyleBackColor = True
        Me.BtnActualizarXLS.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(187, 41)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'g2
        '
        Me.g2.Controls.Add(Me.ComboBox1)
        Me.g2.Controls.Add(Me.Button1)
        Me.g2.Controls.Add(Me.ComboBox2)
        Me.g2.Controls.Add(Me.Label1)
        Me.g2.Controls.Add(Me.Label2)
        Me.g2.Controls.Add(Me.btnNuevo)
        Me.g2.Controls.Add(Me.btnDeshacer)
        Me.g2.Location = New System.Drawing.Point(19, 172)
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(377, 128)
        Me.g2.TabIndex = 20
        Me.g2.TabStop = False
        Me.g2.Text = "Accion"
        '
        'Button1
        '
        Me.Button1.Image = Global.PedroCovino.My.Resources.Resources.redo
        Me.Button1.Location = New System.Drawing.Point(206, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 25
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Proovedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Marca "
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.PedroCovino.My.Resources.Resources.add1
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(114, 75)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 37)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Image = Global.PedroCovino.My.Resources.Resources.cancel1
        Me.btnDeshacer.Location = New System.Drawing.Point(160, 75)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(40, 37)
        Me.btnDeshacer.TabIndex = 22
        Me.btnDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'g3
        '
        Me.g3.Controls.Add(Me.ProgressBar1)
        Me.g3.Controls.Add(Me.btnSubirXLS)
        Me.g3.Location = New System.Drawing.Point(19, 306)
        Me.g3.Name = "g3"
        Me.g3.Size = New System.Drawing.Size(377, 128)
        Me.g3.TabIndex = 22
        Me.g3.TabStop = False
        Me.g3.Text = "Actualizar la Lista"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(71, 51)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(288, 23)
        Me.ProgressBar1.TabIndex = 20
        '
        'btnSubirXLS
        '
        Me.btnSubirXLS.Image = Global.PedroCovino.My.Resources.Resources.up
        Me.btnSubirXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubirXLS.Location = New System.Drawing.Point(15, 42)
        Me.btnSubirXLS.Name = "btnSubirXLS"
        Me.btnSubirXLS.Size = New System.Drawing.Size(40, 41)
        Me.btnSubirXLS.TabIndex = 19
        Me.btnSubirXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubirXLS.UseVisualStyleBackColor = True
        '
        'frmCargarLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 451)
        Me.Controls.Add(Me.g2)
        Me.Controls.Add(Me.g1)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.g3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargarLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Lista"
        Me.g1.ResumeLayout(False)
        Me.g2.ResumeLayout(False)
        Me.g2.PerformLayout()
        Me.g3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCargarXLS As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents btnNuevoInsumoXLS As Button
    Friend WithEvents g1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents g2 As GroupBox
    Friend WithEvents btnDeshacer As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnActualizarXLS As Button
    Friend WithEvents btnSubirXLS As Button
    Friend WithEvents g3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
