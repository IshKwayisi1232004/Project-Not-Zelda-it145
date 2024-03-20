using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth == 0)
        {
            anim.SetBool("IsDead", true);
            Destroy(gameObject);
        }
    }

    void heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > 0)
        {
            //anim.SetBool("IsDead", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
