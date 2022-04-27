Public Class Form4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtLado_TextChanged(sender As Object, e As EventArgs) Handles txtAltura.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged

    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click

        txtResultado.Text = Val(txtAltura.Text) * Val(txtBase.Text)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class