// GENERATED AUTOMATICALLY FROM 'Assets/NovoInputSystem/InputSystemManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystemManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemManager"",
    ""maps"": [
        {
            ""name"": ""Jogador"",
            ""id"": ""8c19a484-5bd8-482f-a9a6-22b97128226a"",
            ""actions"": [
                {
                    ""name"": ""Movimento"",
                    ""type"": ""Value"",
                    ""id"": ""6c15b8ae-226d-4d75-adbc-e69bde4fa7b8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pular"",
                    ""type"": ""Value"",
                    ""id"": ""b9a2eeb6-852d-43d7-8261-7f1d4df16711"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direcao"",
                    ""id"": ""9c63afb0-50ac-49f6-b7b5-4378ea68c1b9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c60ccb6a-7e86-4c19-8aa5-6d43a11adb7d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e404b53f-faf7-455d-b89f-7b14c1baae76"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""20f00a63-f4e9-464d-9253-84b48759a174"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""56590e57-2156-4554-900d-9de4b50ce87d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Setas"",
                    ""id"": ""469a28d1-e171-4cc1-9d02-2904a596ca64"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53f8741a-1223-4e93-be9d-ce377ba21901"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2d9b658b-ad1a-438d-9c8e-7ee998f34ef6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b487bc1e-4335-4537-89fc-2e6b7f5d039f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d2086238-70cb-46d2-96a8-3aa4dd5c80df"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d69243c8-cf33-4fdf-a28d-2a8e12d47ed7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pular"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jogador
        m_Jogador = asset.FindActionMap("Jogador", throwIfNotFound: true);
        m_Jogador_Movimento = m_Jogador.FindAction("Movimento", throwIfNotFound: true);
        m_Jogador_Pular = m_Jogador.FindAction("Pular", throwIfNotFound: true);
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

    // Jogador
    private readonly InputActionMap m_Jogador;
    private IJogadorActions m_JogadorActionsCallbackInterface;
    private readonly InputAction m_Jogador_Movimento;
    private readonly InputAction m_Jogador_Pular;
    public struct JogadorActions
    {
        private @InputSystemManager m_Wrapper;
        public JogadorActions(@InputSystemManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimento => m_Wrapper.m_Jogador_Movimento;
        public InputAction @Pular => m_Wrapper.m_Jogador_Pular;
        public InputActionMap Get() { return m_Wrapper.m_Jogador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JogadorActions set) { return set.Get(); }
        public void SetCallbacks(IJogadorActions instance)
        {
            if (m_Wrapper.m_JogadorActionsCallbackInterface != null)
            {
                @Movimento.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Pular.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPular;
                @Pular.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPular;
                @Pular.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPular;
            }
            m_Wrapper.m_JogadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimento.started += instance.OnMovimento;
                @Movimento.performed += instance.OnMovimento;
                @Movimento.canceled += instance.OnMovimento;
                @Pular.started += instance.OnPular;
                @Pular.performed += instance.OnPular;
                @Pular.canceled += instance.OnPular;
            }
        }
    }
    public JogadorActions @Jogador => new JogadorActions(this);
    public interface IJogadorActions
    {
        void OnMovimento(InputAction.CallbackContext context);
        void OnPular(InputAction.CallbackContext context);
    }
}
