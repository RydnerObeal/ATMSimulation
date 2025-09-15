Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmCreateAcc
    Private connectionString As String = "Server=localhost;Database=atm_system;Uid=root;Pwd=;"
    Private Sub frmCreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.Clear()
        cboRole.Items.Add("Customer")
        cboRole.Items.Add("Admin")
        GenerateAccountNumber()
    End Sub

    Private Sub frmCreateAcc_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtPIN.Clear()
        txtConfirmPin.Clear()
        cboRole.SelectedIndex = -1
        GenerateAccountNumber()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If ValidateInputs() = True Then
            If CheckAccountExists() = False Then
                CreateAccount()
            Else
                MessageBox.Show("Account number already exists! Generating new number.", "Admin Notice")
                GenerateAccountNumber()
            End If
        End If
    End Sub

    Private Sub GenerateAccountNumber()
        Dim random As New Random()
        Dim accountNumber As String = ""
        For i As Integer = 1 To 10
            accountNumber = accountNumber + random.Next(0, 10).ToString()
        Next
        txtAccountNumber.Text = accountNumber
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtName.Text = "" Then
            MessageBox.Show("Please enter a name!", "Admin - Validation Error")
            txtName.Focus()
            Return False
        End If

        If txtAccountNumber.Text = "" Then
            MessageBox.Show("Account number is required!", "Admin - Validation Error")
            txtAccountNumber.Focus()
            Return False
        End If

        If txtAccountNumber.Text.Length <> 10 Then
            MessageBox.Show("Account number must be 10 digits!", "Admin - Validation Error")
            txtAccountNumber.Focus()
            Return False
        End If

        If txtPIN.Text = "" Then
            MessageBox.Show("Please enter a PIN!", "Admin - Validation Error")
            txtPIN.Focus()
            Return False
        End If

        If txtPIN.Text.Length < 4 Then
            MessageBox.Show("PIN must be at least 4 digits!", "Admin - Validation Error")
            txtPIN.Focus()
            Return False
        End If

        If IsNumeric(txtPIN.Text) = False Then
            MessageBox.Show("PIN must contain only numbers!", "Admin - Validation Error")
            txtPIN.Focus()
            Return False
        End If

        If txtConfirmPin.Text = "" Then
            MessageBox.Show("Please confirm your PIN!", "Admin - Validation Error")
            txtConfirmPin.Focus()
            Return False
        End If

        If txtPIN.Text <> txtConfirmPin.Text Then
            MessageBox.Show("PIN and Confirm PIN do not match!", "Admin - Validation Error")
            txtConfirmPin.Focus()
            Return False
        End If

        If cboRole.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role!", "Admin - Validation Error")
            cboRole.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function CheckAccountExists() As Boolean
        Try
            Dim connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM users WHERE account_number = '" + txtAccountNumber.Text + "'"
            Dim command As New MySqlCommand(query, connection)
            Dim count As Integer = command.ExecuteScalar()

            connection.Close()

            If count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Database error: " + ex.Message, "Admin - Error")
            Return True
        End Try
    End Function

    Private Sub CreateAccount()
        Try
            Connect()

            sql = "INSERT INTO users (name, account_number, pin, attempts, role, status, balance) VALUES ('" +
                  txtName.Text + "', '" +
                  txtAccountNumber.Text + "', '" +
                  txtPIN.Text + "', " +
                  "0, '" +
                  cboRole.SelectedItem.ToString() + "', " +
                  "'Active', 0.00)"

            cmd = New MySqlCommand(sql, cn)
            Dim result As Integer = cmd.ExecuteNonQuery()
            cn.Close()

            If result > 0 Then
                MessageBox.Show("Account created successfully!" + vbCrLf +
                               "Name: " + txtName.Text + vbCrLf +
                               "Account Number: " + txtAccountNumber.Text + vbCrLf +
                               "PIN: " + txtPIN.Text + vbCrLf +
                               "Role: " + cboRole.SelectedItem.ToString() + vbCrLf +
                               "Status: Active", "Admin - Success")
                ClearForm()
            Else
                MessageBox.Show("Failed to create account!", "Admin - Error")
            End If

        Catch ex As Exception
            MessageBox.Show("Error creating account: " + ex.Message, "Admin - Database Error")
            cn.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtPIN.Clear()
        txtConfirmPin.Clear()
        cboRole.SelectedIndex = -1
        GenerateAccountNumber()
        txtName.Focus()
    End Sub

    Private Sub txtPIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPIN.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtConfirmPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmPin.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAccountNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccountNumber.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class