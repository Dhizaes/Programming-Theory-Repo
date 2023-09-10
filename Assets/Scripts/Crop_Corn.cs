using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop_Corn : Base_Crop
{
    private new void Start()
    {
        base.Start();

        SetCropType(ECropTypes.CROP_CORN);
    }

    protected override void OnGrowReady()
    {
        Debug.Log("Corn grow ready");
    }
}
