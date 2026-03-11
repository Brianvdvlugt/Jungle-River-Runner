using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{

    [SerializeField] GameObject Button;

    void Start()
    {
        
    }

    
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;
           if (Physics.Raycast(ray, out hit))
           {
               if (hit.collider.gameObject == Button)
               {
                   SceneManager.LoadScene("MainScene");
               }
           }
        }
    }
}
