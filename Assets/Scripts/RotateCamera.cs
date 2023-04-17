using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private InputControll inputControll;

    private float xRotation;
    
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        xRotation -= inputControll.MouseInput.y;
        xRotation = Mathf.Clamp(xRotation, -70f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
