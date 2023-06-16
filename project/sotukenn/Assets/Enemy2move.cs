using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2move : MonoBehaviour
{
    GameObject player;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("PLAYER");
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        Vector2 targetPos = player.transform.position;
        float x = targetPos.x;
        float y = 0;
        Vector2 direction = new Vector2(
            x - transform.position.x, y).normalized;
        rb2d.velocity = direction * 2;
    }
}
