Imports System.Reflection.Emit

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case idTextbox.Text
            Case Productcontrol1.productid
                cs.buy(Productcontrol1)
            Case Productcontrol2.productid
                cs.buy(Productcontrol2)
            Case Productcontrol3.productid
                cs.buy(Productcontrol3)
            Case Productcontrol4.productid
                cs.buy(Productcontrol4)
            Case Productcontrol5.productid
                cs.buy(Productcontrol5)
            Case Productcontrol6.productid
                cs.buy(Productcontrol6)
            Case Productcontrol7.productid
                cs.buy(Productcontrol7)
            Case Productcontrol8.productid
                cs.buy(Productcontrol8)
            Case Productcontrol9.productid
                cs.buy(Productcontrol9)
            Case Productcontrol10.productid
                cs.buy(Productcontrol10)
            Case Productcontrol11.productid
                cs.buy(Productcontrol11)
            Case Productcontrol12.productid
                cs.buy(Productcontrol12)
            Case Productcontrol13.productid
                cs.buy(Productcontrol13)
            Case Productcontrol14.productid
                cs.buy(Productcontrol14)
            Case Productcontrol15.productid
                cs.buy(Productcontrol15)
            Case Productcontrol16.productid
                cs.buy(Productcontrol16)
        End Select
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub cs_dispense(p As Image) Handles cs.dispense
        productPB.Image = p
    End Sub
End Class
