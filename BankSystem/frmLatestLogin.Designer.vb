<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatestLogin
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
        Me.lnkNewAccount = New System.Windows.Forms.LinkLabel()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.totonLogo = New System.Windows.Forms.PictureBox()
        Me.gbLogin.SuspendLayout()
        CType(Me.totonLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkNewAccount
        '
        Me.lnkNewAccount.AutoSize = True
        Me.lnkNewAccount.Location = New System.Drawing.Point(205, 372)
        Me.lnkNewAccount.Name = "lnkNewAccount"
        Me.lnkNewAccount.Size = New System.Drawing.Size(147, 17)
        Me.lnkNewAccount.TabIndex = 5
        Me.lnkNewAccount.TabStop = True
        Me.lnkNewAccount.Text = "Register &New Account"
        '
        'gbLogin
        '
        Me.gbLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbLogin.Controls.Add(Me.lblTest)
        Me.gbLogin.Controls.Add(Me.btnCancel)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.txtPassword)
        Me.gbLogin.Controls.Add(Me.txtID)
        Me.gbLogin.Location = New System.Drawing.Point(203, 208)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(394, 161)
        Me.gbLogin.TabIndex = 4
        Me.gbLogin.TabStop = False
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(7, 90)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(12, 17)
        Me.lblTest.TabIndex = 4
        Me.lblTest.Text = "."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(302, 110)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 36)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(212, 110)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(84, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(6, 57)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(380, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID
        '
        Me.txtID.ForeColor = System.Drawing.Color.Gray
        Me.txtID.Location = New System.Drawing.Point(6, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(380, 22)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "User ID"
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'totonLogo
        '
        Me.totonLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totonLogo.Image = Global.BankSystem.My.Resources.Resources.TOTON_logo_2
        Me.totonLogo.Location = New System.Drawing.Point(278, 62)
        Me.totonLogo.Name = "totonLogo"
        Me.totonLogo.Size = New System.Drawing.Size(260, 130)
        Me.totonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.totonLogo.TabIndex = 3
        Me.totonLogo.TabStop = False
        '
        'frmLatestLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lnkNewAccount)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.totonLogo)
        Me.Name = "frmLatestLogin"
        Me.Text = "frmLatestLogin"
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.totonLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnkNewAccount As LinkLabel
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents lblTest As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents totonLogo As PictureBox
End Class
