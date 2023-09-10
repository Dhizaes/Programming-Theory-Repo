using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop_Tomato : Base_Crop
{
    private new void Start()
    {
        base.Start();

        SetCropType(ECropTypes.CROP_TOMATO);
    }

    protected override void OnGrowReady()
    {
        Debug.Log("Tomato grow ready");
    }
}
