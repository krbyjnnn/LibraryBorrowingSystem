<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMembers
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
        txtFilter = New TextBox()
        Label2 = New Label()
        btnClose = New Button()
        btnArchiveBook = New Button()
        btnEditMember = New Button()
        btnAddMember = New Button()
        dgvMembersData = New DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2.SuspendLayout()
        CType(dgvMembersData, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(txtFilter)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(btnClose)
        Panel2.Controls.Add(btnArchiveBook)
        Panel2.Controls.Add(btnEditMember)
        Panel2.Controls.Add(btnAddMember)
        Panel2.Location = New Point(-14, 456)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1059, 52)
        Panel2.TabIndex = 10
        ' 
        ' txtFilter
        ' 
        txtFilter.Location = New Point(583, 12)
        txtFilter.Name = "txtFilter"
        txtFilter.Size = New Size(261, 27)
        txtFilter.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(382, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 20)
        Label2.TabIndex = 4
        Label2.Text = "Filter by Name or Full Name"
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
        ' btnEditMember
        ' 
        btnEditMember.Location = New Point(144, 3)
        btnEditMember.Name = "btnEditMember"
        btnEditMember.Size = New Size(113, 44)
        btnEditMember.TabIndex = 1
        btnEditMember.Text = "EDIT MEMBER"
        btnEditMember.UseVisualStyleBackColor = True
        ' 
        ' btnAddMember
        ' 
        btnAddMember.Location = New Point(25, 3)
        btnAddMember.Name = "btnAddMember"
        btnAddMember.Size = New Size(113, 44)
        btnAddMember.TabIndex = 0
        btnAddMember.Text = "ADD MEMBER"
        btnAddMember.UseVisualStyleBackColor = True
        ' 
        ' dgvMembersData
        ' 
        dgvMembersData.AllowUserToAddRows = False
        dgvMembersData.AllowUserToDeleteRows = False
        dgvMembersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembersData.BackgroundColor = SystemColors.ButtonHighlight
        dgvMembersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembersData.Columns.AddRange(New DataGridViewColumn() {Column6, Column1, Column2, Column3, Column4, Column5})
        dgvMembersData.Location = New Point(11, 81)
        dgvMembersData.Name = "dgvMembersData"
        dgvMembersData.ReadOnly = True
        dgvMembersData.RowHeadersWidth = 51
        dgvMembersData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembersData.Size = New Size(1007, 369)
        dgvMembersData.TabIndex = 9
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
        Column1.HeaderText = "Full Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 170F
        Column2.HeaderText = "Email"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 150F
        Column3.HeaderText = "Contact"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Membership"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.FillWeight = 130F
        Column5.HeaderText = "Active"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-14, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1059, 63)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(25, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 40)
        Label1.TabIndex = 0
        Label1.Text = "MEMBERS MANAGEMENT"
        ' 
        ' formMembers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 520)
        Controls.Add(Panel2)
        Controls.Add(dgvMembersData)
        Controls.Add(Panel1)
        Name = "formMembers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MEMBERS MANAGEMENT"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvMembersData, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnArchiveBook As Button
    Friend WithEvents btnEditMember As Button
    Friend WithEvents btnAddMember As Button
    Friend WithEvents dgvMembersData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
