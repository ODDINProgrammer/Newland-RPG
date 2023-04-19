using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.SetParent(null);
    }
}
