Imports MySql.Data.MySqlClient

Public Class formPayments

    Private Const MEMBERSHIP_FEE As Decimal = 100D
    Private Const MEMBERSHIP_MONTHS As Integer = 12
    Private Const STAFF_ID As Integer = 1

    Private Sub formPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMembersList()
        txtReceiptNo.Text = GenerateReceiptNo()
        cboPaymentType.SelectedIndex = 0
    End Sub

    Private Sub cboPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentType.SelectedIndexChanged
        Dim is_fine As Boolean = (cboPaymentType.Text = "Overdue Fine")

        lblFine.Visible = is_fine
        cboFine.Visible = is_fine

        If cboPaymentType.Text = "Membership" Then
            txtAmountDue.Text = MEMBERSHIP_FEE.ToString("0.00")
        Else
            txtAmountDue.Text = ""
        End If

        If is_fine Then
            Call LoadFinesList()
        End If

        txtTendered.Text = ""
        txtChange.Text = ""
    End Sub

    Private Sub cboMember_Changed(sender As Object, e As EventArgs) Handles cboMember.SelectedIndexChanged, cboMember.Leave
        If cboPaymentType.Text = "Overdue Fine" Then
            Call LoadFinesList()
            txtAmountDue.Text = ""
            txtTendered.Text = ""
            txtChange.Text = ""
        End If
    End Sub

    Private Sub cboFine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFine.SelectedIndexChanged
        If cboFine.FindStringExact(cboFine.Text) = -1 Then
            Exit Sub
        End If

        Dim transaction_id As Integer = GetFineTransactionId()

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT fine_amount FROM transaction_history WHERE transaction_id=@transaction_id", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("transaction_id", transaction_id)
        da.Fill(ds, "fine")
        txtAmountDue.Text = Convert.ToDecimal(ds.Tables("fine").Rows(0).Item("fine_amount")).ToString("0.00")
        ds.Dispose()
        da.Dispose()
        Call disconnectDB()

        txtTendered.Text = ""
        txtChange.Text = ""
    End Sub

    Private Sub LoadMembersList()
        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT member_id, member_first_name, member_middle_name, member_last_name FROM members WHERE member_active = 1", sqlcon)
        da.Fill(ds, "members")

        cboMember.Items.Clear()

        For i As Integer = 0 To ds.Tables("members").Rows.Count - 1
            Dim member_id As String = ds.Tables("members").Rows(i).Item("member_id").ToString()
            Dim first_name As String = ds.Tables("members").Rows(i).Item("member_first_name").ToString()
            Dim middle_name As String = ds.Tables("members").Rows(i).Item("member_middle_name").ToString()
            Dim last_name As String = ds.Tables("members").Rows(i).Item("member_last_name").ToString()
            Dim full_name As String = (first_name & " " & middle_name & " " & last_name).Replace("  ", " ").Trim()

            cboMember.Items.Add(full_name & " (ID " & member_id & ")")
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Function GetMemberId() As Integer
        Dim member_text As String = cboMember.Text
        Dim id_start As Integer = member_text.LastIndexOf("(ID ") + 4
        Return Convert.ToInt32(member_text.Substring(id_start, member_text.Length - id_start - 1))
    End Function

    Private Function GetFineTransactionId() As Integer
        Dim fine_text As String = cboFine.Text
        Dim id_start As Integer = fine_text.LastIndexOf("(ID ") + 4
        Return Convert.ToInt32(fine_text.Substring(id_start, fine_text.Length - id_start - 1))
    End Function

    Private Sub LoadFinesList()
        cboFine.Items.Clear()
        cboFine.Text = ""

        If cboMember.FindStringExact(cboMember.Text) = -1 Then
            Exit Sub
        End If

        Dim member_id As Integer = GetMemberId()

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT transaction_id, book_title, fine_amount FROM transaction_history WHERE member_id=@member_id AND transaction_type='RETURN' AND fine_amount > 0 AND fine_paid = 0", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("member_id", member_id)
        da.Fill(ds, "fines")

        For i As Integer = 0 To ds.Tables("fines").Rows.Count - 1
            Dim transaction_id As String = ds.Tables("fines").Rows(i).Item("transaction_id").ToString()
            Dim book_title As String = ds.Tables("fines").Rows(i).Item("book_title").ToString()
            Dim fine As Decimal = Convert.ToDecimal(ds.Tables("fines").Rows(i).Item("fine_amount"))

            cboFine.Items.Add(book_title & " - " & fine.ToString("0.00") & " (ID " & transaction_id & ")")
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Function GenerateReceiptNo() As String
        Dim prefix As String = "OR-" & Date.Today.ToString("yyyyMMdd") & "-"

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT COUNT(*) FROM payments WHERE receipt_no LIKE @prefix", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("prefix", prefix & "%")
        da.Fill(ds, "payments")
        Dim receipt_count As Integer = Convert.ToInt32(ds.Tables("payments").Rows(0).Item(0))
        ds.Dispose()
        da.Dispose()
        Call disconnectDB()

        Return prefix & (receipt_count + 1).ToString("0000")
    End Function

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        Dim amount_due As Decimal
        Dim tendered As Decimal
        If Decimal.TryParse(txtAmountDue.Text, amount_due) AndAlso Decimal.TryParse(txtTendered.Text, tendered) AndAlso tendered >= amount_due Then
            txtChange.Text = (tendered - amount_due).ToString("0.00")
        Else
            txtChange.Text = ""
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If cboMember.FindStringExact(cboMember.Text) = -1 Then
            MessageBox.Show("Select a valid member.")
            Exit Sub
        End If

        Dim payment_type As String = cboPaymentType.Text

        If payment_type = "Overdue Fine" AndAlso cboFine.FindStringExact(cboFine.Text) = -1 Then
            MessageBox.Show("Select a fine to pay.")
            Exit Sub
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmountDue.Text, amount) Then
            MessageBox.Show("There is no amount due for this payment type.")
            Exit Sub
        End If

        Dim tendered As Decimal
        If Not Decimal.TryParse(txtTendered.Text, tendered) Then
            MessageBox.Show("Enter the amount tendered.")
            Exit Sub
        End If

        If tendered < amount Then
            MessageBox.Show("Amount tendered is less than the amount due.")
            Exit Sub
        End If

        Dim member_id As Integer = GetMemberId()
        Dim change_given As Decimal = tendered - amount
        Dim receipt_no As String = GenerateReceiptNo()

        Dim transaction_value As Object = DBNull.Value
        If payment_type = "Overdue Fine" Then
            transaction_value = GetFineTransactionId()
        End If

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("INSERT INTO payments (receipt_no, member_id, payment_type, transaction_id, amount, amount_tendered, change_given, processed_by) VALUES (@receipt_no, @member_id, @payment_type, @transaction_id, @amount, @amount_tendered, @change_given, @processed_by)", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("receipt_no", receipt_no)
        da.SelectCommand.Parameters.AddWithValue("member_id", member_id)
        da.SelectCommand.Parameters.AddWithValue("payment_type", payment_type)
        da.SelectCommand.Parameters.AddWithValue("transaction_id", transaction_value)
        da.SelectCommand.Parameters.AddWithValue("amount", amount)
        da.SelectCommand.Parameters.AddWithValue("amount_tendered", tendered)
        da.SelectCommand.Parameters.AddWithValue("change_given", change_given)
        da.SelectCommand.Parameters.AddWithValue("processed_by", STAFF_ID)
        da.Fill(ds, "payments")
        ds.Dispose()
        da.Dispose()

        Dim message As String = "Payment successful." & vbCrLf & "Receipt No: " & receipt_no & vbCrLf & "Change: " & change_given.ToString("0.00")

        If payment_type = "Membership" Then
            Dim expiry_date As Date = Date.Today.AddMonths(MEMBERSHIP_MONTHS)
            Dim ds2 As New DataSet
            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter("UPDATE members SET membership_expiry=@membership_expiry WHERE member_id=@member_id", sqlcon)
            da2.SelectCommand.Parameters.AddWithValue("membership_expiry", expiry_date)
            da2.SelectCommand.Parameters.AddWithValue("member_id", member_id)
            da2.Fill(ds2, "members")
            ds2.Dispose()
            da2.Dispose()
            message &= vbCrLf & "Valid until: " & expiry_date.ToString("yyyy-MM-dd")
        Else
            Dim ds3 As New DataSet
            Dim da3 As MySqlDataAdapter = New MySqlDataAdapter("UPDATE transaction_history SET fine_paid=1, date_paid=NOW() WHERE transaction_id=@transaction_id", sqlcon)
            da3.SelectCommand.Parameters.AddWithValue("transaction_id", transaction_value)
            da3.Fill(ds3, "transaction_history")
            ds3.Dispose()
            da3.Dispose()
        End If
        Call disconnectDB()

        MessageBox.Show(message)

        formMembers.LoadMembersData()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class