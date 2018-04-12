Imports System.Text.RegularExpressions

Public Class FrmUpdate

    Public SelectedID As String

    Private Sub ResetForm()
        txtCustomerName.Text = ""
        txtAddress.Text = ""
        mskPhoneNo.Text = ""
        txtEmail.Text = ""
        txtSalary.Text = ""
        txtCustomerName.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If
        Dim BankDB As New BankDBDataContext()

        Dim cust As Customer = BankDB.Customers.FirstOrDefault(Function(o) o.custID = SelectedID)
        Dim acc As Account = BankDB.Accounts.FirstOrDefault(Function(o) o.accountID = cust.accountID)

        If cust Is Nothing Then
            MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            ' 1: Set the Customer object's Properties accordingly
            ' 2: Update the Customer record using LINQ
            lblCustomerID.Text = cust.custID
            cust.custName = txtCustomerName.Text
            cust.address = txtAddress.Text
            cust.phone = mskPhoneNo.Text

            cust.salary = txtSalary.Text
            cust.accountID = lblAccountID.Text
            acc.description = txtAccountDescription.Text
            lblBalance.Text = acc.balance

            If (txtEmail.Text <> "") Then
                If (emailAddressCheck(txtEmail.Text) = True) Then
                    cust.email = txtEmail.Text
                    BankDB.SubmitChanges()
                    MessageBox.Show("Customer [" & lblCustomerID.Text & "] updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
                End If
            Else
                MessageBox.Show("dj")
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim BankDB As New BankDBDataContext()
        Dim cust As Customer = BankDB.Customers.FirstOrDefault(Function(o) o.custID = SelectedID)
        Dim acc As Account = BankDB.Accounts.FirstOrDefault(Function(o) o.accountID = cust.accountID)

        If cust Is Nothing Then
            MessageBox.Show("Customer not found", "Error"， MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            For Each s In BankDB.TransactionHs
                If (s.accountID = acc.accountID) Then
                    BankDB.TransactionHs.DeleteOnSubmit(s)
                End If
            Next

            ' 1: Delete the Customer record using LINQ

            BankDB.Customers.DeleteOnSubmit(cust)
            BankDB.Accounts.DeleteOnSubmit(acc)

            BankDB.SubmitChanges()

            ' 2: Show a message box to indicate deletion done
            MessageBox.Show("Customer [" & lblCustomerID.Text & "] deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()

        Dim BankDB As New BankDBDataContext()
        Dim cust As Customer = BankDB.Customers.FirstOrDefault(Function(o) o.custID = SelectedID)
        Dim acc As Account = BankDB.Accounts.FirstOrDefault(Function(o) o.accountID = cust.accountID)

        If cust Is Nothing Then
            MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' Customer found --> Display Details
        lblCustomerID.Text = cust.custID
        txtCustomerName.Text = cust.custName
        txtAddress.Text = cust.address
        mskPhoneNo.Text = cust.phone
        txtEmail.Text = cust.email
        txtSalary.Text = cust.salary
        lblAccountID.Text = cust.accountID
        txtAccountDescription.Text = acc.description
        lblBalance.Text = acc.balance
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim email As String
        email = txtEmail.Text
        emailAddressCheck(email)
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

    Private Sub FrmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class