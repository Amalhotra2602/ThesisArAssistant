using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;
public class PanelOpen2 : MonoBehaviour
{

    public GameObject PanelOpen;
    public GameObject Animation;

    // Start is called before the first frame update
    public void AnimationEnd()
    {
        if (Animation != false)
        {
            PanelOpen.SetActive(true);


        }

    }

}
