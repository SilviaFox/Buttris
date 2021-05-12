// GENERATED AUTOMATICALLY FROM 'Assets/UnityAssets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""faebdb7d-300d-40a2-a62b-d93fae54e5a2"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""0a3b75fb-d219-43c8-a0cb-68412e5e21ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""65ae2e4c-cc42-4c09-a533-d8b2819278d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fast Drop"",
                    ""type"": ""Button"",
                    ""id"": ""0c62de74-dd0c-4e9c-872f-a7aff5e983c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hard Drop"",
                    ""type"": ""Button"",
                    ""id"": ""0e7906c6-32c4-40d2-b0c2-2599efc5d40a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate L"",
                    ""type"": ""Button"",
                    ""id"": ""c8b5ffd0-c837-48f3-a4c0-220a6ca47ec3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate R"",
                    ""type"": ""Button"",
                    ""id"": ""2b9db4d5-8f4e-4ecb-92bf-c62873e3bb8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""Button"",
                    ""id"": ""7079f0a4-979f-4f21-994e-03b48563d684"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""e0789bb0-5375-46fd-80a8-9766453e72e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""31a35dd7-eaa9-425e-bc6f-7a7fa2b86889"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cdb84e6-a30e-4cfb-90ed-c082ff1e096b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc9ceda4-44dd-4c2d-89f6-b8229da94d6a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fast Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52da252d-9e0b-479e-8f6c-dbf6d02bc98d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hard Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2026e80-9264-4eff-8d7a-1b58a831b36a"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e615ef6-2a27-4385-948d-08906d81d081"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25befa2b-fddd-4e0d-808e-5b108ad5f22f"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""520dfb1f-5d71-4749-bd23-174f7a7d41ac"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2179e365-439f-4dd3-a2a5-5dfd632d7f27"",
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
            ""name"": ""Menu"",
            ""id"": ""34f2af8a-866a-4aa2-b230-0ff00edca111"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""9bfd99b8-e5eb-4f40-95a6-518392ce4be9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3c6ac4ab-7d56-4357-8501-91d9cdbc154f"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Left = m_Gameplay.FindAction("Left", throwIfNotFound: true);
        m_Gameplay_Right = m_Gameplay.FindAction("Right", throwIfNotFound: true);
        m_Gameplay_FastDrop = m_Gameplay.FindAction("Fast Drop", throwIfNotFound: true);
        m_Gameplay_HardDrop = m_Gameplay.FindAction("Hard Drop", throwIfNotFound: true);
        m_Gameplay_RotateL = m_Gameplay.FindAction("Rotate L", throwIfNotFound: true);
        m_Gameplay_RotateR = m_Gameplay.FindAction("Rotate R", throwIfNotFound: true);
        m_Gameplay_Hold = m_Gameplay.FindAction("Hold", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Start = m_Menu.FindAction("Start", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Left;
    private readonly InputAction m_Gameplay_Right;
    private readonly InputAction m_Gameplay_FastDrop;
    private readonly InputAction m_Gameplay_HardDrop;
    private readonly InputAction m_Gameplay_RotateL;
    private readonly InputAction m_Gameplay_RotateR;
    private readonly InputAction m_Gameplay_Hold;
    private readonly InputAction m_Gameplay_Pause;
    public struct GameplayActions
    {
        private @InputMaster m_Wrapper;
        public GameplayActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_Gameplay_Left;
        public InputAction @Right => m_Wrapper.m_Gameplay_Right;
        public InputAction @FastDrop => m_Wrapper.m_Gameplay_FastDrop;
        public InputAction @HardDrop => m_Wrapper.m_Gameplay_HardDrop;
        public InputAction @RotateL => m_Wrapper.m_Gameplay_RotateL;
        public InputAction @RotateR => m_Wrapper.m_Gameplay_RotateR;
        public InputAction @Hold => m_Wrapper.m_Gameplay_Hold;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight;
                @FastDrop.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFastDrop;
                @FastDrop.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFastDrop;
                @FastDrop.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFastDrop;
                @HardDrop.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHardDrop;
                @HardDrop.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHardDrop;
                @HardDrop.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHardDrop;
                @RotateL.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateL;
                @RotateL.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateL;
                @RotateL.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateL;
                @RotateR.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateR;
                @RotateR.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateR;
                @RotateR.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateR;
                @Hold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @FastDrop.started += instance.OnFastDrop;
                @FastDrop.performed += instance.OnFastDrop;
                @FastDrop.canceled += instance.OnFastDrop;
                @HardDrop.started += instance.OnHardDrop;
                @HardDrop.performed += instance.OnHardDrop;
                @HardDrop.canceled += instance.OnHardDrop;
                @RotateL.started += instance.OnRotateL;
                @RotateL.performed += instance.OnRotateL;
                @RotateL.canceled += instance.OnRotateL;
                @RotateR.started += instance.OnRotateR;
                @RotateR.performed += instance.OnRotateR;
                @RotateR.canceled += instance.OnRotateR;
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Start;
    public struct MenuActions
    {
        private @InputMaster m_Wrapper;
        public MenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameplayActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnFastDrop(InputAction.CallbackContext context);
        void OnHardDrop(InputAction.CallbackContext context);
        void OnRotateL(InputAction.CallbackContext context);
        void OnRotateR(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
