using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanaAnimation : MonoBehaviour
{
   Animator animator;

    private string wake;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


}
