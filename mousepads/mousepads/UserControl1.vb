Public Class UserControl1
    Public Property productid As String
    Public Property price As Decimal
    Public Property count As Integer
    Public Property picture As Image
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
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