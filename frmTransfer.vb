Imports MySql.Data.MySqlClient

Public Class frmTransfer
    Public Property CurrentUserAccount As String
    Private connectionString As String = "server=localhost;user=root;password=;database=atm_system"

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If Not ValidateInputs() Then Return

        Dim transferTo As String = txtTransferTo.Text.Trim()
        Dim amount As Decimal = Convert.ToDecimal(txtAmountTransfer.Text)

        ' Perform the transfer
        If ProcessTransfer(transferTo, amount) Then
            MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check kung may laman ang account number field
        If String.IsNullOrWhiteSpace(txtTransferTo.Text.Trim()) Then
            MessageBox.Show("Please enter the account number to transfer to.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTransferTo.Focus()
            Return False
        End If

        ' Check if amount is valid
        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmountTransfer.Text, amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid transfer amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Return False
        End If

        ' Prevent self-transfer
        If txtTransferTo.Text.Trim() = CurrentUserAccount Then
            MessageBox.Show("You cannot transfer money to your own account.", "Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTransferTo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ProcessTransfer(transferTo As String, amount As Decimal) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Check sender's balance
                If Not HasSufficientBalance(connection, amount) Then Return False

                ' Check if target account exists
                If Not AccountExists(connection, transferTo) Then
                    MessageBox.Show("Target account not found.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                ' Execute the transfer
                Return ExecuteTransfer(connection, transferTo, amount)

            Catch ex As Exception
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Function HasSufficientBalance(connection As MySqlConnection, amount As Decimal) As Boolean
        Dim query As String = "SELECT balance FROM users WHERE account_number = @account_number"
        Using command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@account_number", CurrentUserAccount)
            Dim senderBalanceObj = command.ExecuteScalar()

            If senderBalanceObj Is Nothing Then
                MessageBox.Show("Your account was not found.", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim senderBalance As Decimal = Convert.ToDecimal(senderBalanceObj)
            If senderBalance < amount Then
                MessageBox.Show($"Insufficient funds. Your current balance is: ₱{senderBalance:N2}", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Return True
        End Using
    End Function

    Private Function AccountExists(connection As MySqlConnection, accountNumber As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE account_number = @account_number"
        Using command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@account_number", accountNumber)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Function ExecuteTransfer(connection As MySqlConnection, transferTo As String, amount As Decimal) As Boolean
        Dim transaction = connection.BeginTransaction()
        Try
            ' Deduct from sender
            Dim deductQuery As String = "UPDATE users SET balance = balance - @amount WHERE account_number = @account_number"
            Using deductCommand As New MySqlCommand(deductQuery, connection, transaction)
                deductCommand.Parameters.AddWithValue("@amount", amount)
                deductCommand.Parameters.AddWithValue("@account_number", CurrentUserAccount)
                deductCommand.ExecuteNonQuery()
            End Using

            ' Add to receiver
            Dim addQuery As String = "UPDATE users SET balance = balance + @amount WHERE account_number = @transferTo"
            Using addCommand As New MySqlCommand(addQuery, connection, transaction)
                addCommand.Parameters.AddWithValue("@amount", amount)
                addCommand.Parameters.AddWithValue("@transferTo", transferTo)
                addCommand.ExecuteNonQuery()
            End Using

            ' Log the transfer transaction
            Dim logQuery As String = "INSERT INTO fund_transfers (from_account, to_account, amount, transfer_date) VALUES (@from_account, @to_account, @amount, NOW())"
            Using logCommand As New MySqlCommand(logQuery, connection, transaction)
                logCommand.Parameters.AddWithValue("@from_account", CurrentUserAccount)
                logCommand.Parameters.AddWithValue("@to_account", transferTo)
                logCommand.Parameters.AddWithValue("@amount", amount)
                logCommand.ExecuteNonQuery()
            End Using

            transaction.Commit()
            Return True

        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("Transfer failed: " & ex.Message, "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub ClearFields()
        txtTransferTo.Clear()
        txtAmountTransfer.Clear()
        txtTransferTo.Focus()
    End Sub
End Class