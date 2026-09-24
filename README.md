# Soft-Body Physics Simulation in Unity

A real-time soft-body physics simulation developed in **Unity using C#**, focused on the behavior and deformation of objects under physical forces.

The project provides an interactive environment for creating and controlling deformable objects while experimenting with physics parameters and real-time simulation.

## Overview

Unlike rigid bodies, soft bodies can deform when forces are applied to them.

This project explores the implementation of deformable objects in Unity and provides an interactive interface for configuring and observing their physical behavior.

The simulation allows objects to be spawned dynamically and configured with different initial conditions and physical parameters.

## Features

* Real-time soft-body physics simulation
* Deformable object simulation
* Dynamic object spawning
* Configurable initial position
* Configurable initial velocity
* Interactive simulation controls
* Adjustable physics parameters
* Object deletion and management
* Scene-based Unity environment
* Support for keyboard, mouse, gamepad, touch, and XR input through Unity's Input System

The project includes a UI controller for interacting with individual simulated objects and changing their simulation state and parameters.

## Technologies

* **C#**
* **Unity**
* **Unity Physics**
* **Unity Input System**
* **Universal Render Pipeline (URP)**
* **Virtual Reality / XR support**

## Physics Parameters

The project provides UI fields for configuring several parameters associated with the soft-body simulation, including:

* Mass
* Damping
* Stiffness factor
* Plastic threshold
* Drag coefficient
* Friction coefficient
* Additional simulation parameters

These parameters can be configured through the object's UI controller.

## Object Spawning

Objects can be created dynamically during runtime.

The spawning system allows the user to:

1. Select a shape from the available prefabs.
2. Specify the object's initial position.
3. Specify its initial velocity.
4. Spawn the object into the scene.
5. Create a corresponding UI control for the object.

The `SceneSpawner` component handles the creation and initialization of the simulated objects.

## Simulation Control

Each spawned object can be controlled independently through its associated UI.

The simulation can be enabled or disabled using a toggle, while the object can also be removed from the scene through the delete control.

## Input

The project uses Unity's Input System and includes support for several input devices.

Supported control schemes include:

* Keyboard & Mouse
* Gamepad
* Touch
* Joystick
* XR controllers

The project also defines common gameplay actions such as movement, looking, interaction, jumping, crouching, sprinting, and object interaction.

## Project Structure

The project follows a standard Unity project structure.

```text
Assets/
├── Animation/
├── Models/
├── Prefabs/
├── Resources/
├── Scenes/
├── Settings/
├── Customizable Skybox/
├── scripts/
│
├── SceneSpawner.cs
├── ShapeUIController.cs
├── SceneMangerBar.cs
├── MangeTime.cs
├── MangeTimeFall.cs
├── MoveLeft.cs
├── MoveRight.cs
└── delay.cs
```

The project also contains Unity configuration files, scenes, prefabs, input configuration, and other assets required by the simulation.

## Running the Project

### Requirements

* Unity
* Unity Hub
* A compatible Unity Editor version
* C# development environment (optional)

### Steps

1. Clone the repository.

```bash
git clone <repository-url>
```

2. Open **Unity Hub**.

3. Select **Add** and choose the cloned project directory.

4. Open the project using the appropriate Unity Editor version.

5. Open the main scene from:

```text
Assets/Scenes/
```

6. Press **Play** in the Unity Editor.

## Example Workflow

A typical simulation workflow is:

```text
Select Shape
     ↓
Set Initial Position
     ↓
Set Initial Velocity
     ↓
Spawn Object
     ↓
Configure Physics Parameters
     ↓
Start Simulation
     ↓
Observe Deformation
```

## Purpose

The project was developed as an exploration of **physics simulation, deformable objects, and interactive real-time environments** using Unity.

It provides practical experience with:

* Physics-based simulation
* Object deformation
* Runtime object creation
* Unity UI interaction
* Input handling
* C# scripting
* Real-time parameter control

## Notes

This project is primarily intended as an educational and experimental implementation for studying soft-body physics and real-time deformation in Unity.
