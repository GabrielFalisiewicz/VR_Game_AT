using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetPoint : MonoBehaviour
{
    public int score = 0;
    public TMP_Text coins;
    public AttemptsCounter attemptsCounter; // Referencja do skryptu AttemptsCounter

    void Start()
    {
        coins = GetComponent<TMP_Text>();
        UpdatePointsText();
    }

    public void resetscore()
    {
        score = 0;
        attemptsCounter.CurrentAttempts = attemptsCounter.maxAttempts;
        attemptsCounter.UpdateAttemptsText();
        UpdatePointsText();
        DestroyObjectsWithTag("StickArrow");
    }

    void DestroyObjectsWithTag(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
    }

    public void AddPoints(int amount)
    {
        if (attemptsCounter.DecreaseAttempt()) // Sprawdź, czy nadal są dostępne podejścia
        {
            score += amount;
            UpdatePointsText();
        }
    }

    void UpdatePointsText()
    {
        coins.text = "Twoj wynik: " + score.ToString();
    }
}
