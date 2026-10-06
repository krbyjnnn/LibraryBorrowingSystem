Imports MySql.Data.MySqlClient

Public Class formAddMembers
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim first_name As String = txtFirstName.Text.Trim()
        Dim middle_name As String = txtMiddleName.Text.Trim()
        Dim last_name As String = txtLastName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim contact As String = txtContactNo.Text.Trim()

        If first_name = "" Or last_name = "" Then
            MessageBox.Show("First name and last name are required.")
            Exit Sub
        End If

        Dim middle_value As Object = If(middle_name = "", DBNull.Value, CType(middle_name, Object))
        Dim email_value As Object = If(email = "", DBNull.Value, CType(email, Object))
        Dim contact_value As Object = If(contact = "", DBNull.Value, CType(contact, Object))

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("INSERT INTO members (member_first_name, member_middle_name, member_last_name, member_email, member_contact) VALUES (@member_first_name, @member_middle_name, @member_last_name, @member_email, @member_contact)", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("member_first_name", first_name)
        da.SelectCommand.Parameters.AddWithValue("member_middle_name", middle_value)
        da.SelectCommand.Parameters.AddWithValue("member_last_name", last_name)
        da.SelectCommand.Parameters.AddWithValue("member_email", email_value)
        da.SelectCommand.Parameters.AddWithValue("member_contact", contact_value)
        da.Fill(ds, "members")
        ds.Dispose()
        da.Dispose()
        Call disconnectDB()

        formMembers.LoadMembersData()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class