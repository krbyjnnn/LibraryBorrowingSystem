<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReturnBooks
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
        cboBorrowed = New ComboBox()
        Label3 = New Label()
        txtMember = New TextBox()
        txtBook = New TextBox()
        Label4 = New Label()
        txtDueDate = New TextBox()
        Label5 = New Label()
        txtDaysLate = New TextBox()
        Label6 = New Label()
        txtFine = New TextBox()
        Label7 = New Label()
        Panel2 = New Panel()
        btnReturn = New Button()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-16, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 63)
        Panel1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(87, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 40)
        Label1.TabIndex = 1
        Label1.Text = "RETURN BOOK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 10
        Label2.Text = "Borrowed Book"
        ' 
        ' cboBorrowed
        ' 
        cboBorrowed.FormattingEnabled = True
        cboBorrowed.Location = New Point(143, 81)
        cboBorrowed.Name = "cboBorrowed"
        cboBorrowed.Size = New Size(274, 28)
        cboBorrowed.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 12
        Label3.Text = "Member"
        ' 
        ' txtMember
        ' 
        txtMember.Location = New Point(143, 115)
        txtMember.Name = "txtMember"
        txtMember.Size = New Size(274, 27)
        txtMember.TabIndex = 13
        ' 
        ' txtBook
        ' 
        txtBook.Location = New Point(143, 148)
        txtBook.Name = "txtBook"
        txtBook.Size = New Size(274, 27)
        txtBook.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 14
        Label4.Text = "Book"
        ' 
        ' txtDueDate
        ' 
        txtDueDate.Location = New Point(143, 181)
        txtDueDate.Name = "txtDueDate"
        txtDueDate.Size = New Size(274, 27)
        txtDueDate.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 16
        Label5.Text = "Due Date"
        ' 
        ' txtDaysLate
        ' 
        txtDaysLate.Location = New Point(143, 214)
        txtDaysLate.Name = "txtDaysLate"
        txtDaysLate.Size = New Size(274, 27)
        txtDaysLate.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 217)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 20)
        Label6.TabIndex = 18
        Label6.Text = "Days Late"
        ' 
        ' txtFine
        ' 
        txtFine.Location = New Point(143, 247)
        txtFine.Name = "txtFine"
        txtFine.Size = New Size(274, 27)
        txtFine.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 250)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 20)
        Label7.TabIndex = 20
        Label7.Text = "Fine"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnReturn)
        Panel2.Location = New Point(-26, 280)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(563, 51)
        Panel2.TabIndex = 10
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(169, 12)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 29)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(274, 12)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' formReturnBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 338)
        Controls.Add(Panel2)
        Controls.Add(txtFine)
        Controls.Add(Label7)
        Controls.Add(txtDaysLate)
        Controls.Add(Label6)
        Controls.Add(txtDueDate)
        Controls.Add(Label5)
        Controls.Add(txtBook)
        Controls.Add(Label4)
        Controls.Add(txtMember)
        Controls.Add(Label3)
        Controls.Add(cboBorrowed)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "formReturnBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formReturnBooks"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboBorrowed As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMember As TextBox
    Friend WithEvents txtBook As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDueDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDaysLate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFine As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReturn As Button
End Class
