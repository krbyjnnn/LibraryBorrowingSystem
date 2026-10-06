Imports MySql.Data.MySqlClient

Public Class formMembers

    Private Sub formMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMembersData()
    End Sub

    Public Sub LoadMembersData()
        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM members", sqlcon)
        da.Fill(ds, "members")

        dgvMembersData.Rows.Clear()

        For i As Integer = 0 To ds.Tables("members").Rows.Count - 1
            Dim member_id As String = ds.Tables("members").Rows(i).Item("member_id").ToString()
            Dim first_name As String = ds.Tables("members").Rows(i).Item("member_first_name").ToString()
            Dim middle_name As String = ds.Tables("members").Rows(i).Item("member_middle_name").ToString()
            Dim last_name As String = ds.Tables("members").Rows(i).Item("member_last_name").ToString()
            Dim email As String = ds.Tables("members").Rows(i).Item("member_email").ToString()
            Dim contact As String = ds.Tables("members").Rows(i).Item("member_contact").ToString()
            Dim member_state As String = If(Convert.ToInt32(ds.Tables("members").Rows(i).Item("member_active")) = 1, "Active", "Archived")

            Dim full_name As String = (first_name & " " & middle_name & " " & last_name).Replace("  ", " ").Trim()

            Dim expiry As String = ""
            Dim membership As String = "Unpaid"
            Dim expiry_value As Object = ds.Tables("members").Rows(i).Item("membership_expiry")
            If Not IsDBNull(expiry_value) Then
                Dim expiry_date As Date = Convert.ToDateTime(expiry_value)
                expiry = expiry_date.ToString("yyyy-MM-dd")
                membership = If(expiry_date.Date >= Date.Today, "Valid", "Expired")
            End If

            If Not String.IsNullOrWhiteSpace(member_id) AndAlso
               Not String.IsNullOrWhiteSpace(full_name) Then

                dgvMembersData.Rows.Add(member_id, full_name, email, contact, expiry, membership, member_state)
            End If
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub

    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        formAddMembers.Show()
    End Sub

    Private Sub btnEditMember_Click(sender As Object, e As EventArgs) Handles btnEditMember.Click
        If dgvMembersData.CurrentRow IsNot Nothing AndAlso dgvMembersData.Rows.Count > 0 Then

            Dim i As Integer = dgvMembersData.CurrentRow.Index

            Dim member_id As Integer = Convert.ToInt32(dgvMembersData.Item(0, i).Value)
            Dim email As String = dgvMembersData.Item(2, i).Value.ToString()
            Dim contact As String = dgvMembersData.Item(3, i).Value.ToString()

            Call connectDB()
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT member_first_name, member_middle_name, member_last_name FROM members WHERE member_id=@member_id", sqlcon)
            da.SelectCommand.Parameters.AddWithValue("member_id", member_id)
            da.Fill(ds, "members")
            Dim first_name As String = ds.Tables("members").Rows(0).Item("member_first_name").ToString()
            Dim middle_name As String = ds.Tables("members").Rows(0).Item("member_middle_name").ToString()
            Dim last_name As String = ds.Tables("members").Rows(0).Item("member_last_name").ToString()
            ds.Dispose()
            da.Dispose()
            Call disconnectDB()

            formEditMembers.lblMemberId.Text = member_id.ToString()
            formEditMembers.txtFirstName.Text = first_name
            formEditMembers.txtMiddleName.Text = middle_name
            formEditMembers.txtLastName.Text = last_name
            formEditMembers.txtEmail.Text = email
            formEditMembers.txtContactNo.Text = contact

            formEditMembers.Show()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Dim search_string As String = txtFilter.Text.Trim()

        Call connectDB()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM members WHERE (CONCAT_WS(' ', member_first_name, member_middle_name, member_last_name) LIKE @search OR CONCAT_WS(' ', member_first_name, member_last_name) LIKE @search)", sqlcon)
        da.SelectCommand.Parameters.AddWithValue("search", "%" & search_string & "%")
        da.Fill(ds, "members")

        dgvMembersData.Rows.Clear()

        For i As Integer = 0 To ds.Tables("members").Rows.Count - 1
            Dim member_id As String = ds.Tables("members").Rows(i).Item("member_id").ToString()
            Dim first_name As String = ds.Tables("members").Rows(i).Item("member_first_name").ToString()
            Dim middle_name As String = ds.Tables("members").Rows(i).Item("member_middle_name").ToString()
            Dim last_name As String = ds.Tables("members").Rows(i).Item("member_last_name").ToString()
            Dim email As String = ds.Tables("members").Rows(i).Item("member_email").ToString()
            Dim contact As String = ds.Tables("members").Rows(i).Item("member_contact").ToString()
            Dim member_state As String = If(Convert.ToInt32(ds.Tables("members").Rows(i).Item("member_active")) = 1, "Active", "Archived")
            Dim full_name As String = (first_name & " " & middle_name & " " & last_name).Replace("  ", " ").Trim()
            Dim expiry As String = ""
            Dim membership As String = "Unpaid"
            Dim expiry_value As Object = ds.Tables("members").Rows(i).Item("membership_expiry")
            If Not IsDBNull(expiry_value) Then
                Dim expiry_date As Date = Convert.ToDateTime(expiry_value)
                expiry = expiry_date.ToString("yyyy-MM-dd")
                membership = If(expiry_date.Date >= Date.Today, "Valid", "Expired")
            End If
            If Not String.IsNullOrWhiteSpace(member_id) AndAlso
               Not String.IsNullOrWhiteSpace(full_name) Then
                dgvMembersData.Rows.Add(member_id, full_name, email, contact, expiry, membership, member_state)
            End If
        Next

        ds.Dispose()
        da.Dispose()
        Call disconnectDB()
    End Sub
End Class