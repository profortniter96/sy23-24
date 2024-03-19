
Imports System.Reflection.Emit
Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reelcontrol
    Public Sub spin()        'generate a random number

        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        Label1.Text = r




        PictureBox1.Image = ImageList1.Images(0)
    End Sub



End Class


