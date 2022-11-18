Demo information:

The reason why we haven't done the steps below for you is that we don't want the Asset Pack to overwrite the scenes created below,
e.g. your scenes with the same name or those in the Unity Game Framework, when importing.

Extra steps are necessary. 

1. Rename scene SceneHandler to Start

2. Open the File Assets/Assambra/Game Framework/Modules/GameManager/Scripts/Enums/GameState.cs and 
create a Scene for each GameState with the exact name (except Scene Start (Step 1.)) -> Login, CreateAccount, CharacterSelection, CharacterCreation, BeginnerArea, World.

3. Adding all Scenes including Start to Build Settings -> Scenes in Built.
 
4. Open scene Start and Hit Play, select the GameObject GameManager and change the GameState in the dropdown menu. 
The scene changes to the appropriate GameState.

