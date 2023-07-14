using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveContoller : MonoBehaviour
{
    [SerializeField]
    float SPEED = 100.0f;
    private Rigidbody2D rigidBody;
    private Vector2 inputAxis;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = inputAxis.normalized * SPEED;
    }
}
