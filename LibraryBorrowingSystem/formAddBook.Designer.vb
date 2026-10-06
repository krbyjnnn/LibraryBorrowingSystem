<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddBook
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
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        txtIsbn = New TextBox()
        txtTitle = New TextBox()
        Label3 = New Label()
        txtAuthor = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtPublisher = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        cboCategory = New ComboBox()
        cboStatus = New ComboBox()
        Panel2 = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(460, 63)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(108, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 40)
        Label1.TabIndex = 1
        Label1.Text = "ADD A BOOK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 1
        Label2.Text = "ISBN"
        ' 
        ' txtIsbn
        ' 
        txtIsbn.Location = New Point(133, 81)
        txtIsbn.Name = "txtIsbn"
        txtIsbn.Size = New Size(284, 27)
        txtIsbn.TabIndex = 2
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(133, 114)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(284, 27)
        txtTitle.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 20)
        Label3.TabIndex = 3
        Label3.Text = "Title"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(133, 147)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(284, 27)
        txtAuthor.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 5
        Label4.Text = "Author"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 7
        Label5.Text = "Category"
        ' 
        ' txtPublisher
        ' 
        txtPublisher.Location = New Point(133, 213)
        txtPublisher.Name = "txtPublisher"
        txtPublisher.Size = New Size(284, 27)
        txtPublisher.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 9
        Label6.Text = "Publisher"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 11
        Label7.Text = "Status"
        ' 
        ' cboCategory
        ' 
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(133, 180)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(284, 28)
        cboCategory.TabIndex = 12
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Available", "Borrowed", "Maintenance"})
        cboStatus.Location = New Point(133, 246)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(284, 28)
        cboStatus.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnSave)
        Panel2.Location = New Point(-12, 280)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(468, 63)
        Panel2.TabIndex = 2
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(245, 19)
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
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 0
        btnSave.Text = "Save Book"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' formAddBook
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 352)
        Controls.Add(Panel2)
        Controls.Add(cboStatus)
        Controls.Add(cboCategory)
        Controls.Add(Label7)
        Controls.Add(txtPublisher)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtAuthor)
        Controls.Add(Label4)
        Controls.Add(txtTitle)
        Controls.Add(Label3)
        Controls.Add(txtIsbn)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "formAddBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADD BOOK"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
