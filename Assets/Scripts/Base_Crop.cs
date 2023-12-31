using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Crop : MonoBehaviour
{
    [SerializeField]
    Sprite cropGrowingSprite;
    [SerializeField]
    Sprite cropReadySprite;

    protected SpriteRenderer spriteRenderer;

    // ENCAPSULATION
    public bool IsGrowing { get; private set; }
    // ENCAPSULATION
    public bool IsReady { get; private set; }

    [SerializeField]
    protected int timeUntilGrow = 60;
    protected int m_elapsedTime = 0;

    [SerializeField]
    protected int m_harvestAmount = 0;

    public FarmTile bindedTile;

    public enum ECropTypes
    {
        NONE,
        CROP_CORN,
        CROP_TOMATO,
        CROP_WHEAT
    }

    protected ECropTypes m_cropType = ECropTypes.NONE;

    public ECropTypes GetCropType()
    {
        return m_cropType;
    }

    protected void SetCropType(ECropTypes cropType)
    {
        m_cropType = cropType;
    }

    protected void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartGrowing();
    }

    IEnumerator GrowCountdown()
    {
        bool countIt = true;

        while(countIt)
        {
            yield return new WaitForSeconds(1);

            if (m_elapsedTime > timeUntilGrow)
            {
                countIt = false;

                m_elapsedTime = 0;

                OnGrowReady();
            }
            else
            {
                m_elapsedTime++;
            }
        }
    }

    // ABSTRACTION
    public void StartGrowing()
    {
        IsGrowing = true;
        StartCoroutine(GrowCountdown());
    }

    // ABSTRACTION
    public void StopGrowing()
    {
        IsGrowing = false;
        StopCoroutine(GrowCountdown());
    }

    public void Harvest()
    {
        if(IsReady)
        {
            IsReady = false;

            if(!ReferenceEquals(bindedTile, null))
            {
                bindedTile.GetPlayerFarmer().AddCrop(GetCropType(), m_harvestAmount);

                if (UnityEngine.Random.Range(1, 5) == 1)
                {
                    bindedTile.GetPlayerFarmer().AddSeed(GetCropType(), UnityEngine.Random.Range(1, 2));
                }
            }

            Destroy(gameObject);
        }
        else
        {
            Notification.NotificationManager.SendNotification("Crop isn't ready for harvest");
        }
    }

    protected virtual void OnGrowReady()
    {
        if(!ReferenceEquals(spriteRenderer, null))
        {
            spriteRenderer.sprite = cropReadySprite;
        }

        IsReady = true;

        StopGrowing();
    }

    // ABSTRACTION
    public string CropTypeToString(ECropTypes cropType)
    {
        switch(cropType)
        {
            case ECropTypes.CROP_CORN:
                return "Corn";
            case ECropTypes.CROP_TOMATO:
                return "Tomato";
            case ECropTypes.CROP_WHEAT:
                return "Wheat";
            default:
                return "Unknown";
        }
    }
}
