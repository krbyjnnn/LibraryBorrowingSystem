Imports MySql.Data.MySqlClient

Public Class formReturnBooks

    Private Const FINE_PER_DAY As Decimal = 5D

    Private Sub formReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadBorrowedList()
    End Sub

    Private Sub LoadBorrowedList()
        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT transaction_id, member_name, book_title FROM transaction_history WHERE transaction_type='BORROW' AND status='Active'", sqlcon)
        da.Fill(ds, "borrowed")

        cboBorrowed.Items.Clear()

        For i As Integer = 0 To ds.Tables("borrowed").Rows.Count - 1
            Dim transaction_id As String = ds.Tables("borrowed").Rows(i).Item("transaction_id").ToString()
            Dim member_name As String = ds.Tables("borrowed").Rows(i).Item("member_name").ToString()
            Dim book_title As String = ds.Tables("borrowed").Rows(i).Item("book_title").ToString()

            cboBorrowed.Items.Add(book_title & " - " & member_name & " (ID " & transaction_id & ")")
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Function GetTransactionId() As Integer
        Dim item_text As String = cboBorrowed.Text
        Dim id_start As Integer = item_text.LastIndexOf("(ID ") + 4
        Return Convert.ToInt32(item_text.Substring(id_start, item_text.Length - id_start - 1))
    End Function

    Private Sub cboBorrowed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowed.SelectedIndexChanged
        If cboBorrowed.FindStringExact(cboBorrowed.Text) = -1 Then
            Exit Sub
        End If

        Dim transaction_id As Integer = GetTransactionId()

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT member_name, book_title, due_date FROM transaction_history WHERE transaction_id=@transaction_id", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("transaction_id", transaction_id)
        da.Fill(ds, "borrowed")

        Dim due_date As Date = Convert.ToDateTime(ds.Tables("borrowed").Rows(0).Item("due_date"))
        Dim days_late As Integer = (Date.Today - due_date.Date).Days
        Dim fine As Decimal = If(days_late > 0, days_late * FINE_PER_DAY, 0D)

        txtMember.Text = ds.Tables("borrowed").Rows(0).Item("member_name").ToString()
        txtBook.Text = ds.Tables("borrowed").Rows(0).Item("book_title").ToString()
        txtDueDate.Text = due_date.ToString("yyyy-MM-dd")
        txtDaysLate.Text = If(days_late > 0, days_late, 0).ToString()
        txtFine.Text = fine.ToString("0.00")

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If cboBorrowed.FindStringExact(cboBorrowed.Text) = -1 Then
            MessageBox.Show("Select a borrowed book.")
            Exit Sub
        End If

        Dim transaction_id As Integer = GetTransactionId()

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT member_id, member_name, book_id, book_title, due_date FROM transaction_history WHERE transaction_id=@transaction_id", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("transaction_id", transaction_id)
        da.Fill(ds, "borrowed")

        Dim member_id As Integer = Convert.ToInt32(ds.Tables("borrowed").Rows(0).Item("member_id"))
        Dim member_name As String = ds.Tables("borrowed").Rows(0).Item("member_name").ToString()
        Dim book_id As Integer = Convert.ToInt32(ds.Tables("borrowed").Rows(0).Item("book_id"))
        Dim book_title As String = ds.Tables("borrowed").Rows(0).Item("book_title").ToString()
        Dim due_date As Date = Convert.ToDateTime(ds.Tables("borrowed").Rows(0).Item("due_date"))
        ds.Dispose()
        da.Dispose()

        Dim days_late As Integer = (Date.Today - due_date.Date).Days
        Dim fine As Decimal = If(days_late > 0, days_late * FINE_PER_DAY, 0D)

        Dim ds2 As New DataSet
        Dim da2 As MySqlDataAdapter = New MySqlDataAdapter("UPDATE transaction_history SET status='Closed' WHERE transaction_id=@transaction_id", sqlcon)
        da2.SelectCommand.Parameters.AddWithValue("transaction_id", transaction_id)
        da2.Fill(ds2, "transaction_history")
        ds2.Dispose()
        da2.Dispose()

        Dim ds3 As New DataSet
        Dim da3 As MySqlDataAdapter = New MySqlDataAdapter("INSERT INTO transaction_history (transaction_type, member_id, member_name, book_id, book_title, due_date, fine_amount, status) VALUES ('RETURN', @member_id, @member_name, @book_id, @book_title, @due_date, @fine_amount, 'Closed')", sqlcon)
        da3.SelectCommand.Parameters.AddWithValue("member_id", member_id)
        da3.SelectCommand.Parameters.AddWithValue("member_name", member_name)
        da3.SelectCommand.Parameters.AddWithValue("book_id", book_id)
        da3.SelectCommand.Parameters.AddWithValue("book_title", book_title)
        da3.SelectCommand.Parameters.AddWithValue("due_date", due_date)
        da3.SelectCommand.Parameters.AddWithValue("fine_amount", fine)
        da3.Fill(ds3, "transaction_history")
        ds3.Dispose()
        da3.Dispose()

        Dim ds4 As New DataSet
        Dim da4 As MySqlDataAdapter = New MySqlDataAdapter("UPDATE books SET status='Available' WHERE book_id=@book_id", sqlcon)
        da4.SelectCommand.Parameters.AddWithValue("book_id", book_id)
        da4.Fill(ds4, "books")
        ds4.Dispose()
        da4.Dispose()

        Call disconnectDB()

        If fine > 0 Then
            MessageBox.Show("Book returned." & vbCrLf & "Overdue fine: " & fine.ToString("0.00") & vbCrLf & "Collect it in Payments before this member can borrow again.")
        Else
            MessageBox.Show("Book returned.")
        End If

        formBooks.LoadBooksData()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class