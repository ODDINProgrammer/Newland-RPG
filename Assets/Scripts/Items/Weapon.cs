using System;
using UnityEngine;

public abstract class Weapon : ItemBase, IUsableItem
{
    [SerializeField] 
    protected int damage;
    [SerializeField]
    private Animator animator;

    public virtual void Attack()
    {
        animator.SetTrigger("Attack");
    }

    public void Use()
    {
        Attack();
    }
}
