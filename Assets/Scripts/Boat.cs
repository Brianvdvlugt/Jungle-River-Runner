using UnityEngine;
using UnityEngine.InputSystem;

public class Boat : MonoBehaviour
{
        public float thrust = 1.0f;
        public Rigidbody rb;
    
    void Start()
    { }

    private void FixedUpdate()
    {
        float InputRotateLeft;
        float InputRotateRight;

        InputRotateLeft = Mathf.Max(Keyboard.current.leftShiftKey.ReadValue());
        InputRotateRight = Mathf.Max(Keyboard.current.rightShiftKey.ReadValue());

        if (InputRotateLeft == 1 && InputRotateRight == 0)
        {
            transform.Rotate(0, -1, 0);
        }

        if (InputRotateRight == 1 && InputRotateLeft == 0)
        {
            transform.Rotate(0, 1, 0);
        }

        if (InputRotateLeft == 1 && InputRotateRight == 1)
        {
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);

        }

    }
}

