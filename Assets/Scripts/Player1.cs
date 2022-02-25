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
                    ""type"": ""Value"",
                    ""id"": ""9c63455b-e7b1-4b94-bc1f-340f5773727c"",
                    ""expectedControlType"": ""Digital"",
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
}
