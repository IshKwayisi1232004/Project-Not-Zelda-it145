using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //Sets the speed of the enemy's movement
    public float speed;

    //Public Enemy Object
    public GameObject enemy;

    //Creates an array that allows the user to place all the points of destination for the enemy
    public Transform[] moveLocation;

    //Sets the number spots an enemy can travel
    private int randomSpot;

    //Sets the amount of time it will take for the enemy to wait
    private float waitTime;

    public float startWaitTime;

    //Min and Max distance the enemy can go on screen
    //public float MinX;
    //public float MaxX;
    //public float MinY;
    //public float MaxY;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        //Randomizes the number of spots the enemy will travel depending on the length of the array
        randomSpot = Random.Range(0, moveLocation.Length);
    }

    // Update is called once per frame
    void Update()
    {
        //This allows the enemy to transition from different locations on the screen
        //The first parameter takes in the current position of the enemy
        //The second parameter takes in the destination for the enemy
        //The last parameter takes in the speed of the enemy movement
        transform.position = Vector2.MoveTowards(transform.position, moveLocation[randomSpot].position, speed * Time.deltaTime);

        //If statement for the enemy to pause once its hit its location
        if(Vector2.Distance(transform.position, moveLocation[randomSpot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                //Tells the enemy to move when the wait time is less than or equal to 0
                randomSpot = Random.Range(0, moveLocation.Length);
                waitTime = startWaitTime;
            }
            else
            {
                //Starts to decrease the wait time when greater than 0
                waitTime -= Time.deltaTime;
            }
        }
    }
}
