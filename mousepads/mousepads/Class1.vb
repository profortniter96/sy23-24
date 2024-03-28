Imports System.Security.Cryptography.X509Certificates
Public Class coinslot
    Public Event dispense(p As Image)
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property quarters As Integer
    Public Property nickles As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public Property total As Decimal
        Get
            _total = dollars + quarters * 0.25 + dimes * 0.1 + nickles * 0.05
            Return _total
        End Get
        Set(value As Decimal)
            ' value = value
        End Set
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
    Public Sub buy(p)
        If p.count > 0 And total >= p.price Then
            p.buy()
            _total = _total - p.price
            dollars = 0
            quarters = 0
            dimes = 0
            nickles = _total / 0.05
            RaiseEvent dispense(p.picture)
        End If
    End Sub

End Class
