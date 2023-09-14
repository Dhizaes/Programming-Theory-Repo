using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farmer : MonoBehaviour
{
    private int m_corns = 0;
    private int m_cornSeeds = 0;
    private int m_tomatoes = 0;
    private int m_tomatoSeeds = 0;
    private int m_wheats       = 0;
    private int m_wheatSeeds   = 0;

    public Button cornPlantButton;
    public Button tomatoPlantButton;
    public Button wheatPlantButton;

    public GameObject[] cropList;

    public TMPro.TMP_Text cropInformationText;
    public TMPro.TMP_Text seedInformationText;

    public FarmTile selectedFarmTile;

    private void Start()
    {
        UpdateCropInformation();
        UpdateSeedInformation();

        AddSeed(Base_Crop.ECropTypes.CROP_CORN, UnityEngine.Random.Range(1, 5));
        AddSeed(Base_Crop.ECropTypes.CROP_TOMATO, UnityEngine.Random.Range(1, 5));
        AddSeed(Base_Crop.ECropTypes.CROP_WHEAT, UnityEngine.Random.Range(1, 5));
    }

    private void UpdateCropInformation()
    {
        cropInformationText.text = "Corn: " + m_corns.ToString("00000") + " - Tomato: " + m_tomatoes.ToString("00000") + " - Wheat: " + m_wheats.ToString("00000");
    }

    private void UpdateSeedInformation()
    {
        seedInformationText.text = "Corn seeds: " + m_cornSeeds.ToString("000") + " - Tomato seeds: " + m_tomatoSeeds.ToString("000") + " - Wheat seeds: " + m_wheatSeeds.ToString("000");
    }

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
                cornPlantButton.interactable = true;
                break;
            case Base_Crop.ECropTypes.CROP_TOMATO:
                m_tomatoSeeds += amount;
                cornPlantButton.interactable = true;
                break;
            case Base_Crop.ECropTypes.CROP_WHEAT:
                m_wheatSeeds += amount;
                cornPlantButton.interactable = true;
                break;
        }

        UpdateSeedInformation();
    }

    public void DropSeed(Base_Crop.ECropTypes cropType)
    {
        switch (cropType)
        {
            case Base_Crop.ECropTypes.CROP_CORN:
                m_cornSeeds--;
                if (m_cornSeeds < 1)
                    cornPlantButton.interactable = false;
                break;
            case Base_Crop.ECropTypes.CROP_TOMATO:
                m_tomatoSeeds--;
                if (m_tomatoSeeds < 1)
                    tomatoPlantButton.interactable = false;
                break;
            case Base_Crop.ECropTypes.CROP_WHEAT:
                m_wheatSeeds--;
                if (m_wheatSeeds < 1)
                    wheatPlantButton.interactable = false;
                break;
        }

        UpdateSeedInformation();
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

        UpdateCropInformation();
    }

    public void EnablePlantButtons()
    {
        ToggleButtons(true);
    }

    public void DisablePlantButtons()
    {
        ToggleButtons(false);
    }

    private void ToggleButtons(bool toggle)
    {
        cornPlantButton.interactable = toggle;
        tomatoPlantButton.interactable = toggle;
        wheatPlantButton.interactable = toggle;
    }
}
