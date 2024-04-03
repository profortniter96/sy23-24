Public Class Form2
    Dim WithEvents cs As New coinslot
    Private Sub Button7_click(sender As Object, e As EventArgs) Handles Button7.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("C2")
        Me.BackColor = Color.Green
        Label3.Visible = True
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
End Class