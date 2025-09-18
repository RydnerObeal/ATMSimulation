<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnTransactionLogs = New System.Windows.Forms.Button()
        Me.btnCreateAcc = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAdminName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lvUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.pnlManageUsers = New System.Windows.Forms.Panel()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAttempts = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.pnlManageUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnTransactionLogs)
        Me.Panel1.Controls.Add(Me.btnCreateAcc)
        Me.Panel1.Controls.Add(Me.btnManageUser)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 723)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLogout.Image = Global.ATMSimulation.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(0, 661)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(267, 62)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnTransactionLogs
        '
        Me.btnTransactionLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnTransactionLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransactionLogs.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTransactionLogs.FlatAppearance.BorderSize = 0
        Me.btnTransactionLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTransactionLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransactionLogs.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnTransactionLogs.Image = Global.ATMSimulation.My.Resources.Resources.transactionF
        Me.btnTransactionLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactionLogs.Location = New System.Drawing.Point(0, 293)
        Me.btnTransactionLogs.Name = "btnTransactionLogs"
        Me.btnTransactionLogs.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTransactionLogs.Size = New System.Drawing.Size(267, 63)
        Me.btnTransactionLogs.TabIndex = 3
        Me.btnTransactionLogs.Text = "Transaction Logs"
        Me.btnTransactionLogs.UseVisualStyleBackColor = False
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnCreateAcc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreateAcc.FlatAppearance.BorderSize = 0
        Me.btnCreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAcc.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCreateAcc.Image = Global.ATMSimulation.My.Resources.Resources.userADD
        Me.btnCreateAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateAcc.Location = New System.Drawing.Point(0, 230)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCreateAcc.Size = New System.Drawing.Size(267, 63)
        Me.btnCreateAcc.TabIndex = 2
        Me.btnCreateAcc.Text = "Create Account"
        Me.btnCreateAcc.UseVisualStyleBackColor = False
        '
        'btnManageUser
        '
        Me.btnManageUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnManageUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageUser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnManageUser.FlatAppearance.BorderSize = 0
        Me.btnManageUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUser.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnManageUser.Image = Global.ATMSimulation.My.Resources.Resources.group
        Me.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageUser.Location = New System.Drawing.Point(0, 167)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnManageUser.Size = New System.Drawing.Size(267, 63)
        Me.btnManageUser.TabIndex = 1
        Me.btnManageUser.Text = "Manage Users"
        Me.btnManageUser.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 167)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblAdminName)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(267, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(975, 88)
        Me.Panel3.TabIndex = 1
        '
        'lblAdminName
        '
        Me.lblAdminName.AutoSize = True
        Me.lblAdminName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblAdminName.Location = New System.Drawing.Point(278, 22)
        Me.lblAdminName.Name = "lblAdminName"
        Me.lblAdminName.Size = New System.Drawing.Size(134, 43)
        Me.lblAdminName.TabIndex = 12
        Me.lblAdminName.Text = "Admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(75, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 43)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Welcome!"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(0, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(8, 50)
        Me.Panel4.TabIndex = 30
        '
        'lvUsers
        '
        Me.lvUsers.BackColor = System.Drawing.SystemColors.Menu
        Me.lvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUsers.FullRowSelect = True
        Me.lvUsers.GridLines = True
        Me.lvUsers.HideSelection = False
        Me.lvUsers.Location = New System.Drawing.Point(18, 54)
        Me.lvUsers.Name = "lvUsers"
        Me.lvUsers.Size = New System.Drawing.Size(904, 263)
        Me.lvUsers.TabIndex = 31
        Me.lvUsers.UseCompatibleStateImageBehavior = False
        Me.lvUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Account Number"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PIN"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Attempts"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Role"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Balance"
        Me.ColumnHeader8.Width = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 23)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Search By:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(133, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(387, 25)
        Me.txtSearch.TabIndex = 49
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MainPanel.Controls.Add(Me.pnlManageUsers)
        Me.MainPanel.Controls.Add(Me.Panel4)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(267, 88)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(975, 635)
        Me.MainPanel.TabIndex = 2
        '
        'pnlManageUsers
        '
        Me.pnlManageUsers.Controls.Add(Me.Label1)
        Me.pnlManageUsers.Controls.Add(Me.cboRole)
        Me.pnlManageUsers.Controls.Add(Me.btnClear)
        Me.pnlManageUsers.Controls.Add(Me.Label11)
        Me.pnlManageUsers.Controls.Add(Me.lvUsers)
        Me.pnlManageUsers.Controls.Add(Me.txtAttempts)
        Me.pnlManageUsers.Controls.Add(Me.Label10)
        Me.pnlManageUsers.Controls.Add(Me.btnUpdate)
        Me.pnlManageUsers.Controls.Add(Me.btnDelete)
        Me.pnlManageUsers.Controls.Add(Me.cboStatus)
        Me.pnlManageUsers.Controls.Add(Me.txtPIN)
        Me.pnlManageUsers.Controls.Add(Me.txtAccountNumber)
        Me.pnlManageUsers.Controls.Add(Me.txtName)
        Me.pnlManageUsers.Controls.Add(Me.txtUserID)
        Me.pnlManageUsers.Controls.Add(Me.Label9)
        Me.pnlManageUsers.Controls.Add(Me.Label6)
        Me.pnlManageUsers.Controls.Add(Me.Label4)
        Me.pnlManageUsers.Controls.Add(Me.Label3)
        Me.pnlManageUsers.Controls.Add(Me.Label2)
        Me.pnlManageUsers.Controls.Add(Me.txtSearch)
        Me.pnlManageUsers.Controls.Add(Me.Label7)
        Me.pnlManageUsers.Location = New System.Drawing.Point(7, 10)
        Me.pnlManageUsers.Name = "pnlManageUsers"
        Me.pnlManageUsers.Size = New System.Drawing.Size(956, 612)
        Me.pnlManageUsers.TabIndex = 76
        '
        'cboRole
        '
        Me.cboRole.BackColor = System.Drawing.SystemColors.Menu
        Me.cboRole.DropDownHeight = 120
        Me.cboRole.DropDownWidth = 160
        Me.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRole.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.IntegralHeight = False
        Me.cboRole.ItemHeight = 20
        Me.cboRole.Items.AddRange(New Object() {"Active", "Deactivated"})
        Me.cboRole.Location = New System.Drawing.Point(640, 405)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(220, 28)
        Me.cboRole.TabIndex = 76
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DarkRed
        Me.btnClear.Location = New System.Drawing.Point(363, 552)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 43)
        Me.btnClear.TabIndex = 75
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(514, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 23)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Role"
        '
        'txtAttempts
        '
        Me.txtAttempts.BackColor = System.Drawing.SystemColors.Menu
        Me.txtAttempts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAttempts.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttempts.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtAttempts.Location = New System.Drawing.Point(640, 354)
        Me.txtAttempts.Name = "txtAttempts"
        Me.txtAttempts.Size = New System.Drawing.Size(220, 25)
        Me.txtAttempts.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(514, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 23)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Attempts"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkRed
        Me.btnUpdate.Location = New System.Drawing.Point(562, 552)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(177, 43)
        Me.btnUpdate.TabIndex = 70
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDelete.Location = New System.Drawing.Point(757, 552)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(177, 43)
        Me.btnDelete.TabIndex = 69
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.Menu
        Me.cboStatus.DropDownHeight = 120
        Me.cboStatus.DropDownWidth = 160
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.IntegralHeight = False
        Me.cboStatus.ItemHeight = 20
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Deactivated"})
        Me.cboStatus.Location = New System.Drawing.Point(640, 456)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(220, 28)
        Me.cboStatus.TabIndex = 68
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPIN.Location = New System.Drawing.Point(244, 511)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(220, 25)
        Me.txtPIN.TabIndex = 67
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.BackColor = System.Drawing.SystemColors.Menu
        Me.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountNumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNumber.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtAccountNumber.Location = New System.Drawing.Point(244, 456)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(220, 25)
        Me.txtAccountNumber.TabIndex = 66
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Menu
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtName.Location = New System.Drawing.Point(244, 405)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 25)
        Me.txtName.TabIndex = 65
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Menu
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtUserID.Location = New System.Drawing.Point(244, 354)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(220, 25)
        Me.txtUserID.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(514, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 23)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(33, 511)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 23)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "PIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 23)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Search By: Username and Account Number"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 723)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Controls"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.pnlManageUsers.ResumeLayout(False)
        Me.pnlManageUsers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnManageUser As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTransactionLogs As Button
    Friend WithEvents btnCreateAcc As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblAdminName As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lvUsers As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAttempts As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlManageUsers As Panel
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents Label1 As Label
End Class
