Imports MySql.Data.MySqlClient

Public Class formEditBook

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim book_id As String = lblBookId.Text
        Dim isbn As String = txtIsbn.Text
        Dim title As String = txtTitle.Text
        Dim author As String = txtAuthor.Text
        Dim category As String = cboCategory.Text
        Dim publisher As String = txtPublisher.Text
        Dim status As String = cboStatus.Text

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("UPDATE books SET isbn=@isbn, title=@title, author=@author, category=@category, publisher=@publisher, status=@status WHERE book_id=@book_id", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("isbn", isbn)
        da.SelectCommand.Parameters.AddWithValue("title", title)
        da.SelectCommand.Parameters.AddWithValue("author", author)
        da.SelectCommand.Parameters.AddWithValue("category", category)
        da.SelectCommand.Parameters.AddWithValue("publisher", publisher)
        da.SelectCommand.Parameters.AddWithValue("status", status)
        da.SelectCommand.Parameters.AddWithValue("book_id", book_id)
        da.Fill(ds, "books")
        ds.Dispose()
        da.Dispose()
        Call disconnectDB()

        formBooks.LoadBooksData()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class