using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public Button menuButton;

    private void Start()
    {
        menuButton.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        if (Application.isPlaying)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
