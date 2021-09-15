using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FakeMovement : MonoBehaviour
{

    public Transform Football;
    private NavMeshAgent navMeshAgent;
    private float aggroRange = 15f;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()

{

    if (Vector3.Distance(transform.position, Football.position) < aggroRange)

    {

        navMeshAgent.isStopped = false; 

        navMeshAgent.SetDestination(Football.position);

    }

    else

    {

        navMeshAgent.isStopped = true; 

    }

}
}
