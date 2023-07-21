using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreCounter;

    public void Start()
    {
        scoreCounter = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreCounter.text = playerScore.ToString();
    }
}
