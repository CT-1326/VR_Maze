using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;
    private Transform tr;

    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        tr.LookAt(target);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            Tcount.timeCount -= 2;
        }
    }
}
