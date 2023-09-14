using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop_Tomato : Base_Crop
{
    private void Awake()
    {
        SetCropType(ECropTypes.CROP_TOMATO);
    }

    protected override void OnGrowReady()
    {
        base.OnGrowReady();

        Debug.Log("Tomato grow ready");
    }
}
