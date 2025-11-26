using UnityEngine;

public class EconomySystem : MonoBehaviour
{
    public int upo, kalabasa, talong;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        upo = Random.Range(0, 25);
        kalabasa = Random.Range(0, 25);
        talong = Random.Range(0, 25);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
