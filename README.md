================================================
FILE: README.md
================================================
# Soft-Body Physics Simulation System in Unity

A real-time soft-body physics simulation developed in Unity using C#.

The project explores the simulation of deformable objects and the implementation of physics-based deformation in an interactive environment.

## Overview

Unlike rigid objects, soft bodies can deform when forces are applied to them.

This project explores the implementation of deformable objects within a Unity environment and focuses on real-time simulation.

## Features

* Soft-body object simulation
* Deformable objects
* Physics-based movement
* Real-time interaction
* Unity-based visualization

## Technologies

* C#
* Unity
* Physics Simulation
* Virtual Reality

## Project Structure

The project is organized as a Unity project containing the source code, assets, scenes, and project configuration.

## Running the Project

1. Clone the repository.
2. Open the project using Unity Hub.
3. Open the main scene.
4. Run the project from the Unity Editor.

## Purpose

The project was developed to study physics simulation and the behavior of deformable objects in a real-time Unity environment.



================================================
FILE: ignore.conf
================================================
Library
library
Temp
temp
Obj
obj
Build
build
Builds
builds
UserSettings
usersettings
MemoryCaptures
memorycaptures
Logs
logs
**/Assets/AssetStoreTools
**/assets/assetstoretools
/Assets/Plugins/PlasticSCM*
/assets/plugins/PlasticSCM*
*.private
*.private.meta
^*.private.[0-9]+$
^*.private.[0-9]+.meta$
.vs
.vscode
.idea
.gradle
ExportedObj
.consulo
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db
*.pidb.meta
*.pdb.meta
*.mdb.meta
sysinfo.txt
crashlytics-build.properties
*.apk
*.aab
*.app
*.unitypackage
~UnityDirMonSyncFile~*
**/Assets/AddressableAssetsData/*/*.bin*
**/assets/addressableassetsdata/*/*.bin*
**/Assets/StreamingAssets/aa.meta
**/assets/streamingassets/*/aa/*
.DS_Store*
Thumbs.db
Desktop.ini



================================================
FILE: .vsconfig
================================================
{
  "version": "1.0",
  "components": [
    "Microsoft.VisualStudio.Workload.ManagedGame"
  ]
}



================================================
FILE: Assets/Readme.asset
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: fcf7219bab7fe46a1ad266029b2fee19, type: 3}
  m_Name: Readme
  m_EditorClassIdentifier: 
  icon: {fileID: 2800000, guid: 727a75301c3d24613a3ebcec4a24c2c8, type: 3}
  title: URP Empty Template
  sections:
  - heading: Welcome to the Universal Render Pipeline
    text: This template includes the settings and assets you need to start creating with the Universal Render Pipeline.
    linkText: 
    url:
  - heading: URP Documentation
    text:
    linkText: Read more about URP
    url: https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest
  - heading: Forums
    text:
    linkText: Get answers and support
    url: https://forum.unity.com/forums/universal-render-pipeline.383/
  - heading: Report bugs
    text:
    linkText: Submit a report
    url: https://unity3d.com/unity/qa/bug-reporting
  loadedLayout: 1



================================================
FILE: Assets/Readme.asset.meta
================================================
fileFormatVersion: 2
guid: 8105016687592461f977c054a80ce2f2
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation.meta
================================================
fileFormatVersion: 2
guid: f945e2de4e67e4d4298720359fd706ea
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox.meta
================================================
fileFormatVersion: 2
guid: 7c5e1016ce6fba44ca28ee4414f70db9
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/delay.cs
================================================
using UnityEngine;
using System.Collections;
public class delay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DelayObject());
    }

    IEnumerator DelayObject()
    {
        yield return new WaitForSeconds(2f);  // Wait 2 seconds

        // Do your action here (e.g., enable, move, destroy, etc.)
        Debug.Log("Action after delay");
        gameObject.SetActive(false); // example: disable the object
    }

    // Update is called once per frame

}



================================================
FILE: Assets/delay.cs.meta
================================================
fileFormatVersion: 2
guid: bb6847ee56e9f974c852de4735b8fe4a


================================================
FILE: Assets/InputSystem_Actions.inputactions
================================================
{
    "name": "InputSystem_Actions",
    "maps": [
        {
            "name": "Player",
            "id": "df70fa95-8a34-4494-b137-73ab6b9c7d37",
            "actions": [
                {
                    "name": "Move",
                    "type": "Value",
                    "id": "351f2ccd-1f9f-44bf-9bec-d62ac5c5f408",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Look",
                    "type": "Value",
                    "id": "6b444451-8a00-4d00-a97e-f47457f736a8",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Attack",
                    "type": "Button",
                    "id": "6c2ab1b8-8984-453a-af3d-a3c78ae1679a",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Interact",
                    "type": "Button",
                    "id": "852140f2-7766-474d-8707-702459ba45f3",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Hold",
                    "initialStateCheck": false
                },
                {
                    "name": "Crouch",
                    "type": "Button",
                    "id": "27c5f898-bc57-4ee1-8800-db469aca5fe3",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Jump",
                    "type": "Button",
                    "id": "f1ba0d36-48eb-4cd5-b651-1c94a6531f70",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Previous",
                    "type": "Button",
                    "id": "2776c80d-3c14-4091-8c56-d04ced07a2b0",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Next",
                    "type": "Button",
                    "id": "b7230bb6-fc9b-4f52-8b25-f5e19cb2c2ba",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Sprint",
                    "type": "Button",
                    "id": "641cd816-40e6-41b4-8c3d-04687c349290",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "978bfe49-cc26-4a3d-ab7b-7d7a29327403",
                    "path": "<Gamepad>/leftStick",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "WASD",
                    "id": "00ca640b-d935-4593-8157-c05846ea39b3",
                    "path": "Dpad",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "e2062cb9-1b15-46a2-838c-2f8d72a0bdd9",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "up",
                    "id": "8180e8bd-4097-4f4e-ab88-4523101a6ce9",
                    "path": "<Keyboard>/upArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "320bffee-a40b-4347-ac70-c210eb8bc73a",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "1c5327b5-f71c-4f60-99c7-4e737386f1d1",
                    "path": "<Keyboard>/downArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "d2581a9b-1d11-4566-b27d-b92aff5fabbc",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "2e46982e-44cc-431b-9f0b-c11910bf467a",
                    "path": "<Keyboard>/leftArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "fcfe95b8-67b9-4526-84b5-5d0bc98d6400",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "77bff152-3580-4b21-b6de-dcd0c7e41164",
                    "path": "<Keyboard>/rightArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "1635d3fe-58b6-4ba9-a4e2-f4b964f6b5c8",
                    "path": "<XRController>/{Primary2DAxis}",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "3ea4d645-4504-4529-b061-ab81934c3752",
                    "path": "<Joystick>/stick",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "c1f7a91b-d0fd-4a62-997e-7fb9b69bf235",
                    "path": "<Gamepad>/rightStick",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "8c8e490b-c610-4785-884f-f04217b23ca4",
                    "path": "<Pointer>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse;Touch",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "3e5f5442-8668-4b27-a940-df99bad7e831",
                    "path": "<Joystick>/{Hatswitch}",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "143bb1cd-cc10-4eca-a2f0-a3664166fe91",
                    "path": "<Gamepad>/buttonWest",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Attack",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "05f6913d-c316-48b2-a6bb-e225f14c7960",
                    "path": "<Mouse>/leftButton",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Attack",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "886e731e-7071-4ae4-95c0-e61739dad6fd",
                    "path": "<Touchscreen>/primaryTouch/tap",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Touch",
                    "action": "Attack",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "ee3d0cd2-254e-47a7-a8cb-bc94d9658c54",
                    "path": "<Joystick>/trigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Attack",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "8255d333-5683-4943-a58a-ccb207ff1dce",
                    "path": "<XRController>/{PrimaryAction}",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "Attack",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "b3c1c7f0-bd20-4ee7-a0f1-899b24bca6d7",
                    "path": "<Keyboard>/enter",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Attack",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "cbac6039-9c09-46a1-b5f2-4e5124ccb5ed",
                    "path": "<Keyboard>/2",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Next",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "e15ca19d-e649-4852-97d5-7fe8ccc44e94",
                    "path": "<Gamepad>/dpad/right",
                    "interactions": "",
                    "processors": "",
                    "groups": "Gamepad",
                    "action": "Next",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "f2e9ba44-c423-42a7-ad56-f20975884794",
                    "path": "<Keyboard>/leftShift",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "8cbb2f4b-a784-49cc-8d5e-c010b8c7f4e6",
                    "path": "<Gamepad>/leftStickPress",
                    "interactions": "",
                    "processors": "",
                    "groups": "Gamepad",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "d8bf24bf-3f2f-4160-a97c-38ec1eb520ba",
                    "path": "<XRController>/trigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "eb40bb66-4559-4dfa-9a2f-820438abb426",
                    "path": "<Keyboard>/space",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Jump",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "daba33a1-ad0c-4742-a909-43ad1cdfbeb6",
                    "path": "<Gamepad>/buttonSouth",
                    "interactions": "",
                    "processors": "",
                    "groups": "Gamepad",
                    "action": "Jump",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "603f3daf-40bd-4854-8724-93e8017f59e3",
                    "path": "<XRController>/secondaryButton",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "Jump",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1534dc16-a6aa-499d-9c3a-22b47347b52a",
                    "path": "<Keyboard>/1",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Previous",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "25060bbd-a3a6-476e-8fba-45ae484aad05",
                    "path": "<Gamepad>/dpad/left",
                    "interactions": "",
                    "processors": "",
                    "groups": "Gamepad",
                    "action": "Previous",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1c04ea5f-b012-41d1-a6f7-02e963b52893",
                    "path": "<Keyboard>/e",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Interact",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "b3f66d0b-7751-423f-908b-a11c5bd95930",
                    "path": "<Gamepad>/buttonNorth",
                    "interactions": "",
                    "processors": "",
                    "groups": "Gamepad",
                    "action": "Interact",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "4f4649ac-64a8-4a73-af11-b3faef356a4d",
                    "path": "<Gamepad>/buttonEast",
                    "interactions": "",
                    "processors": "",
                    "groups": "Gamepad",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "36e52cba-0905-478e-a818-f4bfcb9f3b9a",
                    "path": "<Keyboard>/c",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "UI",
            "id": "272f6d14-89ba-496f-b7ff-215263d3219f",
            "actions": [
                {
                    "name": "Navigate",
                    "type": "PassThrough",
                    "id": "c95b2375-e6d9-4b88-9c4c-c5e76515df4b",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Submit",
                    "type": "Button",
                    "id": "7607c7b6-cd76-4816-beef-bd0341cfe950",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Cancel",
                    "type": "Button",
                    "id": "15cef263-9014-4fd5-94d9-4e4a6234a6ef",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Point",
                    "type": "PassThrough",
                    "id": "32b35790-4ed0-4e9a-aa41-69ac6d629449",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Click",
                    "type": "PassThrough",
                    "id": "3c7022bf-7922-4f7c-a998-c437916075ad",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "RightClick",
                    "type": "PassThrough",
                    "id": "44b200b1-1557-4083-816c-b22cbdf77ddf",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "MiddleClick",
                    "type": "PassThrough",
                    "id": "dad70c86-b58c-4b17-88ad-f5e53adf419e",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "ScrollWheel",
                    "type": "PassThrough",
                    "id": "0489e84a-4833-4c40-bfae-cea84b696689",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "TrackedDevicePosition",
                    "type": "PassThrough",
                    "id": "24908448-c609-4bc3-a128-ea258674378a",
                    "expectedControlType": "Vector3",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "TrackedDeviceOrientation",
                    "type": "PassThrough",
                    "id": "9caa3d8a-6b2f-4e8e-8bad-6ede561bd9be",
                    "expectedControlType": "Quaternion",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "Gamepad",
                    "id": "809f371f-c5e2-4e7a-83a1-d867598f40dd",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Navigate",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf",
                    "path": "<Gamepad>/leftStick/up",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "up",
                    "id": "9144cbe6-05e1-4687-a6d7-24f99d23dd81",
                    "path": "<Gamepad>/rightStick/up",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "2db08d65-c5fb-421b-983f-c71163608d67",
                    "path": "<Gamepad>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "58748904-2ea9-4a80-8579-b500e6a76df8",
                    "path": "<Gamepad>/rightStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "8ba04515-75aa-45de-966d-393d9bbd1c14",
                    "path": "<Gamepad>/leftStick/left",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "712e721c-bdfb-4b23-a86c-a0d9fcfea921",
                    "path": "<Gamepad>/rightStick/left",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "fcd248ae-a788-4676-a12e-f4d81205600b",
                    "path": "<Gamepad>/leftStick/right",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "1f04d9bc-c50b-41a1-bfcc-afb75475ec20",
                    "path": "<Gamepad>/rightStick/right",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "fb8277d4-c5cd-4663-9dc7-ee3f0b506d90",
                    "path": "<Gamepad>/dpad",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Gamepad",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "Joystick",
                    "id": "e25d9774-381c-4a61-b47c-7b6b299ad9f9",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Navigate",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "3db53b26-6601-41be-9887-63ac74e79d19",
                    "path": "<Joystick>/stick/up",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "0cb3e13e-3d90-4178-8ae6-d9c5501d653f",
                    "path": "<Joystick>/stick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "0392d399-f6dd-4c82-8062-c1e9c0d34835",
                    "path": "<Joystick>/stick/left",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "942a66d9-d42f-43d6-8d70-ecb4ba5363bc",
                    "path": "<Joystick>/stick/right",
                    "interactions": "",
                    "processors": "",
                    "groups": "Joystick",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "Keyboard",
                    "id": "ff527021-f211-4c02-933e-5976594c46ed",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Navigate",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "563fbfdd-0f09-408d-aa75-8642c4f08ef0",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "up",
                    "id": "eb480147-c587-4a33-85ed-eb0ab9942c43",
                    "path": "<Keyboard>/upArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "2bf42165-60bc-42ca-8072-8c13ab40239b",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "85d264ad-e0a0-4565-b7ff-1a37edde51ac",
                    "path": "<Keyboard>/downArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "74214943-c580-44e4-98eb-ad7eebe17902",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "cea9b045-a000-445b-95b8-0c171af70a3b",
                    "path": "<Keyboard>/leftArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "8607c725-d935-4808-84b1-8354e29bab63",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "4cda81dc-9edd-4e03-9d7c-a71a14345d0b",
                    "path": "<Keyboard>/rightArrow",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Navigate",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc",
                    "path": "*/{Submit}",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse;Gamepad;Touch;Joystick;XR",
                    "action": "Submit",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "82627dcc-3b13-4ba9-841d-e4b746d6553e",
                    "path": "*/{Cancel}",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse;Gamepad;Touch;Joystick;XR",
                    "action": "Cancel",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "c52c8e0b-8179-41d3-b8a1-d149033bbe86",
                    "path": "<Mouse>/position",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Point",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "e1394cbc-336e-44ce-9ea8-6007ed6193f7",
                    "path": "<Pen>/position",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "Point",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "5693e57a-238a-46ed-b5ae-e64e6e574302",
                    "path": "<Touchscreen>/touch*/position",
                    "interactions": "",
                    "processors": "",
                    "groups": "Touch",
                    "action": "Point",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "4faf7dc9-b979-4210-aa8c-e808e1ef89f5",
                    "path": "<Mouse>/leftButton",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Click",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "8d66d5ba-88d7-48e6-b1cd-198bbfef7ace",
                    "path": "<Pen>/tip",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "Click",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "47c2a644-3ebc-4dae-a106-589b7ca75b59",
                    "path": "<Touchscreen>/touch*/press",
                    "interactions": "",
                    "processors": "",
                    "groups": "Touch",
                    "action": "Click",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "bb9e6b34-44bf-4381-ac63-5aa15d19f677",
                    "path": "<XRController>/trigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "Click",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "38c99815-14ea-4617-8627-164d27641299",
                    "path": "<Mouse>/scroll",
                    "interactions": "",
                    "processors": "",
                    "groups": ";Keyboard&Mouse",
                    "action": "ScrollWheel",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "4c191405-5738-4d4b-a523-c6a301dbf754",
                    "path": "<Mouse>/rightButton",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "RightClick",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "24066f69-da47-44f3-a07e-0015fb02eb2e",
                    "path": "<Mouse>/middleButton",
                    "interactions": "",
                    "processors": "",
                    "groups": "Keyboard&Mouse",
                    "action": "MiddleClick",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77",
                    "path": "<XRController>/devicePosition",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "TrackedDevicePosition",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "23e01e3a-f935-4948-8d8b-9bcac77714fb",
                    "path": "<XRController>/deviceRotation",
                    "interactions": "",
                    "processors": "",
                    "groups": "XR",
                    "action": "TrackedDeviceOrientation",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": [
        {
            "name": "Keyboard&Mouse",
            "bindingGroup": "Keyboard&Mouse",
            "devices": [
                {
                    "devicePath": "<Keyboard>",
                    "isOptional": false,
                    "isOR": false
                },
                {
                    "devicePath": "<Mouse>",
                    "isOptional": false,
                    "isOR": false
                }
            ]
        },
        {
            "name": "Gamepad",
            "bindingGroup": "Gamepad",
            "devices": [
                {
                    "devicePath": "<Gamepad>",
                    "isOptional": false,
                    "isOR": false
                }
            ]
        },
        {
            "name": "Touch",
            "bindingGroup": "Touch",
            "devices": [
                {
                    "devicePath": "<Touchscreen>",
                    "isOptional": false,
                    "isOR": false
                }
            ]
        },
        {
            "name": "Joystick",
            "bindingGroup": "Joystick",
            "devices": [
                {
                    "devicePath": "<Joystick>",
                    "isOptional": false,
                    "isOR": false
                }
            ]
        },
        {
            "name": "XR",
            "bindingGroup": "XR",
            "devices": [
                {
                    "devicePath": "<XRController>",
                    "isOptional": false,
                    "isOR": false
                }
            ]
        }
    ]
}


