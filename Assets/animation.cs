using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayMove1()
    {
        animator.SetTrigger("Move");

    }
    public void PlayMove2()
    {
        animator.SetTrigger("move2");

    }
    public void PlayJump()
    {
        animator.SetTrigger("Jump");
    }
    public void PlayDoubleJump()
    {
        animator.SetTrigger("DoubleJump");
    }
}
