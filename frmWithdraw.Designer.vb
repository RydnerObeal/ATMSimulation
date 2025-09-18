<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWithdraw
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblAmountWithdraw = New System.Windows.Forms.Label()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn10000 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(165, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 32)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Amount to Withdraw: "
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatAppearance.BorderSize = 0
        Me.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWithdraw.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.DarkRed
        Me.btnWithdraw.Location = New System.Drawing.Point(210, 425)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(177, 43)
        Me.btnWithdraw.TabIndex = 69
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(613, 425)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(177, 43)
        Me.btnBack.TabIndex = 68
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(163, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 43)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Current Balance: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(789, 43)
        Me.Label2.TabIndex = 65
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
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "==================================="
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBalance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblBalance.Location = New System.Drawing.Point(503, 70)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(97, 43)
        Me.lblBalance.TabIndex = 67
        Me.lblBalance.Text = "0.00"
        '
        'lblAmountWithdraw
        '
        Me.lblAmountWithdraw.AutoSize = True
        Me.lblAmountWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAmountWithdraw.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountWithdraw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblAmountWithdraw.Location = New System.Drawing.Point(503, 144)
        Me.lblAmountWithdraw.Name = "lblAmountWithdraw"
        Me.lblAmountWithdraw.Size = New System.Drawing.Size(97, 43)
        Me.lblAmountWithdraw.TabIndex = 72
        Me.lblAmountWithdraw.Text = "0.00"
        '
        'btn50
        '
        Me.btn50.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn50.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn50.FlatAppearance.BorderSize = 0
        Me.btn50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.ForeColor = System.Drawing.Color.DarkRed
        Me.btn50.Location = New System.Drawing.Point(102, 242)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(177, 43)
        Me.btn50.TabIndex = 73
        Me.btn50.Text = "50"
        Me.btn50.UseVisualStyleBackColor = False
        '
        'btn100
        '
        Me.btn100.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn100.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn100.FlatAppearance.BorderSize = 0
        Me.btn100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.ForeColor = System.Drawing.Color.DarkRed
        Me.btn100.Location = New System.Drawing.Point(334, 240)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(177, 43)
        Me.btn100.TabIndex = 74
        Me.btn100.Text = "100"
        Me.btn100.UseVisualStyleBackColor = False
        '
        'btn200
        '
        Me.btn200.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn200.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn200.FlatAppearance.BorderSize = 0
        Me.btn200.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn200.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.ForeColor = System.Drawing.Color.DarkRed
        Me.btn200.Location = New System.Drawing.Point(571, 240)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(177, 43)
        Me.btn200.TabIndex = 75
        Me.btn200.Text = "200"
        Me.btn200.UseVisualStyleBackColor = False
        '
        'btn500
        '
        Me.btn500.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn500.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn500.FlatAppearance.BorderSize = 0
        Me.btn500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn500.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn500.ForeColor = System.Drawing.Color.DarkRed
        Me.btn500.Location = New System.Drawing.Point(102, 326)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(177, 43)
        Me.btn500.TabIndex = 76
        Me.btn500.Text = "500"
        Me.btn500.UseVisualStyleBackColor = False
        '
        'btn1000
        '
        Me.btn1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn1000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1000.FlatAppearance.BorderSize = 0
        Me.btn1000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1000.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000.ForeColor = System.Drawing.Color.DarkRed
        Me.btn1000.Location = New System.Drawing.Point(334, 326)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(177, 43)
        Me.btn1000.TabIndex = 77
        Me.btn1000.Text = "1,000"
        Me.btn1000.UseVisualStyleBackColor = False
        '
        'btn10000
        '
        Me.btn10000.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btn10000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn10000.FlatAppearance.BorderSize = 0
        Me.btn10000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn10000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10000.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10000.ForeColor = System.Drawing.Color.DarkRed
        Me.btn10000.Location = New System.Drawing.Point(571, 326)
        Me.btn10000.Name = "btn10000"
        Me.btn10000.Size = New System.Drawing.Size(177, 43)
        Me.btn10000.TabIndex = 78
        Me.btn10000.Text = "10,000"
        Me.btn10000.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DarkRed
        Me.btnClear.Location = New System.Drawing.Point(414, 425)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 43)
        Me.btnClear.TabIndex = 86
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmWithdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(823, 523)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn10000)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.lblAmountWithdraw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWithdraw"
        Me.Text = "frmWithdraw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblAmountWithdraw As Label
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn10000 As Button
    Friend WithEvents btnClear As Button
End Class
