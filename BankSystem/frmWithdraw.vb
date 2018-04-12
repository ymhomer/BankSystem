Imports System.Text.RegularExpressions

Public Class frmWithdraw
    Private Sub frmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If txtWithdraw.Text = "" Then
            MessageBox.Show("This Filed Must Be Enter Value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtWithdraw.Text > acc.balance Then
            MessageBox.Show("The amount that withdraw are exceed the balance, Please try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim box = MessageBox.Show("Are you sure want to withdraw this amount from your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If box = Windows.Forms.DialogResult.Yes Then
                acc.balance = acc.balance - CDec(txtWithdraw.Text)
                BankDB.SubmitChanges()

                trans.transactionID = App.GetTransactionID
                trans.date = DateTime.Now.ToString
                trans.amount = CDec(txtWithdraw.Text)
                trans.transactionType = "Withdraw"
                trans.accountId = acc.accountID
                BankDB.TransactionHs.InsertOnSubmit(trans)
                BankDB.SubmitChanges()
                MessageBox.Show("Withdraw Successful, This is your current balance after withdraw: RM " & acc.balance, "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtWithdraw.Text = ""
            End If

            If box = Windows.Forms.DialogResult.No Then
                txtWithdraw.Text = ""
            End If
        End If




    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtWithdraw.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtWithdraw_TextChanged(sender As Object, e As EventArgs) Handles txtWithdraw.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtWithdraw.Text = digitsOnly.Replace(txtWithdraw.Text, "")
    End Sub
End Class