Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM users WHERE user_email=@user_email and user_password=@user_password", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("user_email", username)
        da.SelectCommand.Parameters.AddWithValue("user_password", password)
        da.Fill(ds, "users")

        If ds.Tables("users").Rows.Count > 0 Then
            Dim user_first_name As String = ds.Tables("users").Rows(0).Item("user_first_name").ToString()

            formDashboard.Show()
            formDashboard.lblUser.Text = user_first_name
            Me.Hide()
        Else
            MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