================================================
FILE: Assets/InputSystem_Actions.inputactions.meta
================================================
fileFormatVersion: 2
guid: 052faaac586de48259a63d0c4782560b
ScriptedImporter:
  internalIDToNameTable: []
  externalObjects: {}
  serializedVersion: 2
  userData: 
  assetBundleName: 
  assetBundleVariant: 
  script: {fileID: 11500000, guid: 8404be70184654265930450def6a9037, type: 3}
  generateWrapperCode: 0
  wrapperCodePath: 
  wrapperClassName: 
  wrapperCodeNamespace: 



================================================
FILE: Assets/LastPanel.prefab.meta
================================================
fileFormatVersion: 2
guid: 1450103242bb45b4bac62430039271be
PrefabImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/MangeTime.cs
================================================
using UnityEngine;

public class MangeTime : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //Application.targetFrameRate = 60;
        Time.fixedDeltaTime = 0.001f;
        Time.timeScale = 1;
        //QualitySettings.vSyncCount = 1;

        DontDestroyOnLoad(gameObject);

    }
}



================================================
FILE: Assets/MangeTime.cs.meta
================================================
fileFormatVersion: 2
guid: 5e6c3bb3123843e4bb829c8ccc6d9a15


================================================
FILE: Assets/MangeTimeFall.cs
================================================
using UnityEngine;

public class MangeTimeFall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float TimeSteps = 0.01f;
    void Start()
    {
        Time.fixedDeltaTime = TimeSteps;
    }

    // Update is called once per frame
}



================================================
FILE: Assets/MangeTimeFall.cs.meta
================================================
fileFormatVersion: 2
guid: 69d1a7923cbd2bd46bd81e8d41069d04


================================================
FILE: Assets/Models.meta
================================================
fileFormatVersion: 2
guid: c10a402de45281140b1351326fd1b398
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/MoveLeft.cs
================================================
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float steps = .1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     Vector3 POs = transform.position;
        if (POs.x >= -1)
        {
            POs.x -= steps*Time.deltaTime;
            transform.position = POs;
        }
    }
}



================================================
FILE: Assets/MoveLeft.cs.meta
================================================
fileFormatVersion: 2
guid: a3842078decfd444d9f44a5c7ce6bdce


================================================
FILE: Assets/MoveRight.cs
================================================
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    float steps = .1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 POs = transform.position;
        if (POs.x <= 1)
        {
            POs.x += steps*Time.deltaTime;
            transform.position = POs;
        }
    }
}



================================================
FILE: Assets/MoveRight.cs.meta
================================================
fileFormatVersion: 2
guid: 8653c31d46799d44a8a72b7e82ace6e0


================================================
FILE: Assets/Prefabs.meta
================================================
fileFormatVersion: 2
guid: 4c680ad9224bd7645982706398b6682c
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Resources.meta
================================================
fileFormatVersion: 2
guid: dddcff0a036f2d040bb66c28bf831d71
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/SceneMangerBar.cs
================================================
﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerBar : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // يعيد تحميل المشهد من البداية
    }
}



================================================
FILE: Assets/SceneMangerBar.cs.meta
================================================
fileFormatVersion: 2
guid: 448e7964d6627414c8325c35ae7741fd


================================================
FILE: Assets/Scenes.meta
================================================
fileFormatVersion: 2
guid: 9c53962885c2c4f449125a979d6ad240
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/SceneSpawner.cs
================================================
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SceneSpawner : MonoBehaviour
{
    public Dropdown shapeDropdown;
    public InputField inputX, inputY, inputZ;
    public InputField inputX1, inputY1, inputZ1;
    public Button addButton;

    public List<GameObject> shapePrefabs;

    public GameObject shapeUIPrefab;      
    public Transform canvasPanelParent;  

    void Start()
    {
        addButton.onClick.AddListener(AddShapeToScene);
    }

    void AddShapeToScene()
    {
        int index = shapeDropdown.value;
        if (index < 0 || index >= shapePrefabs.Count)
        {
            Debug.LogWarning("Shape index out of bounds.");
            return;
        }

        if (!float.TryParse(inputX.text, out float x) ||
            !float.TryParse(inputY.text, out float y) ||
            !float.TryParse(inputZ.text, out float z))
        {
            Debug.LogWarning("Invalid position input.");
            return;
        }
        if (!float.TryParse(inputX1.text, out float x1) ||
            !float.TryParse(inputY1.text, out float y1) ||
            !float.TryParse(inputZ1.text, out float z1))
        {
            Debug.LogWarning("Invalid position input.");
            return;
        }

        Vector3 position = new Vector3(x, y, z);
        Vector3 Velocuty = new Vector3(x1, y1, z1);

        GameObject shapeInstance = Instantiate(shapePrefabs[index], position, Quaternion.identity);

        MeshObject1 meshObj = shapeInstance.GetComponentInChildren<MeshObject1>();

        if (meshObj == null)
        {
            Debug.LogError("❌ MeshObject1 not found in the spawned shape prefab.");
            return;
        }
        GameObject ui = Instantiate(shapeUIPrefab, canvasPanelParent);
        ShapeUIController controller = ui.GetComponent<ShapeUIController>();
        if (controller == null)
        {
            Debug.LogError("❌ ShapeUIController not found on shapeUIPrefab.");
            return;
        }
        meshObj.SetDefaults();
        meshObj.SetInitialVelocity(Velocuty);

        controller.Initialize(meshObj);

    }
}



