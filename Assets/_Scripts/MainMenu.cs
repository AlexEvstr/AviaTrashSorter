using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _bestScore;
    [SerializeField] private GameObject _musicOn;
    [SerializeField] private GameObject _musicOff;

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("bestScore", 0);
        _bestScore.text = $"BEST SCORE: {bestScore}";

        AudioListener.volume = PlayerPrefs.GetFloat("music", 1);
        if (AudioListener.volume == 1)
        {
            MusicOn();
        }
        else
        {
            MusicOff();
        }
    }

    public void MusicOff()
    {
        _musicOn.SetActive(false);
        _musicOff.SetActive(true);
        AudioListener.volume = 0;
    }

    public void MusicOn()
    {
        _musicOn.SetActive(true);
        _musicOff.SetActive(false);
        AudioListener.volume = 1;
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("music", AudioListener.volume);
    }
}