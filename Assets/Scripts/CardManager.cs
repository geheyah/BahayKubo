using System;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

public class CardManager : MonoBehaviour
{
    public Transform card;
    public Transform originalPos;
    void Start()
    {
        card.position = originalPos.position;
    }

    public void OnMouseDrag()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        card.DOMove(worldPosition, 0.1f);
    }

    public void OnMouseUp()
    {
        card.DOMove(originalPos.position, 0.3f);
    }
    
    public void OnMouseEnter()
    {
        
    }
    public void OnMouseExit()
    {
        
    }
    
}
