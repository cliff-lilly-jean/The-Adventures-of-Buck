using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 _inputVector;

    public void Move(InputAction.CallbackContext context)
    {
        _inputVector = context.ReadValue<Vector2>();
        Debug.Log(_inputVector);
    }
}