================================================
FILE: Assets/SceneSpawner.cs.meta
================================================
fileFormatVersion: 2
guid: 5bcc6a65658a7e3429c020bda7c12869
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/scripts.meta
================================================
fileFormatVersion: 2
guid: 33eb7dc2177ec3246bae59fa82b62051
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Settings.meta
================================================
fileFormatVersion: 2
guid: 709f11a7f3c4041caa4ef136ea32d874
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/ShapeUIController.cs
================================================
﻿using UnityEngine;
using UnityEngine.UI;

public class ShapeUIController : MonoBehaviour
{
    public Toggle simulationToggle;
    public Button deleteButton;
    public InputField K_Vlaue;
    public InputField M_Vlaue, Damping_Value, StiffnessFactor_Value, PlasticThreshold_Value, DragCoefficient, FrictionCoefficient, γ;

    private MeshObject1 targetObject;

    private void Start()
    {
        targetObject.isSimulating = false;                    

    }
    public void Initialize(MeshObject1 meshObject)
    {
        targetObject = meshObject;
        //targetObject.SetDefaults();
        //Vector3 pos = transform.position;
        //pos.x = meshObject.transform.position.x;
        //transform.position = pos;
        simulationToggle.onValueChanged.RemoveAllListeners(); 
        simulationToggle.isOn = false;                       
        targetObject.isSimulating = false;                         

        // ثم أضف الـ listener
        simulationToggle.onValueChanged.AddListener((on) =>
        {
            if (targetObject != null)
                targetObject.isSimulating = on;
        });

        deleteButton.onClick.AddListener(() =>
        {
            Destroy(targetObject.gameObject);
            Destroy(gameObject);
        });

        UpdateUIFromTarget();

        K_Vlaue.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.K_Value = f));
        M_Vlaue.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.M_Value = f));
        Damping_Value.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.Damping_Value = f));
        StiffnessFactor_Value.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.StiffnessFactor_Value = f));
        PlasticThreshold_Value.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.PlasticThreshold_Value = f));
        DragCoefficient.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.DragCoefficient = f));
        FrictionCoefficient.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.FrictionCoefficient = f));
        γ.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.γ = f));
    }

    private void TrySetFloat(string value, System.Action<float> setter)
    {
        if (float.TryParse(value, out float result))
        {
            setter(result);
        }
    }

    private void UpdateUIFromTarget()
    {

        K_Vlaue.text = targetObject.K_Value.ToString();
        M_Vlaue.text = targetObject.M_Value.ToString();
        Damping_Value.text = targetObject.Damping_Value.ToString();
        StiffnessFactor_Value.text = targetObject.StiffnessFactor_Value.ToString();
        PlasticThreshold_Value.text = targetObject.PlasticThreshold_Value.ToString();
        DragCoefficient.text = targetObject.DragCoefficient.ToString();
        FrictionCoefficient.text = targetObject.FrictionCoefficient.ToString();
        γ.text = targetObject.γ.ToString();
    }
}



================================================
FILE: Assets/ShapeUIController.cs.meta
================================================
fileFormatVersion: 2
guid: 5a71bba5858837042930e5c91485f243
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/TextMesh Pro.meta
================================================
fileFormatVersion: 2
guid: f54d1bd14bd3ca042bd867b519fee8cc
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/TutorialInfo.meta
================================================
fileFormatVersion: 2
guid: ba062aa6c92b140379dbc06b43dd3b9b
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/AirForceMetal.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: AirForceMetal
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves: []
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: "\u03B3"
    path: Metal
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 27515853
      attribute: 1187514889
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 2
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 1
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: "\u03B3"
    path: Metal
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 0
  m_HasMotionFloatCurves: 0
  m_Events: []



================================================
FILE: Assets/Animation/AirForceMetal.anim.meta
================================================
fileFormatVersion: 2
guid: d9dae3b28288df247a7f9c27b2c8d058
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/CrushWithWall.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: CrushWithWall
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves:
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: {x: 7.5660133, y: 1.03, z: -5.148866}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      - serializedVersion: 3
        time: 0.033333335
        value: {x: 4.67, y: 1.03, z: -5.148866}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    path: 
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 2500
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.033333335
        value: 2500
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: K_Value
    path: MetalCube
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 0
      attribute: 1
      script: {fileID: 0}
      typeID: 4
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 1729768752
      attribute: 1009566962
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 0.033333335
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 0
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 7.5660133
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.033333335
        value: 4.67
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.x
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 1.03
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.033333335
        value: 1.03
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.y
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: -5.148866
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.033333335
        value: -5.148866
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.z
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 2500
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.033333335
        value: 2500
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: K_Value
    path: MetalCube
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 1
  m_HasMotionFloatCurves: 0
  m_Events:
  - time: 0.033333335
    functionName: 
    data: 
    objectReferenceParameter: {fileID: 0}
    floatParameter: 0
    intParameter: 0
    messageOptions: 0



================================================
FILE: Assets/Animation/CrushWithWall.anim.meta
================================================
fileFormatVersion: 2
guid: bfde886592262d742a4eb53ba8990443
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/CrushWithWall.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1107 &-8701824421680985892
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -4233773535975541007}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -4233773535975541007}
--- !u!1102 &-4233773535975541007
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: CrushWithWall
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: bfde886592262d742a4eb53ba8990443, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: CrushWithWall
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: -8701824421680985892}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}



================================================
FILE: Assets/Animation/CrushWithWall.controller.meta
================================================
fileFormatVersion: 2
guid: 821d8e4e596b67e41b400dfb8c6fc3f1
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/Drag.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Drag
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves: []
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: FrictionCoefficient
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: FrictionCoefficient
    path: MetalCylinder
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.005
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: PlasticThreshold_Value
    path: MetalCylinder
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 2042982323
      attribute: 1357668792
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 2298312213
      attribute: 1357668792
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 2298312213
      attribute: 649126713
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 0
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 1
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: FrictionCoefficient
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: FrictionCoefficient
    path: MetalCylinder
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.005
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: PlasticThreshold_Value
    path: MetalCylinder
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 0
  m_HasMotionFloatCurves: 0
  m_Events: []



================================================
FILE: Assets/Animation/Drag.anim.meta
================================================
fileFormatVersion: 2
guid: 9c37757a3f203704ebce67a826de08b9
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/Higher_K.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Higher_K
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves: []
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 5000
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: K_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: M_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 2.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: Damping_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: PlasticThreshold_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: PlasticThreshold_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4000
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: K_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 10
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: M_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: Damping_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 2042982323
      attribute: 1009566962
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 2042982323
      attribute: 1610412488
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 2042982323
      attribute: 809635437
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 2042982323
      attribute: 649126713
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 3175860436
      attribute: 649126713
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 3175860436
      attribute: 1009566962
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 3175860436
      attribute: 1610412488
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    - serializedVersion: 2
      path: 3175860436
      attribute: 809635437
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 0
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 1
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 5000
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: K_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: M_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 2.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: Damping_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: PlasticThreshold_Value
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: PlasticThreshold_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4000
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: K_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 10
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: M_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 4
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: Damping_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 0
  m_HasMotionFloatCurves: 0
  m_Events: []



================================================
FILE: Assets/Animation/Higher_K.anim.meta
================================================
fileFormatVersion: 2
guid: f4e844893512393478c078eb530503d4
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/JellyCube 1.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1102 &-1953823046137127763
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Higher_K
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: f4e844893512393478c078eb530503d4, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!1107 &-1503867208034334230
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -1953823046137127763}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -1953823046137127763}
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: JellyCube 1
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: -1503867208034334230}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}



================================================
FILE: Assets/Animation/JellyCube 1.controller.meta
================================================
fileFormatVersion: 2
guid: 4262aeb560e7fb749a85a0275b430d82
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/JellyCube.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1102 &-7446087708417816707
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MoveRight
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: 0d81c04b2190cd443bc69211f7cd21d6, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!1107 &-4766555911100012953
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: 8922217419095983865}
    m_Position: {x: 200, y: 0, z: 0}
  - serializedVersion: 1
    m_State: {fileID: -7446087708417816707}
    m_Position: {x: 235, y: 65, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: 8922217419095983865}
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: JellyCube
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: -4766555911100012953}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}
--- !u!1102 &8922217419095983865
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MoveLeft
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: 498c83c98f33f604eb07f4dd8f40cd8e, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 



================================================
FILE: Assets/Animation/JellyCube.controller.meta
================================================
fileFormatVersion: 2
guid: b488d80a795c9c14ba200e04a98ce55c
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/JellyCylinder.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1102 &-7573705738572329084
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Drag
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: 9c37757a3f203704ebce67a826de08b9, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: JellyCylinder
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: 3412682610646954156}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}
--- !u!1107 &3412682610646954156
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -7573705738572329084}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -7573705738572329084}



================================================
FILE: Assets/Animation/JellyCylinder.controller.meta
================================================
fileFormatVersion: 2
guid: b2570be8750b22e49a25316ddafc5805
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/MetalBall.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1102 &-4611754930876166471
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: AirForceMetal
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: d9dae3b28288df247a7f9c27b2c8d058, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MetalBall
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: 3083679696106687752}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}
--- !u!1107 &3083679696106687752
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -4611754930876166471}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -4611754930876166471}



================================================
FILE: Assets/Animation/MetalBall.controller.meta
================================================
fileFormatVersion: 2
guid: 1fd855438c98ed44393b22894b792979
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/MoveLeft.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MoveLeft
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves:
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: {x: 2, y: 0, z: -6.5}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      - serializedVersion: 3
        time: 0.5
        value: {x: 0, y: 0, z: -6.5}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    path: 
  m_ScaleCurves: []
  m_FloatCurves: []
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 0
      attribute: 1
      script: {fileID: 0}
      typeID: 4
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 0.5
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 0
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 2
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.x
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.y
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: -6.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: -6.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.z
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 1
  m_HasMotionFloatCurves: 0
  m_Events:
  - time: 0
    functionName: 
    data: 
    objectReferenceParameter: {fileID: 0}
    floatParameter: 0
    intParameter: 0
    messageOptions: 0
  - time: 0.5
    functionName: 
    data: 
    objectReferenceParameter: {fileID: 0}
    floatParameter: 0
    intParameter: 0
    messageOptions: 0



================================================
FILE: Assets/Animation/MoveLeft.anim.meta
================================================
fileFormatVersion: 2
guid: 498c83c98f33f604eb07f4dd8f40cd8e
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/MoveRight.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MoveRight
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves:
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: {x: -2, y: 0, z: -6.5}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      - serializedVersion: 3
        time: 0.5
        value: {x: 0, y: 0, z: -6.5}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    path: 
  m_ScaleCurves: []
  m_FloatCurves: []
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 0
      attribute: 1
      script: {fileID: 0}
      typeID: 4
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 0.5
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 0
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: -2
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.x
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.y
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: -6.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 0.5
        value: -6.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: m_LocalPosition.z
    path: 
    classID: 4
    script: {fileID: 0}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 1
  m_HasMotionFloatCurves: 0
  m_Events:
  - time: 0
    functionName: 
    data: 
    objectReferenceParameter: {fileID: 0}
    floatParameter: 0
    intParameter: 0
    messageOptions: 0



================================================
FILE: Assets/Animation/MoveRight.anim.meta
================================================
fileFormatVersion: 2
guid: 0d81c04b2190cd443bc69211f7cd21d6
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/MoveRight.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1102 &-6259481724461121199
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MoveRight
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: 0d81c04b2190cd443bc69211f7cd21d6, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: MoveRight
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: 2955093523792601845}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}
--- !u!1107 &2955093523792601845
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -6259481724461121199}
    m_Position: {x: 270, y: 70, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -6259481724461121199}



