using UnityEngine;
using UnityEngine.InputSystem;

public class Boat : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float RotateSpeed;
    [SerializeField] private float boostSpeed;

    public bool Boosting;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            Boosting = true;
        }
        else
        {
            Boosting = false;
        }

    }
}

