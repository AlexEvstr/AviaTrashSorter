using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    public static int Score;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        if (Score < 0) Score = 0; 
        _scoreText.text = $"Score: {Score}";
    }
}