================================================
FILE: Assets/Animation/MoveRight.controller.meta
================================================
fileFormatVersion: 2
guid: d9fa5d5f909d93e49a70384a026cc161
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/RubberAireForce.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: RubberAireForce
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves: []
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: "\u03B3"
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 3175860436
      attribute: 1187514889
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 2
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 1
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: "\u03B3"
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 0
  m_HasMotionFloatCurves: 0
  m_Events: []



================================================
FILE: Assets/Animation/RubberAireForce.anim.meta
================================================
fileFormatVersion: 2
guid: 7b36c322bf7177047a3757622298cf18
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/RubberBall.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1107 &-8735405585226034785
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -5207328982167188582}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -5207328982167188582}
--- !u!1102 &-5207328982167188582
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: RubberAireForce
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: 7b36c322bf7177047a3757622298cf18, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: RubberBall
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: -8735405585226034785}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}



================================================
FILE: Assets/Animation/RubberBall.controller.meta
================================================
fileFormatVersion: 2
guid: 678b0a2420bf42c49a9595f8d229d4eb
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/RubberCube 1.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1107 &-5727424160238987364
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: -651118825856489263}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: -651118825856489263}
--- !u!1102 &-651118825856489263
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Try
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: 675cd464d011b8541947e21b115afb0b, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: RubberCube 1
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: -5727424160238987364}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}



================================================
FILE: Assets/Animation/RubberCube 1.controller.meta
================================================
fileFormatVersion: 2
guid: bcae1d40f3bb38b4c85a5f7a282fe4e0
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/RubberCube.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: RubberCube
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: 6470582554428627760}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}
--- !u!1102 &633502317397293994
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Higher_K
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: f4e844893512393478c078eb530503d4, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 
--- !u!1107 &6470582554428627760
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: 633502317397293994}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: 633502317397293994}



================================================
FILE: Assets/Animation/RubberCube.controller.meta
================================================
fileFormatVersion: 2
guid: f4733e62cfd51214cb577c1ab681fe66
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/ShootBall.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: ShootBall
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves: []
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: "\u03B3"
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 2042982323
      attribute: 1187514889
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 2
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 0
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      - serializedVersion: 3
        time: 2
        value: 0.5
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: "\u03B3"
    path: Jelly
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 0
  m_HasMotionFloatCurves: 0
  m_Events:
  - time: 0
    functionName: 
    data: 
    objectReferenceParameter: {fileID: 0}
    floatParameter: 0
    intParameter: 0
    messageOptions: 0
  - time: 2
    functionName: 
    data: 
    objectReferenceParameter: {fileID: 0}
    floatParameter: 0
    intParameter: 0
    messageOptions: 0



================================================
FILE: Assets/Animation/ShootBall.anim.meta
================================================
fileFormatVersion: 2
guid: e402082df14e9a844abf1e7186cf1cd9
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/ShootBall.controller
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!91 &9100000
AnimatorController:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: ShootBall
  serializedVersion: 5
  m_AnimatorParameters: []
  m_AnimatorLayers:
  - serializedVersion: 5
    m_Name: Base Layer
    m_StateMachine: {fileID: 3738031948372468160}
    m_Mask: {fileID: 0}
    m_Motions: []
    m_Behaviours: []
    m_BlendingMode: 0
    m_SyncedLayerIndex: -1
    m_DefaultWeight: 0
    m_IKPass: 0
    m_SyncedLayerAffectsTiming: 0
    m_Controller: {fileID: 9100000}
--- !u!1107 &3738031948372468160
AnimatorStateMachine:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Base Layer
  m_ChildStates:
  - serializedVersion: 1
    m_State: {fileID: 5713520727728556281}
    m_Position: {x: 200, y: 0, z: 0}
  m_ChildStateMachines: []
  m_AnyStateTransitions: []
  m_EntryTransitions: []
  m_StateMachineTransitions: {}
  m_StateMachineBehaviours: []
  m_AnyStatePosition: {x: 50, y: 20, z: 0}
  m_EntryPosition: {x: 50, y: 120, z: 0}
  m_ExitPosition: {x: 800, y: 120, z: 0}
  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}
  m_DefaultState: {fileID: 5713520727728556281}
--- !u!1102 &5713520727728556281
AnimatorState:
  serializedVersion: 6
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: ShootBall
  m_Speed: 1
  m_CycleOffset: 0
  m_Transitions: []
  m_StateMachineBehaviours: []
  m_Position: {x: 50, y: 50, z: 0}
  m_IKOnFeet: 0
  m_WriteDefaultValues: 1
  m_Mirror: 0
  m_SpeedParameterActive: 0
  m_MirrorParameterActive: 0
  m_CycleOffsetParameterActive: 0
  m_TimeParameterActive: 0
  m_Motion: {fileID: 7400000, guid: e402082df14e9a844abf1e7186cf1cd9, type: 2}
  m_Tag: 
  m_SpeedParameter: 
  m_MirrorParameter: 
  m_CycleOffsetParameter: 
  m_TimeParameter: 



================================================
FILE: Assets/Animation/ShootBall.controller.meta
================================================
fileFormatVersion: 2
guid: 5b9d5f5c0df86934b97b36a1c096e989
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 9100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Animation/Try.anim
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!74 &7400000
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Try
  serializedVersion: 7
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves: []
  m_PositionCurves: []
  m_ScaleCurves: []
  m_FloatCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.04
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: M_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 3175860436
      attribute: 1610412488
      script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
      typeID: 114
      customType: 0
      isPPtrCurve: 0
      isIntCurve: 0
      isSerializeReferenceCurve: 0
    pptrCurveMapping: []
  m_AnimationClipSettings:
    serializedVersion: 2
    m_AdditiveReferencePoseClip: {fileID: 0}
    m_AdditiveReferencePoseTime: 0
    m_StartTime: 0
    m_StopTime: 0
    m_OrientationOffsetY: 0
    m_Level: 0
    m_CycleOffset: 0
    m_HasAdditiveReferencePose: 0
    m_LoopTime: 1
    m_LoopBlend: 0
    m_LoopBlendOrientation: 0
    m_LoopBlendPositionY: 0
    m_LoopBlendPositionXZ: 0
    m_KeepOriginalOrientation: 0
    m_KeepOriginalPositionY: 1
    m_KeepOriginalPositionXZ: 0
    m_HeightFromFeet: 0
    m_Mirror: 0
  m_EditorCurves:
  - serializedVersion: 2
    curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0.04
        inSlope: 0
        outSlope: 0
        tangentMode: 136
        weightedMode: 0
        inWeight: 0.33333334
        outWeight: 0.33333334
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    attribute: M_Value
    path: Rubber
    classID: 114
    script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
    flags: 0
  m_EulerEditorCurves: []
  m_HasGenericRootTransform: 0
  m_HasMotionFloatCurves: 0
  m_Events: []



