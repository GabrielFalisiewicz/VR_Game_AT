using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttemptsCounter : MonoBehaviour
{
    public int maxAttempts = 5; // Początkowa ilość podejść
    private int currentAttempts; // Aktualna ilość podejść
    public TMP_Text attemptsText;

    // Właściwość do dostępu i modyfikacji currentAttempts
    public int CurrentAttempts
    {
        get { return currentAttempts; }
        set { currentAttempts = value; }
    }

    void Start()
    {
        currentAttempts = maxAttempts;
        attemptsText = GetComponent<TMP_Text>();
        UpdateAttemptsText();
    }

    public bool DecreaseAttempt()
    {
        if (currentAttempts > 0)
        {
            currentAttempts--; // Odejmij jedno podejście
            UpdateAttemptsText();

            if (currentAttempts <= 0)
            {
                currentAttempts = 0;
            }
            return true; // Zwróć true, jeśli nadal są dostępne podejścia
        }
        return false; // Zwróć false, jeśli nie ma już dostępnych podejść
    }

    public void UpdateAttemptsText()
    {
        attemptsText.text = "Podejścia: " + currentAttempts.ToString();
    }
}
