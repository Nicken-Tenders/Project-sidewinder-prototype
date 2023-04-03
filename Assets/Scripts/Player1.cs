// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player1.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player1 : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1"",
    ""maps"": [
        {
            ""name"": ""Battle"",
            ""id"": ""56378b1f-5e75-45bf-8ef3-7c2b505ac446"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""0a8ebe4d-a864-489f-beb8-070876726b4e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Value"",
                    ""id"": ""0f6a9d82-ce0a-4b42-b9bb-bbf225d184ac"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9d756553-2f78-4338-896b-65179a80216c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""5c68f1d9-9abe-493a-8651-f34a05d5f377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""7bda990d-edec-41be-abcf-0710c7149c1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""fbb9b4ce-ec93-4001-8db0-041ba903a54d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""90781cf4-acde-4abe-9114-c257e4e57c2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fbded3c9-d1fa-4dd6-a2bf-69da0324e49f"",
                    ""path"": ""1DAxis(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""1fca491f-eaf8-4f9c-b66a-1aeb9748bcc8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""aefd4fad-adfe-4b24-bc84-ec7c86d9f16c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Pad"",
                    ""id"": ""bc4e9fc4-c7a3-4ca8-8c6b-f85ab70aa619"",
                    ""path"": ""1DAxis(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""3e76f891-6c73-4630-9edc-d7d90b35a4c9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8d1a7f8d-15fc-45b6-99d1-91b3438dd1ef"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""59dd847e-7ce5-406b-9d4f-12a3bf3cc600"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""21edb583-50db-4556-a608-b226f6bd2761"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3352e648-4121-4e87-ab80-0eeb4fc16cd9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a987bd3c-4f1d-428b-ad4b-765fd382bd25"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af6eef9c-8bb3-4e23-b2ff-4c3337c3d193"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61ad3a55-b60c-45b4-811a-76652d36ba18"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b30661f7-335c-4f97-89da-7cbaf7db2c3e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e068bf11-80f2-4649-b277-2815ef7ca5d9"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b50e340d-eed5-4fc6-9f7d-73f2b08a2e20"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""feb40c70-082b-49f3-8c05-19261fb18245"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a2f0551-968f-4eec-9a81-d294594b25a4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28afa8ac-26b6-4cb7-b2fb-08698d89a0dd"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4478642-b54a-44f0-bd8d-ede2133d2295"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e857d18-1409-44df-bfc7-259338261e97"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fbb824b-9eac-4446-b332-09f5dfb5a0bc"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c35e6853-ece3-4895-9063-cbb6e0c4083f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""3abbfa8d-9b48-4811-9a98-914540c22b4a"",
                    ""path"": ""1DAxis(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""55120921-692b-472b-9056-565d00a3a659"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""430cd43e-6271-49a0-a3df-dd2e59e31a44"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Pad"",
                    ""id"": ""91601ec2-9dfc-4ddf-af5c-15d20806dc74"",
                    ""path"": ""1DAxis(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""a84d090a-b6d9-4a7e-a5c2-6f1463090e70"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a1447d7d-d1d4-45a5-9354-c45a17c4530f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0c65b2fe-62e8-4430-94f9-4946b3c10540"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""2897a15d-b1bd-466c-b81f-61a53fbaac77"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""39338138-874c-4dbf-b252-484192ac574d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9c63455b-e7b1-4b94-bc1f-340f5773727c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ee703171-1e25-450d-bd8d-d4a1a715b96d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2cd07fc0-7c75-4674-927b-20a084f26e07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Function 1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fdc3e60a-af80-4848-a30a-c9be98c757ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Function 2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""12388e54-94a8-4e9b-96e4-c1f86b9b1016"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""55c0f84e-2bc9-468c-b81c-891e51b6b5ff"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ec76612-effe-4f80-8cc8-4c5f15aaf386"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee7104b7-092c-4c75-b992-6e00e70afbe4"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1066c548-ea9d-4603-ba87-c0d3168c5167"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9f6c6fa-de8f-483c-ad5d-a24d6a15366e"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Function 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a1c79aa-9fc4-4b68-81f9-965394c5cca4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Function 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""077ad00a-498e-400d-8e64-0d6fd7d6628c"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Function 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""280f88e2-be58-454a-a24b-e27da67fdfd4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Function 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""98b07453-f057-4cb8-b939-1ebc87e8b35d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb42ae1e-202e-42c8-9b91-a4b2111075ca"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d4ab810b-e92b-4dfa-a5c6-ac426deafa55"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""897793d4-d5cc-4070-afd5-609862c6e004"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a3d7db71-506f-4d3f-a96a-636be17802a0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""159d62be-d577-4a01-b657-392d82581462"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4424646c-a718-4bbd-a76a-fe9a81d7927d"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d4f45366-08e4-49ff-b091-d6953c43d663"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""42da0ecb-d1df-4b8a-80ae-4bc0259201a1"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a4ad8398-bbcc-48e6-91ce-1e5aa932e441"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""L-Stick"",
                    ""id"": ""9f23fa34-62c0-4a30-9464-524e281f50c0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50d4ffb1-7104-4361-8556-bc8c773e81ae"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c6d4b944-22db-462b-9021-6547007be7c3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""35033e27-7c4d-4097-8eeb-92227ef062fa"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e95075bb-455a-421a-a671-04be55b93955"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI1"",
            ""id"": ""32b74729-9ef3-496e-ab93-096bd10b8908"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""daa9f5a0-a156-4841-a2bd-3a5e06baef12"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""ec96c698-4530-4160-bb49-684c5a1961eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""d9d1eafa-6cc5-4d2f-a964-a22bc0545313"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""84c5701e-4b87-496d-9823-a56ebce40cb4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""763d9b9c-a38c-41d4-8f6b-137e00071d53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""12765d38-4d50-4448-9239-6615a62d9fd2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a5589d62-b5b7-470a-9fa7-babb4b4c8838"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ac9ae99c-8841-4d9e-a707-13d8909aad02"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ed1a05a-f596-4742-b3fb-8ae9760b79f9"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f7b0880-04eb-4925-805f-820d17967de7"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""ed1e1b4f-6516-4966-8890-0e397f41e7b6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""38458e88-4d5d-4046-b46e-ff6ff1a35514"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""96a6e5fa-97f7-4039-8cc4-353bcbd63c00"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc74c05d-e362-485c-8dde-23d9f2520b83"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3e1bd76c-93f9-4354-bb06-c1ffc48284f5"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""672019d8-0c3c-47f3-bbdd-e9d86a13783c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0acc17df-4a9c-43e3-95f4-83b802ef7880"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b3bacfaf-dff8-4d97-812c-991eb3a0d0d4"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fac7a151-f5dd-46c4-bc3f-61afc4c18be3"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1781f140-8149-4b38-a799-0031d0d36afc"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""814c82c2-c4b7-4234-85a3-cea43f8339a8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8dee5285-6563-4d92-97db-77f956cfb1c9"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c6be4401-b12d-4314-a52b-b8bda0eb6de1"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aa422e65-244b-410b-a6ff-d3c7555bfecf"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8dcf1e05-a817-49fa-885b-3af065a2b622"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""f59605ba-ece0-4a77-b2cc-378e23f00fa9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9483998c-9c3b-43e3-9ae3-82234c30035c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0436b468-8dad-418e-aa42-ccdc516f34c2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""50d9cd6a-c5e4-4fab-8a94-8d6ab0b96982"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eec9a00c-ebc0-46ae-9307-b2b1de102315"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""daac1ca7-cb7b-4ea4-a4cb-d19ad0515471"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b24c7096-4dcb-4592-a5bf-4b0d1a073b6b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""331acbcc-36ba-479d-80b7-a1c18876fb45"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4d0203bb-cac0-4e7c-a133-d9cb810a332f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""976fe1eb-2631-46e8-a424-39f79384dc5f"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd5df569-3b70-48fd-a422-be3dcf32b3c7"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16eeca86-cb8d-4e76-9807-374598ce2625"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7e49921-1888-4cdc-a67a-e2bb8cb2bdf4"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""443ccc04-083b-4a70-be66-0b5b1bbd7f30"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cad784b3-b4db-4d3c-b78b-70bbe300b87a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7685783-fed9-4fd7-977c-9c5a657d7d69"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a12ec233-346a-4aed-b9b0-5319cab09307"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98c379bd-ff50-40fd-8e01-001bebbfa82e"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3290935c-fda2-4079-be76-42924e927f9d"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e530a3f1-dd00-418f-a916-8d6ca01be911"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eebc4c18-75bb-434f-ab5b-3d496f5a388e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b984e230-155e-422d-b5bb-c5c4a7015f01"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70a7e5df-926c-4545-9203-e2d62a8f0a6c"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Temp"",
            ""id"": ""68581389-477b-456a-89c2-5cf5d525bd15"",
            ""actions"": [
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""2ef28f83-4e66-4758-9a20-94979333d379"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""9900364b-372b-4df9-83a8-a34bd0002be6"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HK"",
                    ""type"": ""Button"",
                    ""id"": ""8f6fbb83-af78-4248-9d39-abdedc0f6032"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LP"",
                    ""type"": ""Button"",
                    ""id"": ""d57ead66-4a0e-4e4c-a6df-4d6a436f2c5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HP"",
                    ""type"": ""Button"",
                    ""id"": ""da25d20c-8c70-4cc2-961d-657ff1ee27f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LK"",
                    ""type"": ""Button"",
                    ""id"": ""ecb76f6d-10f2-4f57-950a-caf4a5b87f39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""13c20e82-29b6-4517-8ee8-5867c4cdf703"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b762458-b63b-4db0-b011-b9ee59653250"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1441845e-35f0-448b-84dd-a8a427380709"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c1f8f33-e74c-48ce-aaed-40fe3213ace2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c02a8d4d-cbb3-4375-9e3a-33b31b4c0901"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""371766e5-9c48-4cc4-b5f7-3a7f79bf6c65"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be336d08-951b-4286-8fa8-afe35aa5b1e8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56873c8a-d4bb-4e95-bf48-1f4ca812decc"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57223f10-075b-4cf8-a4b7-5b617ffdfa74"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1df81c2-29ff-4b4c-9cf7-8e14de3c5388"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""316bcf69-fc77-4df7-bcec-20d9552ca167"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a39bf08-e0fb-4a3e-b1ea-2369f3ea4925"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9447b1bb-fa16-4dc1-906c-964e45e8faaa"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""606e8f3e-51cc-4dc8-b94b-e0adcc1a4a44"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6e6b458-b331-4328-af30-bfdd5b8b3098"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec37f0f0-1093-4ec9-afd8-e9f3a5037292"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Battle
        m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
        m_Battle_Walk = m_Battle.FindAction("Walk", throwIfNotFound: true);
        m_Battle_Dash = m_Battle.FindAction("Dash", throwIfNotFound: true);
        m_Battle_Jump = m_Battle.FindAction("Jump", throwIfNotFound: true);
        m_Battle_Crouch = m_Battle.FindAction("Crouch", throwIfNotFound: true);
        m_Battle_A = m_Battle.FindAction("A", throwIfNotFound: true);
        m_Battle_B = m_Battle.FindAction("B", throwIfNotFound: true);
        m_Battle_Pause = m_Battle.FindAction("Pause", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Movement = m_UI.FindAction("Movement", throwIfNotFound: true);
        m_UI_Accept = m_UI.FindAction("Accept", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Function1 = m_UI.FindAction("Function 1", throwIfNotFound: true);
        m_UI_Function2 = m_UI.FindAction("Function 2", throwIfNotFound: true);
        // UI1
        m_UI1 = asset.FindActionMap("UI1", throwIfNotFound: true);
        m_UI1_Navigate = m_UI1.FindAction("Navigate", throwIfNotFound: true);
        m_UI1_Submit = m_UI1.FindAction("Submit", throwIfNotFound: true);
        m_UI1_Cancel = m_UI1.FindAction("Cancel", throwIfNotFound: true);
        m_UI1_Point = m_UI1.FindAction("Point", throwIfNotFound: true);
        m_UI1_Click = m_UI1.FindAction("Click", throwIfNotFound: true);
        m_UI1_ScrollWheel = m_UI1.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI1_MiddleClick = m_UI1.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI1_RightClick = m_UI1.FindAction("RightClick", throwIfNotFound: true);
        m_UI1_TrackedDevicePosition = m_UI1.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI1_TrackedDeviceOrientation = m_UI1.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        // Temp
        m_Temp = asset.FindActionMap("Temp", throwIfNotFound: true);
        m_Temp_Crouch = m_Temp.FindAction("Crouch", throwIfNotFound: true);
        m_Temp_Jump = m_Temp.FindAction("Jump", throwIfNotFound: true);
        m_Temp_HK = m_Temp.FindAction("HK", throwIfNotFound: true);
        m_Temp_LP = m_Temp.FindAction("LP", throwIfNotFound: true);
        m_Temp_HP = m_Temp.FindAction("HP", throwIfNotFound: true);
        m_Temp_LK = m_Temp.FindAction("LK", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Battle
    private readonly InputActionMap m_Battle;
    private IBattleActions m_BattleActionsCallbackInterface;
    private readonly InputAction m_Battle_Walk;
    private readonly InputAction m_Battle_Dash;
    private readonly InputAction m_Battle_Jump;
    private readonly InputAction m_Battle_Crouch;
    private readonly InputAction m_Battle_A;
    private readonly InputAction m_Battle_B;
    private readonly InputAction m_Battle_Pause;
    public struct BattleActions
    {
        private @Player1 m_Wrapper;
        public BattleActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Battle_Walk;
        public InputAction @Dash => m_Wrapper.m_Battle_Dash;
        public InputAction @Jump => m_Wrapper.m_Battle_Jump;
        public InputAction @Crouch => m_Wrapper.m_Battle_Crouch;
        public InputAction @A => m_Wrapper.m_Battle_A;
        public InputAction @B => m_Wrapper.m_Battle_B;
        public InputAction @Pause => m_Wrapper.m_Battle_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
        public void SetCallbacks(IBattleActions instance)
        {
            if (m_Wrapper.m_BattleActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnWalk;
                @Dash.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnDash;
                @Jump.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnCrouch;
                @A.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnB;
                @Pause.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public BattleActions @Battle => new BattleActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Movement;
    private readonly InputAction m_UI_Accept;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Function1;
    private readonly InputAction m_UI_Function2;
    public struct UIActions
    {
        private @Player1 m_Wrapper;
        public UIActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_UI_Movement;
        public InputAction @Accept => m_Wrapper.m_UI_Accept;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Function1 => m_Wrapper.m_UI_Function1;
        public InputAction @Function2 => m_Wrapper.m_UI_Function2;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMovement;
                @Accept.started -= m_Wrapper.m_UIActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnAccept;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Function1.started -= m_Wrapper.m_UIActionsCallbackInterface.OnFunction1;
                @Function1.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnFunction1;
                @Function1.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnFunction1;
                @Function2.started -= m_Wrapper.m_UIActionsCallbackInterface.OnFunction2;
                @Function2.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnFunction2;
                @Function2.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnFunction2;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Function1.started += instance.OnFunction1;
                @Function1.performed += instance.OnFunction1;
                @Function1.canceled += instance.OnFunction1;
                @Function2.started += instance.OnFunction2;
                @Function2.performed += instance.OnFunction2;
                @Function2.canceled += instance.OnFunction2;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // UI1
    private readonly InputActionMap m_UI1;
    private IUI1Actions m_UI1ActionsCallbackInterface;
    private readonly InputAction m_UI1_Navigate;
    private readonly InputAction m_UI1_Submit;
    private readonly InputAction m_UI1_Cancel;
    private readonly InputAction m_UI1_Point;
    private readonly InputAction m_UI1_Click;
    private readonly InputAction m_UI1_ScrollWheel;
    private readonly InputAction m_UI1_MiddleClick;
    private readonly InputAction m_UI1_RightClick;
    private readonly InputAction m_UI1_TrackedDevicePosition;
    private readonly InputAction m_UI1_TrackedDeviceOrientation;
    public struct UI1Actions
    {
        private @Player1 m_Wrapper;
        public UI1Actions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI1_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI1_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI1_Cancel;
        public InputAction @Point => m_Wrapper.m_UI1_Point;
        public InputAction @Click => m_Wrapper.m_UI1_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI1_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI1_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI1_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI1_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI1_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UI1Actions set) { return set.Get(); }
        public void SetCallbacks(IUI1Actions instance)
        {
            if (m_Wrapper.m_UI1ActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UI1ActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UI1ActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UI1ActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UI1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UI1Actions @UI1 => new UI1Actions(this);

    // Temp
    private readonly InputActionMap m_Temp;
    private ITempActions m_TempActionsCallbackInterface;
    private readonly InputAction m_Temp_Crouch;
    private readonly InputAction m_Temp_Jump;
    private readonly InputAction m_Temp_HK;
    private readonly InputAction m_Temp_LP;
    private readonly InputAction m_Temp_HP;
    private readonly InputAction m_Temp_LK;
    public struct TempActions
    {
        private @Player1 m_Wrapper;
        public TempActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Crouch => m_Wrapper.m_Temp_Crouch;
        public InputAction @Jump => m_Wrapper.m_Temp_Jump;
        public InputAction @HK => m_Wrapper.m_Temp_HK;
        public InputAction @LP => m_Wrapper.m_Temp_LP;
        public InputAction @HP => m_Wrapper.m_Temp_HP;
        public InputAction @LK => m_Wrapper.m_Temp_LK;
        public InputActionMap Get() { return m_Wrapper.m_Temp; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TempActions set) { return set.Get(); }
        public void SetCallbacks(ITempActions instance)
        {
            if (m_Wrapper.m_TempActionsCallbackInterface != null)
            {
                @Crouch.started -= m_Wrapper.m_TempActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @HK.started -= m_Wrapper.m_TempActionsCallbackInterface.OnHK;
                @HK.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnHK;
                @HK.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnHK;
                @LP.started -= m_Wrapper.m_TempActionsCallbackInterface.OnLP;
                @LP.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnLP;
                @LP.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnLP;
                @HP.started -= m_Wrapper.m_TempActionsCallbackInterface.OnHP;
                @HP.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnHP;
                @HP.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnHP;
                @LK.started -= m_Wrapper.m_TempActionsCallbackInterface.OnLK;
                @LK.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnLK;
                @LK.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnLK;
            }
            m_Wrapper.m_TempActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @HK.started += instance.OnHK;
                @HK.performed += instance.OnHK;
                @HK.canceled += instance.OnHK;
                @LP.started += instance.OnLP;
                @LP.performed += instance.OnLP;
                @LP.canceled += instance.OnLP;
                @HP.started += instance.OnHP;
                @HP.performed += instance.OnHP;
                @HP.canceled += instance.OnHP;
                @LK.started += instance.OnLK;
                @LK.performed += instance.OnLK;
                @LK.canceled += instance.OnLK;
            }
        }
    }
    public TempActions @Temp => new TempActions(this);
    public interface IBattleActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnFunction1(InputAction.CallbackContext context);
        void OnFunction2(InputAction.CallbackContext context);
    }
    public interface IUI1Actions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
    public interface ITempActions
    {
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHK(InputAction.CallbackContext context);
        void OnLP(InputAction.CallbackContext context);
        void OnHP(InputAction.CallbackContext context);
        void OnLK(InputAction.CallbackContext context);
    }
}
