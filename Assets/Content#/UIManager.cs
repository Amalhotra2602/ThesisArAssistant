using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject firstScreen;
    public GameObject TaskProgress1;
    public GameObject startTimer;
    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject LoginRegister;
    public GameObject BreakTaskOption1;
    public GameObject BreakTimer1;
    public GameObject TaskTimer1;

    public GameObject[] buttons;
    public GameObject Lana;

    private float firstScreenDelay = 15f;
    private float secondScreenDelay = 2f;

    public static UIManager instance;

    private int count;


    private void Awake()
    {
        firstScreen.SetActive(false);
        startTimer.SetActive(false);
        TaskProgress1.SetActive(false);
        TaskTimer1.SetActive(false);
        BreakTimer1.SetActive(false);
        Lana.SetActive(false);
        LoginRegister.SetActive(true);
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        BreakTaskOption1.SetActive(false);

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void FirstScreenEnable()
    {
        StartCoroutine(OpenScreenOne());
        loginUI.SetActive(false);

    }

    IEnumerator OpenScreenOne()
    {
        yield return new WaitForSeconds(firstScreenDelay);
        firstScreen.SetActive(true);
    }

    public void SecondScreenEnable()
    {
        StopCoroutine(OpenScreenOne());
        StartCoroutine(OpenScreenTwo());
    }


    public void StartTimer()
    {
        firstScreen.SetActive(!true);
        startTimer.SetActive(true);
    }

    public void LoginScreen() //Back button
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
        LoginRegister.SetActive(false);
    }
    public void RegisterScreen() // Regester button
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
        LoginRegister.SetActive(false);
    }

    public void ButtonClicked()
    {
        if (count==3)
        {
            //Play sound or last animation
            //open panel

        }
        
        Debug.Log("Button disabled");

        /*
        foreach (GameObject g in buttons)
        {
            g.GetComponent<Button>().interactable = false;
        }
        */

        Debug.Log(buttons.Length);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = false;
        }

        count++;


    }
    public void ButtonClickedEnable()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = true;
        }
    }

    public void disableLana()
    {
        Lana.SetActive(false);
    }

    public void EnableLana()
    {
        Lana.SetActive(true);
    }

    public void TimerPanelOpen() // timer1
    {
        BreakTaskOption1.SetActive(false);
        startTimer.SetActive(false);
        TaskTimer1.SetActive(true);
        BreakTimer1.SetActive(false);
    }

    public void OpenBreakTimerOption1() //Break/timer task panel
    {
        TaskProgress1.SetActive(false);
        BreakTaskOption1.SetActive(true);
    }

    public void StartBreakTimer1()   //Break Timer
    {

        BreakTaskOption1.SetActive(false);
        BreakTimer1.SetActive(true);
    }

    IEnumerator OpenScreenTwo()   // progress panel 1
    {
        TaskTimer1.SetActive(false);
        yield return new WaitForSeconds(secondScreenDelay);
        TaskProgress1.SetActive(true);
    }

}
