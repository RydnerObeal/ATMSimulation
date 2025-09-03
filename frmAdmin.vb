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
        'Obeal lagay mo dto kada click ng user sa button na to nag lload ung update form
        'kase mag kahiwalay ung create acc sa manage account 
        'So pag nag create ng new acc may notif na successful ung pag create   
        'tas chineck ung manage users nandun na agad ung nilagay na bagong account


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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserID.Clear()
        txtName.Clear()
        txtAccountNumber.Clear()
        txtPIN.Clear()
        txtAttempts.Clear()
        txtRole.Clear()
        cboStatus.SelectedIndex = -1
    End Sub
End Class