Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmNewAccount

    Public nextID = App.GetCustomerID()

    Private Sub FrmNewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cust As New Customer()
        Me.CenterToParent()
        lblCustomerID.Text = App.GetCustomerID()
        lblAccountID.Text = App.GetAccountID()
        lblBalance.Text = 250.0
    End Sub

    Private Sub ResetForm()
        lblCustomerID.Text = App.GetCustomerID()
        lblAccountID.Text = App.GetAccountID()
        txtCustomerName.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtAddress.Text = ""
        mskPhoneNo.Text = ""
        txtEmail.Text = ""
        txtDescription.Text = ""
        txtSalary.Text = ""
        txtCustomerName.Focus()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Console.WriteLine("4")
        Dim bankDB As New BankDBDataContext()
        Dim cust As New Customer()
        Dim acc As New Account()



        cust.custID = App.GetCustomerID()
        lblCustomerID.Text = cust.custID
        cust.custName = txtCustomerName.Text
        cust.userName = txtUserName.Text
        cust.password = txtPassword.Text
        cust.address = txtAddress.Text
        cust.phone = mskPhoneNo.Text
        cust.email = txtEmail.Text
        cust.salary = CDec(txtSalary.Text)

        lblAccountID.Text = App.GetAccountID()
        acc.accountID = lblAccountID.Text
        acc.description = txtDescription.Text
        acc.balance = 250.0

        cust.accountID = acc.accountID

        If Not (txtUserName.Text.Equals("")) Then
            bankDB.Customers.InsertOnSubmit(cust)
            bankDB.Accounts.InsertOnSubmit(acc)
            bankDB.SubmitChanges()
            ResetForm()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtSalary.Text = digitsOnly.Replace(txtSalary.Text, "")

    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim email As String
        email = txtEmail.Text
        If (emailAddressCheck(email) = False) Then
            MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
        End If
    End Sub

    Private Function emailAddressCheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailAddressCheck = True
        Else
            emailAddressCheck = False
        End If
    End Function

End Class