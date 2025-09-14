Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmDeposit
    Public Property UserAccountNumber As String

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrentBalance()
        txtAmountDeposit.Focus()
    End Sub

    Private Sub LoadCurrentBalance()
        Call Connect()
        sql = "SELECT balance FROM users WHERE account_number = @acc AND status = 'Active'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Dim balance As Decimal = Convert.ToDecimal(dr("balance"))
            lblBalance.Text = "₱" & balance.ToString("N2")
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim depositAmount As Decimal
        If Not Decimal.TryParse(txtAmountDeposit.Text, depositAmount) OrElse depositAmount <= 0 Then
            MessageBox.Show("Please enter a valid deposit amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountDeposit.Focus()
            Return
        End If

        Call Connect()
        Dim transaction = cn.BeginTransaction()

        Try
            ' Update user balance
            sql = "UPDATE users SET balance = balance + @depositAmount WHERE account_number = @acc AND status = 'Active'"
            cmd = New MySqlCommand(sql, cn, transaction)
            cmd.Parameters.AddWithValue("@depositAmount", depositAmount)
            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
            cmd.ExecuteNonQuery()

            'Log the deposit transaction
            sql = "INSERT INTO deposits (account_number, amount, deposit_date) VALUES (@acc, @amount, NOW())"
            cmd = New MySqlCommand(sql, cn, transaction)
            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
            cmd.Parameters.AddWithValue("@amount", depositAmount)
            cmd.ExecuteNonQuery()

            transaction.Commit()
            cn.Close()

            txtAmountDeposit.Clear()
            LoadCurrentBalance()
            MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            transaction.Rollback()
            cn.Close()
            MessageBox.Show("Deposit failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class