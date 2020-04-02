using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KoolNav : MonoBehaviour
{
	NavMeshAgent kool;

    // Start is called before the first frame update
    void Start()
    {
        kool = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(laser, out hit) && Input.GetMouseButtonDown(0)){
        	kool.SetDestination(hit.point);
        }
    }
}
