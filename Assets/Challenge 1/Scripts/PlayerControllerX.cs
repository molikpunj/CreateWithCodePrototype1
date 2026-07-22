using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public InputAction MoveAction;
    public float UpDown;
    public GameObject Propellor;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpDown = MoveAction.ReadValue<float>();
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * UpDown * Time.deltaTime);

        Propellor.transform.Rotate(Vector3.forward * 2000 * Time.deltaTime);
    }
}
