using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _bestScore;

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("bestScore", 0);
        _bestScore.text = $"BEST SCORE: {bestScore}";
    }
}