using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private ItemBase activeItem;

    public void InteractWithActiveItem()
    {
        IUsableItem usableItem = activeItem.GetComponent<IUsableItem>();
        if (activeItem != null && usableItem != null) 
        {
            usableItem.Use();
        }
    }
}
