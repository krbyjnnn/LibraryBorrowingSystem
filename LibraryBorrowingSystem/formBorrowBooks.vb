Imports MySql.Data.MySqlClient

Public Class formBorrowBooks

    Private Const LOAN_DAYS As Integer = 7

    Private Sub formBorrowBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMembersList()
        Call LoadBooksList()
        txtDueDate.Text = Date.Today.AddDays(LOAN_DAYS).ToString("yyyy-MM-dd")
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

    Private Sub LoadBooksList()
        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT book_id, title FROM books WHERE book_active = 1 AND status = 'Available'", sqlcon)
        da.Fill(ds, "books")

        cboBook.Items.Clear()

        For i As Integer = 0 To ds.Tables("books").Rows.Count - 1
            Dim book_id As String = ds.Tables("books").Rows(i).Item("book_id").ToString()
            Dim title As String = ds.Tables("books").Rows(i).Item("title").ToString()

            cboBook.Items.Add(title & " (ID " & book_id & ")")
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If cboMember.FindStringExact(cboMember.Text) = -1 Then
            MessageBox.Show("Select a valid member.")
            Exit Sub
        End If

        If cboBook.FindStringExact(cboBook.Text) = -1 Then
            MessageBox.Show("Select a valid book.")
            Exit Sub
        End If

        Dim member_text As String = cboMember.Text
        Dim member_name As String = member_text.Substring(0, member_text.LastIndexOf(" (ID "))
        Dim member_start As Integer = member_text.LastIndexOf("(ID ") + 4
        Dim member_id As Integer = Convert.ToInt32(member_text.Substring(member_start, member_text.Length - member_start - 1))

        Dim book_text As String = cboBook.Text
        Dim book_title As String = book_text.Substring(0, book_text.LastIndexOf(" (ID "))
        Dim book_start As Integer = book_text.LastIndexOf("(ID ") + 4
        Dim book_id As Integer = Convert.ToInt32(book_text.Substring(book_start, book_text.Length - book_start - 1))

        Dim due_date As Date = Date.Today.AddDays(LOAN_DAYS)
        Dim block_message As String = ""

        Call connectDB()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT membership_expiry FROM members WHERE member_id=@member_id", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("member_id", member_id)
        da.Fill(ds, "members")
        Dim expiry_value As Object = ds.Tables("members").Rows(0).Item("membership_expiry")
        If IsDBNull(expiry_value) OrElse Convert.ToDateTime(expiry_value).Date < Date.Today Then
            block_message = "This member has no valid membership. Collect the membership fee first."
        End If
        ds.Dispose()
        da.Dispose()

        If block_message = "" Then
            Dim ds2 As New DataSet
            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter("SELECT COUNT(*) FROM transaction_history WHERE member_id=@member_id AND transaction_type='RETURN' AND fine_amount > 0 AND fine_paid = 0", sqlcon)
            da2.SelectCommand.Parameters.AddWithValue("member_id", member_id)
            da2.Fill(ds2, "fines")
            If Convert.ToInt32(ds2.Tables("fines").Rows(0).Item(0)) > 0 Then
                block_message = "This member has an unpaid fine. Collect the fine first."
            End If
            ds2.Dispose()
            da2.Dispose()
        End If

        If block_message <> "" Then
            Call disconnectDB()
            MessageBox.Show(block_message)
            Exit Sub
        End If

        Dim ds3 As New DataSet
        Dim da3 As MySqlDataAdapter = New MySqlDataAdapter("INSERT INTO transaction_history (transaction_type, member_id, member_name, book_id, book_title, due_date, status) VALUES ('BORROW', @member_id, @member_name, @book_id, @book_title, @due_date, 'Active')", sqlcon)
        da3.SelectCommand.Parameters.AddWithValue("member_id", member_id)
        da3.SelectCommand.Parameters.AddWithValue("member_name", member_name)
        da3.SelectCommand.Parameters.AddWithValue("book_id", book_id)
        da3.SelectCommand.Parameters.AddWithValue("book_title", book_title)
        da3.SelectCommand.Parameters.AddWithValue("due_date", due_date)
        da3.Fill(ds3, "transaction_history")
        ds3.Dispose()
        da3.Dispose()

        Dim ds4 As New DataSet
        Dim da4 As MySqlDataAdapter = New MySqlDataAdapter("UPDATE books SET status='Borrowed' WHERE book_id=@book_id", sqlcon)
        da4.SelectCommand.Parameters.AddWithValue("book_id", book_id)
        da4.Fill(ds4, "books")
        ds4.Dispose()
        da4.Dispose()

        Call disconnectDB()

        MessageBox.Show("Book borrowed." & vbCrLf & "Due date: " & due_date.ToString("yyyy-MM-dd"))

        formBooks.LoadBooksData()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class