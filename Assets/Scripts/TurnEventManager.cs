using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TurnEventManager : MonoBehaviour
{
    public int currentturn = 0;
    public int maxturn = 30;
    public Button turnend;
    public TMP_Text turnEndText;
    public TMP_Text turncount;
    public GameObject[] cards;
    public GameObject truck;
    
    void Start()
    {
        cards = GameObject.FindGameObjectsWithTag("Card");
        turnend.onClick.AddListener(EndTurn);
    }

    void EndTurn()
    {
        foreach (var card in cards)
        {
            truck.transform.DOMove(new Vector3(0f,1.5f,0f), 0.5f);
            turnEndText.text = "See Profits";
        }
        
    }

    void SeeProfits()
    {
        
        
    }
    
    void Update()
    {
        turncount.text = "Turn:" + currentturn + "/" + maxturn;
        
        if (currentturn == maxturn)
        {
            //tally results
        }
    }
}
