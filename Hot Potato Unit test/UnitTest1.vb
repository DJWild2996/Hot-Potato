Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub BombExplosion()
        'Variables for the random number generated for the bomb and the number of player guesses
        Dim RndNum, GuessNum As String
        'the bomb goes off at a random number between 1 and 6 
        RndNum = "6"
        GuessNum = "6"
        'If the random Number for the bomb and number of player guesses are the same then the bomb will expoloded and the player will win or loses depending on if they threw it away or not
        Assert.IsTrue(RndNum = "6" And GuessNum = "6")
    End Sub

    <TestMethod()>
    Public Sub BombHold()
        'Variables for the random number generated for the bomb and the number of player guesses
        Dim RndNum, GuessNum As String
        'the bomb goes off at a random number between 1 and 6 
        RndNum = "6"
        GuessNum = "6"
        'If the random Number for the bomb and number of player guesses are the different the bomb will not expolded and the game will continue if the player used a throw away it will be wasted and the bomb will be thrown back to the player
        Assert.IsTrue(RndNum = "6" And GuessNum = "1")
    End Sub

End Class