================================================
FILE: Assets/Animation/Try.anim.meta
================================================
fileFormatVersion: 2
guid: 675cd464d011b8541947e21b115afb0b
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 7400000
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Customizable Skybox Documentaion.pdf.meta
================================================
fileFormatVersion: 2
guid: 631feaddbe683ed4383934ae4201e481
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Customizable Skybox Documentaion.pdf
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials.meta
================================================
fileFormatVersion: 2
guid: ea580a49e393d474a8246aed4e6421fe
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Model.meta
================================================
fileFormatVersion: 2
guid: b3a8b5ae7212a5e469e5295bd49eb2b9
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Scenes.meta
================================================
fileFormatVersion: 2
guid: 4c87f64bb2d3ca445ac1badce6b5c0d4
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Stylized Sky.meta
================================================
fileFormatVersion: 2
guid: 135450dfab8085c4ebd673f58f013df4
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Materials/Clouds.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Clouds
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 1, g: 1, b: 1, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/Clouds.mat.meta
================================================
fileFormatVersion: 2
guid: b2fcea6c7d9dbab4ca781825705d50be
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/Clouds.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/dark trunk.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: dark trunk
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.2830189, g: 0.08582328, b: 0.041384835, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/dark trunk.mat.meta
================================================
fileFormatVersion: 2
guid: 7c7f7e923f30d8b4193dfc9a7eb33ea9
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/dark trunk.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/darken leafs.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: darken leafs
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.056241423, g: 0.2461942, b: 0.067046694, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/darken leafs.mat.meta
================================================
fileFormatVersion: 2
guid: 3020cfb028abb6c4f977e1db1f72bef5
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/darken leafs.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/earth.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: earth
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.5754717, g: 0.5754717, b: 0.5754717, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/earth.mat.meta
================================================
fileFormatVersion: 2
guid: ef6223db6cd2fd94481bcb5ce352cc30
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/earth.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/green tree.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: green tree
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.29627112, g: 0.8000001, b: 0.12844974, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/green tree.mat.meta
================================================
fileFormatVersion: 2
guid: 162ad232b242eb042b91b10dc755c486
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/green tree.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/Material.003.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Material.003
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.19654304, g: 0.8000001, b: 0.7107023, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/Material.003.mat.meta
================================================
fileFormatVersion: 2
guid: a4b1c9205184ab7479ebcb6d01e9bdaa
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/Material.003.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/No Name.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: No Name
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 1, g: 1, b: 1, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/No Name.mat.meta
================================================
fileFormatVersion: 2
guid: 36624e9898987d34da7dcc3c01a72523
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/No Name.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/pine tree green.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: pine tree green
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.120169275, g: 0.4200235, b: 0.034451712, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/pine tree green.mat.meta
================================================
fileFormatVersion: 2
guid: 471bbc61de2af0a47bd80da0aacc49dc
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/pine tree green.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Materials/trunk.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: trunk
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.3679245, g: 0.14014105, b: 0.06421324, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Materials/trunk.mat.meta
================================================
fileFormatVersion: 2
guid: 08c4b67273e724941900639ca93caabc
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Materials/trunk.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Low Poly Island.fbx.meta
================================================
fileFormatVersion: 2
guid: 9e1cb89bae143d046bb9dba32b57bed0
ModelImporter:
  serializedVersion: 23
  fileIDToRecycleName:
    100000: Camera
    100002: Cube
    100004: Cube.001
    100006: Cube.002
    100008: Cube.003
    100010: Cube.004
    100012: Cube.005
    100014: Icosphere
    100016: Icosphere.001
    100018: Icosphere.002
    100020: Light
    100022: //RootNode
    100024: Plane
    100026: Plane.001
    100028: Plane.002
    100030: Plane.003
    100032: Plane.004
    100034: Plane.005
    100036: Plane.006
    400000: Camera
    400002: Cube
    400004: Cube.001
    400006: Cube.002
    400008: Cube.003
    400010: Cube.004
    400012: Cube.005
    400014: Icosphere
    400016: Icosphere.001
    400018: Icosphere.002
    400020: Light
    400022: //RootNode
    400024: Plane
    400026: Plane.001
    400028: Plane.002
    400030: Plane.003
    400032: Plane.004
    400034: Plane.005
    400036: Plane.006
    2300000: Cube
    2300002: Cube.001
    2300004: Cube.002
    2300006: Cube.003
    2300008: Cube.004
    2300010: Cube.005
    2300012: Icosphere
    2300014: Icosphere.001
    2300016: Icosphere.002
    2300018: Plane
    2300020: Plane.001
    2300022: Plane.002
    2300024: Plane.003
    2300026: Plane.004
    2300028: Plane.005
    2300030: Plane.006
    3300000: Cube
    3300002: Cube.001
    3300004: Cube.002
    3300006: Cube.003
    3300008: Cube.004
    3300010: Cube.005
    3300012: Icosphere
    3300014: Icosphere.001
    3300016: Icosphere.002
    3300018: Plane
    3300020: Plane.001
    3300022: Plane.002
    3300024: Plane.003
    3300026: Plane.004
    3300028: Plane.005
    3300030: Plane.006
    4300000: Icosphere
    4300002: Plane
    4300004: Cube
    4300006: Plane.001
    4300008: Plane.002
    4300010: Plane.003
    4300012: Cube.001
    4300014: Plane.004
    4300016: Plane.005
    4300018: Cube.002
    4300020: Cube.003
    4300022: Cube.004
    4300024: Plane.006
    4300026: Cube.005
    4300028: Icosphere.001
    4300030: Icosphere.002
    9500000: //RootNode
  externalObjects:
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: Material.003
    second: {fileID: 2100000, guid: 0b82edc333f454f4fab3b93e8ececd1a, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: No Name
    second: {fileID: 2100000, guid: 9fe81213c48f6e944a8a30f76f30a9c7, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: dark trunk
    second: {fileID: 2100000, guid: b50f1c4e199dc3b47b56b0880d757857, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: darken leafs
    second: {fileID: 2100000, guid: d35ea29c48c3e1944a4f03cab15e36c2, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: earth
    second: {fileID: 2100000, guid: 9d1ca55e2263fd54589900465f90d06e, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: green tree
    second: {fileID: 2100000, guid: c856162727dc18842bc191504f727456, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: pine brown
    second: {fileID: 2100000, guid: 23884aea9e628ee45a87314c9fd2483e, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: pine tree green
    second: {fileID: 2100000, guid: b67fe0ad79964244383e7633743fcc6b, type: 2}
  - first:
      type: UnityEngine:Material
      assembly: UnityEngine.CoreModule
      name: trunk
    second: {fileID: 2100000, guid: 2b1bb1efbeb980540aa4164a74c61686, type: 2}
  materials:
    importMaterials: 1
    materialName: 0
    materialSearch: 1
    materialLocation: 0
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    motionNodeName: 
    rigImportErrors: 
    rigImportWarnings: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 3
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 0
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 0
    importLights: 0
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    optimizeMeshForGPU: 1
    keepQuads: 0
    weldVertices: 1
    preserveHierarchy: 0
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVPackMargin: 4
    useFileScale: 1
    previousCalculatedGlobalScale: 0.01
    hasPreviousCalculatedGlobalScale: 1
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  importAnimation: 1
  copyAvatar: 0
  humanDescription:
    serializedVersion: 2
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 1
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  animationType: 2
  humanoidOversampling: 1
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Low Poly Island.fbx
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials.meta
================================================
fileFormatVersion: 2
guid: 083961627088d3049935b73b4e8fc135
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Model/Materials/dark trunk.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: dark trunk
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.41093805, g: 0.13480727, b: 0.07245277, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/dark trunk.mat.meta
================================================
fileFormatVersion: 2
guid: b50f1c4e199dc3b47b56b0880d757857
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/dark trunk.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/darken leafs.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: darken leafs
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.056241423, g: 0.2461942, b: 0.067046694, a: 0.9437586}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/darken leafs.mat.meta
================================================
fileFormatVersion: 2
guid: d35ea29c48c3e1944a4f03cab15e36c2
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/darken leafs.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/earth.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: earth
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.8, g: 0.8, b: 0.8, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/earth.mat.meta
================================================
fileFormatVersion: 2
guid: 9d1ca55e2263fd54589900465f90d06e
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/earth.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/green tree.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: green tree
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.29627112, g: 0.8000001, b: 0.12844974, a: 0.7037289}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/green tree.mat.meta
================================================
fileFormatVersion: 2
guid: c856162727dc18842bc191504f727456
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/green tree.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/Material.003.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Material.003
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.19654304, g: 0.8000001, b: 0.7107023, a: 0.80345696}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/Material.003.mat.meta
================================================
fileFormatVersion: 2
guid: 0b82edc333f454f4fab3b93e8ececd1a
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/Material.003.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/No Name.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: No Name
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 1, g: 1, b: 1, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/No Name.mat.meta
================================================
fileFormatVersion: 2
guid: 9fe81213c48f6e944a8a30f76f30a9c7
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/No Name.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/pine brown.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: pine brown
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.8000001, g: 0.11405807, b: 0.03590557, a: 0.19999993}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/pine brown.mat.meta
================================================
fileFormatVersion: 2
guid: 23884aea9e628ee45a87314c9fd2483e
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/pine brown.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/pine tree green.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: pine tree green
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.120169275, g: 0.4200235, b: 0.034451712, a: 0.8798307}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/pine tree green.mat.meta
================================================
fileFormatVersion: 2
guid: b67fe0ad79964244383e7633743fcc6b
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/pine tree green.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Model/Materials/trunk.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: trunk
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.8000001, g: 0.27371386, b: 0.10579279, a: 0.19999993}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Model/Materials/trunk.mat.meta
================================================
fileFormatVersion: 2
guid: 2b1bb1efbeb980540aa4164a74c61686
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Model/Materials/trunk.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Scenes/DemoScene.unity
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!29 &1
OcclusionCullingSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_OcclusionBakeSettings:
    smallestOccluder: 5
    smallestHole: 0.25
    backfaceThreshold: 100
  m_SceneGUID: 00000000000000000000000000000000
  m_OcclusionCullingData: {fileID: 0}
--- !u!104 &2
RenderSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 9
  m_Fog: 0
  m_FogColor: {r: 0.5, g: 0.5, b: 0.5, a: 1}
  m_FogMode: 3
  m_FogDensity: 0.01
  m_LinearFogStart: 0
  m_LinearFogEnd: 300
  m_AmbientSkyColor: {r: 0.212, g: 0.227, b: 0.259, a: 1}
  m_AmbientEquatorColor: {r: 0.114, g: 0.125, b: 0.133, a: 1}
  m_AmbientGroundColor: {r: 0.047, g: 0.043, b: 0.035, a: 1}
  m_AmbientIntensity: 1
  m_AmbientMode: 0
  m_SubtractiveShadowColor: {r: 0.42, g: 0.478, b: 0.627, a: 1}
  m_SkyboxMaterial: {fileID: 2100000, guid: 9aa8ed67591432941bb76f12eb23ff91, type: 2}
  m_HaloStrength: 0.5
  m_FlareStrength: 1
  m_FlareFadeSpeed: 3
  m_HaloTexture: {fileID: 0}
  m_SpotCookie: {fileID: 10001, guid: 0000000000000000e000000000000000, type: 0}
  m_DefaultReflectionMode: 0
  m_DefaultReflectionResolution: 128
  m_ReflectionBounces: 1
  m_ReflectionIntensity: 1
  m_CustomReflection: {fileID: 0}
  m_Sun: {fileID: 2028565212}
  m_IndirectSpecularColor: {r: 0.65112025, g: 0.7745485, b: 0.8357976, a: 1}
  m_UseRadianceAmbientProbe: 0
--- !u!157 &3
LightmapSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 11
  m_GIWorkflowMode: 0
  m_GISettings:
    serializedVersion: 2
    m_BounceScale: 1
    m_IndirectOutputScale: 1
    m_AlbedoBoost: 1
    m_EnvironmentLightingMode: 0
    m_EnableBakedLightmaps: 0
    m_EnableRealtimeLightmaps: 1
  m_LightmapEditorSettings:
    serializedVersion: 12
    m_Resolution: 2
    m_BakeResolution: 40
    m_AtlasSize: 1024
    m_AO: 0
    m_AOMaxDistance: 1
    m_CompAOExponent: 1
    m_CompAOExponentDirect: 0
    m_ExtractAmbientOcclusion: 0
    m_Padding: 2
    m_LightmapParameters: {fileID: 0}
    m_LightmapsBakeMode: 1
    m_TextureCompression: 1
    m_FinalGather: 0
    m_FinalGatherFiltering: 1
    m_FinalGatherRayCount: 256
    m_ReflectionCompression: 2
    m_MixedBakeMode: 2
    m_BakeBackend: 0
    m_PVRSampling: 1
    m_PVRDirectSampleCount: 32
    m_PVRSampleCount: 500
    m_PVRBounces: 2
    m_PVREnvironmentSampleCount: 500
    m_PVREnvironmentReferencePointCount: 2048
    m_PVRFilteringMode: 2
    m_PVRDenoiserTypeDirect: 0
    m_PVRDenoiserTypeIndirect: 0
    m_PVRDenoiserTypeAO: 0
    m_PVRFilterTypeDirect: 0
    m_PVRFilterTypeIndirect: 0
    m_PVRFilterTypeAO: 0
    m_PVREnvironmentMIS: 0
    m_PVRCulling: 1
    m_PVRFilteringGaussRadiusDirect: 1
    m_PVRFilteringGaussRadiusIndirect: 5
    m_PVRFilteringGaussRadiusAO: 2
    m_PVRFilteringAtrousPositionSigmaDirect: 0.5
    m_PVRFilteringAtrousPositionSigmaIndirect: 2
    m_PVRFilteringAtrousPositionSigmaAO: 1
    m_ExportTrainingData: 0
    m_TrainingDataDestination: TrainingData
    m_LightProbeSampleCountMultiplier: 4
  m_LightingDataAsset: {fileID: 0}
  m_UseShadowmask: 1
--- !u!196 &4
NavMeshSettings:
  serializedVersion: 2
  m_ObjectHideFlags: 0
  m_BuildSettings:
    serializedVersion: 2
    agentTypeID: 0
    agentRadius: 0.5
    agentHeight: 2
    agentSlope: 45
    agentClimb: 0.4
    ledgeDropHeight: 0
    maxJumpAcrossDistance: 0
    minRegionArea: 2
    manualCellSize: 0
    cellSize: 0.16666667
    manualTileSize: 0
    tileSize: 256
    accuratePlacement: 0
    debug:
      m_Flags: 0
  m_NavMeshData: {fileID: 0}
--- !u!1001 &310053983
PrefabInstance:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Modification:
    m_TransformParent: {fileID: 0}
    m_Modifications:
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalPosition.x
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalPosition.y
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalPosition.z
      value: 0
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalRotation.x
      value: -0.056739226
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalRotation.y
      value: 0.3309474
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalRotation.z
      value: -0.019939525
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalRotation.w
      value: 0.9417308
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_RootOrder
      value: 1
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.x
      value: -5.3750005
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.y
      value: 38.929
      objectReference: {fileID: 0}
    - target: {fileID: -8679921383154817045, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_LocalEulerAnglesHint.z
      value: -4.327
      objectReference: {fileID: 0}
    - target: {fileID: 919132149155446097, guid: 9e1cb89bae143d046bb9dba32b57bed0,
        type: 3}
      propertyPath: m_Name
      value: Low Poly Island
      objectReference: {fileID: 0}
    m_RemovedComponents: []
  m_SourcePrefab: {fileID: 100100000, guid: 9e1cb89bae143d046bb9dba32b57bed0, type: 3}
--- !u!1 &472462115
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 472462117}
  - component: {fileID: 472462116}
  m_Layer: 0
  m_Name: Main Camera
  m_TagString: MainCamera
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!20 &472462116
Camera:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 472462115}
  m_Enabled: 1
  serializedVersion: 2
  m_ClearFlags: 1
  m_BackGroundColor: {r: 0.19215687, g: 0.3019608, b: 0.4745098, a: 0}
  m_projectionMatrixMode: 1
  m_GateFitMode: 2
  m_FOVAxisMode: 0
  m_SensorSize: {x: 36, y: 24}
  m_LensShift: {x: 0, y: 0}
  m_FocalLength: 50
  m_NormalizedViewPortRect:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  near clip plane: 0.3
  far clip plane: 1000
  field of view: 60
  orthographic: 0
  orthographic size: 5
  m_Depth: -1
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingPath: 3
  m_TargetTexture: {fileID: 0}
  m_TargetDisplay: 0
  m_TargetEye: 3
  m_HDR: 1
  m_AllowMSAA: 0
  m_AllowDynamicResolution: 0
  m_ForceIntoRT: 0
  m_OcclusionCulling: 1
  m_StereoConvergence: 10
  m_StereoSeparation: 0.022
