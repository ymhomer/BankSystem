Option Explicit On
Option Strict On
Public Class frmLogin
    Public uId As String = ""
    Public uName As String = ""
    Public uPassword As String = ""
    Public uPosition As String = "g" 'g = guest, c = customer, s = staff

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        gbLogin.Select()
    End Sub

    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter
        If txtID.Text = "User ID" Then
            txtID.Text = ""
        End If

        With txtID
            .ForeColor = Color.Black
            .MaxLength = 6
        End With
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
        End If

        With txtPassword
            .PasswordChar = CChar("*")
            .ForeColor = Color.Black
            .MaxLength = 20
        End With
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        If txtID.Text = "" Then
            With txtID
                .Text = "User ID"
                .ForeColor = Color.Gray
            End With
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            With txtPassword
                .PasswordChar = CChar("")
                .Text = "Password"
                .ForeColor = Color.Gray
            End With
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtID.Text.Equals("User ID") Then
            MsgBox("User ID is required")
            txtID.Select()
        ElseIf txtPassword.Text.Equals("Password") Then
            MsgBox("Password is required")
            txtPassword.Select()
        Else
            confirmCORS()

            'MsgBox("User Type : " & uPosition,, "For testing purpose")
            If uPosition.Equals("c") Then
                compareWithCAccount()
            ElseIf uPosition.Equals("s") Then
                compareWithSAccount()
            Else
                compareErrMsg()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lnkNewAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNewAccount.LinkClicked
        FrmNewAccount.Show()
    End Sub

    Private Sub confirmCORS()
        Dim strAccount As String = txtID.Text.ToUpper
        Dim chars() = strAccount.ToCharArray()

        If chars(0).Equals("C"c) Then
            uPosition = "c"
        ElseIf chars(0).Equals("S"c) Then
            uPosition = "s"
        Else
            uPosition = "g"
        End If
    End Sub

    Private Sub compareWithCAccount()
        Dim db As New BankDBDataContext()
        Dim cust As New Customer()
        Dim rs = From o In db.Customers
                 Where o.custID.Contains(txtID.Text) And o.password.Contains(txtPassword.Text)

        For Each cust In db.Customers
            If cust.custID.Equals(txtID.Text.ToUpper) Then
                uId = cust.custID
                uName = cust.custName
                'MsgBox(txtID.Text & vbNewLine & cust.custName)
            Else

            End If
        Next

        If rs.Count = 0 Then
            compareErrMsg()
        Else
            frmCMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub compareWithSAccount()
        Dim db As New BankDBDataContext()
        Dim stf As New Staff()
        Dim rs = From o In db.Staffs
                 Where o.staffID.Contains(txtID.Text) And o.password.Contains(txtPassword.Text)

        For Each stf In db.Staffs
            If stf.staffID.Equals(txtID.Text.ToUpper) Then
                uId = stf.staffID
                uName = stf.staffName
                'MsgBox(txtID.Text & vbNewLine & stf.staffName)
            Else

            End If
        Next

        If rs.Count = 0 Then
            compareErrMsg()
        Else
            uId = txtID.Text
            uPassword = txtPassword.Text
            frmSMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub compareErrMsg()
        MsgBox("User ID and Password not match with database." & vbNewLine & "Please try in correct User ID and Password", vbOKOnly, "Error")
        txtID.Text = ""
        txtPassword.Text = ""
        txtID_Leave(Nothing, Nothing)
        txtPassword_Leave(Nothing, Nothing)
    End Sub
End Class
