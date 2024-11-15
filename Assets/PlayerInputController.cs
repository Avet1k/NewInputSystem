using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerInputController : MonoBehaviour
{
    private void OnShoot()
    {
        Debug.Log("Shoot");
    }
}
