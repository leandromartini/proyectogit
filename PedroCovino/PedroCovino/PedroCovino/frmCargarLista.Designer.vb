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
        Me.BtnSubirXLS = New System.Windows.Forms.Button()
        Me.BtnCargarXLS = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSubirXLS
        '
        Me.BtnSubirXLS.Image = Global.PedroCovino.My.Resources.Resources.up
        Me.BtnSubirXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSubirXLS.Location = New System.Drawing.Point(106, 44)
        Me.BtnSubirXLS.Name = "BtnSubirXLS"
        Me.BtnSubirXLS.Size = New System.Drawing.Size(40, 41)
        Me.BtnSubirXLS.TabIndex = 15
        Me.BtnSubirXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSubirXLS.UseVisualStyleBackColor = True
        Me.BtnSubirXLS.Visible = False
        '
        'BtnCargarXLS
        '
        Me.BtnCargarXLS.Image = Global.PedroCovino.My.Resources.Resources._01_Excel
        Me.BtnCargarXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargarXLS.Location = New System.Drawing.Point(106, 44)
        Me.BtnCargarXLS.Name = "BtnCargarXLS"
        Me.BtnCargarXLS.Size = New System.Drawing.Size(40, 41)
        Me.BtnCargarXLS.TabIndex = 14
        Me.BtnCargarXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargarXLS.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 13)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(185, 20)
        Me.txtPath.TabIndex = 16
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(213, 13)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(40, 20)
        Me.btnPath.TabIndex = 17
        Me.btnPath.Text = "..."
        Me.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'frmCargarLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 141)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.BtnCargarXLS)
        Me.Controls.Add(Me.BtnSubirXLS)
        Me.Name = "frmCargarLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCargarLista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCargarXLS As Button
    Friend WithEvents BtnSubirXLS As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
End Class
