using UnityEngine;

public class Oefenscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string LeeftijdenBijElkaar(int leeftijd1, int leeftijd2, int leeftijd3)
    {
        int totaalLeeftijd = leeftijd1 + leeftijd2 + leeftijd3;
        return $"De totale leeftijd is {totaalLeeftijd} jaar.";
    }

}
