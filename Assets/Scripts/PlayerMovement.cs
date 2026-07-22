using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction MoveAction;
    public Vector2 MoveInput;
    public float Speed;
    public float Turn;

    private void OnEnable()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        MoveInput = MoveAction.ReadValue<Vector2>();
        transform.Rotate(Vector3.up, Turn * Time.deltaTime * MoveInput.x);
        transform.Translate(Vector3.forward * MoveInput.y * Speed * Time.deltaTime);
    }
}
