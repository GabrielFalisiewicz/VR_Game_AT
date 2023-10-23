using TMPro;
using UnityEngine;

public class GetPoint : MonoBehaviour
{
    public int score = 0;
    public TMP_Text coins;
    public AttemptsCounter attemptsCounter; // Referencja do skryptu AttemptsCounter NIE TYKAC

    public MovingTargetUpDown movingTarget;

    void Start()
    {
        
        if (coins == null)
        {
            Debug.LogError("Nie przypisano komponentu TMP_Text w inspektorze.");
            return;
        }
        coins = GetComponent<TMP_Text>();
        UpdatePointsText();

    }

    public void resetscore()
    {

        score = 0;
        attemptsCounter.CurrentAttempts = attemptsCounter.maxAttempts;
        UpdatePointsText();
        attemptsCounter.UpdateAttemptsText();
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
        if (attemptsCounter.DecreaseAttempt())
        {
            if (attemptsCounter == null)
            {
                Debug.LogError("Nie przypisano skryptu AttemptsCounter w inspektorze.");
                return;
            }
            score += amount;
            UpdatePointsText();

            if (movingTarget != null)
            {
                movingTarget.ResumeMoving();
            }
        }
    }

    void UpdatePointsText()
    {
        coins.text = "Twoj wynik: " + score.ToString();
    }
}
