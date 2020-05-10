using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private bool isPaused = false;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject inventoryMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Pause"))
        {
            ChangePauseValue();
        }
    }

    void ChangePauseValue()
    {
        inventoryMenu.SetActive(false);

        isPaused = !isPaused;
        if (isPaused)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }
    }

    public void OpenInventory()
    {
        if (isPaused)
        {
            inventoryMenu.SetActive(true);
            pauseMenu.SetActive(false);
        }
    }

    public void ResumeButton()
    {
        ChangePauseValue();
    }

 
}
