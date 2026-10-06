<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddMembers
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
        Panel2 = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        txtContactNo = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        txtLastName = New TextBox()
        Label4 = New Label()
        txtMiddleName = New TextBox()
        Label3 = New Label()
        txtFirstName = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        txtEmail = New TextBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnSave)
        Panel2.Location = New Point(-20, 245)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(492, 63)
        Panel2.TabIndex = 16
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(276, 19)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(145, 19)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 29)
        btnSave.TabIndex = 0
        btnSave.Text = "Save Member"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(125, 212)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(284, 27)
        txtContactNo.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(4, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 20)
        Label6.TabIndex = 23
        Label6.Text = "Contact No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(4, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 22
        Label5.Text = "Email"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(125, 146)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(284, 27)
        txtLastName.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 20
        Label4.Text = "Last Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(125, 113)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(284, 27)
        txtMiddleName.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 18
        Label3.Text = "Middle Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(125, 80)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(284, 27)
        txtFirstName.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 15
        Label2.Text = "First Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-20, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(460, 63)
        Panel1.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(55, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 40)
        Label1.TabIndex = 1
        Label1.Text = "ADD NEW MEMBER"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(125, 179)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(284, 27)
        txtEmail.TabIndex = 25
        ' 
        ' formAddMembers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 322)
        Controls.Add(txtEmail)
        Controls.Add(Panel2)
        Controls.Add(txtContactNo)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtLastName)
        Controls.Add(Label4)
        Controls.Add(txtMiddleName)
        Controls.Add(Label3)
        Controls.Add(txtFirstName)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "formAddMembers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formAddMembers"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
End Class
