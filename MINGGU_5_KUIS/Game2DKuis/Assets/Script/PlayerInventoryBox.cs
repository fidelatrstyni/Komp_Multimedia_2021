using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryBox : MonoBehaviour
{
    // Start is called before the first frame update
   public Image[] boxesPlaceholders; 
   public Sprite iconBoxesAktif; 
   public Sprite iconBoxesNonAktif;
   public void OnChangeBoxTotal(int boxTotal)
   {
       for(int i = 0 ; i < boxesPlaceholders.Length; ++i)
        {
           if ( i < boxTotal) 
           boxesPlaceholders[i].sprite = iconBoxesAktif;
           else
           boxesPlaceholders[i].sprite= iconBoxesNonAktif;
        }
    }
}
