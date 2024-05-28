using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenu;

    public static WinMenu Instance { get; private set; }

    void Awake()
    {
        // Ensures there's only one instance of WinMenu
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            // Destroys duplicate instance
            Destroy(gameObject);
        }

        // Ensures the Win Menu is initially hidden
        winMenu.SetActive(false);
    }

    public void ShowWinMenu()
    {
        winMenu.SetActive(true); // Shows the Win Menu
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("NextLevel");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
