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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        btnlogin = New Button()
        btnclose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(92, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 37)
        Label1.TabIndex = 0
        Label1.Text = "Silahkan Masuk"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(154, 189)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(221, 31)
        txtusername.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(154, 244)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(221, 31)
        txtpassword.TabIndex = 4
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.SaddleBrown
        btnlogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.Transparent
        btnlogin.Location = New Point(92, 325)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(114, 41)
        btnlogin.TabIndex = 5
        btnlogin.Text = "Masuk"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' btnclose
        ' 
        btnclose.BackColor = Color.SaddleBrown
        btnclose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclose.ForeColor = Color.Transparent
        btnclose.Location = New Point(242, 325)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(112, 41)
        btnclose.TabIndex = 6
        btnclose.Text = "Keluar"
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnclose)
        Controls.Add(btnlogin)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        RightToLeft = RightToLeft.No
        Text = "Form Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnclose As Button

End Class
