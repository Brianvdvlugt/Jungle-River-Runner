using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> ObsticleVarients = new List<GameObject>();
    [SerializeField] private List<GameObject> DebrisVarients = new List<GameObject>();
    void Start()
    {
        StartGame();
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        for (int i = 0; i < 7; i++)
        {
            Instantiate(ObsticleVarients[Random.Range(0, 3)], new Vector3(Random.Range(-11f, 3.6f), Random.Range(-0.19f, 0f), Random.Range(0, 160)), Quaternion.identity);
        }

        for (int i = 0; i < 5; i++)
        {
            Instantiate(DebrisVarients[Random.Range(0, 2)], new Vector3(Random.Range(-11f, 3.6f), 0.26f, Random.Range(0, 160)), Quaternion.identity);
        }
    }
}
