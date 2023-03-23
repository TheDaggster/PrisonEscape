# Prison Escape - 2023 Unity Project 

## Prison Escape V0.75 -- Lava + Teleporters

Updates

+ Added Lava Blocks that on touch/Collision with the player causes the player to get instantly killed (sends them to the death menu) 
+ Added Basic teleporters into the game where if the player comes into interaction with the teleporter they have to press E to enable the teleporters and be in there hitbox. 
+ Added Basic Lava room which forms as some sort of difficulty for the player to get to to the other side of the room. 
+ Added Basic teleporter room which encloses the rest of the room off to the player unless they use the teleporter. 
+ Added Teleporter Script / Added Lava Script Both have different intakes and can be used multiple amounts for level building later. 

Bug Fixes
- Fixed Heath pickup box collider not being large enough to collect when near the player. 
- Fixed Camera collision with rooms (Again)
- Fixed hearts not taking up the correct amount of hearts in Healing 
- Fixed Death menu not appearing when colliding with the lava blocks (Reason : Lava wasnt take 4 in Value for damage). 
- Fixed Teleporters unable to interact with the players (Pressing E would not work - Reason was the script was using Windows.Input instead of Unity.Input). 
- Fixed Doors (Adding null to next doors script) 
- Fixed Ground collision not appearing next to the lava (It was behind the lava in layers) 
- Fixed Lava not appearing but affecting the player Invisible Lava* (Reason Lava Ground items werre further away than the camera would render causing them invisible).

Features to Add

- Adding Keys to Finish a room (Simple jump puzzle and picking up keys) 
- Adding Powerup to Finish Tutorial (Picking up boost will instantly force you to leave the tutorial room). 
- Add Assets Images to describe what each of the rooms describe and what to do. 
- Add Rooms for the player to play around in. 

(Any features not added from previous Features to Add have been completed).

# Updates Prior to this

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
