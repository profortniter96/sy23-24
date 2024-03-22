Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = True
        Button1.Visible = True
        PictureBox2.Visible = False
        Button2.Visible = False
        PictureBox4.Visible = True
        PictureBox3.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Visible = True
        Button2.Visible = True
        PictureBox1.Visible = False
        Button1.Visible = False
        PictureBox3.Visible = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox3.Load(OpenFileDialog1.FileName)
        PictureBox4.Load(OpenFileDialog1.FileName)
    End Sub
End Class
