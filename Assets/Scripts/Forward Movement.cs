using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        if (Application.isPlaying == true) {

            rb.AddForce(0, 0, 10);

        }
    }
   
    void Update()
    {
        
    }

}
