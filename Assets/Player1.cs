// GENERATED AUTOMATICALLY FROM 'Assets/Player1.inputactions'

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
                    ""name"": ""Walk & Dash"",
                    ""type"": ""Value"",
                    ""id"": ""141fbf86-0d1a-4246-b130-aff4dd48dc28"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""565988ea-a7fc-48e7-9c0b-ce5e91f393b6"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""125a7705-a548-4df2-8a09-6dc33919a61a"",
                    ""expectedControlType"": ""Digital"",
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
                    ""id"": ""26caf0d5-6e5f-423f-8269-f12f6eeafbd2"",
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
                    ""id"": ""7615b707-386d-48d3-8c42-20cce3520b8c"",
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
                    ""id"": ""1e36db39-36cb-4756-9039-12593f6ac116"",
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
                    ""id"": ""ad9354c0-20b8-4c16-aab4-e579b2b6e744"",
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
                    ""id"": ""5528643e-63da-4a48-98bc-ffe5ff8914c4"",
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
                    ""id"": ""049092ed-d3f4-4d56-8d67-baf8a3eaceb4"",
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
                    ""id"": ""605a9e2e-97cd-41c4-b625-fc53fca09f5c"",
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
                    ""id"": ""2779a4e0-b4fa-4fb4-a0da-864fb297a021"",
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
                    ""id"": ""69b9da69-a213-4ee1-8ef8-97c30fc810ca"",
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
                    ""id"": ""b614c07d-b23c-4bca-993b-ae78634e6b3f"",
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
                    ""id"": ""303ffe3f-097f-4df2-b8a1-b62e1edf1fce"",
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
                    ""id"": ""26bed68d-7231-4b83-93c6-192bb2e15019"",
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
                    ""id"": ""affd23ec-988e-4083-9c7f-ce5b58563e0f"",
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
                    ""id"": ""3ffc314b-9ec2-4a86-934a-926db2439f86"",
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
                    ""id"": ""bcb6a7fb-d56d-4beb-abf8-3a6813f7ac22"",
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
                    ""id"": ""71ffb48b-b9b8-4ed0-8fcd-48cabb6a39ab"",
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
                    ""id"": ""a548607d-9e2e-4431-9c78-3c7de3a5a74f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
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
                    ""type"": ""Button"",
                    ""id"": ""9c63455b-e7b1-4b94-bc1f-340f5773727c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""ee703171-1e25-450d-bd8d-d4a1a715b96d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""2cd07fc0-7c75-4674-927b-20a084f26e07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Function 1"",
                    ""type"": ""Button"",
                    ""id"": ""fdc3e60a-af80-4848-a30a-c9be98c757ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Function 2"",
                    ""type"": ""Button"",
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
            ""name"": ""Temp"",
            ""id"": ""737ec439-415c-4868-88e1-1d9aa967a6e6"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""0dd6ec19-0b71-4ffe-8cf7-d9c9149665b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down1"",
                    ""type"": ""Button"",
                    ""id"": ""cedd9e80-ce4e-41e3-a8fe-f6de88d56b1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""52a2d043-ac4f-4832-b038-2eda711cc825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left1"",
                    ""type"": ""Button"",
                    ""id"": ""8f4d5d69-0be7-4019-b09e-1aed35722081"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""Right1"",
                    ""type"": ""Button"",
                    ""id"": ""b1406938-42d8-4d6f-840a-c8970c8e6b56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""66908228-5fa8-49a2-a116-f6d1166a4dc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""387505bf-9498-44a5-aeed-bc716ad9235e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left2"",
                    ""type"": ""Button"",
                    ""id"": ""da35dcdf-ab5e-4101-906b-54e6e7e198b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""8453a75d-4e4f-4c56-9bff-c4cd262aa353"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""00f8882b-6f61-4316-b4cd-6ea049250d96"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d5fdecd-286a-4399-aea9-ebdef479662e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba2076ca-d9d0-4407-931e-0ba341a86a43"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db4681f3-7f04-4b65-a2e6-dc92f58a762c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5ed3035-6a3a-438f-a5e7-bb3b5b8c446d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03e1ad32-0d36-44c4-9c46-4f68d5510fef"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30335ec5-2f36-4454-81b0-0a753eb63d08"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""497d809e-91a3-4a96-9cc4-899596bbb968"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""508196cc-4c4d-4346-8a77-1e30dc93272f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d307b954-4776-43b7-bbcd-4a880abd0273"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edfaa6b2-f79a-4efc-8a78-69e7aa16bab3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cd5f52a-d4ff-4e56-ac22-466304568a0f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""731bcfa3-0994-4bf4-ac9b-a27427a9dd27"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61c3d9ad-6d6f-4173-a4fa-76b5cd9952fe"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75426657-5fa5-40c6-a6d0-73e7abcfd955"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b43ed38-7ba3-4385-9433-d43eb646a5e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5ad5e6b-a0ff-463e-8ed3-e946c99c3823"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8e81205-69df-4f2d-9c91-25e59f38dd56"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57ff5a7f-1427-44a2-9974-16160b5cf7af"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e4197e8-bee3-4d9a-87e2-d00132ddbd7b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dbaf584-02bc-4945-99f6-a7f31286110d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba42f534-a429-48a0-84be-3b62e4671e10"",
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
                    ""id"": ""4933a5bb-8b84-450b-bccc-cfa0072938fe"",
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
                    ""id"": ""d30d3652-a0f1-464c-85d8-324e1dc950f4"",
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
                    ""id"": ""f2651499-e9aa-4fec-88c3-824315e4ddc5"",
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
                    ""id"": ""f7dade05-e3e5-41ba-8108-aad02a05d194"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62faba44-59ef-4cbd-9282-5d55455ac464"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c35bcf7c-e2d2-46f0-bb9e-7fdd9173abbc"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default"",
            ""bindingGroup"": ""Default"",
            ""devices"": []
        }
    ]
}");
        // Battle
        m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
        m_Battle_WalkDash = m_Battle.FindAction("Walk & Dash", throwIfNotFound: true);
        m_Battle_Crouch = m_Battle.FindAction("Crouch", throwIfNotFound: true);
        m_Battle_Jump = m_Battle.FindAction("Jump", throwIfNotFound: true);
        m_Battle_LP = m_Battle.FindAction("LP", throwIfNotFound: true);
        m_Battle_HP = m_Battle.FindAction("HP", throwIfNotFound: true);
        m_Battle_LK = m_Battle.FindAction("LK", throwIfNotFound: true);
        m_Battle_HK = m_Battle.FindAction("HK", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Movement = m_UI.FindAction("Movement", throwIfNotFound: true);
        m_UI_Accept = m_UI.FindAction("Accept", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Function1 = m_UI.FindAction("Function 1", throwIfNotFound: true);
        m_UI_Function2 = m_UI.FindAction("Function 2", throwIfNotFound: true);
        // Temp
        m_Temp = asset.FindActionMap("Temp", throwIfNotFound: true);
        m_Temp_Left = m_Temp.FindAction("Left", throwIfNotFound: true);
        m_Temp_Down1 = m_Temp.FindAction("Down1", throwIfNotFound: true);
        m_Temp_Jump = m_Temp.FindAction("Jump", throwIfNotFound: true);
        m_Temp_Left1 = m_Temp.FindAction("Left1", throwIfNotFound: true);
        m_Temp_Right1 = m_Temp.FindAction("Right1", throwIfNotFound: true);
        m_Temp_Up = m_Temp.FindAction("Up", throwIfNotFound: true);
        m_Temp_Down = m_Temp.FindAction("Down", throwIfNotFound: true);
        m_Temp_Left2 = m_Temp.FindAction("Left2", throwIfNotFound: true);
        m_Temp_Right = m_Temp.FindAction("Right", throwIfNotFound: true);
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
    private readonly InputAction m_Battle_WalkDash;
    private readonly InputAction m_Battle_Crouch;
    private readonly InputAction m_Battle_Jump;
    private readonly InputAction m_Battle_LP;
    private readonly InputAction m_Battle_HP;
    private readonly InputAction m_Battle_LK;
    private readonly InputAction m_Battle_HK;
    public struct BattleActions
    {
        private @Player1 m_Wrapper;
        public BattleActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @WalkDash => m_Wrapper.m_Battle_WalkDash;
        public InputAction @Crouch => m_Wrapper.m_Battle_Crouch;
        public InputAction @Jump => m_Wrapper.m_Battle_Jump;
        public InputAction @LP => m_Wrapper.m_Battle_LP;
        public InputAction @HP => m_Wrapper.m_Battle_HP;
        public InputAction @LK => m_Wrapper.m_Battle_LK;
        public InputAction @HK => m_Wrapper.m_Battle_HK;
        public InputActionMap Get() { return m_Wrapper.m_Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
        public void SetCallbacks(IBattleActions instance)
        {
            if (m_Wrapper.m_BattleActionsCallbackInterface != null)
            {
                @WalkDash.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnWalkDash;
                @WalkDash.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnWalkDash;
                @WalkDash.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnWalkDash;
                @Crouch.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnJump;
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
            }
            m_Wrapper.m_BattleActionsCallbackInterface = instance;
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

    // Temp
    private readonly InputActionMap m_Temp;
    private ITempActions m_TempActionsCallbackInterface;
    private readonly InputAction m_Temp_Left;
    private readonly InputAction m_Temp_Down1;
    private readonly InputAction m_Temp_Jump;
    private readonly InputAction m_Temp_Left1;
    private readonly InputAction m_Temp_Right1;
    private readonly InputAction m_Temp_Up;
    private readonly InputAction m_Temp_Down;
    private readonly InputAction m_Temp_Left2;
    private readonly InputAction m_Temp_Right;
    public struct TempActions
    {
        private @Player1 m_Wrapper;
        public TempActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_Temp_Left;
        public InputAction @Down1 => m_Wrapper.m_Temp_Down1;
        public InputAction @Jump => m_Wrapper.m_Temp_Jump;
        public InputAction @Left1 => m_Wrapper.m_Temp_Left1;
        public InputAction @Right1 => m_Wrapper.m_Temp_Right1;
        public InputAction @Up => m_Wrapper.m_Temp_Up;
        public InputAction @Down => m_Wrapper.m_Temp_Down;
        public InputAction @Left2 => m_Wrapper.m_Temp_Left2;
        public InputAction @Right => m_Wrapper.m_Temp_Right;
        public InputActionMap Get() { return m_Wrapper.m_Temp; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TempActions set) { return set.Get(); }
        public void SetCallbacks(ITempActions instance)
        {
            if (m_Wrapper.m_TempActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft;
                @Down1.started -= m_Wrapper.m_TempActionsCallbackInterface.OnDown1;
                @Down1.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnDown1;
                @Down1.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnDown1;
                @Jump.started -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnJump;
                @Left1.started -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft1;
                @Left1.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft1;
                @Left1.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft1;
                @Right1.started -= m_Wrapper.m_TempActionsCallbackInterface.OnRight1;
                @Right1.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnRight1;
                @Right1.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnRight1;
                @Up.started -= m_Wrapper.m_TempActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_TempActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnDown;
                @Left2.started -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft2;
                @Left2.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft2;
                @Left2.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnLeft2;
                @Right.started -= m_Wrapper.m_TempActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_TempActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_TempActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_TempActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Down1.started += instance.OnDown1;
                @Down1.performed += instance.OnDown1;
                @Down1.canceled += instance.OnDown1;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Left1.started += instance.OnLeft1;
                @Left1.performed += instance.OnLeft1;
                @Left1.canceled += instance.OnLeft1;
                @Right1.started += instance.OnRight1;
                @Right1.performed += instance.OnRight1;
                @Right1.canceled += instance.OnRight1;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left2.started += instance.OnLeft2;
                @Left2.performed += instance.OnLeft2;
                @Left2.canceled += instance.OnLeft2;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public TempActions @Temp => new TempActions(this);
    private int m_DefaultSchemeIndex = -1;
    public InputControlScheme DefaultScheme
    {
        get
        {
            if (m_DefaultSchemeIndex == -1) m_DefaultSchemeIndex = asset.FindControlSchemeIndex("Default");
            return asset.controlSchemes[m_DefaultSchemeIndex];
        }
    }
    public interface IBattleActions
    {
        void OnWalkDash(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLP(InputAction.CallbackContext context);
        void OnHP(InputAction.CallbackContext context);
        void OnLK(InputAction.CallbackContext context);
        void OnHK(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnFunction1(InputAction.CallbackContext context);
        void OnFunction2(InputAction.CallbackContext context);
    }
    public interface ITempActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnDown1(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLeft1(InputAction.CallbackContext context);
        void OnRight1(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft2(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
