Imports MySql.Data.MySqlClient

Public Class frmBalance
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim userForm As New frmUser()
        userForm.CurrentUserAccount = Me.UserAccountNumber
        userForm.Show()

        Me.Close()
    End Sub

    Public Property UserAccountNumber As String

    Private Sub frmBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserBalance()
    End Sub

    Private Sub LoadUserBalance()
        Call Connect()
        Try
            Connect()
            sql = "SELECT balance, name FROM users WHERE account_number = @acc AND status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@acc", UserAccountNumber)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                Dim balance As Decimal = Convert.ToDecimal(dr("balance"))
                Dim userName As String = dr("name").ToString()
                dr.Close()

                lblBalance.Text = "₱" + balance.ToString("N2")

                Me.Text = userName + "'s Balance"

            Else
                dr.Close()
                lblBalance.Text = "Account not found"
                MessageBox.Show("Unable to retrieve account information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cn.Close()

        Catch ex As Exception
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            cn.Close()
            MessageBox.Show("Error loading balance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblBalance.Text = "Error loading balance"
        End Try
    End Sub

    Private Sub lblBalance_Click(sender As Object, e As EventArgs) Handles lblBalance.Click
        LoadUserBalance()
    End Sub

End Class