Public Class frmSMain
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        FrmNewAccount.ShowDialog()
    End Sub

    Private Sub btnDisplayUpDel_Click(sender As Object, e As EventArgs) Handles btnDisplayUpDel.Click
        FrmDisplay.ShowDialog()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmNewPayment.ShowDialog()
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click

    End Sub

    Private Sub frmSMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub
End Class
