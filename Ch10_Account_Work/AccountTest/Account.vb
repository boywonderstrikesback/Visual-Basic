﻿' Fig. 9.2: Account.vb
' Account class for maintaining a bank account balance.
Public Class Account
    Private BalanceDecimal As Decimal ' instance variable stores the balance


    ' constructor initializes balanceValue
    Public Sub New(initialBalanceDecimal As Decimal)
        ' if initialBalance is less than 0, throw an exception
        If initialBalanceDecimal < 0D Then
            Throw New ArgumentOutOfRangeException(
               "Initial balance must be greater than or equal to 0.")
        End If

        Balance = initialBalanceDecimal ' initialize balanceValue
    End Sub ' New


    ' PROPERTIES
    Public Property Balance As Decimal
        Get
            Return BalanceDecimal
        End Get
        Set(value As Decimal)
            BalanceDecimal = value
        End Set
    End Property ' Balance

    ' METHODS

    ' deposit money to the account
    Public Sub Deposit(inDepositAmountDecimal As Decimal)
        ' if depositAmount is less than or equal to 0, throw an exception
        If inDepositAmountDecimal <= 0D Then
            Throw New ArgumentOutOfRangeException(
               "Deposit amount must be positive.")
        End If

        BalanceDecimal += inDepositAmountDecimal ' add depositAmount to balanceValue
    End Sub ' Deposit

    ' withdraw money from the account
    Public Overridable Sub Withdraw(inWithdrawalAmountDecimal As Decimal)
        If inWithdrawalAmountDecimal <= 0D Then
            Throw New ArgumentOutOfRangeException(
               "Withrawal amount must be positive.")
        End If

        ' subtract withdrawalAmount from balanceValue
        BalanceDecimal -= inWithdrawalAmountDecimal
    End Sub ' Withdraw

End Class ' Account
