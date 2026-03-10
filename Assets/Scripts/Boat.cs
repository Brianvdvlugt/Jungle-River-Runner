using UnityEngine;
using UnityEngine.InputSystem;

public class Boat : MonoBehaviour
{
    public Rigidbody rb;

    public float RotateSpeed = 1;
    public float boostSpeed = 1.5f;
    public float baseSpeed = 1;
    
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float InputRotateLeft;
        float InputRotateRight;

        InputRotateLeft = Mathf.Max(Keyboard.current.leftShiftKey.ReadValue());
        InputRotateRight = Mathf.Max(Keyboard.current.rightShiftKey.ReadValue());

        if (InputRotateLeft == 1 && InputRotateRight == 0)
        {
            rb.AddTorque(Vector3.down * RotateSpeed);
        }

        if (InputRotateRight == 1 && InputRotateLeft == 0)
        {
            rb.AddTorque(Vector3.up * RotateSpeed);
        }

        if (InputRotateLeft == 1 && InputRotateRight == 1)
        {
            rb.AddRelativeForce(Vector3.forward * boostSpeed);

        }

        transform.position += Vector3.forward * baseSpeed * Time.fixedDeltaTime;

    }
}

