using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FarmTile : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    Sprite EmptySprite;

    [SerializeField]
    Sprite FilledSprite;

    private Farmer playerFarmer;

    public bool IsEmpty = true;

    void Start()
    {
        playerFarmer = GameObject.Find("Farmer").GetComponent<Farmer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public void PlantSeed(Base_Crop.ECropTypes selectedCrop)
    {
        if (!ReferenceEquals(playerFarmer, null))
        {
            if (IsEmpty)
            {

            }
        }
        else
        {
            Notification.NotificationManager.SendNotification("Farm tile reference is empty", Notification.ENotificationType.NOTIFICATION_ERROR);
        }
    }
}
