using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow_Arrow : MonoBehaviour
{
    //Arrow
    public float life = 3; 

    public Transform bulletSpawnPointRight;
    public Transform bulletSpawnPointLeft;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
