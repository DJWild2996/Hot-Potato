﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnThrow = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnNewBomb = New System.Windows.Forms.Button()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.lblLoses = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblGuesses = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThrow
        '
        Me.btnThrow.Location = New System.Drawing.Point(473, 460)
        Me.btnThrow.Name = "btnThrow"
        Me.btnThrow.Size = New System.Drawing.Size(123, 52)
        Me.btnThrow.TabIndex = 10
        Me.btnThrow.Text = "Throw Bomb"
        Me.btnThrow.UseVisualStyleBackColor = True
        '
        'btnHold
        '
        Me.btnHold.Location = New System.Drawing.Point(300, 460)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(123, 52)
        Me.btnHold.TabIndex = 9
        Me.btnHold.Text = "Hold Bomb"
        Me.btnHold.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(498, 330)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(87, 41)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnNewBomb
        '
        Me.btnNewBomb.Location = New System.Drawing.Point(404, 330)
        Me.btnNewBomb.Name = "btnNewBomb"
        Me.btnNewBomb.Size = New System.Drawing.Size(97, 41)
        Me.btnNewBomb.TabIndex = 7
        Me.btnNewBomb.Text = "New Bomb"
        Me.btnNewBomb.UseVisualStyleBackColor = True
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(323, 330)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(87, 41)
        Me.btnPlayAgain.TabIndex = 6
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'lblLoses
        '
        Me.lblLoses.AutoSize = True
        Me.lblLoses.Location = New System.Drawing.Point(220, 157)
        Me.lblLoses.Name = "lblLoses"
        Me.lblLoses.Size = New System.Drawing.Size(38, 13)
        Me.lblLoses.TabIndex = 12
        Me.lblLoses.Text = "Loses:"
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(220, 138)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(34, 13)
        Me.lblWins.TabIndex = 11
        Me.lblWins.Text = "Wins:"
        '
        'lblGuesses
        '
        Me.lblGuesses.AutoSize = True
        Me.lblGuesses.Location = New System.Drawing.Point(220, 118)
        Me.lblGuesses.Name = "lblGuesses"
        Me.lblGuesses.Size = New System.Drawing.Size(51, 13)
        Me.lblGuesses.TabIndex = 13
        Me.lblGuesses.Text = "Guesses:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(504, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "(2 Chances)"
        '
        'pbImage
        '
        Me.pbImage.Image = Global.VB_Hot_Potato_Assessement.My.Resources.Resources.Hot_potato
        Me.pbImage.Location = New System.Drawing.Point(-4, 0)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(1158, 553)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 1
        Me.pbImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 542)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGuesses)
        Me.Controls.Add(Me.lblLoses)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.btnThrow)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnNewBomb)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.pbImage)
        Me.Name = "Form1"
        Me.Text = "HOT POTATO"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnThrow As System.Windows.Forms.Button
    Friend WithEvents btnHold As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnNewBomb As System.Windows.Forms.Button
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents lblLoses As System.Windows.Forms.Label
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblGuesses As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
