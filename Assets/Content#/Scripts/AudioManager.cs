using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    public AudioClip intro;
    public AudioClip notificationAudio;
    public AudioClip Welldone;
    public AudioClip YouHaveFourHours;
    public AudioClip FiftyPercent;
    public AudioClip FirstAudio;


    public void PlayFirstAudio()
    {
        audioSource.clip = FirstAudio;
        audioSource.Play();
    }



    public void PlayTaskForTodayAudio()
    {
        audioSource.clip = intro;
        audioSource.Play();
    }

    public void PlaynotificationAudio()
    {
        audioSource.clip = notificationAudio;
        audioSource.Play();
    }

    public void PlayWelldone()
    {
        audioSource.clip = Welldone;
        audioSource.Play();
    }

    public void PlayAudiofourHours()
    {
        StartCoroutine(PlayYouHaveFourHours());
    }

    IEnumerator PlayYouHaveFourHours()
    {
        yield return new WaitForSeconds(5);
        audioSource.clip = YouHaveFourHours;
        audioSource.Play();
    }

    public void PlayFiftyPercent()
    {
        audioSource.clip = FiftyPercent;
        audioSource.Play();
    }

}
