using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private CoinSystem _coinSystem;

    private void Start()
    {
        _coinSystem = FindObjectOfType<CoinSystem>();
    }

    private void Update()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (_coinSystem != null)
        {
            // coinCount is coming from CoinsSystem class
            scoreText.text = "Score: " + _coinSystem.coinCount;
        }
    }
}
