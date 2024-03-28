using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Animator anim;
    public GameObject death;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        anim.ResetTrigger("IsDead");
        death.SetActive(false);
    }

    public void takeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth == 0)
        {
            anim.SetTrigger("IsDead");
            death.SetActive(true);
            StartCoroutine(spawnDelay());
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

    private IEnumerator spawnDelay()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
    }
}
