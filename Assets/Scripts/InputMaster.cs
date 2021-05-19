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
                    ""id"": ""88b20cf5-c5a1-45c8-9204-83d5252287b7"",
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
                    ""id"": ""bfadb120-e773-4ad9-899c-8ec2d4910e5f"",
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
                    ""id"": ""b06663f6-8703-4d72-b311-e16f9c6c55db"",
                    ""path"": ""<Gamepad>/dpad/down"",
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
                    ""id"": ""9168b0d8-ceba-4eee-9bb5-6fb05e69f15e"",
                    ""path"": ""<Gamepad>/dpad/up"",
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
                    ""id"": ""fcbd6f82-2201-48aa-a9c6-c0bf3e863435"",
                    ""path"": ""<Gamepad>/buttonWest"",
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
                    ""id"": ""86756831-c812-40b9-b5e7-9764676456b1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
                    ""id"": ""6d3b0138-de15-4229-aec2-1e9a04862d14"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""2edbd2f3-a559-4900-93b9-c7fd3df679e6"",
                    ""path"": ""<Gamepad>/start"",
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
                },
                {
                    ""name"": ""TabL"",
                    ""type"": ""Button"",
                    ""id"": ""bfb75cb2-fab2-4206-bb6d-b54204e1f4dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TabR"",
                    ""type"": ""Button"",
                    ""id"": ""19a2afe1-95a8-4ccf-826b-5bed9f77b0c5"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""f95febc1-e0b9-4e3f-bc86-28fc571c5ab1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74f1cea3-e68b-465b-98ff-58a361bee1a1"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c4f8f41-5e35-408a-8b0c-6dfd8b8ed1f8"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TabL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c655bec-74fc-422a-99fc-ca1b808df04e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TabL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cc2a8bf-6f11-4132-8711-44167a5d0d7f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TabR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0860c554-90f3-4b28-9d3c-d2ae69f12687"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TabR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameTypeMenu"",
            ""id"": ""8eefe657-24bb-4df4-b390-a3080baed534"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""725f4d64-c704-44e2-b8a9-32639cdf5af6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""c7cf00f0-552f-46fc-a5cb-c445c73a6782"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""c99482c6-bbe1-4d74-852e-966acd07c325"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""bd9e5227-6b87-4ceb-897d-7a25d1572447"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""5f2f66d8-78c2-407f-b1de-8100c64bed12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4fcf5064-3338-47d8-b4a2-7808dac8561a"",
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
                    ""id"": ""b32be57b-fea7-4613-8325-16b8c1ab5321"",
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
                    ""id"": ""98ead56a-3a5f-4630-bb0e-d5d9666f73f4"",
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
                    ""id"": ""3964ea44-2174-4c55-9732-06b239f87280"",
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
                    ""id"": ""f156df94-a969-46a4-b227-171e119761a6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1eac79b-6cdf-4fc7-bf00-fbcb893f7632"",
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
                    ""id"": ""3c841797-f511-4ceb-a7e8-e9bab2401c9f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8013ed5-7bc6-4715-b32e-c1ac8d417f91"",
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
                    ""id"": ""6e873e80-ac46-4e3b-97ed-b19b71c6ecf9"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df1c4a93-ba88-47df-aba0-aab0e661ecb1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
        m_Menu_TabL = m_Menu.FindAction("TabL", throwIfNotFound: true);
        m_Menu_TabR = m_Menu.FindAction("TabR", throwIfNotFound: true);
        // GameTypeMenu
        m_GameTypeMenu = asset.FindActionMap("GameTypeMenu", throwIfNotFound: true);
        m_GameTypeMenu_Up = m_GameTypeMenu.FindAction("Up", throwIfNotFound: true);
        m_GameTypeMenu_Down = m_GameTypeMenu.FindAction("Down", throwIfNotFound: true);
        m_GameTypeMenu_Left = m_GameTypeMenu.FindAction("Left", throwIfNotFound: true);
        m_GameTypeMenu_Right = m_GameTypeMenu.FindAction("Right", throwIfNotFound: true);
        m_GameTypeMenu_Start = m_GameTypeMenu.FindAction("Start", throwIfNotFound: true);
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
    private readonly InputAction m_Menu_TabL;
    private readonly InputAction m_Menu_TabR;
    public struct MenuActions
    {
        private @InputMaster m_Wrapper;
        public MenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputAction @TabL => m_Wrapper.m_Menu_TabL;
        public InputAction @TabR => m_Wrapper.m_Menu_TabR;
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
                @TabL.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnTabL;
                @TabL.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnTabL;
                @TabL.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnTabL;
                @TabR.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnTabR;
                @TabR.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnTabR;
                @TabR.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnTabR;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @TabL.started += instance.OnTabL;
                @TabL.performed += instance.OnTabL;
                @TabL.canceled += instance.OnTabL;
                @TabR.started += instance.OnTabR;
                @TabR.performed += instance.OnTabR;
                @TabR.canceled += instance.OnTabR;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // GameTypeMenu
    private readonly InputActionMap m_GameTypeMenu;
    private IGameTypeMenuActions m_GameTypeMenuActionsCallbackInterface;
    private readonly InputAction m_GameTypeMenu_Up;
    private readonly InputAction m_GameTypeMenu_Down;
    private readonly InputAction m_GameTypeMenu_Left;
    private readonly InputAction m_GameTypeMenu_Right;
    private readonly InputAction m_GameTypeMenu_Start;
    public struct GameTypeMenuActions
    {
        private @InputMaster m_Wrapper;
        public GameTypeMenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_GameTypeMenu_Up;
        public InputAction @Down => m_Wrapper.m_GameTypeMenu_Down;
        public InputAction @Left => m_Wrapper.m_GameTypeMenu_Left;
        public InputAction @Right => m_Wrapper.m_GameTypeMenu_Right;
        public InputAction @Start => m_Wrapper.m_GameTypeMenu_Start;
        public InputActionMap Get() { return m_Wrapper.m_GameTypeMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameTypeMenuActions set) { return set.Get(); }
        public void SetCallbacks(IGameTypeMenuActions instance)
        {
            if (m_Wrapper.m_GameTypeMenuActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnRight;
                @Start.started -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GameTypeMenuActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_GameTypeMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public GameTypeMenuActions @GameTypeMenu => new GameTypeMenuActions(this);
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
        void OnTabL(InputAction.CallbackContext context);
        void OnTabR(InputAction.CallbackContext context);
    }
    public interface IGameTypeMenuActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
