'TESTING MATRIX
'METHODOLOGY: create a russian roulette program based on a bomb that explodes at a random number of player guesses between 1 and 6 using GIF i have made in the animation program Pivot. The program will run of a random number generator which generates a number between 1 and 6 on each button click of new bomb the number of player guesses will be counted each time they click a button when the numbers are the same the "IF stagment" will tell the code to run the winner or loser gif deppending of if the player threw the bomb or not. The result will be counted and added to the lables which show the score.

'TESTING
'Layed out he design and created the gifs in the first few days
'Added the gifs to the resource folder and started writting the setup class set them out in the sytle of the weapons class program with protected variables, read only properties and them sub methods.
'Wrote the button code on the form and linked them to the setup class. Tested the if the GIFS play on the button clicks the ones for the Title, new game, new bomb and start work but the ones under the IF for the bomb hold, throw, win and lose do not work must be a problem with IF statment.
'Problem happened between the IF statement using the GameImage Property and passing to the pbImage image box on the design through the form1 code. Fixed after playing around and rewritting the IF, GameImage property and Update Display code. Everything in the game now works.
'Made it so that you can only use the throw away 2 times with a counter in the setup with links to the button click, also amde it so the hold and throw buttons turn off after 6 guesses so the player can not press after the bomb has gone off.
'Added expolsion sound effects to the If statment so if runs when the bomb Gifs play, all works apart from the gifs loop continuelessly until an other button is pushed and the wins and loses lables are set back to 0 at the start of a new game when hold or throw buttons are clicked.
'loop of gifs stopped by using message boxes that pop up when there is a result so it is coded to change the Image to a Winner or loser title screen.
