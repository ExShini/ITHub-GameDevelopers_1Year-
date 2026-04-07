using UnityEngine;
using uSimFramework.SiegeEngines;
using UnityEngine.InputSystem;

public class MyShooter : MonoBehaviour
{
    ReleaseMecanism _charger;
    InputSystem_Actions _inputActions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _charger = gameObject.GetComponent<ReleaseMecanism>();
        _inputActions = new InputSystem_Actions();
        _inputActions.Player.Attack.performed += SetupRelease;
        _inputActions.Player.Enable();
    }

    void SetupRelease(InputAction.CallbackContext cont)
    {
        _charger.releaseCommand = true;
    }
}
