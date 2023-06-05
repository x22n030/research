using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(navmeshAgent))]
public class move : MonoBehaviour
{

    protected float defaultMoveSpeed;


    protected Rigidbody rigidBody;
    protected GemeManager gemeManager;
    protected NavMeshAgent agent;
    protected Transform target;
    protected Animator animator;

    public float MoveSpeed { set; get; }


    // Start is called before the first frame update
    void Start()
    {
        gemaManager = GameObject.FindGameobjcetWitnTag("GameController").GetComponent<GameManager>();





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
