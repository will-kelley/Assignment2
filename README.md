# Haunted Jaunt – Assignment 2

## Team Members
- Will Kelley

## Features Implemented

### Dot Product Gameplay
- A ghost appears only when the player is facing it.
- Uses `Vector3.Dot` to measure the angle between player direction and the ghost.

### Linear Interpolation
- A floating platform moves back and forth between two points.
- Uses `Vector3.Lerp` with `Mathf.PingPong` to create the movement.

### Particle Effect
- Particles play when the player enters a secret zone.
- Triggered using a `ParticleSystem` and a trigger collider.

### Sound Effect
- A creepy sound plays when the player enters a haunted hallway (it is quite loud).
- Triggered using an `AudioSource.PlayOneShot()` via trigger zone.

## How to Run
- Open the `MainScene` in Unity
- Press Play
- Explore the level:
  - Look directly at the ghost to reveal it
  - Find the moving platform
  - Walk into the particle zone to trigger effects
  - Enter the sound zone to hear the haunted audio
