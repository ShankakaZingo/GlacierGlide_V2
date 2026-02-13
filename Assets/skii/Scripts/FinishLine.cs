using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [Header("UI")]
    public GameObject winCanvas; 
    public GameObject memeObject;

    [Header("Audio")]
    public AudioSource backgroundMusic; // To stop the music when you win

    private void OnTriggerEnter(Collider other)
    {
        // Detect if Player hits the line
        // (Make sure XR Origin is tagged "Player")
        if (other.CompareTag("Player") )//|| other.CompareTag("MainCamera"))
        {
            Debug.Log("YOU WIN!");

            // 1. Stop the world moving
            PlaneMovement.isGameStopped = true;

            // 2. Stop Music
            if (backgroundMusic != null) backgroundMusic.Stop();

            // 3. Show Win UI
            if (winCanvas != null) winCanvas.SetActive(true);

            memeObject.SetActive(true);

        }
    }
}