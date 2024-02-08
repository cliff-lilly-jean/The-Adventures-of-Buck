using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    GameControls _gameControls;

    void Awake()
    {
        // Initialize the input actions asset
        _gameControls = new GameControls();

        _gameControls.Movement.Jump.performed += OnJump;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Custom Methods
    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
    }
}
