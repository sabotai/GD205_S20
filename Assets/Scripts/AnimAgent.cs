using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//THIS IS AN EXAMPLE OF COMBINING THE SCRIPTS WE DID THIS WEEK WITH THE ANIMATOR CONTROLLER
//We can set AnimState based on whether the navMesh is moving or not by checking the velocity



public class AnimAgent : MonoBehaviour
{
    NavMeshAgent agent;
    public Vector3 dest;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(laser, out hit) && Input.GetMouseButton(0))
        {
            agent.destination = hit.point;
        }

        //if our agent is not moving, meaning its agent has a velocity of zero
        if (agent.velocity == Vector3.zero)
        {
            //then set our integer to be the idle value
            myAnim.SetInteger("MoveState", 0);
        }
        else
        {
            //otherwise, use the walk one
            myAnim.SetInteger("MoveState", 1);
        }
    }
}