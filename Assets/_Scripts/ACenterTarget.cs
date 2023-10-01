using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACenterTarget : MonoBehaviour, IHittable
{

 public int scoreOnHit = 0; 

    [SerializeField]
    private AudioSource audioSource;

   
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow") == false)
        {
            audioSource.Play();
        }
    }

    public void GetHit()
    {
       
         GetPoint getPointScript = FindObjectOfType<GetPoint>();
            if (getPointScript != null)
            {
                getPointScript.AddPoints(scoreOnHit);
            }
       
    }

   
}