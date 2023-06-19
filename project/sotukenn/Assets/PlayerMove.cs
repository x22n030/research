using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public bool isGrounded;
    private bool enemyTouch;

    Canvas canvas;

    UIController uicontroller;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        //canvas = GameObject.Find("CanvasWrapper").GetComponetInChildren<canvas>();
        //uicontroller = canvas.GetComponent<uicontroller>();

        enemyTouch = uicontroller.EnemyTouch;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }

        if(collision.gameObject.tag == "enemy")
        {
            if(enemyTouch == false)
            {
                EnemyTouchSend();
            }
        }
    }

    void EnemyTouchSend()
    {
        uicontroller.EnemyTouch = true;
    }
}
