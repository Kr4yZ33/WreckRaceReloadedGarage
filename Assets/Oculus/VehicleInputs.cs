// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VehicleInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VehicleInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""d23ca220-0c48-4da7-84bb-3613be79d0d5"",
            ""actions"": [
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Button"",
                    ""id"": ""08418934-8b5c-42af-8fbc-cecbee7797f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""95925003-10f8-4948-9b08-334fa05088cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""HandBrake"",
                    ""type"": ""Button"",
                    ""id"": ""be0c5844-1f2e-49e7-aab2-c6d813235b2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""NOS"",
                    ""type"": ""Button"",
                    ""id"": ""af50071c-803c-49c5-86ba-ba251ea162cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""GatlingGunManualAim"",
                    ""type"": ""Button"",
                    ""id"": ""1f1a1803-175a-4475-b029-b0aa5133f0bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""cdff92a0-092a-4812-8e61-5e540367208c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""758c6da1-9248-4171-8b78-fae40f656513"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b87a4b45-e02f-4f32-8d5d-56bc4d152c23"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13a472de-23d9-4537-ba6d-1a2f2570a009"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc477e47-4f52-4083-b2b0-7dbe47bfca23"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f4ba658-1a68-4ba9-8379-f5b87347b168"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus"",
                    ""action"": ""GatlingGunManualAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Custom"",
                    ""id"": ""7151e9a2-ba0b-426a-a31b-8c5bc0e4620f"",
                    ""path"": ""Custom"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftAndRight"",
                    ""id"": ""58b2c0f0-bbc6-464b-952e-926ffaf78d13"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9694ea7a-e1cb-4343-8b9c-7c8af875aefe"",
                    ""path"": ""<XRController>{LeftHand}/primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Oculus"",
            ""bindingGroup"": ""Oculus"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Acceleration = m_Driving.FindAction("Acceleration", throwIfNotFound: true);
        m_Driving_Brake = m_Driving.FindAction("Brake", throwIfNotFound: true);
        m_Driving_HandBrake = m_Driving.FindAction("HandBrake", throwIfNotFound: true);
        m_Driving_NOS = m_Driving.FindAction("NOS", throwIfNotFound: true);
        m_Driving_GatlingGunManualAim = m_Driving.FindAction("GatlingGunManualAim", throwIfNotFound: true);
        m_Driving_Steering = m_Driving.FindAction("Steering", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Acceleration;
    private readonly InputAction m_Driving_Brake;
    private readonly InputAction m_Driving_HandBrake;
    private readonly InputAction m_Driving_NOS;
    private readonly InputAction m_Driving_GatlingGunManualAim;
    private readonly InputAction m_Driving_Steering;
    public struct DrivingActions
    {
        private @VehicleInputs m_Wrapper;
        public DrivingActions(@VehicleInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Acceleration => m_Wrapper.m_Driving_Acceleration;
        public InputAction @Brake => m_Wrapper.m_Driving_Brake;
        public InputAction @HandBrake => m_Wrapper.m_Driving_HandBrake;
        public InputAction @NOS => m_Wrapper.m_Driving_NOS;
        public InputAction @GatlingGunManualAim => m_Wrapper.m_Driving_GatlingGunManualAim;
        public InputAction @Steering => m_Wrapper.m_Driving_Steering;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Acceleration.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAcceleration;
                @Brake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @HandBrake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHandBrake;
                @HandBrake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHandBrake;
                @HandBrake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHandBrake;
                @NOS.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnNOS;
                @NOS.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnNOS;
                @NOS.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnNOS;
                @GatlingGunManualAim.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnGatlingGunManualAim;
                @GatlingGunManualAim.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnGatlingGunManualAim;
                @GatlingGunManualAim.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnGatlingGunManualAim;
                @Steering.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @HandBrake.started += instance.OnHandBrake;
                @HandBrake.performed += instance.OnHandBrake;
                @HandBrake.canceled += instance.OnHandBrake;
                @NOS.started += instance.OnNOS;
                @NOS.performed += instance.OnNOS;
                @NOS.canceled += instance.OnNOS;
                @GatlingGunManualAim.started += instance.OnGatlingGunManualAim;
                @GatlingGunManualAim.performed += instance.OnGatlingGunManualAim;
                @GatlingGunManualAim.canceled += instance.OnGatlingGunManualAim;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    private int m_OculusSchemeIndex = -1;
    public InputControlScheme OculusScheme
    {
        get
        {
            if (m_OculusSchemeIndex == -1) m_OculusSchemeIndex = asset.FindControlSchemeIndex("Oculus");
            return asset.controlSchemes[m_OculusSchemeIndex];
        }
    }
    public interface IDrivingActions
    {
        void OnAcceleration(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnHandBrake(InputAction.CallbackContext context);
        void OnNOS(InputAction.CallbackContext context);
        void OnGatlingGunManualAim(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
    }
}
