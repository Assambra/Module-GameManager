README GameManager

Demo:
Open your DemoPersistent scene and press play, select the GameObject GameManager and change 
the CurrentScene to another Scene asset. The selected scene asset will load the scene additive / async
and the required UI elements will be instantiated. 
The LastScene is unloaded async and the instantiated UIs are destroyed.


How to use the GameManager Asset:

1.) Create a scene, this will be your permanent scene there will be the GameManager GameObject or other 
manager objects. All other scenes are loaded additive.

2.) Add the GameManager and UserInterface prefab into the hierarchy. 
Add to the Canvas field in the GameManager the Canvas from the UserInterface.

3.) Create your needed scenes like GameMenu, World, Dungeon... Adding all scenes to 
Build Settings -> Scenes in Built.

4.) Create for each scene a Scene asset (except the peristent scene). 
Menu: Create/Assambra/Scene. Create it into a folder e.g. Data/Scenes 
and name it to your scene name. One of this need to have checked IsFirstScene e.g GameMenu.
Add the Scene asset to the GameManager scenes list field.

5.) Create for each scene a SceneUI asset (except the peristent scene).
Menu: Create/Assambra/SceneUI. Create it into a folder e.g Data/UI 
and name it to your scene name.

6.) Use the prefab YoureScenUI and create for each UI Element you need a new prefab 
as example Login, and child UILogin, Inventory, SkillBar and so on and place it into a /Prefab folder.

7.) Select the named SceneUI asset, (lock it  with the lock symbol). 
Add for each UI Element that have to be active in this scene into UI Element Prefab list, 
(the eralier created) UI Element prefabs.

8.) Select the named Scene asset (lock it  with the lock symbol). 
Add the eralier created named SceneUI asset to your field SceneUI.

