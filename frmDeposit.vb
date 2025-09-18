Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmDeposit
    Public Property UserAccountNumber As String
    Private currentDepositAmount As Decimal = 0

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        sql = "SELECT balance FROM users WHERE account_number = @acc AND status = 'Active'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim balance As Decimal = Convert.ToDecimal(dr("balance"))
            lblBalance.Text = "₱" & balance.ToString("N2")
        End While

        dr.Close()
        cn.Close()

        ' Initial deposit amount
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")

        ' Check yung ngayung total deposits
        Call Connect()
        sql = "SELECT COALESCE(SUM(amount), 0) as total FROM deposits WHERE account_number = @acc AND DATE(deposit_date) = CURDATE()"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
        dr = cmd.ExecuteReader()

        Dim todayTotal As Decimal = 0
        While dr.Read()
            todayTotal = Convert.ToDecimal(dr("total"))
        End While

        dr.Close()
        cn.Close()
    End Sub

    ' Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    ' Deposit amount buttons
    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        currentDepositAmount = currentDepositAmount + 50
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        currentDepositAmount = currentDepositAmount + 100
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        currentDepositAmount = currentDepositAmount + 200
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        currentDepositAmount = currentDepositAmount + 500
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        currentDepositAmount = currentDepositAmount + 1000
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        currentDepositAmount = currentDepositAmount + 10000
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub

    ' Deposit process
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        ' Check if less than 100
        If currentDepositAmount <= 99 Then
            MessageBox.Show("Please select at least minimum of ₱100.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Confirm deposit
            Dim result As DialogResult = MessageBox.Show("Do you want to deposit ₱" & currentDepositAmount.ToString("N2") & "?", "Confirm Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Check today's total deposits
                Call Connect()
                sql = "SELECT COALESCE(SUM(amount), 0) as total FROM deposits WHERE account_number = @acc AND DATE(deposit_date) = CURDATE()"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                dr = cmd.ExecuteReader()

                Dim todayTotal As Decimal = 0
                While dr.Read()
                    todayTotal = Convert.ToDecimal(dr("total"))
                End While

                dr.Close()
                cn.Close()

                Dim dailyLimit As Decimal = 100000

                ' Check if deposit exceeds limit
                If (todayTotal + currentDepositAmount) > dailyLimit Then
                    Dim remainingLimit As Decimal = dailyLimit - todayTotal

                    If remainingLimit <= 0 Then
                        MessageBox.Show("Daily deposit limit of ₱100,000 has been reached.", "Daily Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Deposit amount exceeds daily limit. You can only deposit ₱" & remainingLimit.ToString("N2") & " more today." & vbCrLf &
                                        "Today's deposits: ₱" & todayTotal.ToString("N2") & vbCrLf &
                                        "Daily limit: ₱" & dailyLimit.ToString("N2"), "Daily Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    ' Proceed with deposit
                    Call Connect()
                    Dim transaction = cn.BeginTransaction()
                    Dim depositSuccessful As Boolean = False

                    If transaction IsNot Nothing Then
                        ' Pag update ng balance
                        sql = "UPDATE users SET balance = balance + @depositAmount WHERE account_number = @acc AND status = 'Active'"
                        cmd = New MySqlCommand(sql, cn, transaction)
                        cmd.Parameters.AddWithValue("@depositAmount", currentDepositAmount)
                        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)

                        Dim updateResult As Integer = cmd.ExecuteNonQuery()

                        ' If balance updated
                        If updateResult > 0 Then
                            ' Pag pasok ng balance sa deposits table
                            sql = "INSERT INTO deposits (account_number, amount, deposit_date) VALUES (@acc, @amount, NOW())"
                            cmd = New MySqlCommand(sql, cn, transaction)
                            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                            cmd.Parameters.AddWithValue("@amount", currentDepositAmount)

                            Dim insertResult As Integer = cmd.ExecuteNonQuery()

                            If insertResult > 0 Then
                                transaction.Commit()
                                depositSuccessful = True
                            End If
                        End If

                        ' If failed
                        If Not depositSuccessful Then
                            transaction.Rollback()
                            MessageBox.Show("Deposit failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                    cn.Close()

                    ' Pag success yung deposit
                    If depositSuccessful = True Then
                        currentDepositAmount = 0
                        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")

                        ' Mag rereload yung balance
                        Call Connect()
                        sql = "SELECT balance FROM users WHERE account_number = @acc AND status = 'Active'"
                        cmd = New MySqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                        dr = cmd.ExecuteReader()

                        While dr.Read()
                            Dim newBalance As Decimal = Convert.ToDecimal(dr("balance"))
                            lblBalance.Text = "₱" & newBalance.ToString("N2")
                        End While

                        dr.Close()
                        cn.Close()

                        ' if success lalabas yung resibo
                        Dim receipt As String = "----- DEPOSIT RECEIPT -----" & vbCrLf &
                                                "Account Number: " & UserAccountNumber & vbCrLf &
                                                "Amount Deposited: ₱" & currentDepositAmount.ToString("N2") & vbCrLf &
                                                "New Balance: " & lblBalance.Text & vbCrLf &
                                                "Date/Time: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf &
                                                "----------------------------"

                        MessageBox.Show(receipt, "Deposit Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        currentDepositAmount = 0
        lblAmountDeposit.Text = "₱" & currentDepositAmount.ToString("N2")
    End Sub
End Class
