// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameplayN"",
            ""id"": ""992c69c8-b900-4cbc-8500-495aa0fba7d6"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""b12e9708-eab3-41f1-bbc7-ba42412537b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7403c746-1a88-48df-8351-6d5b48760588"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b8ebb8eb-2557-4f8c-a585-8b7d3fb8eeaf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0779987d-6e47-4068-b651-825f305ce86c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42aec617-da65-47fe-8972-bf16893e5fcf"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd56fb0a-ff9e-412e-b2fd-e9025aa2a9e5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83523258-a3be-491b-9564-6d84fc54c373"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a13e348-ffdc-40cc-a9b2-1228e74488fa"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6bc14e42-a564-47f4-b451-cdb4e7269eea"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5f20ff77-e854-4ce2-92db-4e777c147ff8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""44867c70-3b74-4e26-b031-441753803dd7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GameplayN1"",
            ""id"": ""0946a0da-eb13-44f6-8ad6-0f21df8e6c34"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""04e747b4-1f72-40a1-bfbc-82602b07de0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a8ebd0e5-b6f7-482a-ad44-736e5d4468e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""289a4653-cc2e-42af-98a7-e0bbe391ea21"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c469ef97-27df-401c-bcb6-f8260b3dec1f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0bf777c-c758-44db-9773-170fd27ce66d"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c5c5551-84f3-4013-98b4-01d3b460d79d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebfd3c51-12a4-4fb4-9f5a-325d36e6ac32"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cbf19aa-94bd-46be-8363-69a3759b9787"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f6ef1383-6dde-480e-a223-21ee8504b6a0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""17a9a83e-6a58-492e-a1d5-0b58f24790fb"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9ab3fb9c-fcd4-4b8e-8b54-97cd354137b1"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GameplayB1"",
            ""id"": ""a0fd1986-05a3-463c-9308-9a16cd28ae2d"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""103faf34-66f7-48c5-8c5a-b5ee1af40562"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0e1b4348-cc28-48e5-b090-b8f4f481c334"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a4451312-f8cb-42fe-8406-0cb7af817da7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63079827-739e-4d3a-9a42-f522cdc28201"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea043ab6-bb44-422b-80ef-8574fd956c75"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74a7164a-7d29-448a-8bf3-8642bfb7a6e7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea78c2ae-058c-4679-8671-076ae38f209f"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce40cd82-d617-4e9c-bfa8-63ec6b842286"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""94e32c79-afd2-4c75-960f-caefa7ebb626"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9888aaf4-8927-4fab-945a-7c2e100f3897"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3fc4180d-4c98-407c-a47f-21522b633bb0"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GameplayB"",
            ""id"": ""b0e21152-3763-4047-bd38-bd43c8690335"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8888ace8-3c39-48c1-bbac-65fc29678574"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6640a312-9190-4207-b6d4-92318ee103ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""415bbceb-c218-49d5-bd6d-2df3b067922c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1ff7d9b-3eb0-42ee-aa66-b47b0107eb8d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5ffce36-4306-4956-a76a-e9d5e6e6ed76"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a501781f-2164-4f68-92ca-ebe1ee99d3d2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1844de0-177d-4694-8010-cd3f8347cff3"",
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
                    ""id"": ""092ba798-432d-4c54-b0c7-b734dbcbd21b"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""90772cbf-ca2e-4991-b828-25ed5daf4fb8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""23de74d8-2fe4-457f-8920-35b7bc6f79e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7c747558-7d00-4ae6-87b6-df37d0ece013"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GamePlay"",
            ""id"": ""25faab70-2046-4b72-b54f-63c216830ea3"",
            ""actions"": [
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""a4477e1d-51cf-4059-a941-4dd893a6aa92"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b741f599-144e-47d3-aa55-67cbed123a36"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayN
        m_GameplayN = asset.FindActionMap("GameplayN", throwIfNotFound: true);
        m_GameplayN_Attack = m_GameplayN.FindAction("Attack", throwIfNotFound: true);
        m_GameplayN_Jump = m_GameplayN.FindAction("Jump", throwIfNotFound: true);
        m_GameplayN_Move = m_GameplayN.FindAction("Move", throwIfNotFound: true);
        // GameplayN1
        m_GameplayN1 = asset.FindActionMap("GameplayN1", throwIfNotFound: true);
        m_GameplayN1_Attack = m_GameplayN1.FindAction("Attack", throwIfNotFound: true);
        m_GameplayN1_Jump = m_GameplayN1.FindAction("Jump", throwIfNotFound: true);
        m_GameplayN1_Move = m_GameplayN1.FindAction("Move", throwIfNotFound: true);
        // GameplayB1
        m_GameplayB1 = asset.FindActionMap("GameplayB1", throwIfNotFound: true);
        m_GameplayB1_Attack = m_GameplayB1.FindAction("Attack", throwIfNotFound: true);
        m_GameplayB1_Jump = m_GameplayB1.FindAction("Jump", throwIfNotFound: true);
        m_GameplayB1_Move = m_GameplayB1.FindAction("Move", throwIfNotFound: true);
        // GameplayB
        m_GameplayB = asset.FindActionMap("GameplayB", throwIfNotFound: true);
        m_GameplayB_Attack = m_GameplayB.FindAction("Attack", throwIfNotFound: true);
        m_GameplayB_Jump = m_GameplayB.FindAction("Jump", throwIfNotFound: true);
        m_GameplayB_Move = m_GameplayB.FindAction("Move", throwIfNotFound: true);
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Space = m_GamePlay.FindAction("Space", throwIfNotFound: true);
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

    // GameplayN
    private readonly InputActionMap m_GameplayN;
    private IGameplayNActions m_GameplayNActionsCallbackInterface;
    private readonly InputAction m_GameplayN_Attack;
    private readonly InputAction m_GameplayN_Jump;
    private readonly InputAction m_GameplayN_Move;
    public struct GameplayNActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayNActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_GameplayN_Attack;
        public InputAction @Jump => m_Wrapper.m_GameplayN_Jump;
        public InputAction @Move => m_Wrapper.m_GameplayN_Move;
        public InputActionMap Get() { return m_Wrapper.m_GameplayN; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayNActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayNActions instance)
        {
            if (m_Wrapper.m_GameplayNActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayNActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayNActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayNActions @GameplayN => new GameplayNActions(this);

    // GameplayN1
    private readonly InputActionMap m_GameplayN1;
    private IGameplayN1Actions m_GameplayN1ActionsCallbackInterface;
    private readonly InputAction m_GameplayN1_Attack;
    private readonly InputAction m_GameplayN1_Jump;
    private readonly InputAction m_GameplayN1_Move;
    public struct GameplayN1Actions
    {
        private @PlayerControls m_Wrapper;
        public GameplayN1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_GameplayN1_Attack;
        public InputAction @Jump => m_Wrapper.m_GameplayN1_Jump;
        public InputAction @Move => m_Wrapper.m_GameplayN1_Move;
        public InputActionMap Get() { return m_Wrapper.m_GameplayN1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayN1Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplayN1Actions instance)
        {
            if (m_Wrapper.m_GameplayN1ActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayN1ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayN1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayN1Actions @GameplayN1 => new GameplayN1Actions(this);

    // GameplayB1
    private readonly InputActionMap m_GameplayB1;
    private IGameplayB1Actions m_GameplayB1ActionsCallbackInterface;
    private readonly InputAction m_GameplayB1_Attack;
    private readonly InputAction m_GameplayB1_Jump;
    private readonly InputAction m_GameplayB1_Move;
    public struct GameplayB1Actions
    {
        private @PlayerControls m_Wrapper;
        public GameplayB1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_GameplayB1_Attack;
        public InputAction @Jump => m_Wrapper.m_GameplayB1_Jump;
        public InputAction @Move => m_Wrapper.m_GameplayB1_Move;
        public InputActionMap Get() { return m_Wrapper.m_GameplayB1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayB1Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplayB1Actions instance)
        {
            if (m_Wrapper.m_GameplayB1ActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayB1ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayB1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayB1Actions @GameplayB1 => new GameplayB1Actions(this);

    // GameplayB
    private readonly InputActionMap m_GameplayB;
    private IGameplayBActions m_GameplayBActionsCallbackInterface;
    private readonly InputAction m_GameplayB_Attack;
    private readonly InputAction m_GameplayB_Jump;
    private readonly InputAction m_GameplayB_Move;
    public struct GameplayBActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayBActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_GameplayB_Attack;
        public InputAction @Jump => m_Wrapper.m_GameplayB_Jump;
        public InputAction @Move => m_Wrapper.m_GameplayB_Move;
        public InputActionMap Get() { return m_Wrapper.m_GameplayB; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayBActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayBActions instance)
        {
            if (m_Wrapper.m_GameplayBActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayBActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayBActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayBActions @GameplayB => new GameplayBActions(this);

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Space;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Space => m_Wrapper.m_GamePlay_Space;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Space.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSpace;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGameplayNActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IGameplayN1Actions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IGameplayB1Actions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IGameplayBActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IGamePlayActions
    {
        void OnSpace(InputAction.CallbackContext context);
    }
}
