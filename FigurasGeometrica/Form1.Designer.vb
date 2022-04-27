<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FigurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUADRADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRIANGULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECTANGULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FigurasToolStripMenuItem, Me.CUADRADOToolStripMenuItem, Me.TRIANGULOToolStripMenuItem, Me.RECTANGULOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FigurasToolStripMenuItem
        '
        Me.FigurasToolStripMenuItem.Name = "FigurasToolStripMenuItem"
        Me.FigurasToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.FigurasToolStripMenuItem.Text = "CIRCULO"
        '
        'CUADRADOToolStripMenuItem
        '
        Me.CUADRADOToolStripMenuItem.Name = "CUADRADOToolStripMenuItem"
        Me.CUADRADOToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.CUADRADOToolStripMenuItem.Text = "CUADRADO"
        '
        'TRIANGULOToolStripMenuItem
        '
        Me.TRIANGULOToolStripMenuItem.Name = "TRIANGULOToolStripMenuItem"
        Me.TRIANGULOToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.TRIANGULOToolStripMenuItem.Text = "TRIANGULO"
        '
        'RECTANGULOToolStripMenuItem
        '
        Me.RECTANGULOToolStripMenuItem.Name = "RECTANGULOToolStripMenuItem"
        Me.RECTANGULOToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.RECTANGULOToolStripMenuItem.Text = "RECTANGULO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FigurasGeometrica.My.Resources.Resources.images1
        Me.PictureBox1.Location = New System.Drawing.Point(162, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 162)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 278)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Areas De Figuras Geometricas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FigurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUADRADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRIANGULOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECTANGULOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
