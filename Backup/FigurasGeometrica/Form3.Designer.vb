<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.txtLado = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digita el lado: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Formula " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lado * lado"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(454, 240)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(100, 24)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "REGRESAR"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(340, 152)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(73, 42)
        Me.btnArea.TabIndex = 6
        Me.btnArea.Text = "CALCULAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " AREA"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'txtLado
        '
        Me.txtLado.Location = New System.Drawing.Point(454, 43)
        Me.txtLado.Name = "txtLado"
        Me.txtLado.Size = New System.Drawing.Size(100, 20)
        Me.txtLado.TabIndex = 8
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(454, 164)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FigurasGeometrica.My.Resources.Resources.images__1_
        Me.PictureBox1.Location = New System.Drawing.Point(28, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 199)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 292)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtLado)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Area Cuadrado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnArea As Button
    Friend WithEvents txtLado As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
