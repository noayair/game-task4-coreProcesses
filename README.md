# The core process of 7 Boom!
In this task we made a core proccss of our original game called "7 BOOM".
Your mission is to avoid the red balloons and catch the blue ones.
Every blue balloon you catch give you 1 point. But if you hit the red balloon you lose life!

![WhatsApp Image 2020-11-16 at 16 39 55](https://user-images.githubusercontent.com/57709369/99265720-ab250680-282a-11eb-95ca-7703f13f83ee.jpeg)

## How we made it ?
 1. First we made prefab calld "Balloon" that represent one ballon. It is have a rigidbody and collider. And it's have a script that give it a color randomly. 
 
 https://github.com/Noa-Amit/game-task4-coreProcesses/blob/main/Assets/Scripts/ScoreField.cs
 
 2. Then we made a prefab spawner called "BalloonSpawner" that spawns balloons.It's have a rigidbody and collider.And it's have a script that spwans balloons in a randomlt timing.
 
 https://github.com/Noa-Amit/game-task4-coreProcesses/blob/main/Assets/Scripts/TimedSpawner.cs
 
 3. Then we added a player with rigidbody and collider. The player also has 2 scripts:
 
      A. KeyboardMover- moves the player with the keyboard's arrows. The player can move to the sides only. 
      
      https://github.com/Noa-Amit/game-task4-coreProcesses/blob/main/Assets/Scripts/KeyboardMover.cs
      
      B. GetTrigger- when the player hit a red balloon the script subtracts 1 life and when the player hit a blue balloon the script add 1 point.
      
      https://github.com/Noa-Amit/game-task4-coreProcesses/blob/main/Assets/Scripts/getTrigger.cs
   
  4. At least we added 2 objects that will present the whole game the score and the life of the player. 
  
      A. heart- has an image of heart and a child calls "LifeField". LifeField has a script that update the number of life in the screen, using textMes. 
      
      https://github.com/Noa-Amit/game-task4-coreProcesses/blob/main/Assets/Scripts/LifeField.cs
      
      B. score- has an image of balloon and child calls "ScoreField". Score Field has a script that update the scores in the screen, using textMesh.
      
      https://github.com/Noa-Amit/game-task4-coreProcesses/blob/main/Assets/Scripts/ScoreField.cs
