using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _bestPause;
    [SerializeField] private TMP_Text _bestFinish;
    public static int Score;
    private int _bestScore; 

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("bestScore", 0);
        Score = 0;
    }

    private void Update()
    {
        if (Score < 0) Score = 0;
        if (Score > _bestScore)
        {
            _bestScore = Score;
            PlayerPrefs.SetInt("bestScore", _bestScore);
        }
        _scoreText.text = $"Score: {Score}";
        _bestPause.text = $"BEST SCORE: {_bestScore}";
        _bestFinish.text = $"BEST SCORE: {_bestScore}";
    }
}
