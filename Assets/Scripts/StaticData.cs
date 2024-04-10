using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaticData : MonoBehaviour
{
    public Text scoreAccumulation;

    // Use this for initialization
    void Start()
    {
        scoreAccumulation.text = "Final Score: " + PlayerPrefs.GetInt("CoinsCollected").ToString();
    }
}
