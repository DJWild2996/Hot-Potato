Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Dim mySetUp As New SetUp
    'Reset everything for a new game

    Private Sub PlayAgain(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayAgain.Click
        mySetUp.Go()
        UpdateDisplay()
        pbImage.Image = My.Resources.Start
    End Sub
    'Loads the new bomb animation and gets a new random number
    Private Sub NewBomb(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewBomb.Click
        mySetUp = New Bomb()
        mySetUp.Newbomb()
        pbImage.Image = My.Resources.New_Bomb
    End Sub
    'Starts the Guess count counting up till the guesses equals the random bomb number
    Private Sub Start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        mySetUp.Start()
        pbImage.Image = My.Resources.me_hold_bomb
        btnThrow.Enabled = True
        btnHold.Enabled = True
    End Sub
    'Choose to hold the bomb to put the count up in the hope that it does not go off
    Private Sub HoldBomb(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHold.Click
        mySetUp.Hold()
        UpdateDisplay()
        If mySetUp.Guesses = 6 Then
            btnHold.Enabled = False
            btnThrow.Enabled = False
        End If
    End Sub
    'Throw the bomb to the computer hoping it will go off in his hands so you win
    Private Sub ThrowBomb(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrow.Click
        mySetUp.ShootAway()
        UpdateDisplay()
        If mySetUp.ThrowAway = 2 Then
            btnThrow.Enabled = False
        End If
    End Sub
    'Updates the labels and picture box as each thing happens
    Public Sub UpdateDisplay()
        lblGuesses.Text = "Guesses: " & mySetUp.Guesses
        lblWins.Text = "Wins: " & mySetUp.Wins
        lblLoses.Text = "Loses: " & mySetUp.Loses
        pbImage.Image = mySetUp.GameImage

        If mySetUp.Wins = +1 Then
            btnHold.Enabled = False
            btnThrow.Enabled = False
        End If
        If mySetUp.Loses = +1 Then
            btnHold.Enabled = False
            btnThrow.Enabled = False
        End If
    End Sub

End Class