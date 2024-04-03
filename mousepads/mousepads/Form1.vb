Imports System.Windows

Public Class Form1
    Dim WithEvents cs As New coinslot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = True
        Button2.Visible = False
<<<<<<< HEAD
        UserControl11.Visible = True
        UserControl31.Visible = False
=======
        UserControl31.Visible = False
        UserControl11.Visible = True
>>>>>>> main
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        Button1.Visible = False
<<<<<<< HEAD
        UserControl11.Visible = False
        UserControl31.Visible = True
=======
        UserControl31.Visible = True
        UserControl11.Visible = False
>>>>>>> main
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        Me.Show()
    End Sub

<<<<<<< HEAD
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("C2")
<<<<<<< HEAD
        Label3.Visible = True
        Me.BackColor = Color.Green
=======
        Me.BackColor = Color.Green
        Label3.Visible = True
>>>>>>> main
=======
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button8.Visible = True
        RadioButton1.Visible = False
>>>>>>> main
    End Sub
End Class
