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

    public enum ECropTypes
    {
        CROP_CORN,
        CROP_TOMATO,
        CROP_WHEAT
    }

    public void AddSeed(ECropTypes cropType, int amount)
    {
        switch(cropType)
        {
            case ECropTypes.CROP_CORN:
                m_cornSeeds += amount;
                break;
                case ECropTypes.CROP_TOMATO:
                m_tomatoeSeeds += amount;
                break;
            case ECropTypes.CROP_WHEAT:
                m_wheatSeeds += amount;
                break;
        }
    }

    public void AddCrop(ECropTypes cropType, int amount)
    {
        switch (cropType)
        {
            case ECropTypes.CROP_CORN:
                m_corns += amount;
                break;
            case ECropTypes.CROP_TOMATO:
                m_tomatoes += amount;
                break;
            case ECropTypes.CROP_WHEAT:
                m_wheats += amount;
                break;
        }
    }
}
