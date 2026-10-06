<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditBook
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
        btnUpdate = New Button()
        cboStatus = New ComboBox()
        cboCategory = New ComboBox()
        txtPublisher = New TextBox()
        txtAuthor = New TextBox()
        txtTitle = New TextBox()
        txtIsbn = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        lblBookId = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Location = New Point(-12, 303)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(468, 63)
        Panel2.TabIndex = 15
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
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(145, 19)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 0
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Available", "Borrowed", "Maintenance"})
        cboStatus.Location = New Point(133, 265)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(284, 28)
        cboStatus.TabIndex = 21
        ' 
        ' cboCategory
        ' 
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(133, 199)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(284, 28)
        cboCategory.TabIndex = 20
        ' 
        ' txtPublisher
        ' 
        txtPublisher.Location = New Point(133, 232)
        txtPublisher.Name = "txtPublisher"
        txtPublisher.Size = New Size(284, 27)
        txtPublisher.TabIndex = 19
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(133, 166)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(284, 27)
        txtAuthor.TabIndex = 18
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(133, 133)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(284, 27)
        txtTitle.TabIndex = 17
        ' 
        ' txtIsbn
        ' 
        txtIsbn.Location = New Point(133, 100)
        txtIsbn.Name = "txtIsbn"
        txtIsbn.Size = New Size(284, 27)
        txtIsbn.TabIndex = 16
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
        Label1.Location = New Point(133, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 40)
        Label1.TabIndex = 1
        Label1.Text = "EDIT BOOK"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 264)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 27
        Label7.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 26
        Label6.Text = "Publisher"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 25
        Label5.Text = "Category"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 24
        Label4.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 20)
        Label3.TabIndex = 23
        Label3.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 22
        Label2.Text = "ISBN"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 77)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 20)
        Label8.TabIndex = 28
        Label8.Text = "Book ID"
        ' 
        ' lblBookId
        ' 
        lblBookId.AutoSize = True
        lblBookId.Location = New Point(133, 77)
        lblBookId.Name = "lblBookId"
        lblBookId.Size = New Size(17, 20)
        lblBookId.TabIndex = 29
        lblBookId.Text = "0"
        ' 
        ' formEditBook
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 372)
        Controls.Add(lblBookId)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(cboStatus)
        Controls.Add(cboCategory)
        Controls.Add(txtPublisher)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(txtIsbn)
        Controls.Add(Panel1)
        Name = "formEditBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EDIT BOOK"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBookId As Label
End Class
