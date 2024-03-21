using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void tryAgain()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}