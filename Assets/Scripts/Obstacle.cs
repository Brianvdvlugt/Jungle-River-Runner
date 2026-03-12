using UnityEngine;

public class Obstacle : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Destroy(gameObject);
            gameManager.PlayerLives--;
            gameManager.LivesText.text = "Lives: " + gameManager.PlayerLives;
        }
    }
}
