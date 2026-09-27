# Dami Street Racer

A mobile-first 3D street racing game concept and starter Unity project for Android.

## Overview
Dami Street Racer is a realistic-but-accessible street racing game built around quick races, garage progression, and multiplayer competition. This repository contains:

- the game design document
- a Unity-ready C# script starter pack
- a base progression and save system
- a base race and garage implementation
- project structure for a playable MVP

## Included
- `docs/dami-street-racer-gdd.md` — product and game design documentation
- `docs/roadmap.md` — development roadmap for MVP and future phases
- `Assets/Scripts/...` — starter Unity scripts for gameplay, saving, and garage management
- `.gitignore` — Unity project ignore rules

## Quick start
1. Open this folder as a Unity project root.
2. Create the following scenes in Unity:
   - `MainMenu`
   - `Garage`
   - `Race`
3. Add a `Rigidbody` to your player car and attach `CarController`.
4. Attach `RaceManager` to an empty object in the race scene.
5. Attach `GarageManager` to an empty object in the garage scene.
6. Build and test on Android.

## Core starter systems
- `CarController`: driving, braking, steering, nitro
- `RaceManager`: countdown, lap tracking, finish state
- `GarageManager`: currency and upgrade logic
- `SaveSystem`: JSON save file for player progress
- `PlayerProgress`: game progression data model
- `GameManager`: global state and progression persistence

## Recommended next steps
- Add a track and finish line trigger
- Add AI opponents
- Add car selection UI and garage list
- Add local split-screen multiplayer
- Add online multiplayer with Photon or a custom backend
- Add reward and leaderboard systems
- Prepare Google Play store assets and compliance materials

## License
This project is intended as a starter product template for game development educational and prototyping purposes.
