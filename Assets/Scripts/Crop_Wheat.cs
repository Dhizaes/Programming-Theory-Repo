using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop_Wheat : Base_Crop
{
    private void Awake()
    {
        SetCropType(ECropTypes.CROP_WHEAT);
    }

    protected override void OnGrowReady()
    {
        base.OnGrowReady();

        Debug.Log("Wheat grow ready");
    }
}
