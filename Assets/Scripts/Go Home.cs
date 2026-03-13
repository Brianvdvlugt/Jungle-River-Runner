using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Easter egg Screen");
        }
    }
}
