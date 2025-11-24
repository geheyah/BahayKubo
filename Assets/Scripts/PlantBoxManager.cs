using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlantBoxManager : MonoBehaviour
{
    public TMP_Text plantCounter;
    public CardManager cardManager;
    public int upoCount, kalabasaCount, talongCount;
    void Update()
    {
        plantCounter.text = "Tanim ni Manong" + "\n Upo:" + upoCount.ToString() + "\n Kalabasa:" + kalabasaCount.ToString() + "\n Talong:" + talongCount.ToString();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "upo")
        {
            upoCount++;
            other.gameObject.SetActive(false);
        }
        else if (other.name == "kalabasa")
        {
            kalabasaCount++;
            other.gameObject.SetActive(false);

        }
        else if (other.name == "talong")
        {
            talongCount++;
            other.gameObject.SetActive(false);

        }
    }
}
