using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text saveScore;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void addPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
        Debug.Log(scoreText);
       // if(SceneManager = "Endcreen")
        //{

        //}
    }

    void Update() {
        saveScore = scoreText;
    }
}
