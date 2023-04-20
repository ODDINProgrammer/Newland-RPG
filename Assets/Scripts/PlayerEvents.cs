using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class PlayerEvents
{
    public static UnityEvent OnInteraction = new UnityEvent();
    public static UnityEvent OnItemUse = new UnityEvent();
    public static UnityEvent OnInventory = new UnityEvent();
}