--- !u!4 &472462117
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 472462115}
  m_LocalRotation: {x: -0.15932478, y: 0.046809483, z: 0.0075968215, w: 0.9860866}
  m_LocalPosition: {x: -0.73, y: 2.7089684, z: -11.43}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_Children: []
  m_Father: {fileID: 0}
  m_RootOrder: 0
  m_LocalEulerAnglesHint: {x: -22.166, y: 15.373001, z: 0}
--- !u!1 &1892224931
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1892224935}
  - component: {fileID: 1892224934}
  - component: {fileID: 1892224933}
  - component: {fileID: 1892224932}
  m_Layer: 0
  m_Name: Sphere
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!135 &1892224932
SphereCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1892224931}
  m_Material: {fileID: 0}
  m_IsTrigger: 0
  m_Enabled: 1
  serializedVersion: 2
  m_Radius: 0.5
  m_Center: {x: 0, y: 0, z: 0}
--- !u!23 &1892224933
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1892224931}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
--- !u!33 &1892224934
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1892224931}
  m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
--- !u!4 &1892224935
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1892224931}
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 19.300419, y: 36.083687, z: -8.834281}
  m_LocalScale: {x: -1, y: -1, z: -1}
  m_Children: []
  m_Father: {fileID: 0}
  m_RootOrder: 3
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &2028565211
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2028565213}
  - component: {fileID: 2028565212}
  m_Layer: 0
  m_Name: Directional Light
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!108 &2028565212
Light:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2028565211}
  m_Enabled: 1
  serializedVersion: 10
  m_Type: 1
  m_Shape: 0
  m_Color: {r: 0.5849056, g: 0.5131719, b: 0.40557137, a: 1}
  m_Intensity: 1
  m_Range: 10
  m_SpotAngle: 30
  m_InnerSpotAngle: 21.802082
  m_CookieSize: 10
  m_Shadows:
    m_Type: 2
    m_Resolution: -1
    m_CustomResolution: -1
    m_Strength: 1
    m_Bias: 0.05
    m_NormalBias: 0.4
    m_NearPlane: 0.2
    m_CullingMatrixOverride:
      e00: 1
      e01: 0
      e02: 0
      e03: 0
      e10: 0
      e11: 1
      e12: 0
      e13: 0
      e20: 0
      e21: 0
      e22: 1
      e23: 0
      e30: 0
      e31: 0
      e32: 0
      e33: 1
    m_UseCullingMatrixOverride: 0
  m_Cookie: {fileID: 0}
  m_DrawHalo: 0
  m_Flare: {fileID: 0}
  m_RenderMode: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingLayerMask: 1
  m_Lightmapping: 4
  m_LightShadowCasterMode: 0
  m_AreaSize: {x: 1, y: 1}
  m_BounceIntensity: 1
  m_ColorTemperature: 6570
  m_UseColorTemperature: 0
  m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
  m_UseBoundingSphereOverride: 0
  m_ShadowRadius: 0
  m_ShadowAngle: 0
--- !u!4 &2028565213
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 2028565211}
  m_LocalRotation: {x: 0.93967164, y: 0.09617375, z: 0.02854668, w: 0.32703653}
  m_LocalPosition: {x: 0, y: 20.6, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_Children: []
  m_Father: {fileID: 0}
  m_RootOrder: 2
  m_LocalEulerAnglesHint: {x: -217.526, y: -1088.4509, z: -14.562988}



================================================
FILE: Assets/Customizable Skybox/Scenes/DemoScene.unity.meta
================================================
fileFormatVersion: 2
guid: 1811a0c822d2a6c45b5d1435bf7d07d2
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Scenes/DemoScene.unity
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials.meta
================================================
fileFormatVersion: 2
guid: 57832ac6c71e6b44ebdf2a754a4b62d4
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Shaders.meta
================================================
fileFormatVersion: 2
guid: a467af176e3ceba48899c668a09878d2
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day1.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day1
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0.177
    - _HorizonLineExponent: 4
    - _SkyGradientExponent: 2.5
    - _SunDiscContribution: 1
    - _SunDiscExponent: 125000
    - _SunDiscMultiplier: 25
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 125
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0.7921569, g: 0.870793, b: 0.90588236, a: 1}
    - _SkyGradientBottom: {r: 0.76470596, g: 0.81568635, b: 0.85098046, a: 1}
    - _SkyGradientTop: {r: 0.17254902, g: 0.5686275, b: 0.69411767, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.8980392, g: 0.83331764, b: 0.6666667, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day1.mat.meta
================================================
fileFormatVersion: 2
guid: 9aa8ed67591432941bb76f12eb23ff91
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day1.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day2.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day2
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 4
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscMultiplier: 100
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.7803922, g: 0.7912915, b: 0.8313726, a: 1}
    - _SkyGradientTop: {r: 0.45098042, g: 0.6509804, b: 0.7803922, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 1, g: 1, b: 1, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day2.mat.meta
================================================
fileFormatVersion: 2
guid: 5c80d49013691df48ac94280337e88ce
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day2.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day3.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day3
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 4
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscMultiplier: 100
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.64705884, g: 0.9180526, b: 1, a: 1}
    - _SkyGradientTop: {r: 0.098039225, g: 0.53333336, b: 0.9843138, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.3897059, g: 1, b: 0.89898604, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day3.mat.meta
================================================
fileFormatVersion: 2
guid: 56113b3b655ab7349bab4d7d405c258a
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day3.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day4.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day4
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_Parent: {fileID: 2100000, guid: bbe9494f815f3c340956427c884b72a0, type: 2}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Ints: []
    m_Floats:
    - _HorizonLineContribution: 1
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 7
    - _SunDiscExponent: 100
    - _SunDiscMultiplier: 100
    - _SunHaloContribution: 1
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.5222751, g: 0.76317495, b: 0.8455882, a: 1}
    - _SkyGradientTop: {r: 0.22352943, g: 0.6039216, b: 0.7294118, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.83823526, g: 0.9196754, b: 1, a: 1}
  m_BuildTextureStacks: []
  m_AllowLocking: 1



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day4.mat.meta
================================================
fileFormatVersion: 2
guid: 5c57bb9da366e944a8f4ae9be4f413ec
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day4.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day5.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day5
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_Parent: {fileID: 2100000, guid: 8fc56946a1b593c4d8e3e0e94483338e, type: 2}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Ints: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 3
    - _SunDiscExponent: 100000
    - _SunDiscMultiplier: 1000
    - _SunHaloExponent: 250
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.7058823, g: 1, b: 0.939148, a: 1}
    - _SkyGradientTop: {r: 0.043137237, g: 0.7294118, b: 0.7411765, a: 1}
    - _SunDiscColor: {r: 1, g: 0.9953347, b: 0.8308824, a: 1}
    - _SunHaloColor: {r: 1, g: 0.91379315, b: 0.63235295, a: 1}
  m_BuildTextureStacks: []
  m_AllowLocking: 1



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day5.mat.meta
================================================
fileFormatVersion: 2
guid: 6225fa8890cf025489e57d3aa1d87260
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day5.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day6.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day6
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: _DEBUG_FINAL _HALOBLENDMODE_ADD _HORIZONLINEBLENDMODE_ADD _SUNHALOBLENDMODE_ADD
    _VIEW_FINAL _VIEW_SKY _VIEW_SKYBACKGROUND
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _DEBUG: 0
    - _Float0: 40
    - _Float1: 0.23
    - _Float2: 5
    - _HaloBlendMode: 0
    - _HorizonLineBlendMode: 0
    - _HorizonLineContribution: 0.3
    - _HorizonLineExponent: 5.75
    - _SkyGradientExponent: 0.1
    - _Skyexp: 10.99
    - _SunDiscContribution: 1
    - _SunDiscExponent: 500000
    - _SunDiscExponentSize: 200000
    - _SunDiscMultiplier: 100000
    - _SunDiscMultiplierSharpness: 1000
    - _SunHaloBlendMode: 0
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 500
    - _Sunexp: 2000
    - _View: 0
    - __dirty: 0
    - _sunExponent: 500
    m_Colors:
    - _Color0: {r: 0.6321383, g: 1, b: 0.2971698, a: 1}
    - _Horizon: {r: 1, g: 0, b: 0.7466021, a: 1}
    - _HorizonLineColor: {r: 1, g: 1, b: 1, a: 1}
    - _Sky: {r: 1, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.4676485, g: 0.8453282, b: 0.8773585, a: 1}
    - _SkyGradientTop: {r: 0, g: 0.5633725, b: 0.8113207, a: 1}
    - _SubHorizonColor: {r: 0, g: 0, b: 0, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.9117647, g: 0.8648356, b: 0.7709775, a: 1}
    - _Sunhalocolor: {r: 1, g: 0, b: 0, a: 0}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day6.mat.meta
================================================
fileFormatVersion: 2
guid: bbbcd551076325545ba102ba8c308520
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day6.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day7.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Day7
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: _HORIZONLINEBLENDMODE_ADD _SUNHALOBLENDMODE_ADD _VIEW_FINAL
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineBlendMode: 0
    - _HorizonLineContribution: 1
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 1
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscExponentSize: 100000
    - _SunDiscMultiplier: 100000
    - _SunDiscMultiplierSharpness: 100000
    - _SunHaloBlendMode: 0
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 100
    - _View: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 0}
    - _SkyGradientBottom: {r: 0.9607844, g: 0.90196085, b: 0.7725491, a: 1}
    - _SkyGradientTop: {r: 0.90196085, g: 0.78823537, b: 0.58431375, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.7735849, g: 0.69111997, b: 0.62397647, a: 0}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Day7.mat.meta
================================================
fileFormatVersion: 2
guid: ddbcbb3899687ea469ed4a5fce1532df
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Day7.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning1.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Morning1
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 4
    - _SkyGradientExponent: 2.5
    - _SunDiscContribution: 1
    - _SunDiscExponent: 6250
    - _SunDiscMultiplier: 2
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 25
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.909804, g: 0.8431373, b: 0.76470596, a: 1}
    - _SkyGradientTop: {r: 0.7686275, g: 0.79215693, b: 0.8078432, a: 1}
    - _SunDiscColor: {r: 1, g: 0.96572006, b: 0.9044118, a: 1}
    - _SunHaloColor: {r: 1, g: 0.74264705, b: 0.81186616, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning1.mat.meta
================================================
fileFormatVersion: 2
guid: 8fc56946a1b593c4d8e3e0e94483338e
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Morning1.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning2.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Morning2
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 4
    - _SunDiscContribution: 1
    - _SunDiscExponent: 25000
    - _SunDiscMultiplier: 4
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.56078434, g: 0.61960787, b: 0.7019608, a: 1}
    - _SkyGradientTop: {r: 0.25490198, g: 0.4039216, b: 0.5568628, a: 1}
    - _SunDiscColor: {r: 1, g: 0.99239343, b: 0.8897059, a: 1}
    - _SunHaloColor: {r: 1, g: 0.8411765, b: 0.60294116, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning2.mat.meta
================================================
fileFormatVersion: 2
guid: 5464c15ff9c6ca04cb5790c1773e76fa
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Morning2.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning3.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Morning3
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 4
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscMultiplier: 100
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.9294118, g: 0.8705883, b: 0.85098046, a: 1}
    - _SkyGradientTop: {r: 0.6392157, g: 0.6862745, b: 0.7411765, a: 1}
    - _SunDiscColor: {r: 1, g: 0.8604463, b: 0.6838235, a: 1}
    - _SunHaloColor: {r: 1, g: 0.5841785, b: 0.2647059, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning3.mat.meta
================================================
fileFormatVersion: 2
guid: 022e71752654d3f4fa0cbe71b312ad20
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Morning3.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning4.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Morning4
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: _HORIZONLINEBLENDMODE_ADD _SUNHALOBLENDMODE_ADD _VIEW_FINAL
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineBlendMode: 0
    - _HorizonLineContribution: 1
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 1
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscExponentSize: 100000
    - _SunDiscMultiplier: 100000
    - _SunDiscMultiplierSharpness: 100000
    - _SunHaloBlendMode: 0
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 100
    - _View: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 0}
    - _SkyGradientBottom: {r: 0.9294118, g: 0.9176471, b: 0.89019614, a: 1}
    - _SkyGradientTop: {r: 0.9058824, g: 0.87843144, b: 0.8078432, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.7735849, g: 0.69111997, b: 0.62397647, a: 0}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Morning4.mat.meta
