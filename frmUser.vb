Public Class frmUser
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        With frmBalance
            .TopLevel = False
            ShowPanel.Controls.Add(frmBalance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        With frmWithdraw
            .TopLevel = False
            ShowPanel.Controls.Add(frmWithdraw)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        With frmDeposit
            .TopLevel = False
            ShowPanel.Controls.Add(frmDeposit)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        With frmTransfer
            .TopLevel = False
            ShowPanel.Controls.Add(frmTransfer)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        With frmUserLogs
            .TopLevel = False
            ShowPanel.Controls.Add(frmUserLogs)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()

    End Sub
End Class