using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Notification : MonoBehaviour
{
    public static Notification NotificationManager;

    [SerializeField]
    GameObject messageUI;
    [SerializeField]
    public TMPro.TMP_Text headerText;
    [SerializeField]
    public TMPro.TMP_Text messageText;

    public enum ENotificationType
    {
        NOTIFICATION_NORMAL,
        NOTIFICATION_WARNING,
        NOTIFICATION_ERROR
    }

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

    public void SendNotification(string message, ENotificationType notificationType)
    {
        if(!ReferenceEquals(messageUI, null))
        {
            if(!ReferenceEquals(headerText, null) && !ReferenceEquals(messageText, null))
            {
                Debug.Log(NotificationTypeToString(notificationType) + ": " + message);
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

    private string NotificationTypeToString(ENotificationType notificationType)
    {
        switch(notificationType)
        {
            case ENotificationType.NOTIFICATION_NORMAL:
                return "Notification";
            case ENotificationType.NOTIFICATION_WARNING:
                return "Warning";
            case ENotificationType.NOTIFICATION_ERROR:
                return "Error";
            default:
                return "";
        }
    }
}
