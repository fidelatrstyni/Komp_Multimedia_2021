using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    // Start is called before the first frame update
   public Image[] enemiesPlaceholders; 
   public Sprite iconEnemiesAktif; 
   public Sprite iconEnemiesNonAktif;
   public void OnChangeEnemyTotal(int enemyTotal)
   {
       for(int i = 0 ; i < enemiesPlaceholders.Length; ++i)
        {
           if ( i < enemyTotal) 
            enemiesPlaceholders[i].sprite = iconEnemiesAktif;
           else
            enemiesPlaceholders[i].sprite= iconEnemiesNonAktif;
        }
    }
}
