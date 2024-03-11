using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattacking: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

// Assuming this is the start of a new class
public class PlayerAttack : MonoBehaviour
{
    // Adjust the attack damage according to your game design
    public int attackDamage = 2;

    // Set the attack cooldown to prevent spamming attacks
    public float attackCooldown = 1f;
    private float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // Check for player input (e.g., spacebar) to trigger the attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if enough time has passed since the last attack
            if (Time.time >= nextAttackTime)
            {
                // Trigger the attack
                Attack();

                // Set the next attack time based on the cooldown
                nextAttackTime = Time.time + 1f / attackCooldown;
            }
        }
    }

    void Attack()
    {
        // Perform attack logic here, e.g., deal damage to enemies
        Debug.Log("Player attacks!");

        // You can add more logic here, like dealing damage to enemies, playing attack animation, etc.
    }
}