using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    private int m_corns = 0;
    private int m_cornSeeds = 0;
    private int m_tomatoeSeeds = 0;
    private int m_tomatoes     = 0;
    private int m_wheats       = 0;
    private int m_wheatSeeds   = 0;

    public void AddSeed(Base_Crop.ECropTypes cropType, int amount)
    {
        switch(cropType)
        {
            case Base_Crop.ECropTypes.CROP_CORN:
                m_cornSeeds += amount;
                break;
            case Base_Crop.ECropTypes.CROP_TOMATO:
                m_tomatoeSeeds += amount;
                break;
            case Base_Crop.ECropTypes.CROP_WHEAT:
                m_wheatSeeds += amount;
                break;
        }
    }

    public void AddCrop(Base_Crop.ECropTypes cropType, int amount)
    {
        switch (cropType)
        {
            case Base_Crop.ECropTypes.CROP_CORN:
                m_corns += amount;
                break;
            case Base_Crop.ECropTypes.CROP_TOMATO:
                m_tomatoes += amount;
                break;
            case Base_Crop.ECropTypes.CROP_WHEAT:
                m_wheats += amount;
                break;
        }
    }
}
