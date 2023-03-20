# Prison Escape - 2023 Unity Project 

## Prison Escape V0.5 -- Health Fixes + Healing Update

Updates 

+ Picking Up items such as Painkillers/Medkit will now heal the player (each item has a different health intake)

Bug Fixes
- Fixed Prior bug which causes the player to pause if they have died and try to restart the scene
- Fixed Mistake on Health not giving health to the player
- Fixed interaction and colliders not picking up health
- Fixed Seizure inducing glitch with debug.logs causing the game to flash the Pause menu ever 0.1 seconds
- Fixed Camera Size so you can see the "bottomless pit" from start of the game and also the doorway
- Fixed walls being used as double jumps (could be added later?)
- Fixed Debug.logs removing any "ReSharper disable Unity.PerformanceAnalysis" this is causing prior seizures. with them being spammed heavily due to confliction of other debug.logs. 

*Not Neccessary a bug Fix but cleaned up the ReadMe file to look cleaner on GitHub UI. 

Bugs 
- Bottomless pit needs a instant death interactable or teleporter once jumped into to stop the player from forcing Pause menu restarts or ALT + F4'ing the game. 

# Updates Prior to this

## Prison Escape V0.25 -- Health Update

Updates 

+ Added a Health (Heart based) System 
+ Added a Death Screen 
+ Added a Pause Menu
+ Added Scripts ("Health","Healthbar","DoorEnabler","Camera Movement").
+ Added "Bottomless pit"
+ You can take Damage by pressing F (this is to simulate the death screen)


Fixes
- Fixed Player camera not being large enough to see rooms
- Added small details to rooms to distinguish them appart (all small details are temp)
- Jumping on crates/boxes will know allow the player to jump on top of them
- Bottomless pit has now a fixed area so you cant escape the map 
- Rooms can now swiftly move to side to side of each as long as they arent "Forced" into a new room
- Doors will now send the camera forward to another room
- having 0 Hearts left now pauses the time in game and sends them to the Death screen
- return to menu works for death screen
- unpause/return to menu works for pause menu

Bugs 

- Currently respawning in game causes the player to stay still.
(I have a Reason as to why this happens and will be able to fix it in lesson hopefully)

Features to add : 

- Damage pools (Lava), To give the platformer game some sort of obstacle for the user to try.
- Health Pickups for healing
- Teleporters to finish of tutorial
- Adding Keys needed to Finish a Level.
- Adding the Chance roll the dice powerups. 




## Prison Escape V0.1

Game is currently NOT upto latest build due to error with migration with git but have no fear I should have majority or all of the prison escape game
imbeded into by next week!



Updates -
New rooms

Removed - 

Logs from unity for Repo
