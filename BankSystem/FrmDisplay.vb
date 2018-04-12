Public Class FrmDisplay

    Private Sub BindData()
        Dim BankDB As New BankDBDataContext()
        Dim rs = From cust In BankDB.Customers, acc In BankDB.Accounts
                 Where cust.custName.Contains(txtName.Text) And cust.accountID = acc.accountID
                 Select cust.custID, cust.custName, acc.accountID

        dgvView.DataSource = rs
    End Sub

    Private Sub FrmDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub

    Private Sub dgvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgvView.Rows(i).Cells(0).Value)
            FrmUpdate.SelectedID = id
            FrmUpdate.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class