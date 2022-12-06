//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Inputs/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""0a92f5d8-8be0-451a-a244-6d3495a97b7a"",
            ""actions"": [
                {
                    ""name"": ""MovementDpad"",
                    ""type"": ""Value"",
                    ""id"": ""a08770f6-6908-4d36-9674-f6f18ad205ef"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""25ffcf1a-1e77-4641-b895-3a967fe6803e"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interactions"",
            ""id"": ""629ff90e-f3a9-4186-bc64-8fcb02525f44"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""Value"",
                    ""id"": ""595f2798-21fe-4a8b-a1c5-2b7381504224"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b2ea643a-87f0-4982-b2f3-05cd0abf415f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Value"",
                    ""id"": ""e351b320-13d8-4e19-a810-17379f625022"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ab238732-cdda-4aa4-84cd-f0005643f516"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ad69d3b-8456-4d9d-b5cd-372adc5a4f0e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b0e228f-59dd-49cd-84a0-2965b7ad276c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MovementDpad = m_Movement.FindAction("MovementDpad", throwIfNotFound: true);
        // Interactions
        m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
        m_Interactions_Grab = m_Interactions.FindAction("Grab", throwIfNotFound: true);
        m_Interactions_Dash = m_Interactions.FindAction("Dash", throwIfNotFound: true);
        m_Interactions_Drop = m_Interactions.FindAction("Drop", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_MovementDpad;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementDpad => m_Wrapper.m_Movement_MovementDpad;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @MovementDpad.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovementDpad;
                @MovementDpad.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovementDpad;
                @MovementDpad.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovementDpad;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementDpad.started += instance.OnMovementDpad;
                @MovementDpad.performed += instance.OnMovementDpad;
                @MovementDpad.canceled += instance.OnMovementDpad;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Interactions
    private readonly InputActionMap m_Interactions;
    private IInteractionsActions m_InteractionsActionsCallbackInterface;
    private readonly InputAction m_Interactions_Grab;
    private readonly InputAction m_Interactions_Dash;
    private readonly InputAction m_Interactions_Drop;
    public struct InteractionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public InteractionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_Interactions_Grab;
        public InputAction @Dash => m_Wrapper.m_Interactions_Dash;
        public InputAction @Drop => m_Wrapper.m_Interactions_Drop;
        public InputActionMap Get() { return m_Wrapper.m_Interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterface != null)
            {
                @Grab.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnGrab;
                @Dash.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDash;
                @Drop.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDrop;
            }
            m_Wrapper.m_InteractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
            }
        }
    }
    public InteractionsActions @Interactions => new InteractionsActions(this);
    public interface IMovementActions
    {
        void OnMovementDpad(InputAction.CallbackContext context);
    }
    public interface IInteractionsActions
    {
        void OnGrab(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
    }
}
