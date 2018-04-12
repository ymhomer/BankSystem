<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewPayment))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCustId = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.gbFundTransfer = New System.Windows.Forms.GroupBox()
        Me.txtReceiverName = New System.Windows.Forms.TextBox()
        Me.txtReceiverAccount = New System.Windows.Forms.TextBox()
        Me.txtSenderName = New System.Windows.Forms.TextBox()
        Me.lblReceiverName = New System.Windows.Forms.Label()
        Me.lblReceiverID = New System.Windows.Forms.Label()
        Me.lblSenderName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboPaymentType = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPaymentID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.gbFundTransfer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(408, 593)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 45)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(279, 593)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(121, 45)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(150, 593)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(121, 45)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.Gray
        Me.lblDate.Location = New System.Drawing.Point(338, 133)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(13, 20)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "."
        '
        'lblCustId
        '
        Me.lblCustId.Location = New System.Drawing.Point(21, 195)
        Me.lblCustId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustId.Name = "lblCustId"
        Me.lblCustId.Size = New System.Drawing.Size(202, 25)
        Me.lblCustId.TabIndex = 8
        Me.lblCustId.Text = "Customer ID : "
        Me.lblCustId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustID
        '
        Me.txtCustID.Enabled = False
        Me.txtCustID.Location = New System.Drawing.Point(224, 191)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustID.MaxLength = 6
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(305, 26)
        Me.txtCustID.TabIndex = 10
        '
        'gbFundTransfer
        '
        Me.gbFundTransfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFundTransfer.Controls.Add(Me.txtReceiverName)
        Me.gbFundTransfer.Controls.Add(Me.txtReceiverAccount)
        Me.gbFundTransfer.Controls.Add(Me.txtSenderName)
        Me.gbFundTransfer.Controls.Add(Me.lblReceiverName)
        Me.gbFundTransfer.Controls.Add(Me.lblReceiverID)
        Me.gbFundTransfer.Controls.Add(Me.lblSenderName)
        Me.gbFundTransfer.Location = New System.Drawing.Point(13, 419)
        Me.gbFundTransfer.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFundTransfer.Name = "gbFundTransfer"
        Me.gbFundTransfer.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFundTransfer.Size = New System.Drawing.Size(539, 154)
        Me.gbFundTransfer.TabIndex = 12
        Me.gbFundTransfer.TabStop = False
        '
        'txtReceiverName
        '
        Me.txtReceiverName.Enabled = False
        Me.txtReceiverName.Location = New System.Drawing.Point(210, 105)
        Me.txtReceiverName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiverName.MaxLength = 40
        Me.txtReceiverName.Name = "txtReceiverName"
        Me.txtReceiverName.Size = New System.Drawing.Size(305, 26)
        Me.txtReceiverName.TabIndex = 2
        '
        'txtReceiverAccount
        '
        Me.txtReceiverAccount.Location = New System.Drawing.Point(210, 68)
        Me.txtReceiverAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiverAccount.MaxLength = 6
        Me.txtReceiverAccount.Name = "txtReceiverAccount"
        Me.txtReceiverAccount.Size = New System.Drawing.Size(305, 26)
        Me.txtReceiverAccount.TabIndex = 2
        '
        'txtSenderName
        '
        Me.txtSenderName.Location = New System.Drawing.Point(210, 28)
        Me.txtSenderName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenderName.MaxLength = 40
        Me.txtSenderName.Name = "txtSenderName"
        Me.txtSenderName.Size = New System.Drawing.Size(305, 26)
        Me.txtSenderName.TabIndex = 1
        '
        'lblReceiverName
        '
        Me.lblReceiverName.Location = New System.Drawing.Point(8, 106)
        Me.lblReceiverName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceiverName.Name = "lblReceiverName"
        Me.lblReceiverName.Size = New System.Drawing.Size(202, 25)
        Me.lblReceiverName.TabIndex = 0
        Me.lblReceiverName.Text = "Receiver Name : "
        Me.lblReceiverName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReceiverID
        '
        Me.lblReceiverID.Location = New System.Drawing.Point(8, 71)
        Me.lblReceiverID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceiverID.Name = "lblReceiverID"
        Me.lblReceiverID.Size = New System.Drawing.Size(202, 25)
        Me.lblReceiverID.TabIndex = 0
        Me.lblReceiverID.Text = "Receiver Account : "
        Me.lblReceiverID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSenderName
        '
        Me.lblSenderName.Location = New System.Drawing.Point(8, 31)
        Me.lblSenderName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenderName.Name = "lblSenderName"
        Me.lblSenderName.Size = New System.Drawing.Size(202, 25)
        Me.lblSenderName.TabIndex = 0
        Me.lblSenderName.Text = "Sender Name : "
        Me.lblSenderName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPaymentType)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPaymentID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblType)
        Me.GroupBox1.Controls.Add(Me.lblPaymentID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 257)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(539, 154)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cboPaymentType
        '
        Me.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentType.FormattingEnabled = True
        Me.cboPaymentType.Items.AddRange(New Object() {"Fund transfer", "Payment"})
        Me.cboPaymentType.Location = New System.Drawing.Point(210, 67)
        Me.cboPaymentType.Name = "cboPaymentType"
        Me.cboPaymentType.Size = New System.Drawing.Size(306, 28)
        Me.cboPaymentType.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(248, 109)
        Me.txtAmount.MaxLength = 7
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(267, 26)
        Me.txtAmount.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RM"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Enabled = False
        Me.txtPaymentID.Location = New System.Drawing.Point(211, 24)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentID.MaxLength = 6
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(305, 26)
        Me.txtPaymentID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(8, 68)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(202, 25)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type : "
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaymentID
        '
        Me.lblPaymentID.Location = New System.Drawing.Point(8, 28)
        Me.lblPaymentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(202, 25)
        Me.lblPaymentID.TabIndex = 0
        Me.lblPaymentID.Text = "Payment ID : "
        Me.lblPaymentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BankSystem.My.Resources.Resources.TOTON_logo_2
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 228)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Customer Name : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustName
        '
        Me.txtCustName.Enabled = False
        Me.txtCustName.Location = New System.Drawing.Point(224, 227)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustName.MaxLength = 30
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(305, 26)
        Me.txtCustName.TabIndex = 10
        '
        'doc
        '
        Me.doc.OriginAtMargins = True
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.UseAntiAlias = True
        Me.dlgPreview.Visible = False
        '
        'frmNewPayment
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(569, 651)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCustId)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.gbFundTransfer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewPayment"
        Me.Text = "frmNewPayment"
        Me.gbFundTransfer.ResumeLayout(False)
        Me.gbFundTransfer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblCustId As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents gbFundTransfer As GroupBox
    Friend WithEvents txtReceiverAccount As TextBox
    Friend WithEvents txtSenderName As TextBox
    Friend WithEvents lblReceiverID As Label
    Friend WithEvents lblSenderName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents txtReceiverName As TextBox
    Friend WithEvents lblReceiverName As Label
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
