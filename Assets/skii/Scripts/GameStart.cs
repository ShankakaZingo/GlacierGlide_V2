using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    [Header("Settings")]
    public string sceneToLoad = "MainGame"; // MAKE SURE THIS MATCHES BUILD SETTINGS

    private void OnTriggerEnter(Collider other)
    {
       {
    Debug.Log("Hit by: " + other.name); // <--- 'other' instead of 'collision'

    if (other.CompareTag("Snowball"))
    {
        Debug.Log("LOADING SCENE...");
        SceneManager.LoadScene(sceneToLoad);
    }
}
    }
}