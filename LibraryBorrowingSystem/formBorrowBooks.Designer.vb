<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBorrowBooks
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
        btnBorrow = New Button()
        txtDueDate = New TextBox()
        Label4 = New Label()
        cboBook = New ComboBox()
        Label3 = New Label()
        cboMember = New ComboBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnBorrow)
        Panel2.Location = New Point(-21, 181)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(471, 47)
        Panel2.TabIndex = 9
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(262, 10)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnBorrow
        ' 
        btnBorrow.Location = New Point(162, 10)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(94, 29)
        btnBorrow.TabIndex = 8
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = True
        ' 
        ' txtDueDate
        ' 
        txtDueDate.Location = New Point(141, 148)
        txtDueDate.Name = "txtDueDate"
        txtDueDate.Size = New Size(273, 27)
        txtDueDate.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 14
        Label4.Text = "Due Date"
        ' 
        ' cboBook
        ' 
        cboBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboBook.AutoCompleteSource = AutoCompleteSource.ListItems
        cboBook.FormattingEnabled = True
        cboBook.Location = New Point(141, 114)
        cboBook.Name = "cboBook"
        cboBook.Size = New Size(273, 28)
        cboBook.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 12
        Label3.Text = "Book"
        ' 
        ' cboMember
        ' 
        cboMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboMember.AutoCompleteSource = AutoCompleteSource.ListItems
        cboMember.FormattingEnabled = True
        cboMember.Location = New Point(141, 80)
        cboMember.Name = "cboMember"
        cboMember.Size = New Size(273, 28)
        cboMember.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 10
        Label2.Text = "Member"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-21, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(463, 63)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(87, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 40)
        Label1.TabIndex = 1
        Label1.Text = "BORROW BOOK"
        ' 
        ' formBorrowBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 239)
        Controls.Add(Panel2)
        Controls.Add(txtDueDate)
        Controls.Add(Label4)
        Controls.Add(cboBook)
        Controls.Add(Label3)
        Controls.Add(cboMember)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "formBorrowBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BORROW"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents txtDueDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboBook As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMember As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
