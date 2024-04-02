using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectItem : MonoBehaviour
{
    private int orbCount = 0;
    public GameObject collectSound;
    // Start is called before the first frame update
    void Start()
    {
        collectSound.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); 
            collectSound.SetActive(true);
            orbCount++;
            Debug.Log("Orbs: " +  orbCount);
            collectSound.SetActive(false);
            SceneManager.LoadScene("EndScreen");
        }
    }

    // Update is called once per frame
    //void Update()
    //{    
    //}
}
