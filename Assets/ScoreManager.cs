using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text score_text;
    public int Score = 0;

    public void SetScore(int _score)
    {
        Score = _score;
        score_text.text = "Score: " + Score;
    }
}
