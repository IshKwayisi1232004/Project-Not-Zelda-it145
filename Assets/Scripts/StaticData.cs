using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaticData : MonoBehaviour
{
    //Creates a variable to store overall score
    public Text scoreAccumulation;

    // Use this for initialization
    void Start()
    {
        //Now I am retrieving the data for the score and storing it into the 
        //the new variable "scoreAccumulation.
        //Add this script to the end screen and store a text GameObject
        scoreAccumulation.text = "Final Score: " + PlayerPrefs.GetInt("CoinsCollected").ToString();
    }
}
