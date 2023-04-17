using UnityEngine;

public class MovementControll : MonoBehaviour, ICanMove
{
    private InputControll inputController;
    private Player player;

    private float yRot;

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

    public void Move()
    {
        float movementSpeed = player.MovementSpeed;
        Vector2 movePos = inputController.Movement;
        Vector3 newPosition = new Vector3 (movePos.x, 0f, movePos.y);

        transform.Translate(newPosition * movementSpeed * Time.deltaTime);
    }

}
