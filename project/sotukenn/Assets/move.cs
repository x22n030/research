using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private float speed = 0.05f; /*�L�����̑��x*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position; //�L�����̈ʒu���擾���Ă���
        if (Input.GetKey("left")) //�����L�[��������
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right"))//�E���L�[��������
        {
            position.x += speed;

        }
        else if (Input.GetKey("up"))//����L�[��������
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))//�����L�[��������
        {
            position.y -= speed;
        }

        transform.position = position;

    }
}
