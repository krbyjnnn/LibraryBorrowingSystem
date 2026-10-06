Imports MySql.Data.MySqlClient

Public Class formBooks

    Private Sub formBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadBooksData()
    End Sub

    Public Sub LoadBooksData()
        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM books", sqlcon)
        da.Fill(ds, "books")

        dgvBooksData.Rows.Clear()

        For i As Integer = 0 To ds.Tables("books").Rows.Count - 1
            Dim book_id As String = ds.Tables("books").Rows(i).Item("book_id").ToString()
            Dim isbn As String = ds.Tables("books").Rows(i).Item("isbn").ToString()
            Dim title As String = ds.Tables("books").Rows(i).Item("title").ToString()
            Dim author As String = ds.Tables("books").Rows(i).Item("author").ToString()
            Dim category As String = ds.Tables("books").Rows(i).Item("category").ToString()
            Dim publisher As String = ds.Tables("books").Rows(i).Item("publisher").ToString()
            Dim status As String = ds.Tables("books").Rows(i).Item("status").ToString()
            Dim book_state As String = If(Convert.ToInt32(ds.Tables("books").Rows(i).Item("book_active")) = 1, "Active", "Archived")

            If Not String.IsNullOrWhiteSpace(title) AndAlso
               Not String.IsNullOrWhiteSpace(author) AndAlso
               Not String.IsNullOrWhiteSpace(book_id) Then

                dgvBooksData.Rows.Add(book_id, isbn, title, author, category, publisher, status, book_state)
            End If
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        formAddBook.Show()
    End Sub

    Private Sub btnEditBook_Click(sender As Object, e As EventArgs) Handles btnEditBook.Click
        If dgvBooksData.CurrentRow IsNot Nothing AndAlso dgvBooksData.Rows.Count > 0 Then

            Dim i As Integer = dgvBooksData.CurrentRow.Index

            Dim book_id As Integer = Convert.ToInt32(dgvBooksData.Item(0, i).Value)
            Dim isbn As String = dgvBooksData.Item(1, i).Value.ToString()
            Dim title As String = dgvBooksData.Item(2, i).Value.ToString()
            Dim author As String = dgvBooksData.Item(3, i).Value.ToString()
            Dim category As String = dgvBooksData.Item(4, i).Value.ToString()
            Dim publisher As String = dgvBooksData.Item(5, i).Value.ToString()
            Dim status As String = dgvBooksData.Item(6, i).Value.ToString()

            formEditBook.lblBookId.Text = book_id.ToString()
            formEditBook.txtIsbn.Text = isbn
            formEditBook.txtTitle.Text = title
            formEditBook.txtAuthor.Text = author
            formEditBook.cboCategory.Text = category
            formEditBook.txtPublisher.Text = publisher
            formEditBook.cboStatus.Text = status
            formEditBook.Show()
        End If
    End Sub

    Private Sub btnArchiveBook_Click(sender As Object, e As EventArgs) Handles btnArchiveBook.Click
        If dgvBooksData.CurrentRow Is Nothing Then Exit Sub

        Dim i As Integer = dgvBooksData.CurrentRow.Index
        Dim book_id As Integer = Convert.ToInt32(dgvBooksData.Item(0, i).Value)

        Call connectDB()
        Dim dataSet As New DataSet
        Dim dataAdapter As MySqlDataAdapter = New MySqlDataAdapter("UPDATE books SET book_active = NOT book_active WHERE book_id=@book_id", sqlcon)
        dataAdapter.SelectCommand.Parameters.AddWithValue("book_id", book_id)
        dataAdapter.Fill(dataSet, "books")
        dataSet.Dispose()
        dataAdapter.Dispose()
        Call disconnectDB()
        Call LoadBooksData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Dim search_string As String = txtFilter.Text.Trim()

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM books WHERE (title LIKE @search OR author LIKE @search OR isbn LIKE @search)", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("search", "%" & search_string & "%")
        da.Fill(ds, "books")

        dgvBooksData.Rows.Clear()

        For i As Integer = 0 To ds.Tables("books").Rows.Count - 1
            Dim book_id As String = ds.Tables("books").Rows(i).Item("book_id").ToString()
            Dim isbn As String = ds.Tables("books").Rows(i).Item("isbn").ToString()
            Dim title As String = ds.Tables("books").Rows(i).Item("title").ToString()
            Dim author As String = ds.Tables("books").Rows(i).Item("author").ToString()
            Dim category As String = ds.Tables("books").Rows(i).Item("category").ToString()
            Dim publisher As String = ds.Tables("books").Rows(i).Item("publisher").ToString()
            Dim status As String = ds.Tables("books").Rows(i).Item("status").ToString()
            Dim book_state As String = If(Convert.ToInt32(ds.Tables("books").Rows(i).Item("book_active")) = 1, "Active", "Archived")

            If Not String.IsNullOrWhiteSpace(title) AndAlso
               Not String.IsNullOrWhiteSpace(author) AndAlso
               Not String.IsNullOrWhiteSpace(book_id) Then

                dgvBooksData.Rows.Add(book_id, isbn, title, author, category, publisher, status, book_state)
            End If
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub
End Class