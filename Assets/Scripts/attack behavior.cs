using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackbehavior : MonoBehaviour
{
    private GameObject attackArea = default;
    private bool attacking = false;
    private bool attackInitiated = false; // Flag to track whether an attack has been initiated

    [SerializeField] private float swordSpeed;
    public Animator animator;

    private void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        // Check if the space key is pressed to start attacking
        if (!attacking && Input.GetKeyDown(KeyCode.Space) && !attackInitiated)
        {
            Attack();
            attackInitiated = true; // Set the flag to true indicating an attack has been initiated
        }
        // Check if the space key is released to stop attacking
        else if (attacking && Input.GetKeyUp(KeyCode.Space))
        {
            StopAttack();
            attackInitiated = false; // Reset the flag when the attack stops
        }
    }

    private void Attack()
    {
        attacking = true;
        animator.SetTrigger("attacking");
        // Optionally, activate the attack area collider or perform other attack-related actions
    }

    private void StopAttack()
    {
        // This method is now triggered by an animation event
    }

    // Method to be called by the animation event
    public void EndAttackAnimation()
    {
        attacking = false;
    }
}
