Imports MySql.Data.MySqlClient

Public Class formEditMembers
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim member_id As String = lblMemberId.Text
        Dim first_name As String = txtFirstName.Text
        Dim middle_name As String = txtMiddleName.Text
        Dim last_name As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim contact As String = txtContactNo.Text

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("UPDATE members SET member_first_name=@member_first_name, member_middle_name=@member_middle_name, member_last_name=@member_last_name, member_email=@member_email, member_contact=@member_contact WHERE member_id=@member_id", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("member_first_name", first_name)
        da.SelectCommand.Parameters.AddWithValue("member_middle_name", middle_name)
        da.SelectCommand.Parameters.AddWithValue("member_last_name", last_name)
        da.SelectCommand.Parameters.AddWithValue("member_email", email)
        da.SelectCommand.Parameters.AddWithValue("member_contact", contact)
        da.SelectCommand.Parameters.AddWithValue("member_id", member_id)
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