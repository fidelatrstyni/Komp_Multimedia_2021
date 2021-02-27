using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private  PlayerInventoryDisplay  playerInventoryDisplay; 
    private  int  totalCoins  =  0;
    void Start()
    {
        playerInventoryDisplay  =  GetComponent  <PlayerInventoryDisplay>();

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D  hit)
    {
        if  (hit.CompareTag("Coin"))
        {
            totalCoins++; 
            playerInventoryDisplay.OnChangeCoinTotal(totalCoins); 
            Destroy(hit.gameObject);
        }

    }
}
