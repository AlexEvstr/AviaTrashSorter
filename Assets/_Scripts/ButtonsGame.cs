using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGame : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void OpenPause()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePause()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
