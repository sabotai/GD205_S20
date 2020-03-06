using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorBehavior : MonoBehaviour
{

    Rigidbody rb;
    public Transform prey;
    public float hungerForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 preyDirection = Vector3.Normalize(prey.position - transform.position);

        rb.AddForce(preyDirection * hungerForce);
    }
}
