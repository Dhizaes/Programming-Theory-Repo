using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Crop : MonoBehaviour
{
    public FarmTile bindedFarmTile;

    public bool IsGrowing { get; private set; }
    public bool IsReady { get; private set; }

    protected int m_timeUntilGrow = 60;
    protected int m_elapsedTime = 0;

    [SerializeField]
    protected int m_harvestAmount = 0;

    public enum ECropTypes
    {
        CROP_CORN,
        CROP_TOMATO,
        CROP_WHEAT
    }

    private void Start()
    {
        StartGrowing();
    }

    IEnumerator GrowCountdown()
    {
        yield return new WaitForSeconds(1);

        if (m_elapsedTime > m_timeUntilGrow)
        {
            m_elapsedTime = 0;
            IsReady = true;
            IsGrowing = false;
        }
        else
        {
            m_elapsedTime++;
        }
    }

    public void StartGrowing()
    {
        IsGrowing = true;
        StartCoroutine(GrowCountdown());
    }

    public void StopGrowing()
    {
        IsGrowing = true;
        StopCoroutine(GrowCountdown());
    }

    public void Harvest(int amount)
    {
        if(IsReady)
        {
            IsReady = false;

            Destroy(gameObject);
        }
        else
        {
            Notification.NotificationManager.SendNotification("Crop isn't ready for harvest");
        }
    }

    protected virtual void OnGrowStarted()
    {

    }

    protected virtual void OnGrowStopped()
    {

    }
}
