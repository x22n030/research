using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private float speed = 0.05f; /*キャラの速度*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position; //キャラの位置を取得している
        if (Input.GetKey("left")) //左矢印キーを押すと
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right"))//右矢印キーを押すと
        {
            position.x += speed;

        }
        else if (Input.GetKey("up"))//上矢印キーを押すと
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))//下矢印キーを押すと
        {
            position.y -= speed;
        }

        transform.position = position;

    }
}
