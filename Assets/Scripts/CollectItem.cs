using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectItem : MonoBehaviour
{
    private int orbCount = 0;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); 
            orbCount++;
            Debug.Log("Orbs: " +  orbCount);
            SceneManager.LoadScene("EndScreen");
        }
    }

    // Update is called once per frame
    //void Update()
    //{    
    //}
}
