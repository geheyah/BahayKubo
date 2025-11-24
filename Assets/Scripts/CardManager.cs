using System;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class CardManager : MonoBehaviour
{
    public Transform currentPos;
    public int veggieID;
    public SpriteRenderer cardSprite;
    public Sprite uposprite,kalabasasprite,talongsprite;
    
    void Start()
    {
        this.transform.position = currentPos.position;
        veggieID = UnityEngine.Random.Range(0, 3);
        // 0=Upo,1=Kalabasa,2=Talong   
    }

    void Update()
    {
        if (veggieID == 0)
        {
            this.name = "upo";
            cardSprite.sprite = uposprite;
        }

        if (veggieID == 1)
        {
            this.name = "kalabasa";
            cardSprite.sprite = kalabasasprite;
        }

        if (veggieID == 2)
        {
            this.name = "talong";
            cardSprite.sprite = talongsprite;
        }

    }
    
    public void OnMouseDrag()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.transform.DOMove(worldPosition, 0.1f);
    }

    public void OnMouseUp()
    {
        this.transform.DOMove(currentPos.position, 0.3f);
    }
    
}
