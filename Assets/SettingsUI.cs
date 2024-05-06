using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SettingsUI : MonoBehaviour
{
    public GameObject settingsUI;
    public InputActionReference openSettingsAction;
    private void Awake()
    {
        openSettingsAction.action.Enable();
        openSettingsAction.action.performed += ToggleSettings;
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    private void OnDestroy()
    {
        openSettingsAction.action.Disable();
        openSettingsAction.action.performed -= ToggleSettings;
        InputSystem.onDeviceChange -= OnDeviceChange;
    }
    
    void ToggleSettings(InputAction.CallbackContext context)
    {
        settingsUI.SetActive(!settingsUI.activeSelf);
    }

    void OnDeviceChange (InputDevice device, InputDeviceChange change)
    {
        switch(change)
        {
            case InputDeviceChange.Disconnected:
                openSettingsAction.action.Disable();
                openSettingsAction.action.performed -= ToggleSettings;
                break;
            case InputDeviceChange.Reconnected:
                openSettingsAction.action.Enable();
                openSettingsAction.action.performed += ToggleSettings;
                break;

        }
    }
}