================================================
fileFormatVersion: 2
guid: c7a8e24b01cf73e4bad6eb3cb7d40acc
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Morning4.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night1.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Night1
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_Parent: {fileID: 2100000, guid: c7a8e24b01cf73e4bad6eb3cb7d40acc, type: 2}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Ints: []
    m_Floats:
    - _HorizonLineContribution: 0.56
    - _HorizonLineExponent: 4.86
    - _SkyGradientExponent: 2.5
    - _SunDiscExponent: 250000
    - _SunDiscMultiplier: 200
    - _SunHaloExponent: 50
    m_Colors:
    - _HorizonLineColor: {r: 1, g: 0.8150102, b: 0.64705884, a: 1}
    - _SkyGradientBottom: {r: 0.28654844, g: 0.66930693, b: 0.7352941, a: 1}
    - _SkyGradientTop: {r: 0.09411766, g: 0.11764707, b: 0.17254902, a: 1}
    - _SunDiscColor: {r: 1, g: 0.2352941, b: 0.2352941, a: 1}
    - _SunHaloColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
  m_AllowLocking: 1



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night1.mat.meta
================================================
fileFormatVersion: 2
guid: bbe9494f815f3c340956427c884b72a0
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Night1.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night2.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Night2
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0.182
    - _HorizonLineExponent: 4
    - _SkyGradientExponent: 2.5
    - _SunDiscContribution: 1
    - _SunDiscExponent: 249999.88
    - _SunDiscMultiplier: 2271.9
    - _SunHaloContribution: 0.587
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0.1021271, g: 0.8018868, b: 0.7241357, a: 1}
    - _SkyGradientBottom: {r: 0.082146674, g: 0.1536585, b: 0.24528301, a: 1}
    - _SkyGradientTop: {r: 0.17254902, g: 0.27058825, b: 0.43137258, a: 1}
    - _SunDiscColor: {r: 0.6431373, g: 0.8509804, b: 0.80990815, a: 1}
    - _SunHaloColor: {r: 0.14509805, g: 0.3764706, b: 0.32723585, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night2.mat.meta
================================================
fileFormatVersion: 2
guid: 52fcefd712182d743a781fde12426775
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Night2.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night3.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Night3
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0
    - _HorizonLineExponent: 1
    - _SkyGradientExponent: 2.5
    - _SunDiscContribution: 1
    - _SunDiscExponent: 250000
    - _SunDiscMultiplier: 500
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0, g: 0, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.3803922, g: 0.47450984, b: 0.6156863, a: 1}
    - _SkyGradientTop: {r: 0.1137255, g: 0.1764706, b: 0.26666668, a: 1}
    - _SunDiscColor: {r: 0.6286764, g: 0.7428499, b: 0.83823526, a: 1}
    - _SunHaloColor: {r: 0.4900519, g: 0.5582597, b: 0.75735295, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night3.mat.meta
================================================
fileFormatVersion: 2
guid: 135a7036ca1a07b4e9e162d80e6b6e77
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Night3.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night4.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Night4
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _HorizonLineContribution: 0.121
    - _HorizonLineExponent: 12.3
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SkyGradientExponent: 0.75
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _SunDiscContribution: 1
    - _SunDiscExponent: 250000
    - _SunDiscMultiplier: 500
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 500
    - _UVSec: 0
    - _ZWrite: 1
    - __dirty: 0
    m_Colors:
    - _Color: {r: 1, g: 1, b: 1, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
    - _HorizonLineColor: {r: 0.49729663, g: 0.9264706, b: 0.85543495, a: 0}
    - _SkyGradientBottom: {r: 0.12683824, g: 0.3133874, b: 0.375, a: 0}
    - _SkyGradientTop: {r: 0.027897932, g: 0.049892798, b: 0.08823531, a: 0}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 0.04757783, g: 0.8088235, b: 0.7143241, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Night4.mat.meta
================================================
fileFormatVersion: 2
guid: ed1387202b1349540a5d6464f0f27488
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Night4.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset1.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Sunset1
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0.84
    - _HorizonLineExponent: 5.24
    - _SkyGradientExponent: 8.32
    - _SunDiscContribution: 1
    - _SunDiscExponent: 20000
    - _SunDiscMultiplier: 5
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 100
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0.86764705, g: 0, b: 0.12565862, a: 1}
    - _SkyGradientBottom: {r: 0.8396226, g: 0.6131095, b: 0.5109024, a: 1}
    - _SkyGradientTop: {r: 0.10980392, g: 0.1609628, b: 0.2, a: 0}
    - _SunDiscColor: {r: 1, g: 0.7391862, b: 0.4009434, a: 1}
    - _SunHaloColor: {r: 1, g: 0.5481836, b: 0, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset1.mat.meta
================================================
fileFormatVersion: 2
guid: 2441c79940171dc43b33badf9fe97828
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset1.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset2.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Sunset2
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: 
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineContribution: 0.75
    - _HorizonLineExponent: 6
    - _SkyGradientExponent: 1
    - _SunDiscContribution: 1
    - _SunDiscExponent: 250000
    - _SunDiscMultiplier: 200
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 50
    - _Title: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 1, g: 0.062068965, b: 0, a: 1}
    - _SkyGradientBottom: {r: 0.09839968, g: 0.45069495, b: 0.6691177, a: 1}
    - _SkyGradientTop: {r: 0.06666667, g: 0.14509805, b: 0.27450982, a: 1}
    - _SunDiscColor: {r: 1, g: 0.56997967, b: 0.41176468, a: 1}
    - _SunHaloColor: {r: 1, g: 0.16911763, b: 0.16911763, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset2.mat.meta
================================================
fileFormatVersion: 2
guid: 528363c5c1cf6a7458140c6851c77b68
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset2.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset3.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Sunset3
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: _HORIZONLINEBLENDMODE_ADD _SUNHALOBLENDMODE_ADD _VIEW_FINAL
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _HorizonLineBlendMode: 0
    - _HorizonLineContribution: 1
    - _HorizonLineExponent: 30
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SkyGradientExponent: 0.5
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscExponentSize: 100000
    - _SunDiscMultiplier: 100000
    - _SunDiscMultiplierSharpness: 1000
    - _SunHaloBlendMode: 0
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 100
    - _UVSec: 0
    - _View: 0
    - _ZWrite: 1
    - __dirty: 0
    m_Colors:
    - _Color: {r: 1, g: 1, b: 1, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
    - _HorizonLineColor: {r: 1, g: 0.50885606, b: 0.23921567, a: 0.6}
    - _SkyGradientBottom: {r: 0.38431376, g: 0.13333334, b: 0.20392159, a: 1}
    - _SkyGradientTop: {r: 0, g: 0, b: 0, a: 1}
    - _SunDiscColor: {r: 1, g: 1, b: 1, a: 1}
    - _SunHaloColor: {r: 1, g: 0.37821245, b: 0.108490564, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset3.mat.meta
================================================
fileFormatVersion: 2
guid: 7ed994c1997814049b44c36a823bba6c
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset3.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset4.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Sunset4
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: _HORIZONLINEBLENDMODE_LERP _SUNHALOBLENDMODE_ADD _VIEW_FINAL
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineBlendMode: 1
    - _HorizonLineContribution: 0.36
    - _HorizonLineExponent: 15
    - _SkyGradientExponent: 0.25
    - _SunDiscContribution: 1
    - _SunDiscExponent: 5000
    - _SunDiscExponentSize: 12000
    - _SunDiscMultiplier: 500
    - _SunDiscMultiplierSharpness: 1200
    - _SunHaloBlendMode: 0
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 250
    - _View: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0.854902, g: 0.8267749, b: 0.77647066, a: 1}
    - _SkyGradientBottom: {r: 0.992647, g: 0.6458246, b: 0.51822007, a: 1}
    - _SkyGradientTop: {r: 0.23930442, g: 0.040116776, b: 0.38970587, a: 1}
    - _SunDiscColor: {r: 1, g: 0.9516228, b: 0.9338235, a: 1}
    - _SunHaloColor: {r: 0.9333334, g: 0.86274517, b: 0.81568635, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset4.mat.meta
================================================
fileFormatVersion: 2
guid: 20f6d22d93779de4ea6f62f8ab305593
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset4.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset5.mat
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 6
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Sunset5
  m_Shader: {fileID: 4800000, guid: eb3c6fb598ded4c71b8968e1c40a3b4d, type: 3}
  m_ShaderKeywords: _HORIZONLINEBLENDMODE_LERP _SUNHALOBLENDMODE_ADD _VIEW_FINAL
  m_LightmapFlags: 0
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs: []
    m_Floats:
    - _HorizonLineBlendMode: 1
    - _HorizonLineContribution: 0.32
    - _HorizonLineExponent: 5
    - _SkyGradientExponent: 0.25
    - _SunDiscContribution: 1
    - _SunDiscExponent: 100000
    - _SunDiscExponentSize: 12000
    - _SunDiscMultiplier: 100000
    - _SunDiscMultiplierSharpness: 1200
    - _SunHaloBlendMode: 0
    - _SunHaloContribution: 0.5
    - _SunHaloExponent: 250
    - _View: 0
    - __dirty: 0
    m_Colors:
    - _HorizonLineColor: {r: 0.854902, g: 0.77647066, b: 0.84705883, a: 0.8509804}
    - _SkyGradientBottom: {r: 0.48529404, g: 0.33542383, b: 0.48529404, a: 1}
    - _SkyGradientTop: {r: 0.23356402, g: 0.23682135, b: 0.7058823, a: 1}
    - _SunDiscColor: {r: 1, g: 0.94117653, b: 0.8705883, a: 1}
    - _SunHaloColor: {r: 1, g: 0.3737834, b: 0.09803921, a: 1}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset5.mat.meta
================================================
fileFormatVersion: 2
guid: baef7505b9e48404cb74585601f49ff9
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Materials/Sunset5.mat
  uploadId: 378796



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Shaders/Stylized Sky.shader
================================================
﻿Shader "Stylized/Sky"
{
    Properties
    {
        [Header(Sun Disc)]
        _SunDiscColor ("Color", Color) = (1, 1, 1, 1)
        _SunDiscMultiplier ("Multiplier", float) = 25
        _SunDiscExponent ("Exponent", float) = 125000

        [Header(Sun Halo)]
        _SunHaloColor ("Color", Color) = (0.8970588, 0.7760561, 0.6661981, 1)
        _SunHaloExponent ("Exponent", float) = 125
        _SunHaloContribution ("Contribution", Range(0, 1)) = 0.75

        [Header(Horizon Line)]
        _HorizonLineColor ("Color", Color) = (0.9044118, 0.8872592, 0.7913603, 1)
        _HorizonLineExponent ("Exponent", float) = 4
        _HorizonLineContribution ("Contribution", Range(0, 1)) = 0.25
        
        [Header(Sky Gradient)]
        _SkyGradientTop ("Top", Color) = (0.172549, 0.5686274, 0.6941177, 1)
        _SkyGradientBottom ("Bottom", Color) = (0.764706, 0.8156863, 0.8509805)
        _SkyGradientExponent ("Exponent", float) = 2.5
    }
    SubShader
    {
        Tags
        {
            "RenderType" = "Background"
            "Queue" = "Background"
        }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            
            float3 _SunDiscColor;
            float _SunDiscExponent;
            float _SunDiscMultiplier;

            float3 _SunHaloColor;
            float _SunHaloExponent;
            float _SunHaloContribution;

            float3 _HorizonLineColor;
            float _HorizonLineExponent;
            float _HorizonLineContribution;

            float3 _SkyGradientTop;
            float3 _SkyGradientBottom;
            float _SkyGradientExponent;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
                float3 worldPosition : TEXCOORD1;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.worldPosition = mul(unity_ObjectToWorld, v.vertex).xyz;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // Masks.
                float maskHorizon = dot(normalize(i.worldPosition), float3(0, 1, 0));
                float maskSunDir = dot(normalize(i.worldPosition), _WorldSpaceLightPos0.xyz);

                // Sun disc.
                float maskSun = pow(saturate(maskSunDir), _SunDiscExponent);
                maskSun = saturate(maskSun * _SunDiscMultiplier);

                // Sun halo.
                float3 sunHaloColor = _SunHaloColor * _SunHaloContribution;
                float bellCurve = pow(saturate(maskSunDir), _SunHaloExponent * saturate(abs(maskHorizon)));
                float horizonSoften = 1 - pow(1 - saturate(maskHorizon), 50);
                sunHaloColor *= saturate(bellCurve * horizonSoften);

                // Horizon line.
                float3 horizonLineColor = _HorizonLineColor * saturate(pow(1 - abs(maskHorizon), _HorizonLineExponent));
                horizonLineColor = lerp(0, horizonLineColor, _HorizonLineContribution);

                // Sky gradient.
                float3 skyGradientColor = lerp(_SkyGradientTop, _SkyGradientBottom, pow(1 - saturate(maskHorizon), _SkyGradientExponent));

                float3 finalColor = lerp(saturate(sunHaloColor + horizonLineColor + skyGradientColor), _SunDiscColor, maskSun);
                return float4(finalColor, 1);
            }
            ENDCG
        }
    }
}



================================================
FILE: Assets/Customizable Skybox/Stylized Sky/Shaders/Stylized Sky.shader.meta
================================================
fileFormatVersion: 2
guid: eb3c6fb598ded4c71b8968e1c40a3b4d
ShaderImporter:
  externalObjects: {}
  defaultTextures: []
  nonModifiableTextures: []
  userData: 
  assetBundleName: 
  assetBundleVariant: 
AssetOrigin:
  serializedVersion: 1
  productId: 174576
  packageName: Customizable skybox
  packageVersion: 1.0
  assetPath: Assets/Customizable Skybox/Stylized Sky/Shaders/Stylized Sky.shader
  uploadId: 378796



================================================
FILE: Assets/Models/Barrel_550verts.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/Barrel_550verts.fbx.meta
================================================
fileFormatVersion: 2
guid: f7af3d46bde553644a017f8665d4b25e
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/bean bag.fbx.meta
================================================
fileFormatVersion: 2
guid: 0c5a9cf7e1cefc243a6bcaea586f7220
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/InfosStand.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/InfosStand.fbx.meta
================================================
fileFormatVersion: 2
guid: e81b6efe553c87e4ea7948c4ceb85707
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/OfficeTable.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/OfficeTable.fbx.meta
================================================
fileFormatVersion: 2
guid: fdd52a9b77b1a6f4ba96b1b6c220a187
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/Pillow_130kVerts.fbx.meta
================================================
fileFormatVersion: 2
guid: 026d1e42c3a4de04db7a3e6050eafc09
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/Pillow_900verts.fbx.meta
================================================
fileFormatVersion: 2
guid: 46307e4dcec280e4ab0556f57b7503d8
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 0
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/SM_table.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/SM_table.fbx.meta
================================================
fileFormatVersion: 2
guid: 2e95f8db5e81c8448936326262fd9cb0
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/stone-chair.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/stone-chair.fbx.meta
================================================
fileFormatVersion: 2
guid: acf2d6ed4713be54e958edddb0db62a3
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/tab1.fbx.meta
================================================
fileFormatVersion: 2
guid: 4c36943f5b21ac241bcb28f9cd4bb10c
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/teapot.fbx.meta
================================================
fileFormatVersion: 2
guid: 348186d8b5e949549bb6403bc8a90c2f
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/Tire_23kVerts.fbx.meta
================================================
fileFormatVersion: 2
guid: 1bfb2b418b144f44eb2a81b73e0ec72c
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/Tire_400verts.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/Tire_400verts.fbx.meta
================================================
fileFormatVersion: 2
guid: 11258472ab518b74ab9ac1b788d0b2dc
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/trashCan.fbx
================================================
[Binary file]


================================================
FILE: Assets/Models/trashCan.fbx.meta
================================================
fileFormatVersion: 2
guid: 2285e4e2abc9a764e918dda9459d84d6
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 0
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Models/WOOD CHAIR1.fbx.meta
================================================
fileFormatVersion: 2
guid: f4fe0dda87f757e4ba31d7dd24a107c8
ModelImporter:
  serializedVersion: 22200
  internalIDToNameTable: []
  externalObjects: {}
  materials:
    materialImportMode: 2
    materialName: 0
    materialSearch: 1
    materialLocation: 1
  animations:
    legacyGenerateAnimations: 4
    bakeSimulation: 0
    resampleCurves: 1
    optimizeGameObjects: 0
    removeConstantScaleCurves: 0
    motionNodeName: 
    animationImportErrors: 
    animationImportWarnings: 
    animationRetargetingWarnings: 
    animationDoRetargetingWarnings: 0
    importAnimatedCustomProperties: 0
    importConstraints: 0
    animationCompression: 1
    animationRotationError: 0.5
    animationPositionError: 0.5
    animationScaleError: 0.5
    animationWrapMode: 0
    extraExposedTransformPaths: []
    extraUserProperties: []
    clipAnimations: []
    isReadable: 1
  meshes:
    lODScreenPercentages: []
    globalScale: 1
    meshCompression: 0
    addColliders: 0
    useSRGBMaterialColor: 1
    sortHierarchyByName: 1
    importPhysicalCameras: 1
    importVisibility: 1
    importBlendShapes: 1
    importCameras: 1
    importLights: 1
    nodeNameCollisionStrategy: 1
    fileIdsGeneration: 2
    swapUVChannels: 0
    generateSecondaryUV: 0
    useFileUnits: 1
    keepQuads: 0
    weldVertices: 1
    bakeAxisConversion: 0
    preserveHierarchy: 0
    skinWeightsMode: 0
    maxBonesPerVertex: 4
    minBoneWeight: 0.001
    optimizeBones: 1
    meshOptimizationFlags: -1
    indexFormat: 0
    secondaryUVAngleDistortion: 8
    secondaryUVAreaDistortion: 15.000001
    secondaryUVHardAngle: 88
    secondaryUVMarginMethod: 1
    secondaryUVMinLightmapResolution: 40
    secondaryUVMinObjectScale: 1
    secondaryUVPackMargin: 4
    useFileScale: 1
    strictVertexDataChecks: 0
  tangentSpace:
    normalSmoothAngle: 60
    normalImportMode: 0
    tangentImportMode: 3
    normalCalculationMode: 4
    legacyComputeAllNormalsFromSmoothingGroupsWhenMeshHasBlendShapes: 0
    blendShapeNormalImportMode: 1
    normalSmoothingSource: 0
  referencedClips: []
  importAnimation: 1
  humanDescription:
    serializedVersion: 3
    human: []
    skeleton: []
    armTwist: 0.5
    foreArmTwist: 0.5
    upperLegTwist: 0.5
    legTwist: 0.5
    armStretch: 0.05
    legStretch: 0.05
    feetSpacing: 0
    globalScale: 1
    rootMotionBoneName: 
    hasTranslationDoF: 0
    hasExtraRoot: 0
    skeletonHasParents: 1
  lastHumanDescriptionAvatarSource: {instanceID: 0}
  autoGenerateAvatarMappingIfUnspecified: 1
  animationType: 2
  humanoidOversampling: 1
  avatarSetup: 0
  addHumanoidExtraRootOnlyWhenUsingAvatar: 1
  importBlendShapeDeformPercent: 1
  remapMaterialsIfMaterialImportModeIsNone: 0
  additionalBone: 0
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Prefabs/BadShape.meta
================================================
fileFormatVersion: 2
guid: 752e0148f57bead4daf7a0af0eaba9f2
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant: 



================================================
FILE: Assets/Prefabs/Ground.prefab
================================================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &8686148080936043720
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6498241727434720564}
  - component: {fileID: 2836007940660597269}
  - component: {fileID: 1362088290540641496}
  - component: {fileID: 2122792122582418993}
  - component: {fileID: 1452536502602628609}
  m_Layer: 0
  m_Name: Ground
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6498241727434720564
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8686148080936043720}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 7.5965567, y: 0, z: -1.103136}
  m_LocalScale: {x: 1.5, y: 1, z: 1.5}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!33 &2836007940660597269
