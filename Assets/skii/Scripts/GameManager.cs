using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // This function is for the "Try Again" button
    public void RestartLevel()
    {
        // IMPORTANT: Reset your static stop variable so the game moves again!
        // (Assuming your moving script is called 'PlaneMovement')
        if (PlaneMovement.isGameStopped)
        {
            PlaneMovement.isGameStopped = false;
        }

        // Reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // This function is for the "Quit" button
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}