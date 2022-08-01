using Unity.Notifications.Android;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NotificationManager : MonoBehaviour
{

    private void Start()
    {

        AndroidNotificationCenter.CancelAllDisplayedNotifications();


        //Set up notification channel
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Notifications Channel",
            Importance = Importance.High,
            Description = "JaiShriKrishna",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);


        //notification parameters
        var notification = new AndroidNotification();
        notification.Title = "Update for your task";
        notification.Text = "Lana is here to see you";
        notification.LargeIcon = "icon_0";

        notification.FireTime = System.DateTime.Now.AddSeconds(20);


        //send notification
        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        //if statement
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
           AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
         return;
        }
        


    }






}




