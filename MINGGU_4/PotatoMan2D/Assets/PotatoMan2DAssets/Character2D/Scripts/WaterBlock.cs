using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlock : MonoBehaviour
{
    private Animator animatorController;
    void Start()
    {
        animatorController = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.CompareTag("Player")){
            animatorController.SetTrigger("Fall");
        }
    }
}
