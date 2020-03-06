using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyBehavior : MonoBehaviour
{
    Rigidbody rb;
    public Transform predator;
    public float terrorForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 predatorDirection = Vector3.Normalize(predator.position - transform.position);

       
        rb.AddForce(-predatorDirection * terrorForce); //negative = opposite direction
    }
}
