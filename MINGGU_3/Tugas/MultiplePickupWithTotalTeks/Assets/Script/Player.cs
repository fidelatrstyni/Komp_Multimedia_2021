using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text coinText; 
    private int totalCoins = 0; 
    void Start()
    {
        UpdateCoinText();
    }

    void OnTriggerEnter2D(Collider2D  hit)
    {
        if  (hit.CompareTag("Coin"))
        {
            totalCoins++; UpdateCoinText(); 
            Destroy(hit.gameObject);
        }

    }
    private  void  UpdateCoinText()
    {
        string  coinMessage  =  "Coins  =  "  +  totalCoins; 
        coinText.text  =  coinMessage;
    }

}
