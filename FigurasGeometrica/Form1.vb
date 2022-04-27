Public Class Form1
    Private Sub FigurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FigurasToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CUADRADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUADRADOToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RECTANGULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECTANGULOToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub TRIANGULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRIANGULOToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
