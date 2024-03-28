using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseSound;
    public GameObject quitSound;

    private void Start()
    {
        pauseMenu.SetActive(false);
        pauseSound.SetActive(false);
        quitSound.SetActive(false);
    }

    public void Pause()
    {
        pauseSound.SetActive(true);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pauseSound.SetActive(false);
    }

    public void Quit()
    {
        quitSound.SetActive(true);
        StartCoroutine(WaitBeforeLoad());
        SceneManager.LoadScene("TitleScreen");
        quitSound.SetActive(false);
        Time.timeScale = 1;
    }

    private IEnumerator WaitBeforeLoad()
    {
        yield return new WaitForSeconds(3);
    }
}
