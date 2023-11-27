<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtjumlahpesanan = New TextBox()
        txthargapesanan = New TextBox()
        txttotalharga = New TextBox()
        txttotalbayar = New TextBox()
        txtkembalian = New TextBox()
        btnbayar = New Button()
        btntotal = New Button()
        btnkeluar = New Button()
        cmboxnamapesanan = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama Pesanan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 20)
        Label3.TabIndex = 4
        Label3.Text = "Harga Pesanan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 20)
        Label4.TabIndex = 5
        Label4.Text = "Jumlah Pesanan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(487, 161)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 6
        Label5.Text = "Total Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(487, 198)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 20)
        Label6.TabIndex = 7
        Label6.Text = "Total Bayar"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(487, 235)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
        Label7.TabIndex = 8
        Label7.Text = "Kembalian"
        ' 
        ' txtjumlahpesanan
        ' 
        txtjumlahpesanan.Location = New Point(188, 228)
        txtjumlahpesanan.Name = "txtjumlahpesanan"
        txtjumlahpesanan.Size = New Size(272, 31)
        txtjumlahpesanan.TabIndex = 10
        ' 
        ' txthargapesanan
        ' 
        txthargapesanan.Location = New Point(188, 191)
        txthargapesanan.Name = "txthargapesanan"
        txthargapesanan.Size = New Size(272, 31)
        txthargapesanan.TabIndex = 11
        ' 
        ' txttotalharga
        ' 
        txttotalharga.Location = New Point(607, 154)
        txttotalharga.Name = "txttotalharga"
        txttotalharga.Size = New Size(160, 31)
        txttotalharga.TabIndex = 12
        ' 
        ' txttotalbayar
        ' 
        txttotalbayar.Location = New Point(607, 191)
        txttotalbayar.Name = "txttotalbayar"
        txttotalbayar.Size = New Size(160, 31)
        txttotalbayar.TabIndex = 13
        ' 
        ' txtkembalian
        ' 
        txtkembalian.Location = New Point(607, 228)
        txtkembalian.Name = "txtkembalian"
        txtkembalian.Size = New Size(160, 31)
        txtkembalian.TabIndex = 14
        ' 
        ' btnbayar
        ' 
        btnbayar.BackColor = Color.SaddleBrown
        btnbayar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnbayar.ForeColor = Color.Transparent
        btnbayar.Location = New Point(124, 328)
        btnbayar.Name = "btnbayar"
        btnbayar.Size = New Size(114, 41)
        btnbayar.TabIndex = 15
        btnbayar.Text = "Bayar"
        btnbayar.UseVisualStyleBackColor = False
        ' 
        ' btntotal
        ' 
        btntotal.BackColor = Color.SaddleBrown
        btntotal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntotal.ForeColor = Color.Transparent
        btntotal.Location = New Point(346, 328)
        btntotal.Name = "btntotal"
        btntotal.Size = New Size(114, 41)
        btntotal.TabIndex = 16
        btntotal.Text = "Total"
        btntotal.UseVisualStyleBackColor = False
        ' 
        ' btnkeluar
        ' 
        btnkeluar.BackColor = Color.SaddleBrown
        btnkeluar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnkeluar.ForeColor = Color.Transparent
        btnkeluar.Location = New Point(566, 328)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(114, 41)
        btnkeluar.TabIndex = 17
        btnkeluar.Text = "Keluar"
        btnkeluar.UseVisualStyleBackColor = False
        ' 
        ' cmboxnamapesanan
        ' 
        cmboxnamapesanan.FormattingEnabled = True
        cmboxnamapesanan.Items.AddRange(New Object() {"Hazelnut Chocolate Boba Milk", "Taro Boba Milk Tea", "Green Tea Boba", "Matcha Latte Boba Milk Tea", "Milk Foam Green Tea Boba", "Strawberry Boba Milk Tea"})
        cmboxnamapesanan.Location = New Point(188, 152)
        cmboxnamapesanan.Name = "cmboxnamapesanan"
        cmboxnamapesanan.Size = New Size(272, 33)
        cmboxnamapesanan.TabIndex = 18
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(cmboxnamapesanan)
        Controls.Add(btnkeluar)
        Controls.Add(btntotal)
        Controls.Add(btnbayar)
        Controls.Add(txtkembalian)
        Controls.Add(txttotalbayar)
        Controls.Add(txttotalharga)
        Controls.Add(txthargapesanan)
        Controls.Add(txtjumlahpesanan)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form2"
        RightToLeft = RightToLeft.No
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtjumlahpesanan As TextBox
    Friend WithEvents txthargapesanan As TextBox
    Friend WithEvents txttotalharga As TextBox
    Friend WithEvents txttotalbayar As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents btnbayar As Button
    Friend WithEvents btntotal As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents cmboxnamapesanan As ComboBox
End Class
