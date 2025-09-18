Imports MySql.Data.MySqlClient

Public Class frmTransfer
    Public Property CurrentUserAccount As String
    Private connectionString As String = "server=localhost;user=root;password=;database=atm_system"

    ' Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    ' Transfer button
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim transferTo As String = txtTransferTo.Text.Trim()
        Dim amount As Decimal = 0

        ' Check kung may laman ang account number field
        If transferTo = "" Then
            MessageBox.Show("Please enter the account number to transfer to.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTransferTo.Focus()
            Exit Sub
        End If

        ' Check if amount is valid
        If Decimal.TryParse(txtAmountTransfer.Text, amount) = False OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid transfer amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Exit Sub
        End If

        ' Prevent self-transfer
        If transferTo = CurrentUserAccount Then
            MessageBox.Show("You cannot transfer money to your own account.", "Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTransferTo.Focus()
            Exit Sub
        End If

        ' Perform the transfer
        If ProcessTransfer(transferTo, amount) = True Then
            ' Show receipt
            Dim receipt As String = "----- TRANSFER RECEIPT -----" & vbCrLf &
                                    "From Account: " & CurrentUserAccount & vbCrLf &
                                    "To Account: " & transferTo & vbCrLf &
                                    "Amount Transferred: ₱" & amount.ToString("N2") & vbCrLf &
                                    "Date/Time: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf &
                                    "----------------------------"

            MessageBox.Show(receipt, "Transfer Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearFields()
        End If
    End Sub

    ' Process transfer logic
    Private Function ProcessTransfer(transferTo As String, amount As Decimal) As Boolean
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim senderBalance As Decimal = 0
        Dim targetExists As Boolean = False

        ' Check sender balance
        sql = "SELECT balance FROM users WHERE account_number=@acc"
        cmd = New MySqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@acc", CurrentUserAccount)
        dr = cmd.ExecuteReader()

        While dr.Read()
            senderBalance = Convert.ToDecimal(dr("balance"))
        End While
        dr.Close()

        If senderBalance < amount Then
            MessageBox.Show("Insufficient funds. Your balance is ₱" & senderBalance.ToString("N2"), "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connection.Close()
            Return False
        End If

        ' Check if target account exists
        sql = "SELECT account_number FROM users WHERE account_number=@target"
        cmd = New MySqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@target", transferTo)
        dr = cmd.ExecuteReader()

        While dr.Read()
            targetExists = True
        End While
        dr.Close()

        If targetExists = False Then
            MessageBox.Show("Target account not found.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
            Return False
        End If

        ' Process transfer with transaction
        Dim transaction = connection.BeginTransaction()
        Dim success As Boolean = False

        Try
            ' Deduct from sender
            sql = "UPDATE users SET balance = balance - @amt WHERE account_number=@acc"
            cmd = New MySqlCommand(sql, connection, transaction)
            cmd.Parameters.AddWithValue("@amt", amount)
            cmd.Parameters.AddWithValue("@acc", CurrentUserAccount)
            cmd.ExecuteNonQuery()

            ' Add to receiver
            sql = "UPDATE users SET balance = balance + @amt WHERE account_number=@target"
            cmd = New MySqlCommand(sql, connection, transaction)
            cmd.Parameters.AddWithValue("@amt", amount)
            cmd.Parameters.AddWithValue("@target", transferTo)
            cmd.ExecuteNonQuery()

            ' Log transfer
            sql = "INSERT INTO fund_transfers (from_account, to_account, amount, transfer_date) VALUES (@from, @to, @amt, NOW())"
            cmd = New MySqlCommand(sql, connection, transaction)
            cmd.Parameters.AddWithValue("@from", CurrentUserAccount)
            cmd.Parameters.AddWithValue("@to", transferTo)
            cmd.Parameters.AddWithValue("@amt", amount)
            cmd.ExecuteNonQuery()

            transaction.Commit()
            success = True

        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("Transfer failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        connection.Close()
        Return success
    End Function

    ' Clear input fields
    Private Sub ClearFields()
        txtTransferTo.Clear()
        txtAmountTransfer.Clear()
        txtTransferTo.Focus()
    End Sub
End Class
