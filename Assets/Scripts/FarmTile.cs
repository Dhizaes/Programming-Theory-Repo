using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FarmTile : MonoBehaviour
{
    [SerializeField]
    Sprite EmptySprite;

    [SerializeField]
    Sprite FilledSprite;

    private Farmer playerFarmer;

    public bool IsEmpty = true;

    private GameObject currentCrop;

    public Farmer GetPlayerFarmer()
    {
        return playerFarmer;
    }

    void Start()
    {
        playerFarmer = Camera.main.gameObject.GetComponent<Farmer>();
    }

    private void OnMouseDown()
    {
        if (!ReferenceEquals(playerFarmer, null))
        {
            if (IsEmpty)
            {
                playerFarmer.selectedFarmTile = this;

                Debug.Log("Selected farm tile: " + this.name);

                playerFarmer.EnablePlantButtons();
            }
            else
            {
                if (!ReferenceEquals(currentCrop, null))
                {
                    Base_Crop cropClass = currentCrop.GetComponent<Base_Crop>();

                    if (!cropClass.IsGrowing && cropClass.IsReady)
                    {
                        cropClass.Harvest();

                        IsEmpty = true;
                    }
                }

                playerFarmer.DisablePlantButtons();
            }
        }
    }

    public void PlantSeed(GameObject plantObject)
    {
        if (!ReferenceEquals(playerFarmer, null))
        {
            if (IsEmpty)
            {
                if(playerFarmer.cropList.Length > 0)
                {
                    IsEmpty = false;

                    currentCrop = Instantiate(plantObject, transform);
                    Base_Crop cropClass = currentCrop.GetComponent<Base_Crop>();
                    cropClass.bindedTile = this;

                    playerFarmer.selectedFarmTile = null;
                }
                else
                {
                    Notification.NotificationManager.SendNotification("Crop list is empty", Notification.ENotificationType.NOTIFICATION_ERROR);
                }
            }
        }
        else
        {
            Notification.NotificationManager.SendNotification("Farmer reference is empty", Notification.ENotificationType.NOTIFICATION_ERROR);
        }
    }
}
