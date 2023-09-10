using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop_Wheat : Base_Crop
{
    private new void Start()
    {
        base.Start();

        SetCropType(ECropTypes.CROP_WHEAT);
    }

    protected override void OnGrowReady()
    {
        Debug.Log("Wheat grow ready");
    }
}
