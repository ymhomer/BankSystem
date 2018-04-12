Module App

    Dim answer As String = ""
    Dim custFirstId As String = "C001"
    Dim accFirstId As String = "A001"
    Dim paymentFirstId As String = "P001"
    Dim transFirstId As String = "T001"
    Public Function GetCustomerID() As String
        Dim bankDB As New BankDBDataContext()
        Try
            Dim rs = (From r In bankDB.Customers
                      Select r.custID
                      Order By custID Descending).Take(1)

            Dim strID = rs.Single.Substring(1, 3)
            Dim intId = Integer.Parse(strID) + 1
            answer = "C" & intId.ToString("000")

        Catch ex As Exception
            answer = custFirstId
        End Try

        Return answer
    End Function

    Public Function GetAccountID() As String
        Dim bankDB As New BankDBDataContext()
        Try
            Dim rs = (From acc In bankDB.Accounts
                      Select acc.accountID
                      Order By accountID Descending).Take(1)

            Dim strID = rs.Single.Substring(1, 3)
            Dim intId = Integer.Parse(strID) + 1

            answer = "A" & intId.ToString("000")

        Catch ex As Exception
            answer = accFirstId
        End Try

        Return answer
    End Function

    Public Function GetPaymentID() As String
        Dim bankDB As New BankDBDataContext()
        Try
            Dim rs = (From r In bankDB.Payments
                      Select r.paymentID
                      Order By paymentID Descending).Take(1)

            Dim strID = rs.Single.Substring(1, 3)
            Dim intId = Integer.Parse(strID) + 1
            answer = "P" & intId.ToString("000")

        Catch ex As Exception
            answer = paymentFirstId
        End Try

        Return answer
    End Function

    Public Function GetTransactionID() As String
        Dim bankDB As New BankDBDataContext()
        Try
            Dim rs = (From trans In bankDB.TransactionHs
                      Select trans.transactionID
                      Order By transactionID Descending).Take(1)

            Dim strID = rs.Single.Substring(1, 3)
            Dim intId = Integer.Parse(strID) + 1

            answer = "T" & intId.ToString("000")

        Catch ex As Exception
            answer = transFirstId

        End Try

        Return answer
    End Function

End Module
