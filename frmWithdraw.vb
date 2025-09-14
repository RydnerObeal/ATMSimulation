Imports MySql.Data.MySqlClient
Public Class frmWithdraw
    Public Property UserAccountNumber As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrentBalance()
        txtAmountWithdraw.Focus()
    End Sub

    Private Sub LoadCurrentBalance()
        Call Connect()
        sql = "SELECT balance FROM users WHERE account_number=@acc AND status='Active'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Dim balance As Decimal = Convert.ToDecimal(dr("balance"))
            lblBalance.Text = "₱" & balance.ToString("N2")
        Else
            lblBalance.Text = "Account not found"
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim withdrawAmount As Decimal
        If Not Decimal.TryParse(txtAmountWithdraw.Text, withdrawAmount) OrElse withdrawAmount <= 0 Then
            MessageBox.Show("Please enter a valid withdrawal amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountWithdraw.Focus()
            Return
        End If

        ' Check balance first
        Call Connect()
        sql = "SELECT balance FROM users WHERE account_number=@acc AND status='Active'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
        Dim currentBalance As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
        cn.Close()

        If withdrawAmount > currentBalance Then
            MessageBox.Show($"Insufficient balance! Your current balance is: ₱{currentBalance:N2}", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Process withdrawal with transaction logging
        Call Connect()
        Dim transaction = cn.BeginTransaction()

        Try
            ' Update user balance
            sql = "UPDATE users SET balance = balance - @withdrawAmount WHERE account_number=@acc AND status='Active'"
            cmd = New MySqlCommand(sql, cn, transaction)
            cmd.Parameters.AddWithValue("@withdrawAmount", withdrawAmount)
            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
            cmd.ExecuteNonQuery()

            ' Log the withdrawal transaction
            sql = "INSERT INTO withdrawals (account_number, amount, withdrawal_date) VALUES (@acc, @amount, NOW())"
            cmd = New MySqlCommand(sql, cn, transaction)
            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
            cmd.Parameters.AddWithValue("@amount", withdrawAmount)
            cmd.ExecuteNonQuery()

            transaction.Commit()
            cn.Close()

            txtAmountWithdraw.Clear()
            LoadCurrentBalance()
            MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            transaction.Rollback()
            cn.Close()
            MessageBox.Show("Withdrawal failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class