using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlantBoxManager : MonoBehaviour
{
    public TMP_Text plantCounter;
    public int upoCount, kalabasaCount, talongCount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        plantCounter.text = "Planted Vegetables:" + "\n Upo:" + upoCount.ToString() + "\n Kalabasa:" + kalabasaCount.ToString() + "\n Talong" + talongCount.ToString();
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Upo"))
        {
            upoCount++;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Kalabasa"))
        {
            kalabasaCount++;
            other.gameObject.SetActive(false);

        }
        else if (other.CompareTag("Talong"))
        {
            talongCount++;
            other.gameObject.SetActive(false);

        }
    }
}
