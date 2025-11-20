using System;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class CardManager : MonoBehaviour
{
    private Transform currentPos;
    public int veggieID;

    private void Awake()
    {
        currentPos.position = this.transform.position;
    }

    void Start()
    {
        
        veggieID = UnityEngine.Random.Range(0, 2);
        // 0=Upo,1=Kalabasa,2=Talong   
    }

    void Update()
    {
        if (veggieID == 0){this.name = "upo";}
        if (veggieID == 1){this.name = "kalabasa";}
        if (veggieID == 2){this.name = "talong";}

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
