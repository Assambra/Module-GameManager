Demo information:

The reason why we haven't done the steps below for you is that we don't want the Asset Pack to overwrite the scenes created below, 
e.g. your scenes with the same name or those in the Unity Game Framework, when importing.

Extra steps are necessary. 

1. If not allready done Import the latest Unity Asset Pack Module-GameManager from https://github.com/Assambra/Module-GameManager/releases and import it to your Project.

2. Rename scene SceneHandler to Start

3. Open the File Assets/Assambra/Game Framework/Modules/GameManager/Scripts/Enums/GameState.cs and 
create a Scene for each GameState with the exact name (except Scene Start (Step 2.)) -> Login, CreateAccount, CharacterSelection, CharacterCreation, BeginnerArea, World.

4. Adding all Scenes including Start to Build Settings -> Scenes in Built.
Set Start Scene on index 0;
 
5. Hit Play, select the GameObject GameManager and change the GameState in the dropdown menu. 
The Scene UI Element will enabled to corresponding GameState and disable the last UI Element. 