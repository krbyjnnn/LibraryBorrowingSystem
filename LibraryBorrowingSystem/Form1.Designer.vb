<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblUsername = New Label()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        lblPassword = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        btnLogin = New Button()
        btnExit = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(211, 119)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(65, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "EMAIL"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(21, 142)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(436, 28)
        txtEmail.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(21, 202)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(436, 28)
        txtPassword.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(193, 179)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(105, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "PASSWORD"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-23, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(523, 105)
        Panel1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label2.Location = New Point(206, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 33)
        Label2.TabIndex = 1
        Label2.Text = "SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(100, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 33)
        Label1.TabIndex = 0
        Label1.Text = "LIBRARY BORROWING"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(-23, 276)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(533, 53)
        Panel2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        Label4.Location = New Point(100, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(309, 20)
        Label4.TabIndex = 1
        Label4.Text = "Unauthorized attempts to log in are prohibited."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        Label3.Location = New Point(187, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 20)
        Label3.TabIndex = 0
        Label3.Text = "Authorized Access Only."
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(145, 237)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 33)
        btnLogin.TabIndex = 6
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(255, 237)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 33)
        btnExit.TabIndex = 7
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 341)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtEmail)
        Controls.Add(lblUsername)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button

End Class
