Public Class frmpolicy

    Private Sub frmpolicy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim policyBox As TextBox = Nothing

        Dim i As Integer = 0
        While i < Me.Controls.Count
            If Me.Controls(i).Name = "txtPolicy" AndAlso TypeOf Me.Controls(i) Is TextBox Then
                policyBox = CType(Me.Controls(i), TextBox)
                Exit While
            End If
            i += 1
        End While

        If policyBox Is Nothing Then
            policyBox = New TextBox()
            policyBox.Name = "txtPolicy"
            policyBox.Multiline = True
            policyBox.ScrollBars = ScrollBars.Vertical
            policyBox.ReadOnly = True
            policyBox.Font = New Font("Segoe UI", 10)
            policyBox.Location = New Point(10, 10)
            policyBox.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 70)
            policyBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            Me.Controls.Add(policyBox)
            policyBox.SendToBack()
        Else
            policyBox.Multiline = True
            policyBox.ScrollBars = ScrollBars.Vertical
            policyBox.ReadOnly = True
        End If

        policyBox.Text =
            "🏦 ATM SYSTEM POLICY" & vbCrLf & vbCrLf &
            "1. Withdrawal Policy" & vbCrLf &
            "- Daily withdrawal limit is ₱50,000 per account." & vbCrLf &
            "- Minimum balance of ₱100 must remain after withdrawal." & vbCrLf &
            "- Transactions exceeding limit will be declined." & vbCrLf & vbCrLf &
            "2. Deposit Policy" & vbCrLf &
            "- Daily deposit limit is ₱100,000 per account." & vbCrLf &
            "- Minimum deposit accepted is ₱100." & vbCrLf &
            "- Deposits above the limit will be declined and must be retried the next day." & vbCrLf &
            "- Deposits are subject to verification." & vbCrLf & vbCrLf &
            "3. Transfer Policy" & vbCrLf &
            "- Transfers cannot be made to the same account." & vbCrLf &
            "- Maximum transfer is subject to available balance and withdrawal limit." & vbCrLf & vbCrLf &
            "4. Security Policy" & vbCrLf &
            "- Accounts lock after 3 invalid login attempts." & vbCrLf &
            "- Customers must keep PINs confidential." & vbCrLf &
            "- All ATM transactions are logged for auditing." & vbCrLf & vbCrLf &
            "5. General Policies" & vbCrLf &
            "- Accounts must maintain ₱100 minimum balance at all times." & vbCrLf &
            "- ATM may be suspended during system maintenance." & vbCrLf &
            "- Fraudulent or suspicious activity will result in account suspension." & vbCrLf &
            "- Lost or stolen cards must be reported immediately." & vbCrLf
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
