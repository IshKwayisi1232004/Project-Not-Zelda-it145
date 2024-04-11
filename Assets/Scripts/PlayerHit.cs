using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GameObject slimeSound;
    public GameObject heeSound;
    public GameObject tonberrySound;

    // Start is called before the first frame update
    void Start()
    {
        slimeSound.SetActive(false);   
        heeSound.SetActive(false);
        tonberrySound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "enemy")
        {
            heeSound.SetActive(false);
            tonberrySound.SetActive(false);
            slimeSound.SetActive(true);
            Destroy(other.gameObject);
            ScoreManager.instance.addPointBronze(); 
        }

        if (other.tag == "hee-ho")
        {
            slimeSound.SetActive(false);
            tonberrySound.SetActive(false);
            heeSound.SetActive(true);
            Destroy(other.gameObject);
            ScoreManager.instance.addPointSilver();
        }

        if (other.tag == "tonberry")
        {
            heeSound.SetActive(false);
            slimeSound.SetActive(false);
            tonberrySound.SetActive(true);
            Destroy(other.gameObject);
            ScoreManager.instance.addPointGold();
        }
    }
}
