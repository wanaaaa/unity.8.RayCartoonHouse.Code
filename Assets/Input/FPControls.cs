// GENERATED AUTOMATICALLY FROM 'Assets/Input/FPControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay Controls"",
            ""id"": ""e96e09b9-8f5e-4352-87a1-d0411d6b7732"",
            ""actions"": [
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""3f8bab73-04c8-4602-a340-ea85378a1446"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerMove"",
                    ""type"": ""Value"",
                    ""id"": ""1c301cad-44cd-4042-aadf-bc34ed2ee743"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fec6ba4d-c6e3-4401-9bf0-e50ad4a0713d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and Mouse"",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""7a9b3e46-1836-44e4-ac27-51eaf768fe6f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b45dcc23-b65e-4c2b-bbf2-76944dcf0ab9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aab4de8f-f1bc-4be3-abdf-85489d7a0357"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6064b480-1e34-4d03-bc12-7048a98f955d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""57dac87a-6715-4fdb-a25f-c5d53120ab3a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard and Mouse"",
            ""bindingGroup"": ""keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay Controls
        m_GameplayControls = asset.FindActionMap("Gameplay Controls", throwIfNotFound: true);
        m_GameplayControls_CameraLook = m_GameplayControls.FindAction("CameraLook", throwIfNotFound: true);
        m_GameplayControls_PlayerMove = m_GameplayControls.FindAction("PlayerMove", throwIfNotFound: true);
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

    // Gameplay Controls
    private readonly InputActionMap m_GameplayControls;
    private IGameplayControlsActions m_GameplayControlsActionsCallbackInterface;
    private readonly InputAction m_GameplayControls_CameraLook;
    private readonly InputAction m_GameplayControls_PlayerMove;
    public struct GameplayControlsActions
    {
        private @FPControls m_Wrapper;
        public GameplayControlsActions(@FPControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraLook => m_Wrapper.m_GameplayControls_CameraLook;
        public InputAction @PlayerMove => m_Wrapper.m_GameplayControls_PlayerMove;
        public InputActionMap Get() { return m_Wrapper.m_GameplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayControlsActions instance)
        {
            if (m_Wrapper.m_GameplayControlsActionsCallbackInterface != null)
            {
                @CameraLook.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCameraLook;
                @CameraLook.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCameraLook;
                @CameraLook.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCameraLook;
                @PlayerMove.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnPlayerMove;
                @PlayerMove.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnPlayerMove;
                @PlayerMove.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnPlayerMove;
            }
            m_Wrapper.m_GameplayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraLook.started += instance.OnCameraLook;
                @CameraLook.performed += instance.OnCameraLook;
                @CameraLook.canceled += instance.OnCameraLook;
                @PlayerMove.started += instance.OnPlayerMove;
                @PlayerMove.performed += instance.OnPlayerMove;
                @PlayerMove.canceled += instance.OnPlayerMove;
            }
        }
    }
    public GameplayControlsActions @GameplayControls => new GameplayControlsActions(this);
    private int m_keyboardandMouseSchemeIndex = -1;
    public InputControlScheme keyboardandMouseScheme
    {
        get
        {
            if (m_keyboardandMouseSchemeIndex == -1) m_keyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("keyboard and Mouse");
            return asset.controlSchemes[m_keyboardandMouseSchemeIndex];
        }
    }
    public interface IGameplayControlsActions
    {
        void OnCameraLook(InputAction.CallbackContext context);
        void OnPlayerMove(InputAction.CallbackContext context);
    }
}
