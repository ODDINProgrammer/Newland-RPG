using System.Runtime.CompilerServices;
using UnityEngine;

public class MovementControll : MonoBehaviour, ICanMove
{
    private InputControll inputController;
    private Player player;

    private float yRot;

    [SerializeField]
    private Transform groundedChecker;
    private bool isGrounded = true;
    [SerializeField]
    private float jumpForce;

    private void Awake()
    {
        player = GetComponent<Player>();
        inputController = GetComponent<InputControll>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        yRot += inputController.MouseInput.x;

        transform.localRotation = Quaternion.Euler(0, yRot, 0);
    }

    public void Jump()
    {
        if(isGrounded)
        {
            player.RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void Move()
    {
        float movementSpeed = player.MovementSpeed;
        Vector2 movePos = inputController.Movement;
        Vector3 newPosition = new Vector3 (movePos.x, 0f, movePos.y);

        transform.Translate(newPosition * movementSpeed * Time.deltaTime);
    }

    
}
