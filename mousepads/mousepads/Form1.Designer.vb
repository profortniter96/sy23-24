<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserControl31 = New mousepads.UserControl3()
        Me.UserControl11 = New mousepads.UserControl1()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 79)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "11x13 Custom Mousepad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 79)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "11x36 Custom Mousepad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UserControl31
        '
        Me.UserControl31.count = 0
        Me.UserControl31.Location = New System.Drawing.Point(22, 12)
        Me.UserControl31.Name = "UserControl31"
        Me.UserControl31.picture = Nothing
        Me.UserControl31.price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UserControl31.productid = Nothing
        Me.UserControl31.Size = New System.Drawing.Size(172, 154)
        Me.UserControl31.TabIndex = 39
        '
        'UserControl11
        '
        Me.UserControl11.count = 0
        Me.UserControl11.Location = New System.Drawing.Point(27, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.picture = Nothing
        Me.UserControl11.price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UserControl11.productid = Nothing
        Me.UserControl11.Size = New System.Drawing.Size(372, 158)
        Me.UserControl11.TabIndex = 40
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 297)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(400, 85)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Cart"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(197, 208)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(142, 20)
        Me.RadioButton1.TabIndex = 43
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Ready to Checkout"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 389)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.UserControl31)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    '  Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserControl31 As UserControl3
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents Button8 As Button
    Friend WithEvents RadioButton1 As RadioButton
End Class
