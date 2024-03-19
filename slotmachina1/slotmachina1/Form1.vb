Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        ReelControl1.Spin()
        ReelControl2.Spin()
        ReelControl3.Spin()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If ReelControl1.ItemValue = ReelControl2.ItemValue _
        And ReelControl2.ItemValue = ReelControl3.ItemValue Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.White
        End If
    End Sub
End Class
