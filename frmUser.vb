Imports MySql.Data.MySqlClient

Public Class frmUser
    Public Property CurrentUserAccount As String
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerInfo()
    End Sub

    Private Sub LoadCustomerInfo()
        Call Connect()

        sql = "SELECT name, account_number FROM users WHERE account_number = @account AND status = 'Active'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@account", CurrentUserAccount)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            lblName.Text = dr("name").ToString()
            lblNumber.Text = dr("account_number").ToString()
        End If

        dr.Close()
        cn.Close()
    End Sub

    '********************************************************************
    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Dim balanceForm As New frmBalance()
        balanceForm.UserAccountNumber = CurrentUserAccount
        balanceForm.TopLevel = False
        balanceForm.FormBorderStyle = FormBorderStyle.None
        balanceForm.Dock = DockStyle.Fill

        PanelBottons.Visible = False

        ShowPanel.Controls.Add(balanceForm)
        balanceForm.Show()

        AddHandler balanceForm.FormClosed, AddressOf BalanceForm_FormClosed

    End Sub

    Private Sub BalanceForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        PanelBottons.Visible = True

        ShowPanel.Controls.Remove(DirectCast(sender, Form))
    End Sub
    '********************************************************************
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim withdrawForm As New frmWithdraw()
        withdrawForm.UserAccountNumber = CurrentUserAccount
        withdrawForm.TopLevel = False
        withdrawForm.FormBorderStyle = FormBorderStyle.None
        withdrawForm.Dock = DockStyle.Fill

        PanelBottons.Visible = False

        ShowPanel.Controls.Add(withdrawForm)
        withdrawForm.Show()

        AddHandler withdrawForm.FormClosed, AddressOf WithdrawForm_FormClosed
    End Sub

    Private Sub WithdrawForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        PanelBottons.Visible = True
        ShowPanel.Controls.Remove(DirectCast(sender, Form))
    End Sub
    '********************************************************************
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim depositForm As New frmDeposit()
        depositForm.UserAccountNumber = CurrentUserAccount
        depositForm.TopLevel = False
        depositForm.FormBorderStyle = FormBorderStyle.None
        depositForm.Dock = DockStyle.Fill


        PanelBottons.Visible = False

        ShowPanel.Controls.Add(depositForm)
        depositForm.Show()
        AddHandler depositForm.FormClosed, AddressOf DepositForm_FormClosed
    End Sub

    Private Sub DepositForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        PanelBottons.Visible = True
        ShowPanel.Controls.Remove(DirectCast(sender, Form))
    End Sub
    '********************************************************************
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim transferForm As New frmTransfer()
        transferForm.TopLevel = False
        transferForm.FormBorderStyle = FormBorderStyle.None
        transferForm.Dock = DockStyle.Fill
        transferForm.CurrentUserAccount = Me.CurrentUserAccount

        PanelBottons.Visible = False

        ShowPanel.Controls.Add(transferForm)
        transferForm.Show()

        AddHandler transferForm.FormClosed, AddressOf TransferForm_FormClosed
    End Sub

    Private Sub TransferForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        PanelBottons.Visible = True
        ShowPanel.Controls.Remove(DirectCast(sender, Form))
    End Sub
    '********************************************************************
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Dim userLogsForm As New frmUserLogs()
        userLogsForm.TopLevel = False
        userLogsForm.FormBorderStyle = FormBorderStyle.None
        userLogsForm.Dock = DockStyle.Fill

        userLogsForm.CurrentUserAccount = Me.CurrentUserAccount

        PanelBottons.Visible = False
        ShowPanel.Controls.Add(userLogsForm)
        userLogsForm.Show()
        AddHandler userLogsForm.FormClosed, AddressOf UserLogsForm_FormClosed
    End Sub

    Private Sub UserLogsForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        PanelBottons.Visible = True
        ShowPanel.Controls.Remove(DirectCast(sender, Form))
    End Sub
    '********************************************************************
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub
End Class