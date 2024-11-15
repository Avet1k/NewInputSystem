using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerInputController : MonoBehaviour
{
    public void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("Shoot");
    }
}
