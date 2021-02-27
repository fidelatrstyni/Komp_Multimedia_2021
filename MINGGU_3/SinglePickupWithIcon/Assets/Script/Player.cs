using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public  Image  starImage; 
    public  Sprite  iconStar; 
    public  Sprite  iconNoStar;
    private  bool  carryingStar  =  false; 
    void OnTriggerEnter2D(Collider2D  hit)
    {
        if  (hit.CompareTag("Star"))
        {
            carryingStar  =  true; 
            UpdateStarImage(); 
            Destroy(hit.gameObject);
        }

    }

    // Update is called once per frame
    private void UpdateStarImage()
    {
        if  (carryingStar) 
            starImage.sprite  =  iconStar;
        else
            starImage.sprite  =  iconNoStar;

    }
}
