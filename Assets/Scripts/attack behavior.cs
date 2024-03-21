//Script for the player to attack when a key is input.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackbehavior : MonoBehaviour
{
    private GameObject attackArea = default;
    public GameObject swordSlash;
    private bool attacking = false;

    [SerializeField] private float swordSpeed;

    private float timerToAttack = 0.25f;
    //private float timer = 0f;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        swordSlash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (timerToAttack < 0f)
        {
            //attacking = false;
            //attackArea.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                slash();
                Attack();
            }
        }
        else
        {
            timerToAttack -= Time.deltaTime;
            animator.ResetTrigger("attacking");
            stopSlash();
        }
    }


    private void Attack()
    {
        animator.SetTrigger("attacking");
        timerToAttack = swordSpeed;
        //attacking = true;
        //attackArea.SetActive(attacking);
    }

    void slash()
    {
        swordSlash.SetActive(true);
    }

    void stopSlash()
    {
        swordSlash.SetActive(false);
    }
}