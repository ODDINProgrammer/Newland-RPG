using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputControll : MonoBehaviour
{
    [SerializeField]
    [Range(100f, 500f)]
    private float mouseSensitivity;
    public Vector2 Movement { get; private set; }
    public Vector2 MouseInput { get; private set; }

    private InputAction.CallbackContext context;

    private void Awake()
    {
        CursorLockMode cursor = CursorLockMode.Locked;
    }

    private void Update()
    {
        ReadMouseInput();
    }

    private void ReadMouseInput()
    {
        float xInput = Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime;
        float yInput = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;

        MouseInput = new Vector2(xInput, yInput);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            PlayerEvents.OnInteraction.Invoke();
        }
    }

    public void OnItemUse(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            PlayerEvents.OnItemUse.Invoke();
        }
    }

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            PlayerEvents.OnInventory.Invoke();
        }
    }
}
