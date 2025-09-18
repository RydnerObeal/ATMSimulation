Imports MySql.Data.MySqlClient

Public Class frmWithdraw
    Public Property UserAccountNumber As String
    Private currentWithdrawAmount As Decimal = 0

    ' Daily limit ay 50,000
    Private Const dailyLimit As Decimal = 50000

    Private Sub frmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pag kuha ng balance ng user
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

        ' Initial withdrawal amount
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")

        ' Icheck yung ngayung total withdrawals
        Call Connect()
        sql = "SELECT COALESCE(SUM(amount), 0) as total FROM withdrawals WHERE account_number = @acc AND DATE(withdrawal_date) = CURDATE()"
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    ' Buttons for withdrawal amounts
    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        currentWithdrawAmount += 50
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        currentWithdrawAmount += 100
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        currentWithdrawAmount += 200
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        currentWithdrawAmount += 500
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        currentWithdrawAmount += 1000
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        currentWithdrawAmount += 10000
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub

    ' Withdraw process
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        ' Check minimum amount
        If currentWithdrawAmount <= 99 Then
            MessageBox.Show("Please select at least minimum of ₱100.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Confirm withdrawal
            Dim result As DialogResult = MessageBox.Show("Do you want to withdraw ₱" & currentWithdrawAmount.ToString("N2") & "?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Check today's total withdrawals
                Call Connect()
                sql = "SELECT COALESCE(SUM(amount), 0) as total FROM withdrawals WHERE account_number = @acc AND DATE(withdrawal_date) = CURDATE()"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                dr = cmd.ExecuteReader()

                Dim todayTotal As Decimal = 0
                While dr.Read()
                    todayTotal = Convert.ToDecimal(dr("total"))
                End While

                dr.Close()
                cn.Close()

                ' Check if withdrawal exceeds daily limit
                If (todayTotal + currentWithdrawAmount) > dailyLimit Then
                    Dim remainingLimit As Decimal = dailyLimit - todayTotal

                    If remainingLimit <= 0 Then
                        MessageBox.Show("Daily withdrawal limit of ₱50,000 has been reached.", "Daily Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Withdrawal amount exceeds daily limit. You can only withdraw ₱" & remainingLimit.ToString("N2") & " more today." & vbCrLf &
                                        "Today's withdrawals: ₱" & todayTotal.ToString("N2") & vbCrLf &
                                        "Daily limit: ₱" & dailyLimit.ToString("N2"), "Daily Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    ' Get current balance
                    Call Connect()
                    sql = "SELECT balance FROM users WHERE account_number = @acc AND status = 'Active'"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                    dr = cmd.ExecuteReader()

                    Dim currentBalance As Decimal = 0
                    While dr.Read()
                        currentBalance = Convert.ToDecimal(dr("balance"))
                    End While

                    dr.Close()
                    cn.Close()

                    ' Check naman kung sapat ba yung balance
                    If currentWithdrawAmount > currentBalance Then
                        MessageBox.Show("Insufficient balance. Your balance is ₱" & currentBalance.ToString("N2"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Check minimum balance dapat 100
                    If (currentBalance - currentWithdrawAmount) < 100 Then
                        MessageBox.Show("You must maintain at least ₱100 in your account.", "Minimum Balance Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Dto yung process ng withdrawal
                    Call Connect()
                    Dim transaction = cn.BeginTransaction()
                    Dim withdrawSuccessful As Boolean = False

                    If transaction IsNot Nothing Then
                        ' Update balance
                        sql = "UPDATE users SET balance = balance - @withdrawAmount WHERE account_number = @acc AND status = 'Active'"
                        cmd = New MySqlCommand(sql, cn, transaction)
                        cmd.Parameters.AddWithValue("@withdrawAmount", currentWithdrawAmount)
                        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)

                        Dim updateResult As Integer = cmd.ExecuteNonQuery()

                        ' If balance updated
                        If updateResult > 0 Then
                            ' Insert withdrawal record
                            sql = "INSERT INTO withdrawals (account_number, amount, withdrawal_date) VALUES (@acc, @amount, NOW())"
                            cmd = New MySqlCommand(sql, cn, transaction)
                            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                            cmd.Parameters.AddWithValue("@amount", currentWithdrawAmount)

                            Dim insertResult As Integer = cmd.ExecuteNonQuery()

                            If insertResult > 0 Then
                                transaction.Commit()
                                withdrawSuccessful = True
                            End If
                        End If

                        ' If failed
                        If Not withdrawSuccessful Then
                            transaction.Rollback()
                            MessageBox.Show("Withdrawal failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                    cn.Close()

                    ' Withdrawal success
                    If withdrawSuccessful = True Then
                        ' Reload balance
                        Call Connect()
                        sql = "SELECT balance FROM users WHERE account_number = @acc AND status = 'Active'"
                        cmd = New MySqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
                        dr = cmd.ExecuteReader()

                        Dim newBalance As Decimal = 0
                        While dr.Read()
                            newBalance = Convert.ToDecimal(dr("balance"))
                        End While

                        dr.Close()
                        cn.Close()

                        ' Resibo
                        Dim receipt As String = "----- WITHDRAWAL RECEIPT -----" & vbCrLf &
                                                "Account Number: " & UserAccountNumber & vbCrLf &
                                                "Amount Withdrawn: ₱" & currentWithdrawAmount.ToString("N2") & vbCrLf &
                                                "New Balance: ₱" & newBalance.ToString("N2") & vbCrLf &
                                                "Date/Time: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf &
                                                "-------------------------------"

                        MessageBox.Show(receipt, "Withdrawal Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Reset amount
                        currentWithdrawAmount = 0
                        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
                        lblBalance.Text = "₱" & newBalance.ToString("N2")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        currentWithdrawAmount = 0
        lblAmountWithdraw.Text = "₱" & currentWithdrawAmount.ToString("N2")
    End Sub
End Class
