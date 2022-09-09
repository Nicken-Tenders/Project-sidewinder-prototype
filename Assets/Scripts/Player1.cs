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
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0a8ebe4d-a864-489f-beb8-070876726b4e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LP"",
                    ""type"": ""Button"",
                    ""id"": ""5319bc47-1074-4d58-bae1-e4586c660db8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HP"",
                    ""type"": ""Button"",
                    ""id"": ""f48ef7e5-4ed1-4523-a9f3-a8a7b0446e46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LK"",
                    ""type"": ""Button"",
                    ""id"": ""524c4cbd-4ad4-4f7e-8e3b-436c2a9c0acb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HK"",
                    ""type"": ""Button"",
                    ""id"": ""f8fe335f-063c-45a3-9513-1f6527344c53"",
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
                    ""name"": """",
                    ""id"": ""bd359115-2361-47ab-82e7-42727388fb0a"",
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
                    ""id"": ""71e272c5-d50f-42cd-979a-63f59be7686d"",
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
                    ""id"": ""7290ea83-c49f-4c5c-9185-7fc059a6fbba"",
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
                    ""id"": ""650122b4-98ba-43c5-b55a-f55a76490ba1"",
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
                    ""id"": ""8dd5e2bd-5bcf-4fe7-b318-2fbaf1130428"",
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
                    ""id"": ""fbd1f8a3-409a-4326-a968-0dbe1240dd4e"",
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
                    ""id"": ""ce67d2fa-2b33-4737-a9a3-403ac4511d5b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8318eee9-db0c-4e97-9fa7-4d9e53708d62"",
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
                    ""id"": ""62fd8d78-7b29-4e18-aaf3-823be29134ed"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""fbded3c9-d1fa-4dd6-a2bf-69da0324e49f"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""313198c1-29a3-48db-b5f2-10c7fe22dba8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4c84be6d-16ab-462a-a546-d9de4aeda96c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""31601811-b483-4fb3-ba1a-8cef5f823e27"",
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
                    ""id"": ""1fca491f-eaf8-4f9c-b66a-1aeb9748bcc8"",
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
                    ""id"": ""aefd4fad-adfe-4b24-bc84-ec7c86d9f16c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Pad"",
                    ""id"": ""bc4e9fc4-c7a3-4ca8-8c6b-f85ab70aa619"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""309fd972-9ee4-4133-85c9-fbe07f0df05e"",
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
                    ""id"": ""e7d48825-6981-4645-9824-81dfe168c7a5"",
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
                    ""id"": ""3e76f891-6c73-4630-9edc-d7d90b35a4c9"",
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
                    ""id"": ""ba437847-d6b3-4865-acbf-d3a92a2126ee"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""id"": ""3352e648-4121-4e87-ab80-0eeb4fc16cd9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                    ""name"": ""Walk & Dash"",
                    ""type"": ""Value"",
                    ""id"": ""5a91022f-a65a-4906-994a-bf207d2a1216"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""900d42b7-c3f6-48cf-b0f0-18d40f65a880"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6aa3b503-6b04-4727-bc8a-137e3a2a55c3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c24a13da-2979-447d-9557-b7e8d754639b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""23c2d044-e84a-487e-9bb4-977c14b98d2d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c04700c9-f118-4a99-aede-768faf105cc4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dddfbb52-ba97-4ec1-a6ed-7e621a9e7342"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""L-Stick"",
                    ""id"": ""790ad449-2a3b-45f2-a3f9-858aa36c1fab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e0ba97d7-a27d-425e-aa90-900d5f07fc34"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2638baac-a693-4641-b6b9-e5fafe62a834"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk & Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Battle
        m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
        m_Battle_Movement = m_Battle.FindAction("Movement", throwIfNotFound: true);
        m_Battle_LP = m_Battle.FindAction("LP", throwIfNotFound: true);
        m_Battle_HP = m_Battle.FindAction("HP", throwIfNotFound: true);
        m_Battle_LK = m_Battle.FindAction("LK", throwIfNotFound: true);
        m_Battle_HK = m_Battle.FindAction("HK", throwIfNotFound: true);
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
        m_Temp_WalkDash = m_Temp.FindAction("Walk & Dash", throwIfNotFound: true);
        m_Temp_Crouch = m_Temp.FindAction("Crouch", throwIfNotFound: true);
        m_Temp_Jump = m_Temp.FindAction("Jump", throwIfNotFound: true);
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
    private readonly InputAction m_Battle_Movement;
    private readonly InputAction m_Battle_LP;
    private readonly InputAction m_Battle_HP;
    private readonly InputAction m_Battle_LK;
    private readonly InputAction m_Battle_HK;
    private readonly InputAction m_Battle_Pause;
    public struct BattleActions
    {
        private @Player1 m_Wrapper;
        public BattleActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Battle_Movement;
        public InputAction @LP => m_Wrapper.m_Battle_LP;
        public InputAction @HP => m_Wrapper.m_Battle_HP;
        public InputAction @LK => m_Wrapper.m_Battle_LK;
        public InputAction @HK => m_Wrapper.m_Battle_HK;
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
                @Movement.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnMovement;
                @LP.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnLP;
                @LP.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnLP;
                @LP.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnLP;
                @HP.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnHP;
                @HP.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnHP;
                @HP.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnHP;
                @LK.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnLK;
                @LK.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnLK;
                @LK.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnLK;
                @HK.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnHK;
                @HK.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnHK;
                @HK.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnHK;
                @Pause.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @LP.started += instance.OnLP;
                @LP.performed += instance.OnLP;
                @LP.canceled += instance.OnLP;
                @HP.started += instance.OnHP;
                @HP.performed += instance.OnHP;
                @HP.canceled += instance.OnHP;
                @LK.started += instance.OnLK;
                @LK.performed += instance.OnLK;
                @LK.canceled += instance.OnLK;
                @HK.started += instance.OnHK;
                @HK.performed += instance.OnHK;
                @HK.canceled += instance.OnHK;
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
    private readonly InputAction m_Temp_WalkDash;
    private readonly InputAction m_Temp_Crouch;
    private readonly InputAction m_Temp_Jump;
    public struct TempActions
    {
        private @Player1 m_Wrapper;
        public TempActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @WalkDash => m_Wrapper.m_Temp_WalkDash;
        public InputAction @Crouch => m_Wrapper.m_Temp_Crouch;
        public InputAction @Jump => m_Wrapper.m_Temp_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Temp; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TempActions set) { return set.Get(); }
        public void SetCallbacks(ITempActions instance)
        {
            if (m_Wrapper.m_TempActionsCallbackInterface != null)
            {
                @WalkDash.started -= m_Wrapper.m_TempActionsCallbackInterface.OnWalkDash;
                @WalkDash.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnWalkDash;
                @WalkDash.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnWalkDash;
                @Crouch.started -= m_Wrapper.m_TempActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_TempActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WalkDash.started += instance.OnWalkDash;
                @WalkDash.performed += instance.OnWalkDash;
                @WalkDash.canceled += instance.OnWalkDash;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public TempActions @Temp => new TempActions(this);
    public interface IBattleActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLP(InputAction.CallbackContext context);
        void OnHP(InputAction.CallbackContext context);
        void OnLK(InputAction.CallbackContext context);
        void OnHK(InputAction.CallbackContext context);
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
        void OnWalkDash(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
