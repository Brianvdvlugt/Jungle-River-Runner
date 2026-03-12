//using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> ObsticleVarients = new List<GameObject>();
    [SerializeField] private List<GameObject> DebrisVarients = new List<GameObject>();
    [SerializeField] public int PlayerLives;

    public TMP_Text LivesText;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (PlayerLives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void StartGame()
    {
        PlayerLives = 3;

        LivesText.text = "Lives: " + PlayerLives;

        for (int i = 0; i < 7; i++)
        {
            Instantiate(ObsticleVarients[Random.Range(0, 3)], new Vector3(Random.Range(-11f, 3.6f), Random.Range(-0.19f, 0f), Random.Range(15, 160)), Quaternion.identity);
        }

        for (int i = 0; i < 5; i++)
        {
            Instantiate(DebrisVarients[Random.Range(0, 2)], new Vector3(Random.Range(-11f, 3.6f), 0.26f, Random.Range(15, 160)), Quaternion.identity);
        }
    }
}
