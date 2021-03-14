using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay pid;
    private PlayerInventoryBox pib;
    private int totalEnemies = 0;
    public Text pointText;
    public float speed;
    Rigidbody2D rb;
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();
        pid = GetComponent <PlayerInventoryDisplay> ();
        UpdatePointText();
    }

    // Update is called once per frame
    void FixedUpdate(){
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");
        float xSpeed = xMove * speed;
        float ySpeed = yMove * speed;
        Vector2 newVelocity = new Vector2(xSpeed, ySpeed);
        rb.velocity = newVelocity;
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.CompareTag("Enemy_1"))
        {
            totalEnemies++;
            UpdatePointText();
            pid.OnChangeEnemyTotal(totalEnemies);
            Destroy(hit.gameObject);
        }
    }
    private void UpdatePointText(){
            string pointMessage = "Point = "+ totalEnemies;
            pointText.text = pointMessage;
    }
}
