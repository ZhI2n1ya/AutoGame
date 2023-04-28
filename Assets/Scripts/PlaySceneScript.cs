using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneScript : MonoBehaviour
{
    public GameObject pauseMunu;
    public GameObject pauseIcon;
    public GameObject settings;
    public GameObject cont;
    public GameObject exitMainMenu;

    void Update()
    {
        if (pauseMunu.activeSelf == true && Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMunu.SetActive(false);
        }
    }
    public void ClickPause()
    {
        pauseMunu.SetActive(true);
        Time.timeScale = 0f;
        pauseIcon.SetActive(false);
    }

    public void ClickExitMainMenu()
    {
        exitMainMenu.SetActive(true);
    }

    public void ClickCont()
    {
        pauseMunu.SetActive(false);
        Time.timeScale = 1f;
        pauseIcon.SetActive(true);
    }

    public void ClickContNo()
    {
        exitMainMenu.SetActive(false);
        pauseIcon.SetActive(false);
        pauseIcon.SetActive(false);
    }

    public void ClickSettings()
    {
        settings.SetActive(true);
        pauseIcon.SetActive(false);
        cont.SetActive(true);
    }

    public void ClickExitSettings()
    {
        settings.SetActive(false);
        pauseIcon.SetActive(false);
        cont.SetActive(false);
    }

    public void ReastartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pauseMunu.SetActive(false);
        Time.timeScale = 1f;
    }
}
