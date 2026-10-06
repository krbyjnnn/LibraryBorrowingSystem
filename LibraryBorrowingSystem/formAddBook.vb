Imports MySql.Data.MySqlClient

Public Class formAddBook

    Private Sub formAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        cboStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadCategories()
        cboCategory.Items.Clear()

        Call connectDB()
        Dim cmd As New MySqlCommand("SELECT DISTINCT category FROM books WHERE category <> '' ORDER BY category", sqlcon)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cboCategory.Items.Add(reader("category").ToString())
        End While
        reader.Close()
        cmd.Dispose()
        Call disconnectDB()

        cboCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboCategory.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim isbn As String = txtIsbn.Text
        Dim title As String = txtTitle.Text
        Dim author As String = txtAuthor.Text
        Dim category As String = cboCategory.Text
        Dim publisher As String = txtPublisher.Text
        Dim status As String = cboStatus.Text

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("INSERT INTO books (isbn, title, author, category, publisher, status) VALUES (@isbn, @title, @author, @category, @publisher, @status)", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("isbn", isbn)
        da.SelectCommand.Parameters.AddWithValue("title", title)
        da.SelectCommand.Parameters.AddWithValue("author", author)
        da.SelectCommand.Parameters.AddWithValue("category", category)
        da.SelectCommand.Parameters.AddWithValue("publisher", publisher)
        da.SelectCommand.Parameters.AddWithValue("status", status)
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