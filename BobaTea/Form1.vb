Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "abcd" And txtpassword.Text = "123" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            txtpassword.Text = ""
            txtusername.Text = ""
        End If
    End Sub

End Class
