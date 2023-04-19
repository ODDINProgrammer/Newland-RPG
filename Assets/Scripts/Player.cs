using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player stats")]
    [SerializeField] 
    private float movementSpeed;
    public float MovementSpeed => movementSpeed;

    [SerializeField]
    private Rigidbody rb;
    public Rigidbody RB => rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

}
