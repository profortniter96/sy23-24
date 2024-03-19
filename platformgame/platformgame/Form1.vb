Imports System.Reflection.Emit

Public Class Form1
    Dim movespeed As Integer = 15
    Dim isJumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                timerRight.Start()
            Case Keys.D
                timerRight.Start()
            Case Keys.Left
                timerLeft.Start()
            Case Keys.A
                timerLeft.Start()
            Case Keys.Up
                timerUp.Start()
                isJumping = True
            Case Keys.W
                timerUp.Start()
                isJumping = True

        End Select
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                timerRight.Stop()
            Case Keys.D
                timerRight.Stop()
            Case Keys.Left
                timerLeft.Stop()
            Case Keys.A
                timerLeft.Stop()
            Case Keys.Up
                timerUp.Stop()
                isJumping = False
            Case Keys.W
                timerUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles timerRight.Tick
        picPlayer.Left += movespeed
    End Sub


    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles timerLeft.Tick
        picPlayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles timerUp.Tick
        picPlayer.Top -= movespeed

    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles timerGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            timerGravity.Stop()
        Else
            If isJumping = False Then
                timerGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        timerGravity.Stop()
                    End If
                End If
                If b.Tag = "exit" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) And picPlayer.Visible = True Then
                        timerGravity.Stop()
                        b.BackColor = Color.Black
                        Label1.Visible = False
                        picPlayer.Visible = False
                        Label2.Visible = True
                    End If
                End If
                If b.Tag = "enemy" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        timerGravity.Stop()
                        picPlayer.Visible = False
                        Label2.Text = "You Lose"
                        Label2.Visible = True
                    End If
                End If
                If b.Tag = "coin1" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        PictureBox2.Visible = False
                    End If
                End If
                If b.Tag = "coin2" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        PictureBox3.Visible = False
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        picPlayer.Top += movespeed
    End Sub
End Class