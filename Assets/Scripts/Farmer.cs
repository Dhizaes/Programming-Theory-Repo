using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farmer : MonoBehaviour
{
    private int m_corns = 0;
    private int m_cornSeeds = 0;
    private int m_tomatoeSeeds = 0;
    private int m_tomatoes     = 0;
    private int m_wheats       = 0;
    private int m_wheatSeeds   = 0;

    public Button[] plantButtons;

    public GameObject[] cropList;

    public FarmTile selectedFarmTile;

    public void PlantCorn()
    {
        for (int i = 0; i < cropList.Length; i++)
        {
            Crop_Corn temp = cropList[i].GetComponent<Crop_Corn>();

            if (!ReferenceEquals(temp, null))
            {
                selectedFarmTile.PlantSeed(cropList[i]);
                return;
            }
        }
    }

    public void PlantTomato()
    {
        for (int i = 0; i < cropList.Length; i++)
        {
            Crop_Tomato temp = cropList[i].GetComponent<Crop_Tomato>();

            if (!ReferenceEquals(temp, null))
            {
                selectedFarmTile.PlantSeed(cropList[i]);
                return;
            }
        }
    }

    public void PlantWheat()
    {
        for (int i = 0; i < cropList.Length; i++)
        {
            Crop_Wheat temp = cropList[i].GetComponent<Crop_Wheat>();

            if (!ReferenceEquals(temp, null))
            {
                selectedFarmTile.PlantSeed(cropList[i]);
                return;
            }
        }
    }

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

    public void EnablePlantButtons()
    {
        if(plantButtons.Length > 0)
        {
            for (int i = 0; i < plantButtons.Length; i++)
            {
                if (!ReferenceEquals(plantButtons[i], null))
                {
                    plantButtons[i].interactable = true;
                }
            }
        }
    }

    public void DisablePlantButtons()
    {
        if (plantButtons.Length > 0)
        {
            for (int i = 0; i < plantButtons.Length; i++)
            {
                if (!ReferenceEquals(plantButtons[i], null))
                {
                    plantButtons[i].interactable = false;
                }
            }
        }
    }
}
