<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPayments
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
        cboMember = New ComboBox()
        Label3 = New Label()
        txtAmountDue = New TextBox()
        cboPaymentType = New ComboBox()
        cboFine = New ComboBox()
        lblFine = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtTendered = New TextBox()
        Label7 = New Label()
        txtChange = New TextBox()
        Label8 = New Label()
        txtReceiptNo = New TextBox()
        Panel2 = New Panel()
        btnCancel = New Button()
        btnPay = New Button()
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
        Panel1.Size = New Size(484, 63)
        Panel1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(26), CByte(32), CByte(44))
        Label1.Location = New Point(24, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(402, 40)
        Label1.TabIndex = 1
        Label1.Text = "PAY FOR MEMBERSHIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 16
        Label2.Text = "Member"
        ' 
        ' cboMember
        ' 
        cboMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboMember.AutoCompleteSource = AutoCompleteSource.ListItems
        cboMember.FormattingEnabled = True
        cboMember.Location = New Point(147, 81)
        cboMember.Name = "cboMember"
        cboMember.Size = New Size(267, 28)
        cboMember.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 18
        Label3.Text = "Payment Type"
        ' 
        ' txtAmountDue
        ' 
        txtAmountDue.Location = New Point(147, 183)
        txtAmountDue.Name = "txtAmountDue"
        txtAmountDue.ReadOnly = True
        txtAmountDue.Size = New Size(267, 27)
        txtAmountDue.TabIndex = 19
        ' 
        ' cboPaymentType
        ' 
        cboPaymentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentType.FormattingEnabled = True
        cboPaymentType.Items.AddRange(New Object() {"Membership", "Overdue Fine"})
        cboPaymentType.Location = New Point(147, 115)
        cboPaymentType.Name = "cboPaymentType"
        cboPaymentType.Size = New Size(267, 28)
        cboPaymentType.TabIndex = 20
        ' 
        ' cboFine
        ' 
        cboFine.FormattingEnabled = True
        cboFine.Location = New Point(147, 149)
        cboFine.Name = "cboFine"
        cboFine.Size = New Size(267, 28)
        cboFine.TabIndex = 22
        cboFine.Visible = False
        ' 
        ' lblFine
        ' 
        lblFine.AutoSize = True
        lblFine.Location = New Point(12, 152)
        lblFine.Name = "lblFine"
        lblFine.Size = New Size(61, 20)
        lblFine.TabIndex = 21
        lblFine.Text = "Fine For"
        lblFine.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 20)
        Label5.TabIndex = 23
        Label5.Text = "Amount Due"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 20)
        Label6.TabIndex = 25
        Label6.Text = "Amount Tendered"
        ' 
        ' txtTendered
        ' 
        txtTendered.Location = New Point(147, 216)
        txtTendered.Name = "txtTendered"
        txtTendered.Size = New Size(267, 27)
        txtTendered.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 20)
        Label7.TabIndex = 27
        Label7.Text = "Change"
        ' 
        ' txtChange
        ' 
        txtChange.Location = New Point(147, 249)
        txtChange.Name = "txtChange"
        txtChange.ReadOnly = True
        txtChange.Size = New Size(267, 27)
        txtChange.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 285)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 20)
        Label8.TabIndex = 29
        Label8.Text = "Receipt No."
        ' 
        ' txtReceiptNo
        ' 
        txtReceiptNo.Location = New Point(147, 282)
        txtReceiptNo.Name = "txtReceiptNo"
        txtReceiptNo.ReadOnly = True
        txtReceiptNo.Size = New Size(267, 27)
        txtReceiptNo.TabIndex = 28
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnPay)
        Panel2.Location = New Point(-12, 315)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(508, 51)
        Panel2.TabIndex = 16
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(259, 12)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Location = New Point(159, 12)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(94, 29)
        btnPay.TabIndex = 0
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' formPayments
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 374)
        Controls.Add(Panel2)
        Controls.Add(Label8)
        Controls.Add(txtReceiptNo)
        Controls.Add(Label7)
        Controls.Add(txtChange)
        Controls.Add(Label6)
        Controls.Add(txtTendered)
        Controls.Add(Label5)
        Controls.Add(cboFine)
        Controls.Add(lblFine)
        Controls.Add(cboPaymentType)
        Controls.Add(txtAmountDue)
        Controls.Add(Label3)
        Controls.Add(cboMember)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "formPayments"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PAYMENTS"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMember As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmountDue As TextBox
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents cboFine As ComboBox
    Friend WithEvents lblFine As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTendered As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
End Class
