<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnDisplayUpDel = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BankSystem.My.Resources.Resources.TOTON_logo_2
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(587, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btnLoan
        '
        Me.btnLoan.Location = New System.Drawing.Point(186, 322)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(195, 40)
        Me.btnLoan.TabIndex = 18
        Me.btnLoan.Text = "&Loan"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnDisplayUpDel
        '
        Me.btnDisplayUpDel.Location = New System.Drawing.Point(186, 259)
        Me.btnDisplayUpDel.Name = "btnDisplayUpDel"
        Me.btnDisplayUpDel.Size = New System.Drawing.Size(195, 40)
        Me.btnDisplayUpDel.TabIndex = 17
        Me.btnDisplayUpDel.Text = "&Display, Update And Delete"
        Me.btnDisplayUpDel.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(186, 387)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(195, 40)
        Me.btnPayment.TabIndex = 16
        Me.btnPayment.Text = "&Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(186, 198)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(195, 40)
        Me.btnInsert.TabIndex = 15
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'frmSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 482)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnDisplayUpDel)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmSMain"
        Me.Text = "Staff Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnDisplayUpDel As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnInsert As Button
End Class
