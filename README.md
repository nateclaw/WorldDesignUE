# WorldDesignUE
## Goals:

After completing the project, students should be able to:

+ Create a basic game in a game engine.
+ Populate the game world with objects to create an interesting, cohesive environment.

## Overview:

In this assignment, you will be creating a world for a simple collection game. In later assignments, you will be creating new objects and adding additional functionality to it.

## Project Specifications:

### <ins>World</ins>:

Create a world for your game. Make sure it meets the following requirements.

### Important Note: It is strongly suggested that, when creating the Unreal project, that you specify that it is a C++ project instead of a Blueprint project (the default). You can still use either in either type of project, but the C++ project settings will simplify some of the setup for you.

+ The world should be large enough that the player can explore for a short time. Provide some variety in the landscape.
+ Make the world maze-like in that the player will not be able to see everything easily and will need to explore some. This does not mean that you need to have walls to make it a maze; hills and trees will serve a similar purpose.
+ Use materials to give it an interesting, cohesive look. Use any materials you have access to (or create your own, if you wish).
+ Add objects to the world. Use any (reasonable) objects you have access to, including those from the marketplace, and decorate the world. Some of the objects should just be decorations and should allow the player to pass through (like a flower bed or garbage on the floor).
+ Add (or modify) a directional light to the world. Add (or modify) a sky light.
+ Add a visual distinct area where the collected items will be deposited (i.e., if you have collecting garbage, this might be a trashcan or a dumpster).
+ Use blueprints to make it easier to create your world.

### <ins>Collectible</ins>:

Create a collectible game object. This object will be collected as the player touches it (but that functionality will not be implemented yet). At this point, create the object as a blueprint object. Later, this will be given a C++ parent class with more functionality.

+ Create a blueprint object that will be the collectible object in the world. Use any materials or meshes that you have access to.
+ Put a few of these collectible items around your world where the player will have to find them.

### <ins>Character</ins>:

Create a character for your game. The character should be able to move around the screen and will (eventually) have an inventory. This will also have a C++ parent class with more functionality (again, later).

+ Create a blueprint for your character. The character can be 1st person or 3rd
+ Modify the character so that it is not just a default character from Unreal. (This does not have to be a big change, but it needs to show you have played with the character design some.)
+ The character should be able to move about the world, but there will not be much functionality yet.

### Important Note: While you can use very detailed textures and create a huge world, it will make your game bigger and slower to run. Since you will be testing this frequently, some restraint is advisable.
