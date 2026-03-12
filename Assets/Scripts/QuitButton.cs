using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quitbutton : MonoBehaviour
{
    public Button quitButton;

    private void Start()
    {
        quitButton.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        if (Application.isPlaying)
        {
            Application.Quit();

        }
    }
}
