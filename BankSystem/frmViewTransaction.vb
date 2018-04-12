Public Class frmViewTransaction
    Private Sub BindData()
        Dim BankDB As New BankDBDataContext()
        Dim rs = From cust In BankDB.Customers, acc In BankDB.Accounts, trans In BankDB.TransactionHs
                 Where cust.custID.Equals(frmLatestLogin.uId) And cust.accountID = acc.accountID And trans.accountId = acc.accountID
                 Select trans.date, trans.amount, trans.transactionType

        If rs.Count = 0 Then
            MessageBox.Show("Does Not Have Any Transaction Record, Please Come View If Done One Time Transaction", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            dgvHistory.DataSource = rs
        End If

    End Sub

    Private Sub frmViewTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub
End Class