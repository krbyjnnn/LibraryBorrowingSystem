<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBooks
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
        dgvBooksData = New DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        txtFilter = New TextBox()
        Label2 = New Label()
        btnClose = New Button()
        btnArchiveBook = New Button()
        btnEditBook = New Button()
        btnAddBook = New Button()
        Panel1.SuspendLayout()
        CType(dgvBooksData, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-13, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1059, 63)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(25, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 40)
        Label1.TabIndex = 0
        Label1.Text = "BOOK MANAGEMENT"
        ' 
        ' dgvBooksData
        ' 
        dgvBooksData.AllowUserToAddRows = False
        dgvBooksData.AllowUserToDeleteRows = False
        dgvBooksData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBooksData.BackgroundColor = SystemColors.ButtonHighlight
        dgvBooksData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooksData.Columns.AddRange(New DataGridViewColumn() {Column6, Column1, Column2, Column3, Column4, Column5, Status, Column7})
        dgvBooksData.Location = New Point(12, 81)
        dgvBooksData.Name = "dgvBooksData"
        dgvBooksData.ReadOnly = True
        dgvBooksData.RowHeadersWidth = 51
        dgvBooksData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBooksData.Size = New Size(1007, 369)
        dgvBooksData.TabIndex = 7
        ' 
        ' Column6
        ' 
        Column6.FillWeight = 40F
        Column6.HeaderText = "ID"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 130F
        Column1.HeaderText = "ISBN"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 170F
        Column2.HeaderText = "Title"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 150F
        Column3.HeaderText = "Author"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Category"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.FillWeight = 130F
        Column5.HeaderText = "Publisher"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.FillWeight = 90F
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.FillWeight = 80F
        Column7.HeaderText = "Active"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(txtFilter)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(btnClose)
        Panel2.Controls.Add(btnArchiveBook)
        Panel2.Controls.Add(btnEditBook)
        Panel2.Controls.Add(btnAddBook)
        Panel2.Location = New Point(-13, 456)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1059, 52)
        Panel2.TabIndex = 7
        ' 
        ' txtFilter
        ' 
        txtFilter.Location = New Point(521, 12)
        txtFilter.Name = "txtFilter"
        txtFilter.Size = New Size(323, 27)
        txtFilter.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(382, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 4
        Label2.Text = "Filter by Book Title"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(919, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(113, 44)
        btnClose.TabIndex = 3
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnArchiveBook
        ' 
        btnArchiveBook.Location = New Point(263, 3)
        btnArchiveBook.Name = "btnArchiveBook"
        btnArchiveBook.Size = New Size(113, 44)
        btnArchiveBook.TabIndex = 2
        btnArchiveBook.Text = "ARCHIVE"
        btnArchiveBook.UseVisualStyleBackColor = True
        ' 
        ' btnEditBook
        ' 
        btnEditBook.Location = New Point(144, 3)
        btnEditBook.Name = "btnEditBook"
        btnEditBook.Size = New Size(113, 44)
        btnEditBook.TabIndex = 1
        btnEditBook.Text = "EDIT BOOK"
        btnEditBook.UseVisualStyleBackColor = True
        ' 
        ' btnAddBook
        ' 
        btnAddBook.Location = New Point(25, 3)
        btnAddBook.Name = "btnAddBook"
        btnAddBook.Size = New Size(113, 44)
        btnAddBook.TabIndex = 0
        btnAddBook.Text = "ADD BOOK"
        btnAddBook.UseVisualStyleBackColor = True
        ' 
        ' formBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 520)
        Controls.Add(Panel2)
        Controls.Add(dgvBooksData)
        Controls.Add(Panel1)
        Name = "formBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BOOK MANAGEMENT"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBooksData, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBooksData As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnArchiveBook As Button
    Friend WithEvents btnEditBook As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
