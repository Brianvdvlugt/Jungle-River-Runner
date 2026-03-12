using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}
