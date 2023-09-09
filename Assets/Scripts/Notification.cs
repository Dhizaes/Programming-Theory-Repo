using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Notification : MonoBehaviour
{
    public static Notification NotificationManager;
    public GameObject messageUI;
    public TMPro.TMP_Text headerText;
    public TMPro.TMP_Text messageText;

    private void Awake()
    {
        if(!ReferenceEquals(NotificationManager, null))
        {
            Destroy(gameObject);
            return;
        }

        NotificationManager = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SendNotification(string header, string message)
    {
        if(!ReferenceEquals(messageUI, null))
        {
            if(!ReferenceEquals(headerText, null) && !ReferenceEquals(messageText, null))
            {
                Debug.Log(header + ": " + message);
            }
        }
    }

    public void SendNotification(string message)
    {
        if (!ReferenceEquals(messageUI, null))
        {
            if (!ReferenceEquals(messageText, null))
            {
                Debug.Log(message);
            }
        }
    }
}
