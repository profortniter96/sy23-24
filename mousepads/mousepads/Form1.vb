Public Class Form1
    Dim WithEvents cs As New coinslot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = True
        Button2.Visible = False
        UserControl11.Visible = True
        UserControl31.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        Button1.Visible = False
        UserControl11.Visible = False
        UserControl31.Visible = True
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
    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If

        If q > 0 Then
            PictureBox8.Visible = True
        Else
            PictureBox8.Visible = False
        End If

        If di > 0 Then
            PictureBox7.Visible = True
        Else
            PictureBox7.Visible = False
        End If

        If n > 0 Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("C2")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickle()
        Label1.Text = cs.total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("C2")
        Label3.Visible = True
        Me.BackColor = Color.Green
    End Sub
End Class
