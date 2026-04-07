using UnityEngine;
using uSimFramework.SiegeEngines;
using UnityEngine.InputSystem;

public class MyCharget : MonoBehaviour
{
    ChargeMecanism _charger;
    InputSystem_Actions _inputActions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _charger = gameObject.GetComponent<ChargeMecanism>();
        _inputActions = new InputSystem_Actions();
        _inputActions.Player.Charge.performed += SetupCharge;
        _inputActions.Player.Enable();
    }

    void SetupCharge(InputAction.CallbackContext cont)
    {
        _charger.actionCharge = true;
    }
    
}
