using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private void PlayAnimation()
    {
        GetComponent<Animator>().Play("Waving"); ;
    }



}
