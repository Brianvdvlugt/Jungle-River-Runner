using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    private Rigidbody rb;

    private Boat boat;

    [SerializeField] private float baseSpeed;

    void Start()
    {
        boat = FindFirstObjectByType<Boat>();
    }
   
    void FixedUpdate()
    {
        transform.position += Vector3.forward * baseSpeed * Time.fixedDeltaTime;


    }

}
