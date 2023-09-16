using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Crop_Wheat : Base_Crop
{
    private void Awake()
    {
        SetCropType(ECropTypes.CROP_WHEAT);
    }

    // POLYMORPHISM
    protected override void OnGrowReady()
    {
        base.OnGrowReady();

        Debug.Log("Wheat grow ready");
    }
}
