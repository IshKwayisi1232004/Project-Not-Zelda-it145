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

    public int score = 0;
    int finalScore;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
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

    public void showPoint() { 
        finalScore = score;
    }

    void Update() {
        PlayerPrefs.SetInt("CoinsCollected", score);
    }
}
