<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.lnkNewAccount = New System.Windows.Forms.LinkLabel()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.totonLogo = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbLogin.SuspendLayout()
        CType(Me.totonLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkNewAccount
        '
        Me.lnkNewAccount.AutoSize = True
        Me.lnkNewAccount.Location = New System.Drawing.Point(13, 403)
        Me.lnkNewAccount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkNewAccount.Name = "lnkNewAccount"
        Me.lnkNewAccount.Size = New System.Drawing.Size(204, 25)
        Me.lnkNewAccount.TabIndex = 1
        Me.lnkNewAccount.TabStop = True
        Me.lnkNewAccount.Text = "Register &New Account"
        Me.ToolTip1.SetToolTip(Me.lnkNewAccount, "To Register new account")
        '
        'gbLogin
        '
        Me.gbLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbLogin.Controls.Add(Me.btnCancel)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.txtPassword)
        Me.gbLogin.Controls.Add(Me.txtID)
        Me.gbLogin.Location = New System.Drawing.Point(13, 198)
        Me.gbLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Padding = New System.Windows.Forms.Padding(4)
        Me.gbLogin.Size = New System.Drawing.Size(473, 201)
        Me.gbLogin.TabIndex = 0
        Me.gbLogin.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(362, 138)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 45)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(254, 138)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(101, 45)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(7, 71)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(455, 30)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPassword, "This field is required.")
        '
        'txtID
        '
        Me.txtID.ForeColor = System.Drawing.Color.Gray
        Me.HelpProvider1.SetHelpString(Me.txtID, "Please ensure the account already registed.")
        Me.txtID.Location = New System.Drawing.Point(7, 31)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.HelpProvider1.SetShowHelp(Me.txtID, True)
        Me.txtID.Size = New System.Drawing.Size(455, 30)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "User ID"
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtID, "This field is required.")
        '
        'totonLogo
        '
        Me.totonLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totonLogo.Image = Global.BankSystem.My.Resources.Resources.TOTON_logo_2
        Me.totonLogo.Location = New System.Drawing.Point(84, 13)
        Me.totonLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.totonLogo.Name = "totonLogo"
        Me.totonLogo.Size = New System.Drawing.Size(336, 174)
        Me.totonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.totonLogo.TabIndex = 6
        Me.totonLogo.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        Me.ToolTip1.ToolTipTitle = "Tips"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(504, 449)
        Me.Controls.Add(Me.lnkNewAccount)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.totonLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.totonLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnkNewAccount As LinkLabel
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents totonLogo As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
