Imports System.Security.Cryptography.X509Certificates
Public Class coinslot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property quarters As Integer
    Public Property nickles As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return dollars + quarters * 0.25 + dimes * 0.1 + nickles * 0.05
        End Get
    End Property


    Public Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickles)
        quarters = 0
        dollars = 0
        dimes = 0
        nickles = 0
    End Sub
    Public Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Public Sub insertnickle()
        nickles = nickles + 1
    End Sub
    Public Sub insertdime()
        dimes = dimes + 1
    End Sub
    Public Sub insertdollar()
        dollars = dollars + 1
    End Sub

End Class
