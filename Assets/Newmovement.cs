using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newmovement : MonoBehaviour
{


    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(Vector3.up * 5);

    }
}
