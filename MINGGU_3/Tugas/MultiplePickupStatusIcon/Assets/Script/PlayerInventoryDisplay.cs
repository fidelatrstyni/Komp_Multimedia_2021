using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public  Image[]  coinPlaceholders; 
    public  Sprite  iconCoinYellow; 
    public  Sprite  iconCoinGrey;
    public void OnChangeCoinTotal(int  coinTotal)
    {
        for  (int  i  =  0;  i  <  coinPlaceholders.Length;  ++i)
        {
            if  (i  <  coinTotal)
                coinPlaceholders[i].sprite  =  iconCoinYellow;
            else
                coinPlaceholders[i].sprite  =  iconCoinGrey;
        }

    }

}
