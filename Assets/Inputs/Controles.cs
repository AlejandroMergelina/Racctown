//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Inputs/Controles.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controles : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controles"",
    ""maps"": [
        {
            ""name"": ""MoveOut"",
            ""id"": ""d958f3b6-9a25-4618-a56f-03468f16995d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4bdaf435-e841-41e1-a321-a69ac75540b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Button"",
                    ""id"": ""0b66f05a-cbe6-49cb-b5d0-04968a326615"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""1f29eef1-e6ac-43d1-998f-f1bdd30777ec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""852d818e-f554-4f39-b6a5-a736eee4410e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""23bce1f7-a05d-45d5-96b1-8255cd85ea85"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f49d616c-49fd-41ed-b3ce-781aba780678"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aec89ce6-a448-4898-8e75-b253c5a2f8b2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ba8b8e87-3aa3-46da-a00f-f471b6cefe23"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e9ff2b5c-a411-4c4d-81a1-7bd145eef4c5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""acc3f4c5-0f04-4e60-ab0f-a62576f2d00c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""e86274d1-57b5-40c8-bf11-99115991e74d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""83828463-6807-41a4-acf4-3e05f0671d0a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1b3e658b-c962-4ccb-8ff1-9bce421d48b8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f88d4e96-0022-420d-a832-a63b18dbbe63"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""CombatMode"",
            ""id"": ""aa2a0b10-5e1b-4e18-a7e4-a69d58ccaa32"",
            ""actions"": [
                {
                    ""name"": ""ActionP1"",
                    ""type"": ""Button"",
                    ""id"": ""7affe9d5-5a6f-449e-a843-ba1c4ead3db3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionP2"",
                    ""type"": ""Button"",
                    ""id"": ""285eecab-1213-45e8-a475-ab2aca2eb724"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9d555985-3ef3-4eb1-a676-278ce7719894"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dde404e4-34ef-4e0d-94cc-fc8358b0d2d2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""e0452012-50f1-431b-9cb9-129368ff40f8"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""d45bb217-c5c1-43c7-b3a6-05f320a295ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""881fc409-8b73-48f0-a2a2-0a8a4a03c04e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MoveOut
        m_MoveOut = asset.FindActionMap("MoveOut", throwIfNotFound: true);
        m_MoveOut_Move = m_MoveOut.FindAction("Move", throwIfNotFound: true);
        m_MoveOut_RotateCamera = m_MoveOut.FindAction("RotateCamera", throwIfNotFound: true);
        // CombatMode
        m_CombatMode = asset.FindActionMap("CombatMode", throwIfNotFound: true);
        m_CombatMode_ActionP1 = m_CombatMode.FindAction("ActionP1", throwIfNotFound: true);
        m_CombatMode_ActionP2 = m_CombatMode.FindAction("ActionP2", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MoveOut
    private readonly InputActionMap m_MoveOut;
    private IMoveOutActions m_MoveOutActionsCallbackInterface;
    private readonly InputAction m_MoveOut_Move;
    private readonly InputAction m_MoveOut_RotateCamera;
    public struct MoveOutActions
    {
        private @Controles m_Wrapper;
        public MoveOutActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MoveOut_Move;
        public InputAction @RotateCamera => m_Wrapper.m_MoveOut_RotateCamera;
        public InputActionMap Get() { return m_Wrapper.m_MoveOut; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveOutActions set) { return set.Get(); }
        public void SetCallbacks(IMoveOutActions instance)
        {
            if (m_Wrapper.m_MoveOutActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MoveOutActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MoveOutActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MoveOutActionsCallbackInterface.OnMove;
                @RotateCamera.started -= m_Wrapper.m_MoveOutActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_MoveOutActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_MoveOutActionsCallbackInterface.OnRotateCamera;
            }
            m_Wrapper.m_MoveOutActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
            }
        }
    }
    public MoveOutActions @MoveOut => new MoveOutActions(this);

    // CombatMode
    private readonly InputActionMap m_CombatMode;
    private ICombatModeActions m_CombatModeActionsCallbackInterface;
    private readonly InputAction m_CombatMode_ActionP1;
    private readonly InputAction m_CombatMode_ActionP2;
    public struct CombatModeActions
    {
        private @Controles m_Wrapper;
        public CombatModeActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActionP1 => m_Wrapper.m_CombatMode_ActionP1;
        public InputAction @ActionP2 => m_Wrapper.m_CombatMode_ActionP2;
        public InputActionMap Get() { return m_Wrapper.m_CombatMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatModeActions set) { return set.Get(); }
        public void SetCallbacks(ICombatModeActions instance)
        {
            if (m_Wrapper.m_CombatModeActionsCallbackInterface != null)
            {
                @ActionP1.started -= m_Wrapper.m_CombatModeActionsCallbackInterface.OnActionP1;
                @ActionP1.performed -= m_Wrapper.m_CombatModeActionsCallbackInterface.OnActionP1;
                @ActionP1.canceled -= m_Wrapper.m_CombatModeActionsCallbackInterface.OnActionP1;
                @ActionP2.started -= m_Wrapper.m_CombatModeActionsCallbackInterface.OnActionP2;
                @ActionP2.performed -= m_Wrapper.m_CombatModeActionsCallbackInterface.OnActionP2;
                @ActionP2.canceled -= m_Wrapper.m_CombatModeActionsCallbackInterface.OnActionP2;
            }
            m_Wrapper.m_CombatModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ActionP1.started += instance.OnActionP1;
                @ActionP1.performed += instance.OnActionP1;
                @ActionP1.canceled += instance.OnActionP1;
                @ActionP2.started += instance.OnActionP2;
                @ActionP2.performed += instance.OnActionP2;
                @ActionP2.canceled += instance.OnActionP2;
            }
        }
    }
    public CombatModeActions @CombatMode => new CombatModeActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @Controles m_Wrapper;
        public MenuActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMoveOutActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
    }
    public interface ICombatModeActions
    {
        void OnActionP1(InputAction.CallbackContext context);
        void OnActionP2(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
