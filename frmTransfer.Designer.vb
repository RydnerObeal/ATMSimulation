<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransferTo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmountTransfer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatAppearance.BorderSize = 0
        Me.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.Color.DarkRed
        Me.btnTransfer.Location = New System.Drawing.Point(195, 395)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(177, 43)
        Me.btnTransfer.TabIndex = 73
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkRed
        Me.btnBack.Location = New System.Drawing.Point(440, 395)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(177, 43)
        Me.btnBack.TabIndex = 72
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(789, 43)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "==================================="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(789, 43)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "==================================="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(265, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(290, 43)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Transfer Funds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(58, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Transfer to: (Account Number)"
        '
        'txtTransferTo
        '
        Me.txtTransferTo.BackColor = System.Drawing.SystemColors.Menu
        Me.txtTransferTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransferTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferTo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtTransferTo.Location = New System.Drawing.Point(412, 198)
        Me.txtTransferTo.Name = "txtTransferTo"
        Me.txtTransferTo.Size = New System.Drawing.Size(311, 32)
        Me.txtTransferTo.TabIndex = 75
        Me.txtTransferTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 23)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Amount to Transfer: "
        '
        'txtAmountTransfer
        '
        Me.txtAmountTransfer.BackColor = System.Drawing.SystemColors.Menu
        Me.txtAmountTransfer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountTransfer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountTransfer.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtAmountTransfer.Location = New System.Drawing.Point(412, 277)
        Me.txtAmountTransfer.Name = "txtAmountTransfer"
        Me.txtAmountTransfer.Size = New System.Drawing.Size(311, 32)
        Me.txtAmountTransfer.TabIndex = 77
        Me.txtAmountTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(823, 523)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAmountTransfer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransferTo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransfer"
        Me.Text = "frmTransfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTransfer As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTransferTo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmountTransfer As TextBox
End Class
