using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //Creates a public variable to transfer functions across differnt scripts
    public static ScoreManager instance;

    //Creates the score text variable
    public Text scoreText;

    //Creates the score variable, where the score is stored. 
    public int score = 0;

    private void Awake()
    {
        //Allows the instance variable to be referred in other scripts
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Always sets the score to 0 at the beginning of the
        //program
        scoreText.text = "Score: " + score.ToString();
    }

    public void addPointBronze()
    {
        score += 50;
        scoreText.text = "Score: " + score.ToString();
    }

    public void addPointSilver()
    {
        score += 200;
        scoreText.text = "Score: " + score.ToString();
    }

    public void addPointGold()
    {
        score += 400;
        scoreText.text = "Score: " + score.ToString();
    }

    void Update() {
        //Here we are calling a class called "PlayerPrefs"
        //And we are setting a tag and integer in the parameters
        //This stores data for the player between different scenes
        PlayerPrefs.SetInt("CoinsCollected", score);
    }
}
