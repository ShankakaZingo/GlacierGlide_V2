using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float speed = 15f; 
    
    // The Global Stop Switch
    public static bool isGameStopped = false;

    void Start()
    {
        // Reset the switch every time we play
        isGameStopped = false;
    }

    void Update()
    {
        // 1. Check if the game is stopped
        if (isGameStopped == true) return;

        // 2. Move Backwards
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}