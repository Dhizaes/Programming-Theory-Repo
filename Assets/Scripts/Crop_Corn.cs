using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop_Corn : Base_Crop
{
    private void Awake()
    {
        SetCropType(ECropTypes.CROP_CORN);
    }

    protected override void OnGrowReady()
    {
        base.OnGrowReady();

        Debug.Log("Corn grow ready");
    }
}