MeshFilter:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8686148080936043720}
  m_Mesh: {fileID: 10209, guid: 0000000000000000e000000000000000, type: 0}
--- !u!23 &1362088290540641496
MeshRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8686148080936043720}
  m_Enabled: 1
  m_CastShadows: 1
  m_ReceiveShadows: 1
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 1
  m_ReflectionProbeUsage: 1
  m_RayTracingMode: 2
  m_RayTraceProcedural: 0
  m_RayTracingAccelStructBuildFlagsOverride: 0
  m_RayTracingAccelStructBuildFlags: 1
  m_SmallMeshCulling: 1
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {fileID: 2100000, guid: 98eef98fc146d364385915854b07d1f9, type: 2}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {fileID: 0}
  m_ProbeAnchor: {fileID: 0}
  m_LightProbeVolumeOverride: {fileID: 0}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 3
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {fileID: 0}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: 0
  m_AdditionalVertexStreams: {fileID: 0}
--- !u!64 &2122792122582418993
MeshCollider:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8686148080936043720}
  m_Material: {fileID: 0}
  m_IncludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_ExcludeLayers:
    serializedVersion: 2
    m_Bits: 0
  m_LayerOverridePriority: 0
  m_IsTrigger: 0
  m_ProvidesContacts: 0
  m_Enabled: 0
  serializedVersion: 5
  m_Convex: 0
  m_CookingOptions: 30
  m_Mesh: {fileID: 10209, guid: 0000000000000000e000000000000000, type: 0}
--- !u!114 &1452536502602628609
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8686148080936043720}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: a589c91c96a44524590d38d46b660123, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  materialType: 0
  K_Value: 0
  M_Value: 0.1
  Damping_Value: 0
  StiffnessFactor_Value: 0
  PlasticThreshold_Value: 0
  DragCoefficient: 0
  FrictionCoefficient: 0
  "\u03B3": 0
  isGround: 1
  voxelizer: {fileID: 0}
  points: []
  mesh: {fileID: 0}



================================================
FILE: Assets/Prefabs/Ground.prefab.meta
================================================
fileFormatVersion: 2
guid: 9ea6cdd877e5fa64fbe9c4f1e00067dc
PrefabImporter:
  externalObjects: {}
  us
