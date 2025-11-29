using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlantBoxManager : MonoBehaviour
{
    public TMP_Text plantCounter;
    public int upoCount, kalabasaCount, talongCount;
    void Update()
    {
        plantCounter.text = "Upo=" + upoCount + "\n Kalabasa=" + kalabasaCount + "\n Talong=" + talongCount;
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
