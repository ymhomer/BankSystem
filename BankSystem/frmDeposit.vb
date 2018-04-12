Imports System.Text.RegularExpressions

Public Class frmDeposit
    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BankDB As New BankDBDataContext()
        Dim cust As Customer = BankDB.Customers.FirstOrDefault(Function(o) o.custID = frmLatestLogin.uId)
        Dim acc As Account = BankDB.Accounts.FirstOrDefault(Function(o) o.accountID = cust.accountID)
        If cust Is Nothing Then
            MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            lblName.Text = cust.custName
            lblBalance.Text = acc.balance

        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim BankDB As New BankDBDataContext()
        Dim cust As Customer = BankDB.Customers.FirstOrDefault(Function(o) o.custID = frmLatestLogin.uId)
        Dim acc As Account = BankDB.Accounts.FirstOrDefault(Function(o) o.accountID = cust.accountID)
        Dim trans As New TransactionH()
        If txtDeposit.Text = "" Then
            MessageBox.Show("This Filed Must Be Enter Value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim box = MessageBox.Show("Are you sure want to add this amount to your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If box = Windows.Forms.DialogResult.Yes Then
                acc.balance = acc.balance + CDec(txtDeposit.Text)
                BankDB.SubmitChanges()

                trans.transactionID = App.GetTransactionID
                trans.date = DateTime.Now.ToString
                trans.amount = CDec(txtDeposit.Text)
                trans.transactionType = "Deposit"
                trans.accountId = acc.accountID
                BankDB.TransactionHs.InsertOnSubmit(trans)
                BankDB.SubmitChanges()
                MessageBox.Show("Deposit Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDeposit.Text = ""
            End If

            If box = Windows.Forms.DialogResult.No Then
                txtDeposit.Text = ""
            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDeposit.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtDeposit.Text = digitsOnly.Replace(txtDeposit.Text, "")
    End Sub
End Class