using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAlert : MonoBehaviour
{
	NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
      enemy = GetComponent<NavMeshAgent>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this will run every frame that this gameobject hits a trigger
    void OnTriggerStay(Collider triggerReport){

    	Debug.Log("Hit a trigger...");

    	//check if the collider/trigger hit has the tag player
    	if (triggerReport.CompareTag("Player")){
    		//if so, set the navmeshagents destination to be the position of the collider
    		enemy.SetDestination(triggerReport.transform.position);
    	}

    }
}
