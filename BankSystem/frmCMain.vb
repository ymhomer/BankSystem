Public Class frmCMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDeposit.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmWithdraw.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmViewTransaction.ShowDialog()
    End Sub

    Private Sub btnDisplayForCustomer_Click(sender As Object, e As EventArgs) Handles btnDisplayForCustomer.Click
        FrmDisplayForCustomer.ShowDialog()
    End Sub

    Private Sub frmCMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "User : " + frmLogin.uName
    End Sub

    Private Sub frmCMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmNewPayment.ShowDialog()
    End Sub
End Class