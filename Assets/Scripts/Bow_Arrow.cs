using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bow_Arrow : MonoBehaviour
{
    //Arrow
    public float speed = 4.5F;

    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreManager.instance.addPointBronze();
        }

        if (other.tag == "hee-ho")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreManager.instance.addPointSilver();
        }

        if (other.tag == "tonberry")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreManager.instance.addPointGold();
        }

    }
}
