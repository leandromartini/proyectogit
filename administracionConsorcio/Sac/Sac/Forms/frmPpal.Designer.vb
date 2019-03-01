<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPpal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPpal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeDeudasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobranzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibosEmitidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropietariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblfechahora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.ExpensasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.VerToolStripMenuItem.Text = "Ver / Nuevo"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeDeudasToolStripMenuItem, Me.BalanceMensualToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.InformesToolStripMenuItem.Text = "Contabilidad"
        '
        'DeDeudasToolStripMenuItem
        '
        Me.DeDeudasToolStripMenuItem.Name = "DeDeudasToolStripMenuItem"
        Me.DeDeudasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.DeDeudasToolStripMenuItem.Text = "Ingresar Movimientos"
        '
        'BalanceMensualToolStripMenuItem
        '
        Me.BalanceMensualToolStripMenuItem.Name = "BalanceMensualToolStripMenuItem"
        Me.BalanceMensualToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BalanceMensualToolStripMenuItem.Text = "Ver Informes"
        '
        'ExpensasToolStripMenuItem
        '
        Me.ExpensasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CobranzasToolStripMenuItem, Me.RecibosEmitidosToolStripMenuItem, Me.PropietariosToolStripMenuItem})
        Me.ExpensasToolStripMenuItem.Name = "ExpensasToolStripMenuItem"
        Me.ExpensasToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ExpensasToolStripMenuItem.Text = "Expensas"
        '
        'CobranzasToolStripMenuItem
        '
        Me.CobranzasToolStripMenuItem.Name = "CobranzasToolStripMenuItem"
        Me.CobranzasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CobranzasToolStripMenuItem.Text = "Cobranzas"
        '
        'RecibosEmitidosToolStripMenuItem
        '
        Me.RecibosEmitidosToolStripMenuItem.Name = "RecibosEmitidosToolStripMenuItem"
        Me.RecibosEmitidosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecibosEmitidosToolStripMenuItem.Text = "Recibos Emitidos"
        '
        'PropietariosToolStripMenuItem
        '
        Me.PropietariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem1, Me.ActualizarToolStripMenuItem})
        Me.PropietariosToolStripMenuItem.Name = "PropietariosToolStripMenuItem"
        Me.PropietariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PropietariosToolStripMenuItem.Text = "Propietarios"
        '
        'VerToolStripMenuItem1
        '
        Me.VerToolStripMenuItem1.Name = "VerToolStripMenuItem1"
        Me.VerToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.VerToolStripMenuItem1.Text = "Ver"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActualizarToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblfechahora
        '
        Me.lblfechahora.AutoSize = True
        Me.lblfechahora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechahora.Location = New System.Drawing.Point(467, 376)
        Me.lblfechahora.Name = "lblfechahora"
        Me.lblfechahora.Size = New System.Drawing.Size(81, 16)
        Me.lblfechahora.TabIndex = 3
        Me.lblfechahora.Text = "fecha y hora"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(670, 399)
        Me.Controls.Add(Me.lblfechahora)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblfechahora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DeDeudasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BalanceMensualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpensasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobranzasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecibosEmitidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropietariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
End Class
