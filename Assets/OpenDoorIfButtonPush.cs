using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit.Interactables; 

public class OpenDoorIfButtonPush : MonoBehaviour
{
    // FIX 1: 'public' was spelled wrong
    // FIX 2: 'Animator' was spelled 'Aminator'
    public Animator animator; 
    
    // FIX 3: 'public' was spelled wrong
    public string boolName = "Open"; 

    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleDoorOpen());
    }

    // FIX 4: 'public' was spelled wrong
    public void ToggleDoorOpen()
    {
        bool isOpen = animator.GetBool(boolName); 
        animator.SetBool(boolName, !isOpen);
    }
}