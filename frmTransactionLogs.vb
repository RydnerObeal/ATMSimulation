Imports MySql.Data.MySqlClient

Public Class frmTransactionLogs
    Private Sub frmTransactionLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadTransactions()
    End Sub

    Private Sub frmTransactionLogs_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
    End Sub

    Private Sub SetupListView()
        TransactionList.View = View.Details
        TransactionList.FullRowSelect = True
        TransactionList.GridLines = True
        TransactionList.Columns.Clear()
        TransactionList.Columns.Add("Account Number", 120)
        TransactionList.Columns.Add("Customer Name", 150)
        TransactionList.Columns.Add("Transaction Type", 120)
        TransactionList.Columns.Add("Amount", 100)
        TransactionList.Columns.Add("Date", 150)
    End Sub

    ' ===== LOAD ALL TRANSACTIONS =====
    Private Sub LoadTransactions()
        TransactionList.Items.Clear()

        Try
            Call Connect()

            sql = "
                SELECT 
                    ft.from_account as account_number,
                    COALESCE(u.name, 'Unknown') as customer_name,
                    'Transfer Out' as transaction_type,
                    ft.amount,
                    COALESCE(ft.transfer_date, NOW()) as transaction_date
                FROM fund_transfers ft
                LEFT JOIN users u ON ft.from_account = u.account_number
                
                UNION ALL
                
                SELECT 
                    ft.to_account as account_number,
                    COALESCE(u.name, 'Unknown') as customer_name,
                    'Transfer In' as transaction_type,
                    ft.amount,
                    COALESCE(ft.transfer_date, NOW()) as transaction_date
                FROM fund_transfers ft
                LEFT JOIN users u ON ft.to_account = u.account_number
                
                UNION ALL
                
                SELECT 
                    d.account_number,
                    COALESCE(u.name, 'Unknown') as customer_name,
                    'Deposit' as transaction_type,
                    d.amount,
                    COALESCE(d.deposit_date, NOW()) as transaction_date
                FROM deposits d
                LEFT JOIN users u ON d.account_number = u.account_number
                
                UNION ALL
                
                SELECT 
                    w.account_number,
                    COALESCE(u.name, 'Unknown') as customer_name,
                    'Withdrawal' as transaction_type,
                    w.amount,
                    COALESCE(w.withdrawal_date, NOW()) as transaction_date
                FROM withdrawals w
                LEFT JOIN users u ON w.account_number = u.account_number
                
                ORDER BY transaction_date DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                ' Create ListView item
                Dim item As New ListViewItem(dr("account_number").ToString())
                item.SubItems.Add(dr("customer_name").ToString())
                item.SubItems.Add(dr("transaction_type").ToString())
                item.SubItems.Add("₱" & Convert.ToDecimal(dr("amount")).ToString("N2"))

                ' Format date
                Dim transactionDate As DateTime
                If DateTime.TryParse(dr("transaction_date").ToString(), transactionDate) Then
                    item.SubItems.Add(transactionDate.ToString("MM/dd/yyyy HH:mm"))
                Else
                    item.SubItems.Add("N/A")
                End If

                ' Color coding
                Dim transType = dr("transaction_type").ToString()
                If transType = "Deposit" Or transType = "Transfer In" Then
                    item.BackColor = Color.LightGreen
                ElseIf transType = "Withdrawal" Or transType = "Transfer Out" Then
                    item.BackColor = Color.LightCoral
                End If

                TransactionList.Items.Add(item)
            End While

            dr.Close()
            cn.Close()

        Catch ex As Exception
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            MessageBox.Show("Error loading transactions: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactions()
        MessageBox.Show("Transactions refreshed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ShowAccountBalance(accountNumber As String)
        Try
            Call Connect()

            sql = "SELECT balance FROM users WHERE account_number = @account"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@account", accountNumber)
            Dim balance = cmd.ExecuteScalar()

            cn.Close()

            If balance IsNot Nothing Then
                MessageBox.Show($"Account: {accountNumber}" & vbCrLf &
                              $"Current Balance: ₱{Convert.ToDecimal(balance):N2}",
                              "Account Balance", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Account not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            MessageBox.Show("Error getting balance: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class