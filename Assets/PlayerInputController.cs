using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player.Shoot.performed += OnShoot;
        _playerInput.Player.Move.performed += OnMove;
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("Shoot");
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 direction = context.action.ReadValue<Vector2>();
        Debug.Log(direction);
    }
}
