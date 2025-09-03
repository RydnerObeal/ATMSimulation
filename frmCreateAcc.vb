Public Class frmCreateAcc
    Private Sub frmCreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmCreateAcc_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAccountNumber.Clear()
        txtPIN.Clear()
        cboRole.SelectedIndex = -1
    End Sub
End Class