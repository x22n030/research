using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vi : MonoBehaviour
{
    private float speed = 0.05f; /*�L�����̑��x*/

    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>(); //
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position; //�L�����̈ʒu���擾���Ă���
        if (Input.GetKey("left")) //�����L�[��������
        {
            position.x -= speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("right"))//�E���L�[��������
        {
            position.x += speed;
            renderer.flipX = true;

        }
        else if (Input.GetKey("up"))//����L�[��������
        {
            position.y += speed;
            renderer.flipX = true;
        }
        else if (Input.GetKey("down"))//�����L�[��������
        {
            position.y -= speed;
            renderer.flipY = true;
        }

        transform.position = position;

    }
}
