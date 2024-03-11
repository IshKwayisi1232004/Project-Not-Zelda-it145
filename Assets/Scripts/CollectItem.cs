using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private int orbCount = 0;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Orb"))
        {
            Destroy(collision.gameObject); 
            orbCount++;
            Debug.Log("Orbs: " +  orbCount);
        }
    }

    // Update is called once per frame
    //void Update()
    //{    
    //}
}
