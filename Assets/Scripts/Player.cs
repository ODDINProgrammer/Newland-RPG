using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player stats")]
    [SerializeField] private float movementSpeed;
    public float MovementSpeed => movementSpeed;
}
