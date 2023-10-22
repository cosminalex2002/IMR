using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreboardController : MonoBehaviour
{
    TextMeshPro tmpro;
    float totalScore;

    void Start()
    {
        tmpro = gameObject.GetComponent<TextMeshPro>();
        totalScore = 0;
    }

    public void UpdateScore(float score)
    {
        totalScore += score;
        tmpro.text = "Score: " + totalScore;      
    }
}