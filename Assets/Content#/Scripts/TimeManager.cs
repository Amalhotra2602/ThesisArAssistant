using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{
    public float timeValue = 10;
    public float breakTime = 2;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI BreakTimeText;

    public bool TimerActive = false;
    public bool BreakTimerActive = false;

    public GameObject Lana;

    

    private void Update()
    {
        if (TimerActive)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;

            }
            else
            {
                timeValue = 0;
            }
            DisplayTime(timeValue);
        }


        if (BreakTimerActive)
        {
            if (breakTime > 0)
            {
                breakTime -= Time.deltaTime;

            }
            else
            {
                breakTime = 0;
            }
            DisplayTime(breakTime);
        }

        ReappearLana();

    }

    public void StartTimer()
    {

        TimerActive = !TimerActive;
        timeValue = 10;
    Lana.SetActive(false);

    }

    public void StartBreakTimer()
    {
        BreakTimerActive = !BreakTimerActive;
        Lana.SetActive(false);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        //float hours = Mathf.FloorToInt(timeToDisplay / 3600) % 24;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60) % 60;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        BreakTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }

    public void ReappearLana()
    {
        if (timeValue == 0)
        {
            Lana.SetActive(true);
            UIManager.instance.SecondScreenEnable();
            timeValue = 5;
            TimerActive = false;
            UIManager.instance.ButtonClickedEnable();
        }


        

    }


}
