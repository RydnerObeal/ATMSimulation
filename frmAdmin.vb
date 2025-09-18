Imports MySql.Data.MySqlClient

Public Class frmAdmin
    Public Property AdminName As String

    Private Sub ShowInMainPanel(ctrl As Control)
        MainPanel.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        MainPanel.Controls.Add(ctrl)
        ctrl.BringToFront()
        ctrl.Visible = True
    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        With frmCreateAcc
            .TopLevel = False
            .AutoScroll = True
            ShowInMainPanel(frmCreateAcc)
            .Show()
        End With
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        Call Connect()
        LoadUsers()
        ShowInMainPanel(pnlManageUsers)
    End Sub

    Private Sub LoadUsers()
        Try
            Call Connect()

            sql = "SELECT user_id, name, account_number, pin, attempts, role, status, balance 
               FROM users ORDER BY user_id"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            lvUsers.Items.Clear()

            While dr.Read()
                Dim item As New ListViewItem(dr("name").ToString())
                item.SubItems.Add(dr("account_number").ToString())
                item.SubItems.Add(dr("pin").ToString())
                item.SubItems.Add(dr("attempts").ToString())
                item.SubItems.Add(dr("role").ToString())
                item.SubItems.Add(dr("status").ToString())
                item.SubItems.Add(FormatNumber(dr("balance"), 2))

                item.Tag = dr("user_id").ToString()

                lvUsers.Items.Add(item)
            End While

            dr.Close()
            cn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(AdminName) Then
            lblAdminName.Text = "To the Admin Control " & AdminName
        End If

        Call Connect()
        LoadUsers()
        ShowInMainPanel(pnlManageUsers)

        If txtSearch.Text = "" Then
            txtSearch.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnTransactionLogs_Click(sender As Object, e As EventArgs) Handles btnTransactionLogs.Click
        With frmTransactionLogs
            .TopLevel = False
            .AutoScroll = True
            ShowInMainPanel(frmTransactionLogs)
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserID.Clear()
        txtName.Clear()
        txtAccountNumber.Clear()
        txtPIN.Clear()
        txtAttempts.Clear()
        cboRole.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtUserID.Text = "" Then
                MessageBox.Show("Please select a user to update.")
                Exit Sub
            End If

            Call Connect()
            sql = "UPDATE users SET name=@name, account_number=@acc, pin=@pin, attempts=@att, role=@role, status=@status WHERE user_id=@id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            cmd.Parameters.AddWithValue("@pin", txtPIN.Text)
            cmd.Parameters.AddWithValue("@att", txtAttempts.Text)
            cmd.Parameters.AddWithValue("@role", cboRole.Text)
            cmd.Parameters.AddWithValue("@status", cboStatus.Text)
            cmd.Parameters.AddWithValue("@id", txtUserID.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("User updated successfully!")

            LoadUsers()

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub
    Private Sub lvUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUsers.SelectedIndexChanged
        If lvUsers.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvUsers.SelectedItems(0)
            txtUserID.Text = item.Tag.ToString()
            txtName.Text = item.SubItems(0).Text
            txtAccountNumber.Text = item.SubItems(1).Text
            txtPIN.Text = item.SubItems(2).Text
            txtAttempts.Text = item.SubItems(3).Text
            cboRole.Text = item.SubItems(4).Text
            cboStatus.Text = item.SubItems(5).Text
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtUserID.Text = "" Then
                MessageBox.Show("Please select a user to delete.")
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Call Connect()
                sql = "DELETE FROM users WHERE user_id=@id"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", txtUserID.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("User deleted successfully!")

                LoadUsers()
                btnClear.PerformClick()
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message)
        End Try
    End Sub

    ' Enhanced search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.ForeColor = Color.Gray Then Return
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            LoadUsers()
            Return
        End If
        If txtSearch.Text.Length >= 2 Then
            PerformSearch(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub PerformSearch(searchTerm As String)
        Try
            Call Connect()

            sql = "SELECT user_id, name, account_number, pin, attempts, role, status, balance 
                   FROM users 
                   WHERE LOWER(user_id) LIKE LOWER(@search) 
                      OR LOWER(name) LIKE LOWER(@search) 
                      OR LOWER(account_number) LIKE LOWER(@search) 
                      OR LOWER(role) LIKE LOWER(@search) 
                      OR LOWER(status) LIKE LOWER(@search)
                   ORDER BY 
                      CASE 
                          WHEN LOWER(name) LIKE LOWER(@exactSearch) THEN 1
                          WHEN LOWER(account_number) LIKE LOWER(@exactSearch) THEN 2
                          WHEN LOWER(user_id) LIKE LOWER(@exactSearch) THEN 3
                          ELSE 4
                      END,
                      name"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
            cmd.Parameters.AddWithValue("@exactSearch", searchTerm & "%")
            dr = cmd.ExecuteReader()

            lvUsers.Items.Clear()
            Dim resultCount As Integer = 0

            While dr.Read()
                Dim item As New ListViewItem(dr("name").ToString())
                item.SubItems.Add(dr("account_number").ToString())
                item.SubItems.Add(dr("pin").ToString())
                item.SubItems.Add(dr("attempts").ToString())
                item.SubItems.Add(dr("role").ToString())
                item.SubItems.Add(dr("status").ToString())
                item.SubItems.Add(FormatNumber(dr("balance"), 2))
                item.Tag = dr("user_id").ToString()

                lvUsers.Items.Add(item)

                resultCount += 1
            End While

            dr.Close()
            cn.Close()

            If resultCount = 0 Then
                lvUsers.Items.Add(New ListViewItem("No results found for: " & searchTerm))
            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.ForeColor = Color.Gray Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search by ID, Name, or Account Number..."
            txtSearch.ForeColor = Color.Gray
            LoadUsers()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            If txtSearch.ForeColor <> Color.Gray And txtSearch.Text.Trim().Length > 0 Then
                PerformSearch(txtSearch.Text.Trim())
            End If
        End If
    End Sub
End Class
