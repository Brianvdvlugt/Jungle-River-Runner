using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject boat;
    private Rigidbody rb;
    private Rigidbody boatRb;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float boostSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        boatRb = boat.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
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
            boatRb.AddTorque(Vector3.down * rotateSpeed);
        }

        if (InputRotateRight == 1 && InputRotateLeft == 0)
        {
            boatRb.AddTorque(Vector3.up * rotateSpeed);
        }

        if (InputRotateLeft == 1 && InputRotateRight == 1)
        {
            float x = Mathf.Cos((boat.transform.localEulerAngles.y + 90f) * Mathf.Deg2Rad);
            float y = Mathf.Sin((boat.transform.localEulerAngles.y + 90f) * Mathf.Deg2Rad);

            boatRb.AddForce(-x * boostSpeed, 0, 0);
            rb.AddForce(0, 0, y * boostSpeed);
        }

    }

    
}
