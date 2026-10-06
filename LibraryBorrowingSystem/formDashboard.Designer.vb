<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDashboard
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnPayments = New Button()
        btnMembers = New Button()
        btnBooks = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        dgvTransactionHistory = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        lblUser = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        lblTime = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvTransactionHistory, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-5, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 105)
        Panel1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label2.Location = New Point(17, 55)
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
        Label1.Location = New Point(17, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 33)
        Label1.TabIndex = 0
        Label1.Text = "LIBRARY BORROWING"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnPayments)
        Panel2.Controls.Add(btnMembers)
        Panel2.Controls.Add(btnBooks)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(-14, 123)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(882, 77)
        Panel2.TabIndex = 6
        ' 
        ' btnPayments
        ' 
        btnPayments.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPayments.Location = New Point(739, 40)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(118, 29)
        btnPayments.TabIndex = 6
        btnPayments.Text = "Payments"
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnMembers
        ' 
        btnMembers.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMembers.Location = New Point(463, 40)
        btnMembers.Name = "btnMembers"
        btnMembers.Size = New Size(118, 29)
        btnMembers.TabIndex = 4
        btnMembers.Text = "Members"
        btnMembers.UseVisualStyleBackColor = True
        ' 
        ' btnBooks
        ' 
        btnBooks.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBooks.Location = New Point(320, 40)
        btnBooks.Name = "btnBooks"
        btnBooks.Size = New Size(118, 29)
        btnBooks.TabIndex = 3
        btnBooks.Text = "Books"
        btnBooks.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(173, 40)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 29)
        Button2.TabIndex = 2
        Button2.Text = "Return Book"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(26, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 29)
        Button1.TabIndex = 1
        Button1.Text = "Borrow Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 24)
        Label3.TabIndex = 0
        Label3.Text = "NAVIGATION MENU"
        ' 
        ' dgvTransactionHistory
        ' 
        dgvTransactionHistory.AllowUserToAddRows = False
        dgvTransactionHistory.AllowUserToDeleteRows = False
        dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactionHistory.BackgroundColor = SystemColors.ButtonHighlight
        dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionHistory.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvTransactionHistory.Location = New Point(12, 234)
        dgvTransactionHistory.Name = "dgvTransactionHistory"
        dgvTransactionHistory.ReadOnly = True
        dgvTransactionHistory.RowHeadersWidth = 51
        dgvTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactionHistory.Size = New Size(831, 268)
        dgvTransactionHistory.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date/Time"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Transaction Type"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "User/Patron"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Book Title"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Status"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(206, 28)
        Label4.TabIndex = 5
        Label4.Text = "RECENT ACTIVITY LOG"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, lblUser, ToolStripStatusLabel3, lblTime})
        StatusStrip1.Location = New Point(0, 507)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(855, 26)
        StatusStrip1.TabIndex = 8
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(74, 20)
        ToolStripStatusLabel1.Text = "Welcome,"
        ' 
        ' lblUser
        ' 
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(36, 20)
        lblUser.Text = "user"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(13, 20)
        ToolStripStatusLabel3.Text = "|"
        ' 
        ' lblTime
        ' 
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(63, 20)
        lblTime.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' formDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 533)
        Controls.Add(StatusStrip1)
        Controls.Add(Label4)
        Controls.Add(dgvTransactionHistory)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "formDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DASHBOARD"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvTransactionHistory, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvTransactionHistory As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPayments As Button
End Class
