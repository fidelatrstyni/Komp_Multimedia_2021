using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public  Image  coinImage; 
    public  Sprite  iconCoin; 
    public  Sprite  iconNoCoin;
    private  bool  carryingCoin  =  false; 
    void OnTriggerEnter2D(Collider2D  hit)
    {
        if  (hit.CompareTag("Coin"))
        {
            carryingCoin  =  true; 
            UpdateCoinImage(); 
            Destroy(hit.gameObject);
        }

    }

    // Update is called once per frame
    private void UpdateCoinImage()
    {
        if  (carryingCoin) 
            coinImage.sprite  =  iconCoin;
        else
            coinImage.sprite  =  iconNoCoin;

    }
}
