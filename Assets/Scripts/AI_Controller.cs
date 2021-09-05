// Patrol.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AI_Controller : MonoBehaviour
{

    private GameObject target;
    private NavMeshAgent agent;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet (Clone)")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Plasma Ball(Clone)")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Pistal Round(Clone)")
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        agent = gameObject.GetComponent<NavMeshAgent>();
    }



    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
} 