using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent onInteract = new UnityEvent();
    
    public void Interact()
    {
        Debug.Log("Interacted with chest!");
        onInteract.Invoke();
    }

    
}
