using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Jack2 : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 3 * Time.deltaTime);
    }
}