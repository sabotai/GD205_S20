using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    Rigidbody rb;
    //public GameObject victim;
    public string predatorTag, preyTag;

           // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
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
        if (myCollision.gameObject.CompareTag(preyTag))
        //if (myCollision.gameObject == victim)
        {
            Destroy(myCollision.gameObject);
        } else if (myCollision.gameObject.CompareTag(predatorTag))
        {
            Destroy(gameObject);
        }
        //print("lol collision");
    }
}
