using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Text starText;
    private bool carryingStar = false;
    void Start()
    {
        UpdateStarText();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D  hit)
    {
        if  (hit.CompareTag("Star"))
        {
            carryingStar  =  true; 
            UpdateStarText(); 
            Destroy(hit.gameObject);
        }

    }
    private  void  UpdateStarText()
    {
        string  starMessage  =  "Tidak  Bawa  Bintang  :-(";
        if  (carryingStar)  starMessage  =  "Bawa  Bintang  :-)"; 
        starText.text  =  starMessage;
    }

}
