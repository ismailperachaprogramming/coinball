using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{
    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    public Text mutetext;

    void Start()
    {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;

        }
        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "Unmute";

        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
        }
    }

    public void Resume()
    {
        paused = false;

    }
    public void MainMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("currentscenesave", SceneManager.GetActiveScene().buildIndex);

    }
    public void Load()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
    }
    public void Mute()
    {
        muted = !muted;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
