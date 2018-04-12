Public Class FrmDisplayForCustomer
    Private Sub BindData()
        Dim BankDB As New BankDBDataContext()
        Dim rs = From cust In BankDB.Customers, acc In BankDB.Accounts
                 Where cust.custID.Equals(frmLatestLogin.uId) And cust.accountID = acc.accountID
                 Select cust.custID, cust.salary, acc.accountID, acc.balance

        If rs.Count = 0 Then
            MessageBox.Show("Does Not Have Any Transaction Record, Please Come View If Done One Time Transaction", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            dgvView.DataSource = rs
        End If
    End Sub

    Private Sub FrmDisplayForCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub
End Class