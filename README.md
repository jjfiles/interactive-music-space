# Interactive Music Space

*The Interactive Music Space or IMS* is a desktop application that turns a room into an interactive music experience. It uses Unity, FMOD, SteamVR, and C# to let users conduct a one of a kind music track.

[![IMS Debut Demo](http://img.youtube.com/vi/bc7wb3WGFGA/0.jpg)](https://www.youtube.com/watch?v=bc7wb3WGFGA)

# Table of Contents
- [Interactive Music Space](#interactive-music-space)
- [Table of Contents](#table-of-contents)
- [Setup](#setup)
  - [SteamVR](#steamvr)
  - [In Game](#in-game)
    - [Controls](#controls)
- [Running the Project](#running-the-project)
- [Editing this Project](#editing-this-project)
  - [Unity](#unity)
    - [Change Game Objects](#change-game-objects)
    - [Change Scripts](#change-scripts)
  - [FMOD](#fmod)
    - [Adding your own tracks](#adding-your-own-tracks)
- [References](#references)
  - [Unity and SteamVR](#unity-and-steamvr)
  - [FMOD](#fmod-1)
- [Meet the Team](#meet-the-team)
  - [Music](#music)
  - [Software](#software)
  - [Studio Engineers](#studio-engineers)
  - [Musicians](#musicians)
  - [Special Thanks](#special-thanks)


# Setup

## SteamVR

1. Start SteamVR
2. Make sure you have run your room setup (found in your steam library)
3. Power on controllers **AFTER** you have confirmed headset and base stations have been detected
4. Select your desired audio output **BEFORE** launching the game.

## In Game

Your controllers should already be tracking and ready to go! If you notice the model of your device doesn't look like your controller (i.e. a base station) then you need to restart SteamVR and make sure to power on the controllers after the headset and base stations are ready.

### Controls

- F1 Starts playback
- F2 Stops playback
- F3 Mutes currently playing tracks, but does not stop playback
- Alt + F4 Exits the app

# Running the Project

The `./'Build v#.#'` will contain the .exe file to run this project out of the box.

# Editing this Project

## Unity 

### Change Game Objects
The `./IMS/` folder will contain all of the files necessary to open and edit this project in unity. (Built using Unity Version 2019.3.15f1), Change the room however you see fit! The 8 zones control 4 sounds each. Make them any size or shape to fit what you need.

### Change Scripts
The `roomSize.cs` Script reshapes the *Interactable Area* game object, at a ratio, to fit your room. The objects inside will fit relative to this one. So changes you make will scale to whatever room you place it in!

The `paramAdjust.cs` Script is what fades track in and out as you move. You could change this if you wanted to, but it is not encouraged.

## FMOD
The `./ims2/` folder contains the FMOD files required to edit the audio tracks. (Built using FMOD Version 2.00.09)

### Adding your own tracks

Note that all tracks play simultaneously, so keeping the tracks the same length will keep them in sync.

Replace any sounds in the tracks already created. Build with F7 and then launch from within Unity or rebuild the Unity project.


The `./tracks/` folder are the most recent versions of our tracks used in the base project.

# References

## Unity and SteamVR
![Unity](reference%20imgs/Unity%20Logos/unity-master-black.png)

![SteamVR](reference%20imgs/SteamVR%20Logos/SteamVR%20Logo.png)

IMS uses [Unity](https://unity.com/) for Windows Desktop. Paired with [SteamVR](https://store.steampowered.com/steamvr) to create an easy and reliable tracking experience. 

A quick start guide can be found [here.](https://valvesoftware.github.io/steamvr_unity_plugin/articles/Quickstart.html)


## FMOD
![FMOD](reference%20imgs/FMOD%20Logos/FMOD%20Logo%20White%20-%20Black%20Background.svg)

IMS uses [FMOD](https://www.fmod.com/) to manage sounds and effects. It integrates very well with Unity.

A great tutorial can be found [here](https://www.fmod.com/unity-integrate), and the fantastic documentation can be found [here.](https://www.fmod.com/resources/documentation-studio?version=2.0&page=welcome-to-fmod-studio-new-in-200.html)

# Meet the Team

This entire project was completed by Hattiesburg, Mississippi locals

## Music
- Composed, arranged, mixed, and modular system designed by Joshua C. Hale
- Consulting by Tae Young Hong

## Software
- Designed and built by Jeffery Files: 
  - [portfolio website](https://jfiles.dev) | [github](https://github.com/jjfiles)
- Unity consulting by Jonathan Beyea

## Studio Engineers
- John Shannon
  - [Email](jshan0626@icloud.com)
- Dylan Ragland
  - [Website](dylanragland.com) | [Instagram](instagram.com/dylanraglandsound)

## Musicians
- Christopher Dean - Violin
- Rebecca Hale - Viola
- Ana Ospina - Cello 
- Dr. Samuel Dahmer - Double Bass
  - [Website](dahmerbass.wixsite.com/bass)
- Dr. Fabi Dahmer - Flute 
  - [Website](fabiflute.wixsite.com/fabiflute)
- Heather Gering - Clarinet 
- Jerico Gotte - Alto Saxophone
  - [Email](balambsymphony@gmail.com) | [Facebook](https://www.facebook.com/jerico.gotte)
- Kevin Fails - French Horn
  - [Email](kevinlf.music@gmail.com) | [Facebook](facebook.com/kevhornmusic) | [Instagram](instagram.com/hornmusic_kevin)
- Tae Young Hong - Piano, Guitar,additional Drums
  - [Email](tyhong0826@gmail.com) | [Instagram](instagram.com/taeyoung.music)
- Nick Wilson - Drums
  - [Email](nicholas.kaine@gmail.com) | [Instagram](instagram.com/the_real_nick_wilson)
- Victoria Beyea - Harp
- Joshua Isaiah Hale - Marimba, Vibraphone
  - [Email](halejoshua19@gmail.com)
- Evan Cochran - Voice 

## Special Thanks
- Rachel Zou and Aaron Munson for providing additional equipment
- Aaron Munson for beta testing
- The Author Shoppe for providing their beautiful space to debut the project