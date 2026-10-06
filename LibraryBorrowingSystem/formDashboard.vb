Imports MySql.Data.MySqlClient

Public Class formDashboard

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToString("MMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub formDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        formBooks.Show()
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        formMembers.Show()
    End Sub

    Private Sub btnPayMembership_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        formPayments.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formBorrowBooks.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formReturnBooks.Show()
    End Sub

    Private Sub formDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadActivityLog()
    End Sub

    Private Sub formDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call LoadActivityLog()
    End Sub

    Public Sub LoadActivityLog()
        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT transaction_date, transaction_type, member_name, book_title, status, due_date FROM transaction_history ORDER BY transaction_date DESC, transaction_id DESC LIMIT 50", sqlcon)
        da.Fill(ds, "activity")

        dgvTransactionHistory.Rows.Clear()

        For i As Integer = 0 To ds.Tables("activity").Rows.Count - 1
            Dim transaction_date As String = Convert.ToDateTime(ds.Tables("activity").Rows(i).Item("transaction_date")).ToString("yyyy-MM-dd hh:mm tt")
            Dim transaction_type As String = ds.Tables("activity").Rows(i).Item("transaction_type").ToString()
            Dim member_name As String = ds.Tables("activity").Rows(i).Item("member_name").ToString()
            Dim book_title As String = ds.Tables("activity").Rows(i).Item("book_title").ToString()
            Dim status As String = ds.Tables("activity").Rows(i).Item("status").ToString()

            Dim due_value As Object = ds.Tables("activity").Rows(i).Item("due_date")
            If transaction_type = "BORROW" AndAlso status = "Active" AndAlso Not IsDBNull(due_value) Then
                If Convert.ToDateTime(due_value).Date < Date.Today Then
                    status = "Overdue"
                End If
            End If

            dgvTransactionHistory.Rows.Add(transaction_date, transaction_type, member_name, book_title, status)
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

End Class