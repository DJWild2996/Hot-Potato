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
        MsgBox("Throw the Bomb back at the right time before it blows up in your face!")
        pbImage.Image = My.Resources.me_hold_bomb
    End Sub
    'Starts the Guess count counting up till the guesses equals the random bomb number
    Private Sub Start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        mySetUp.Start()
        pbImage.Image = My.Resources.me_hold_bomb
        btnThrow.Enabled = True
        btnHold.Enabled = True
        MsgBox("The bomb will explode randomly between 1 and 6 guesses")
    End Sub
    'runs the hold method from the class from the hold button click and sets it so that the buttons hold and throw cannot be used after 6 guesses
    Private Sub HoldBomb(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHold.Click
        mySetUp.Hold()
        UpdateDisplay()
        If mySetUp.Guesses = 6 Then
            btnHold.Enabled = False
            btnThrow.Enabled = False
        End If
        If mySetUp.Loses = +1 Then
            MsgBox("You Lost! Try Again!")
            pbImage.Image = My.Resources.LoserTitle
        Else
            MsgBox("It didn't explode! What do you do now!")
        End If

    End Sub
    'runs the shoot away method from the class thorugh the thow away button click and makes it so the player can only throw away twice before the button is turned off
    Private Sub ThrowBomb(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrow.Click
        mySetUp.ShootAway()
        pbImage.Image = My.Resources.me_hold_bomb
        UpdateDisplay()
        If mySetUp.ThrowAway = 2 Then
            btnThrow.Enabled = False
        End If
        If mySetUp.Wins = +1 Then
            MsgBox("You Won!")
            pbImage.Image = My.Resources.WinnerTitle
        Else
            MsgBox("It didn't explode! He Threw if right back to you!")
            pbImage.Image = My.Resources.me_hold_bomb
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