Public Class Bomb
    Inherits SetUp
    'generates a new random number for the bomb to go off at between 1 and 6
    Sub New()
        _Bomb = _BombCounter.Next(1, 7)
    End Sub

End Class
