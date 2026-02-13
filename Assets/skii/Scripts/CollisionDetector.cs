using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR; 
using System.Collections.Generic;

public class CollisionDetector : MonoBehaviour
{
    [Header("UI & Visuals")]
    public GameObject gameOverCanvas;
    public GameObject redFlashPanel; 

    [Header("Audio")]
    public AudioSource backgroundMusic;
    public AudioSource crashSound;

    private void Start()
    {
        if(gameOverCanvas != null) gameOverCanvas.SetActive(false);
        if(redFlashPanel != null) redFlashPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            Debug.Log("CRASH!");

            // 1. Stop Movement
            PlaneMovement.isGameStopped = true;

            // 2. Play Sound
            if (backgroundMusic != null) backgroundMusic.Stop();
            if (crashSound != null) crashSound.Play();

            // 3. Show Red Flash
            if(redFlashPanel != null) redFlashPanel.SetActive(true);

            // 4. Vibrate Hands
            VibrateHands();

            // 5. Show Menu
            if(gameOverCanvas != null) gameOverCanvas.SetActive(true);
        }
    }

    void VibrateHands() // use only for hands ☠️
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

        foreach (var device in devices)
        {
            if (device.TryGetHapticCapabilities(out var capabilities) && capabilities.supportsImpulse)
            {
                device.SendHapticImpulse(0, 1.0f, 1.0f);
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}