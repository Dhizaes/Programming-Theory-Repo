using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Crop_Corn : Base_Crop
{
    private void Awake()
    {
        SetCropType(ECropTypes.CROP_CORN);
    }

    // POLYMORPHISM
    protected override void OnGrowReady()
    {
        base.OnGrowReady();

        Debug.Log("Corn grow ready");
    }
}
