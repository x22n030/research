using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //当たった時の処理
    void OnCollisionEnter2D(Collision2D collision)
    {
        //当たったオブジェクトを消す
        Destroy(collision.Tag="Player");
    }
}
