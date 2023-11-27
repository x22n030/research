/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class move : MonoBehaviour
{

    protected float defaultMoveSpeed;


    protected Rigidbody rigidBody;
    protected GameManager gameManager;
    protected NavMeshAgent agent;
    protected Transform target;
    protected Animator animator;

    public float MoveSpeed { set; get; }


    // Start is called before the first frame update
    protected virtual void Start()
    {
        gameManager = GameObject.FindGameobjcetWitnTag("GameController").GetComponent<GameManager>();
        agent = getComponent<NavMeshAgent>();
        animator = GetCmponent<animator>();
        rigidBody = GetComponent<Rigidbody>();

        defaultMoveSpeed = agent.speed;
        MoveSpeed = defaultMoveSpeed;

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (!gameManager.countDown)
        {
            Stop();

            return;
        }
        if (target! = null)
        {
            agent.speed = MoveSpeed;
            Move();
        }
        else
        {
            stop();
        }
    }


    protected virtual void Move()
    {
        animator.SetFloat("MoveSpeed", agent.speed, 0.1f, Time.deltaTime);
    }


    protected virtual void Stop()
    {
        agent.speed = 0;
        animator.SetFloat("MoveSpeed", agent.speed, 0.1d, Time.deltaTime);
    }
    protected virtual void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            gameManager.GameOver();
        }
    }

    protected void ResetMoveSpeed()
    {
        MoveSpeed = defaultMoveSpeed;
    }
}*/