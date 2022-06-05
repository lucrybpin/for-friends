// GENERATED AUTOMATICALLY FROM 'Assets/InputAssetAction/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""standard"",
            ""id"": ""a425a96e-ee74-4b74-a29e-49b8986c1fa4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2a720d0e-5aae-438d-bb73-1a04c068de5a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Value"",
                    ""id"": ""6e3dd287-335f-4561-8657-6e30da4f31a8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d5ace693-441c-4af7-99c2-31743d7807e2"",
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
                    ""id"": ""3b2739ac-c8ba-4ff5-930f-fd4b4004fa28"",
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
                    ""id"": ""cc4fd654-de64-4e71-85c6-e4544a6f6faf"",
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
                    ""id"": ""f53b746d-3f76-4cbc-873c-bca04d7d56d1"",
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
                    ""id"": ""5ad7b70f-50f7-489d-b847-3978fd815048"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fc9e5792-05bf-4316-b239-b1974517b14b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // standard
        m_standard = asset.FindActionMap("standard", throwIfNotFound: true);
        m_standard_Movement = m_standard.FindAction("Movement", throwIfNotFound: true);
        m_standard_Break = m_standard.FindAction("Break", throwIfNotFound: true);
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

    // standard
    private readonly InputActionMap m_standard;
    private IStandardActions m_StandardActionsCallbackInterface;
    private readonly InputAction m_standard_Movement;
    private readonly InputAction m_standard_Break;
    public struct StandardActions
    {
        private @PlayerInputActions m_Wrapper;
        public StandardActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_standard_Movement;
        public InputAction @Break => m_Wrapper.m_standard_Break;
        public InputActionMap Get() { return m_Wrapper.m_standard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardActions set) { return set.Get(); }
        public void SetCallbacks(IStandardActions instance)
        {
            if (m_Wrapper.m_StandardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Break.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnBreak;
            }
            m_Wrapper.m_StandardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
            }
        }
    }
    public StandardActions @standard => new StandardActions(this);
    public interface IStandardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
    }
}
