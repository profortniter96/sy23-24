Public Class productcontrol
    Public Property productid As String
    Public Property price As Decimal
    Public Property count As Integer
    Public Property picture As Image

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
        idLabel.Text = productid
        priceLabel.Text = price.ToString("C2")
    End Sub
End Class
