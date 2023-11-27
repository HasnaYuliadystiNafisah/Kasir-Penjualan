Public Class Form2

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txttotalbayar.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxnamapesanan.SelectedIndexChanged
        If cmboxnamapesanan.Text = "Hazelnut Chocolate Boba Milk" Then
            txthargapesanan.Text = 25000
        ElseIf cmboxnamapesanan.Text = "Taro Boba Milk Tea" Then
            txthargapesanan.Text = 20000
        ElseIf cmboxnamapesanan.Text = "Green Tea Boba" Then
            txthargapesanan.Text = 25000
        ElseIf cmboxnamapesanan.Text = "Matcha Latte Boba Milk Tea" Then
            txthargapesanan.Text = 30000
        ElseIf cmboxnamapesanan.Text = "Milk Foam Green Tea Boba" Then
            txthargapesanan.Text = 25000
        ElseIf cmboxnamapesanan.Text = "Strawberry Boba Milk Tea" Then
            txthargapesanan.Text = 30000
        End If
    End Sub

    Private Sub txtjumlahpesanan_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahpesanan.TextChanged
        Dim Nilai As Integer
        If Val(txtjumlahpesanan.Text) <> 0 Then
            Nilai = Int(txtjumlahpesanan.Text)
            txtjumlahpesanan.Text = Nilai
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        txttotalharga.Text = txtjumlahpesanan.Text * txthargapesanan.Text
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txtkembalian.Text = txttotalbayar.Text - txttotalharga.Text
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class