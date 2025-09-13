Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Login()
    End Sub

    Private Sub Login()
        Call Connect()

        sql = "SELECT * FROM users WHERE account_number=@acc AND pin=@pin AND status='Active'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", txtAccNumber.Text)
        cmd.Parameters.AddWithValue("@pin", txtPIN.Text)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            Dim role As String = dr("role").ToString()
            Dim userName As String = dr("name").ToString()
            dr.Close()

            ' Reset attempts to 3 on successful login
            sql = "UPDATE users SET attempts=3 WHERE account_number=@acc"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@acc", txtAccNumber.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Login Success! Welcome " + userName, MsgBoxStyle.Information)

            ' Redirect based on role
            If role = "Admin" Then
                Dim adminForm As New frmAdmin()
                adminForm.Show()
                Me.Hide()
            ElseIf role = "Customer" Then
                Dim userForm As New frmUser()
                userForm.CurrentUserAccount = txtAccNumber.Text
                userForm.Show()
                Me.Hide()
            End If

        Else
            dr.Close()

            sql = "SELECT attempts, status FROM users WHERE account_number=@acc"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@acc", txtAccNumber.Text)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                Dim attemptsLeft As Integer = CInt(dr("attempts"))
                Dim accountStatus As String = dr("status").ToString()
                dr.Close()

                If accountStatus = "Deactivated" Then
                    MsgBox("Your account is deactivated. Please contact administrator!", MsgBoxStyle.Critical)
                Else
                    attemptsLeft -= 1

                    sql = "UPDATE users SET attempts=@att WHERE account_number=@acc"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@att", attemptsLeft)
                    cmd.Parameters.AddWithValue("@acc", txtAccNumber.Text)
                    cmd.ExecuteNonQuery()

                    If attemptsLeft <= 0 Then
                        MsgBox("You don't have attempts left. Your account is now inactive!", MsgBoxStyle.Critical)
                        DeactivateAccount()
                    Else
                        MsgBox("Login Failed! Invalid PIN. Attempts left: " & attemptsLeft, MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                dr.Close()
                MsgBox("Account number not found!", MsgBoxStyle.Exclamation)
            End If
        End If

        cn.Close()
    End Sub

    Private Sub DeactivateAccount()
        Call Connect()
        sql = "UPDATE users SET status='Deactivated' WHERE account_number=@acc"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", txtAccNumber.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Your Account is now Inactive, Please Contact the Administrator!", MsgBoxStyle.Critical)
        cn.Close()
    End Sub

    Private Sub txtAccNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccNumber.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPIN.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class
