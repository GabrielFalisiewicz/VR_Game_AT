using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetPoint : MonoBehaviour
{
    public int score = 0;
      public TMP_Text coins;
    void Start(){
        coins = GetComponent<TMP_Text>();
        UpdatePointsText();
    } 
    // Start is called before the first frame update
   public void resetscore(){
    score = 0;
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
   public void AddPoints(int amount){
        score += amount;
        UpdatePointsText();
   } 
   void UpdatePointsText(){
        coins.text = "Twoj wynik: " + score.ToString();
   }
   
   
}
