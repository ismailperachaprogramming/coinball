Introduction:
The goal of this game is for each level, your player (the ball) must collect all the coins on the platform. Once the player collects all the coins in level one, they have the option to advance to level two, which has more coins and physical barriers that serve as obstacles, as well as coins on two corners of the platform to make it more difficult for the player to stay on the platform. Once the player collects all the coins, they have completed the game. The arrow keys are used to move, and the escape key triggers the pause menu, in which the player has the option to resume the game, mute the game music, go to the main menu, save the level, load the level, or quit the game. 
Summary of Written Scripts:
There are 7 scripts in use in my game. 
CameraController.cs
This script continuously adjusts the rotation of the camera so that it always faces the specified target.
CoinScript.cs
This script controls the rotation of the coin GameObject by continuously rotating it around its z-axis at a speed determined by a variable of the same name.
MainMenu.cs
This script allows players to start the game in the Menu scene, view the instructions, or to quit the application. 
MixerControl.cs
This script allows the player to adjust the volume by moving the slider in the volume slider.
PauseScript.cs
This script provides functionality to pause the game, display a pause menu, resume the game, go to the main menu, save and load the game, mute/unmute the audio, and quit the application.
PlayerController.cs
This script allows the player to control their character in the game, collect coins, and trigger a win condition (showing the win text).
WinMenu.cs
This script provides functionality to show the win menu and shows buttons giving the option to load the next level or return to the main menu.
Important Game Objects:
Menu Objects:
Play Button: The play button is the only visual aspect in the Menu scene, and when clicked on, the TitleScreenController script will transition to the Game Scene.
How to Play Button: The instructions button when clicked on shows the instructions text.
Quit: The quit button quits the application when clicked on.
Objects in the Game:
Ground: The ground is the plane platform that the ball and coins are on. 
Ball: The ball is the player character, which is a sphere. The Player Controller Script is needed for it to have a set speed, a set win score (how many coins it must collect), and what comes up as the win text when the win score is achieved.
Coin: The coin is a cylinder that has been resized and rotated to appear like a coin. The coin rotates at a set speed using the Coin Script. The coin was duplicated to where there are multiple total coins in each level.
Canvas/WinText: The win text is a sizable text that appears on the screen telling the player they win once they collect all the coins in the game.
Volume Slider: Adjusts the music volume of the game per direction it is moved in.
Pause Menu:
Resume Button: Resumes the game from its paused state.
Main Menu Button: Returns the player to the main menu
Save Button: Saves the scene the player is on.
Load Button: Loads the scene the player saved and also restarts the game.
Mute Button: Mutes the game music or unmutes it.
Quit Button: Quits the Application
Win Menu:
Next Level Button: Takes the player to Level Two after having won Level One.
Main Menu Button: Takes the player to the main menu.
Level Two Unique Object:
Obstacles: Large cylinders intended to make the player’s path to collecting all coins harder.
Scenes and Descriptions:
Main Menu:
The starting scene of the game where the player can start the game, view the instructions on how to play, or quit the application.

Main Menu with Instructions:
The instructions are shown when the player clicks the “How to Play” button.

Game Scene (Level One):
The player must collect all coins. Can change game volume and hit escape to pause and trigger the pause menu.

Pause Menu (Present in both Levels):
Gives the player the option to resume the game, return to the main menu, save the game, load the game, mute/unmute the game music, or quit the application.

Win Menu (Present in Level One when the player wins):
Gives the player the option to advance to level two or return to the main menu.

Level Two (Scene):
Like level one, the player must collect all coins. Can change game volume and hit escape to pause and trigger the pause menu. Key difference is more coins are present and physical barriers are as well. One major challenge added is the user must take a major risk to win all coins in the game by rolling through two of the platform’s corners to collect some coins. It is possible!

Winning the game (it was possible!)

There is a win/loss condition, where if the player wins, they advance to the next level, but if they lose then they must restart the game. The saving and loading functions are present, as the user can return to the level they saved when the load button is clicked. There is music, including an option to mute it. There is a volume button that can increase the game volume. There are instructions that are accessible via the main menu. An interesting decision for the player is that they must decide whether they want to make the bold risk and collect the corner coins, as this is needed to win the game.

