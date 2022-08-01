using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JaiMataDi : MonoBehaviour
{
    public int maxValue;
    public Image fill;
    public TextMeshProUGUI progress;
    private int currentValue;

    

    private void Start()
    {
        currentValue = 0;
        fill.fillAmount = 0;
    }

    public void Add(int i)
    {
        currentValue += i;

        if (currentValue > maxValue)
            currentValue = maxValue;
        fill.fillAmount = (float)currentValue/ maxValue;

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Add(12);
    }
}
