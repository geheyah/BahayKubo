using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnEventManager : MonoBehaviour
{
    public int currentturn = 0;
    public int maxturn = 30;
    public Button turnend;
    public TMP_Text turncount;
    public GameObject[] cards;
    
    void Start()
    {
        cards = GameObject.FindGameObjectsWithTag("Card");
        turnend.onClick.AddListener(EndTurn);
    }

    void EndTurn()
    {
        currentturn++;
        foreach (var card in cards)
        {
          card.SetActive(true);
        }
        
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
