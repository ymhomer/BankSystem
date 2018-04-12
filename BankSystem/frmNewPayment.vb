Imports System.Text

Public Class frmNewPayment
    Dim uAccountID As String = ""
    Dim rAccountID As String = ""
    Dim payDate As String = ""
    Dim sAmount As Double = 0.0
    Dim sAmountNew As Double = 0.0
    Dim rAmount As Double = 0.0
    Dim rAmountNew As Double = 0.0
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        Me.CenterToParent()

        With txtReceiverAccount
            .Text = "Enter receiver's Account ID"
            .ForeColor = Color.Gray
        End With

        txtPaymentID.Text = App.GetPaymentID
        cboPaymentType.SelectedIndex = 0

        If frmLogin.uPosition.Equals("s") Then
            txtCustID.Enabled = True
        Else
            txtCustID.Text = frmLogin.uId.ToString
            getCustName()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        confirmPayment()
    End Sub

    Private Sub txtAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAmount.KeyUp
        If Not Double.TryParse(txtAmount.Text, 0.0) Then
            If txtAmount.Text = "" Then
                '
            Else
                txtAmount.Text = ""
                MessageBox.Show("Please enter correct the amount")
            End If
            Exit Sub
        End If
    End Sub

    Private Sub txtCustID_Leave(sender As Object, e As EventArgs) Handles txtCustID.Leave
        getCustName()
    End Sub

    Private Sub txtCustID_Enter(sender As Object, e As EventArgs) Handles txtCustID.Enter
        txtCustName.Text = ""
    End Sub

    Private Sub cboPaymentType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPaymentType.SelectedValueChanged
        'Fund transfer
        'Payment
        If cboPaymentType.SelectedItem.Equals("Fund transfer") Then
            gbFundTransfer.Visible = True
        Else
            gbFundTransfer.Visible = False
        End If
    End Sub

    Private Sub txtReceiverAccount_Enter(sender As Object, e As EventArgs) Handles txtReceiverAccount.Enter
        With txtReceiverAccount
            .Text = ""
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub txtReceiverAccount_Leave(sender As Object, e As EventArgs) Handles txtReceiverAccount.Leave
        getReceiverAccount()
    End Sub

    Private Sub getCustName()
        Dim db As New BankDBDataContext()
        Dim cust As New Customer()

        For Each cust In db.Customers
            If cust.custID.Equals(txtCustID.Text.ToUpper) Then
                txtCustName.Text = cust.custName
                uAccountID = cust.accountID 'for tranfer purpose
            End If
        Next
        If txtCustName.Text.Equals("") Then
            txtCustName.Text = "N/A"
            MsgBox("Customer ID not found, Please Try again.")
            With txtCustID
                .Text = ""
                .Select()
            End With
        End If
    End Sub

    Private Sub getReceiverAccount()
        Dim db As New BankDBDataContext()
        Dim cust As New Customer()

        For Each cust In db.Customers
            If cust.accountID.Equals(txtReceiverAccount.Text.ToUpper) Then
                txtReceiverName.Text = cust.custName
            End If
        Next
        If txtReceiverName.Text.Equals("") Then
            txtReceiverName.Text = "N/A"
            MsgBox("Receiver not found, Please Try again.")
            With txtReceiverName
                .Text = ""
                .Select()
            End With
        End If
    End Sub

    Private Sub confirmPayment()
        If txtCustID.Text.Equals("") Then
            MsgBox("Customer ID cannot be empty")
            txtCustID.Select()
        ElseIf txtCustName.Text.Equals("") Then
            MsgBox("Customer Name cannot be empty")
            txtCustName.Select()
        ElseIf txtAmount.Text.Equals("") Then
            MsgBox("Amount cannot be empty")
            txtAmount.Select()
        ElseIf cboPaymentType.SelectedItem.Equals("Fund transfer") Then
            If txtSenderName.Text.Equals("") Then
                MsgBox("Sender Name cannot be empty")
                txtSenderName.Select()
            ElseIf txtReceiverName.Text.Equals("") Then
                MsgBox("Receiver not Valid")
                txtReceiverAccount.Select()
            ElseIf txtReceiverName.Text.Equals("N/A") Then
                MsgBox("Invalid Receiver")
                txtReceiverAccount.Select()
            ElseIf txtReceiverName.Text.Equals(txtCustName.Text) Then
                MsgBox("The receiver cannot same with current account")
                txtReceiverAccount.Select()
            Else
                checkRemainAmount()
            End If
        Else
            checkRemainAmount()
        End If
    End Sub

    Private Sub checkRemainAmount() ' and transfer money
        MsgBox("Checking Amount")
        Dim db As New BankDBDataContext()
        Dim cust As New Customer()
        Dim acc As New Account()

        For Each acc In db.Accounts
            If acc.accountID.Equals(uAccountID) Then
                'check confirm the transfer amount
                'update sender amount
                sAmount = acc.balance
                If sAmount < CDbl(txtAmount.Text) Then
                    MsgBox("Your balance is : RM " & sAmount & vbNewLine & "No enough to Transfer/Pay.")
                    With txtAmount
                        .Text = ""
                        .Select()
                    End With

                    Exit Sub
                    Exit For
                Else
                    sAmountNew = sAmount - CDbl(txtAmount.Text)
                    MsgBox("Sender New Balance = " & sAmountNew)
                    Exit For
                End If
            End If
        Next

        If cboPaymentType.SelectedItem.Equals("Fund transfer") Then
            'update receiver amount
            For Each acc In db.Accounts
                If acc.accountID.Equals(txtReceiverAccount.Text) Then
                    rAccountID = acc.accountID
                    rAmount = acc.balance
                    rAmountNew = rAmount + CDbl(txtAmount.Text)
                    MsgBox("Receiver New Balance = " & rAmountNew)
                    'update
                    'updatePayment()
                    Exit For
                End If
            Next
        End If
        updatePayment()
    End Sub

    Private Sub updatePayment()
        Try
            Dim db As New BankDBDataContext()
            Dim pay As New Payment()
            Dim cust As New Customer()
            Dim acc As New Account()

            Dim response As String = ""
            payDate = DateTime.Now.ToString

            MsgBox("1")
            pay.paymentID = txtPaymentID.Text
            MsgBox("11")
            pay.paymentType = cboPaymentType.SelectedItem.ToString
            MsgBox("12")
            pay.custID = txtCustID.Text.ToUpper
            MsgBox("13")
            pay.paymentDate = payDate
            MsgBox("14")
            db.Payments.InsertOnSubmit(pay)
            MsgBox("15")
            db.SubmitChanges()
            MsgBox("16")

            If cboPaymentType.SelectedItem.Equals("Fund transfer") Then
                MsgBox("2")
                pay.receiveName = txtReceiverName.Text
                pay.senderName = txtSenderName.Text

                'update receiver
                acc = db.Accounts.FirstOrDefault(Function(o) o.accountID = rAccountID)
                acc.balance = rAmountNew
                db.SubmitChanges()
            End If
            MsgBox("3")


            'update sender
            acc = db.Accounts.FirstOrDefault(Function(o) o.accountID = uAccountID)
            acc.balance = sAmountNew
            db.SubmitChanges()

            response = MsgBox("Data updated!" & vbNewLine & "Do you want to Print?", vbYesNo, "Data uptate")
            If response = vbYes Then
                dlgPreview.Document = doc
                dlgPreview.ShowDialog(Me)
                MsgBox("Done")
                frmSMain.Show()
                Me.Hide()
            Else
                frmSMain.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("An error occur during update record!")
        End Try
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        ' (1) Fonts
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header
        Dim header As String = "TOTON Bank System"
        Dim subHeader As String = String.Format("Success on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine & "by " & uAccountID, payDate)

        ' (3) Prepare body
        Dim body As New StringBuilder()
        body.AppendLine("Payment Bill (" & cboPaymentType.SelectedItem & ")")
        body.AppendLine("=================================================")
        body.AppendLine("  Customer ID : " & uAccountID)
        body.AppendLine("Customer Name : " & txtCustName.Text & vbNewLine)
        body.AppendLine("   Payment ID : " & txtPaymentID.Text)
        body.AppendLine("       Amount : RM" & txtAmount.Text & vbNewLine)

        If cboPaymentType.SelectedItem.Equals("Fund transfer") Then
            body.AppendLine("Fund Transfer Details")
            body.AppendLine("=================================================")
            body.AppendLine("         From : " & txtSenderName.Text)
            body.AppendLine("           To : " & txtReceiverName.Text & " (" & txtReceiverAccount.Text & ")")
        End If

        With e.Graphics
            .DrawImage(My.Resources.TOTON_logo_2, 0, 0, 220, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 220, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 220, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class