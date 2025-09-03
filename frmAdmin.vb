Public Class frmAdmin
    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        With frmCreateAcc
            .TopLevel = False
            .AutoScroll = True
            MainPanel.Controls.Add(frmCreateAcc)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        With Me
            MainPanel.Controls.Remove(frmCreateAcc)
            MainPanel.Controls.Remove(frmTransactionLogs)
            MainPanel.Show()
        End With

    End Sub

    Private Sub btnTransactionLogs_Click(sender As Object, e As EventArgs) Handles btnTransactionLogs.Click
        With frmTransactionLogs
            .TopLevel = False
            .AutoScroll = True
            MainPanel.Controls.Add(frmTransactionLogs)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub
End Class