using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion lookRotation = Quaternion.LookRotation(target.transform.position - transform.position, Vector3.up);

        Debug.Log("TEST1:" + (target.transform.position - transform.position));

        lookRotation.z = 0;
        lookRotation.x = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 0.4f);

        Vector3 p = new Vector3(0.05f, 0f, 0f);

        transform.Translate(p);
        Debug.Log("TEST2:" + this.transform.position.x+"/"+this.transform.position.y+"/"+this.transform.position.z);

    }
}
