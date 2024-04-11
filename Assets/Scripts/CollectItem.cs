using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    private int orbCount = 0;
    public GameObject collectSound;
    public ScoreManager save;
    // Start is called before the first frame update
    void Start()
    {
        collectSound.SetActive(false);
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //string dataToKeep = myText.text;
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); 
           // collectSound.SetActive(true);
            orbCount++;
            Debug.Log("Orbs: " +  orbCount);
            //collectSound.SetActive(false);
            SceneManager.LoadScene("EndScreen");
            //StaticData.valueToKeep = dataToKeep;

        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreManager score;
    }
}
