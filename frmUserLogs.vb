Imports MySql.Data.MySqlClient

Public Class frmUserLogs
    Public Property CurrentUserAccount As String
    Private connectionString As String = "server=localhost;user=root;password=;database=atm_system"

    Private Sub frmUserLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadUserTransactions()
    End Sub

    Private Sub SetupListView()
        ListView2.View = View.Details
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Columns.Clear()
        ListView2.Columns.Add("Transaction Type", 150)
        ListView2.Columns.Add("Amount", 150)
        ListView2.Columns.Add("Details", 150)
        ListView2.Columns.Add("Date", 150)
    End Sub

    Private Sub LoadUserTransactions()
        ListView2.Items.Clear()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "
                    SELECT 
                        'Deposit' as transaction_type,
                        amount,
                        'Cash Deposit' as details,
                        COALESCE(deposit_date, NOW()) as transaction_date
                    FROM deposits
                    WHERE account_number = @account
                    
                    UNION ALL
                    
                    SELECT 
                        'Withdrawal' as transaction_type,
                        amount,
                        'Cash Withdrawal' as details,
                        COALESCE(withdrawal_date, NOW()) as transaction_date
                    FROM withdrawals
                    WHERE account_number = @account
                    
                    UNION ALL
                    
                    SELECT 
                        'Transfer Out' as transaction_type,
                        amount,
                        CONCAT('To: ', to_account) as details,
                        COALESCE(transfer_date, NOW()) as transaction_date
                    FROM fund_transfers
                    WHERE from_account = @account
                    
                    UNION ALL
                    
                    SELECT 
                        'Transfer In' as transaction_type,
                        amount,
                        CONCAT('From: ', from_account) as details,
                        COALESCE(transfer_date, NOW()) as transaction_date
                    FROM fund_transfers
                    WHERE to_account = @account
                    
                    ORDER BY transaction_date DESC"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@account", CurrentUserAccount)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("transaction_type").ToString())
                            item.SubItems.Add("₱" & Convert.ToDecimal(reader("amount")).ToString("N2"))
                            item.SubItems.Add(reader("details").ToString())

                            Dim transactionDate As DateTime
                            If DateTime.TryParse(reader("transaction_date").ToString(), transactionDate) Then
                                item.SubItems.Add(transactionDate.ToString("MM/dd/yyyy HH:mm"))
                            Else
                                item.SubItems.Add("N/A")
                            End If

                            ' Color coding
                            Dim transType = reader("transaction_type").ToString()
                            If transType = "Deposit" Or transType = "Transfer In" Then
                                item.BackColor = Color.LightGreen
                            ElseIf transType = "Withdrawal" Or transType = "Transfer Out" Then
                                item.BackColor = Color.LightCoral
                            End If

                            ListView2.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

            MessageBox.Show($"Loaded {ListView2.Items.Count} transactions for account: {CurrentUserAccount}",
                          "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error loading your transactions: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        If ListView2.SelectedItems.Count > 0 Then
            Dim selectedItem = ListView2.SelectedItems(0)

            Dim transactionType = selectedItem.Text
            Dim amount = selectedItem.SubItems(1).Text
            Dim details = selectedItem.SubItems(2).Text
            Dim dateTime = selectedItem.SubItems(3).Text

            Dim message As String = $"Transaction Details:" & vbCrLf & vbCrLf &
                                  $"Type: {transactionType}" & vbCrLf &
                                  $"Amount: {amount}" & vbCrLf &
                                  $"Details: {details}" & vbCrLf &
                                  $"Date: {dateTime}"

            MessageBox.Show(message, "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class