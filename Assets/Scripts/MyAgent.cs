﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //dont forget to add this to scripts in which you use AI functions!

public class MyAgent : MonoBehaviour
{
    NavMeshAgent steve; //create a new navmeshagent to manipulate in our script
    public Vector3 dest; //this will serve as our destination for steve

    // Start is called before the first frame update
    void Start()
    {
        steve = GetComponent<NavMeshAgent>(); //assign it to be the one attached to the same gameobject
    }

    // Update is called once per frame
    void Update()
    {
    	if(gameObject.CompareTag("Player")){
        //create a ray using the method we previously emplyed in the laser script
        //the next four lines are literally copied and pasted from that script
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            steve.SetDestination(hit.point);
        }
    }
    }

    //OnTriggerStay will be executed every frame in which something occupies the trigger collider we created
    void OnTriggerStay(Collider triggerReport)
    {
        Debug.Log("trigger entered");

        //if the collider that entered our trigger is named steveobject
        if (triggerReport.CompareTag("Player"))
        {
            Debug.Log("STEVE LOCATED");

            //now that we know its that gosh darned steve, update joes destination to go after steve
            steve.SetDestination(triggerReport.transform.position);
        }
    }
}