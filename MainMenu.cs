using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MainMenu : MonoBehaviour
{
    public GameObject instructionsText; // Reference to the instructions text GameObject

    // Start is called before the first frame update
    void Start()
    {
        // Hide the instructions text initially
        instructionsText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // Load the game scene
        Application.LoadLevel("Game");
    }

    public void Quit()
    {
        // Quit the application
        Application.Quit();
    }

    public void ShowInstructions()
    {
        // Show the instructions text when the button is clicked
        instructionsText.SetActive(true);
    }
}
