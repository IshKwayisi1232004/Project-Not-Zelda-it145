using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GameObject enemySound;

    // Start is called before the first frame update
    void Start()
    {
        enemySound.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "enemy")
        {
            enemySound.SetActive(true);
            Destroy(other.gameObject);
            
        }
    }
}
