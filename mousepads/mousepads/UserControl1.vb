﻿Public Class UserControl1
    Public Property productid As String
    Public Property price As Decimal
    Public Property count As Integer
    Public Property picture As Image
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

<<<<<<< HEAD

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
=======
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
>>>>>>> main
    End Sub
    Public Sub buy()
        If count > 0 Then
            count = count - 1
        End If
        If count = 0 Then
            'PictureBox1.Image = Nothing
        End If
    End Sub
End Class