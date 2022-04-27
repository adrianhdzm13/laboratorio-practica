Public Class Form5
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        txtResultado.Text = (Val(txtAltura.Text * txtBase.Text)) / 2
    End Sub

    Private Sub txtBase_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) 
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txtAltura_TextChanged(sender As Object, e As EventArgs) Handles txtAltura.TextChanged

    End Sub
End Class