﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    Rigidbody rb;
    public GameObject victim;
           // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * 5f);
        }
    }
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject == victim)
        {
            Destroy(victim);
        }
        //print("lol collision");
    }
}
