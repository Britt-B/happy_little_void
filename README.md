# Happy Little Void
demo video (from presentation, no audio):  https://youtu.be/8AmcMSJqRwM
***
## Task
Develop a game using Unity to showcase what you've learned during the semester (fundamentals of game development course)
***
## Criteria
* Use Unity game engine or Processing (Unity chosen)
* Game can be 2d or 3d (3d chosen)
* Must include menu screen
* Goal clearly defined
* Indicator of progression
* Completion Scenario
***
## Summary
Happy Little Void (HLV) is a puzzle role play game (rpg) that includes elements of strategy, problem solving, and exploration.The player walks through the void maze searching for keys and overcoming trials. A trial area consists of a themed puzzle to be solved. Once a trial is completed, the center of the maze gets a new light indicator. Once all 4 lights are ignited, the player has won the game.
***
## Functionality
Movement in the game is defined by the horizontal X and Z axis. The player can use the W, A, S, and D keys to move around. Moving the mouse points the player in different directions.Collectible objects are called keys. They are bright blue orbs that float and rotate throughout the maze. Using the left shift key the player can collect these keys which are added to the inventory. When the player approaches a red door and has at least one key in the inventory, the door is opened and one of the keys is destroyed. To interact with anything in the game world the player presses left shift. This action will call a script associated with the object. Torches have scripts that turn them on (blue) and off (red) and update their state in the class hierarchy. If a button is pressed a script is called to check the status of these torches. When interacting with a button, it will either give an error message as a hint or open the connecting door. The action taken depends on whether the player has met the desired conditions. Instruction panels and other readable panels are also interactable. If a player presses left shift while looking at one of these panels, text appears on the screen. The text may tell the player what they need to do in the area or present a question that must be answered using the torches. If a question is present, hovering the mouse over the torches will briefly display the answer linked with that torch. When a player completes a trial, they may interact with the final panel that gives them a brief message of congratulations and tells them that they have gained a blessing. The final interactable object in a trial is a teleportation console. When the player interacts with this console, they will be teleported back to the spawn location (near the main fountain).
***
## Design
Happy Little Void is meant to be a dark yet soothing puzzle game that is relaxing rather than scary. Typically, games that have mazes in a dark setting include horror aspects such as jump scares, monsters, and off-putting audio. The goal of HLV is to avoid these things. Overall, the game is designed to be entertaining and calm. The target audience is adults looking for a casual but not mindless game to play. This game may be fitting for someone who enjoys playing low-stress games after working.
***
## Target Hardware
The target hardware for HLV is PC computers. Because it was built in Unity Game Engine, Mac and Linux support is available as well. This game would be good to play on console because of the simple controls. No network is required to play this game. Laptops that can handle indie games using little resources should be able to handle HLV. The game does not consist of numerous assets and resources like large studio games.
