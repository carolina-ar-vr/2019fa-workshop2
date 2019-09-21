using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score;
    private TextMesh scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMesh>();
        AdjustScore(0);
    }

    public void AdjustScore(int points) {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
