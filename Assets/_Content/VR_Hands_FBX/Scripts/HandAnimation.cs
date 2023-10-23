using UnityEngine;

public class HandAnimation : MonoBehaviour
{

    private Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }


    public void TriggerGrab() => animator.SetTrigger("Grab");
    public void TriggerLet() => animator.SetTrigger("Let");
}
