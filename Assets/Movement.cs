using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
     private NavMeshAgent navMeshAgent;
     private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        rigidbody.AddForce(Vector3.up * 5);


    }
}
