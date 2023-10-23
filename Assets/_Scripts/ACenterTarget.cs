using UnityEngine;

public class ACenterTarget : MonoBehaviour, IHittable
{
    public int scoreOnHit = 0;
    [SerializeField] private AudioSource audioSource;

    public void GetHit()
    {
        if(audioSource == null)
        {
            Debug.LogError("AudioSource nie zosta� przypisany w inspektorze.");
            return; // Przerwij operacj� je�li audioSource jest r�wny null.
        }

        GetPoint getPointScript = FindObjectOfType<GetPoint>();
        if (getPointScript != null)
        {
            getPointScript.AddPoints(scoreOnHit);
            audioSource.Play();
        }
    }
}
