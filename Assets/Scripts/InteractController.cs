using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    private IInteractable go;

    private void Awake()
    {
        PlayerEvents.OnInteraction.AddListener(Interact);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IInteractable>() == null) return;

        go = other.gameObject.GetComponent<IInteractable>();
    }

    private void OnTriggerExit(Collider other)
    {
        go = null;
    }

    public void Interact()
    {
        if (go != null) go.Interact();
    }
}
