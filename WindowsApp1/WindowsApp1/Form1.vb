Public Class Form1
    Dim WithEvents cs As New coinslot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("C2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertnickle()
        Label1.Text = cs.total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If

        If q > 0 Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If

        If di > 0 Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If

        If n > 0 Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If
    End Sub


End Class
