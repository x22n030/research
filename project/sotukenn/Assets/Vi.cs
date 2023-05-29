using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vi : MonoBehaviour
{
    private float speed = 0.05f; /*キャラの速度*/

    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>(); //
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position; //キャラの位置を取得している
        if (Input.GetKey("left")) //左矢印キーを押すと
        {
            position.x -= speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("right"))//右矢印キーを押すと
        {
            position.x += speed;
            renderer.flipX = true;

        }
        else if (Input.GetKey("up"))//上矢印キーを押すと
        {
            position.y += speed;
            renderer.flipX = true;
        }
        else if (Input.GetKey("down"))//下矢印キーを押すと
        {
            position.y -= speed;
            renderer.flipY = true;
        }

        transform.position = position;

    }
}
