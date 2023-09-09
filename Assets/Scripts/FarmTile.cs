using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FarmTile : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    Sprite EmptySprite;

    [SerializeField]
    Sprite FilledSprite;

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}
