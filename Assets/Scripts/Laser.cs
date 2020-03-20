using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

	public float boomForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit = new RaycastHit();

        Debug.DrawRay(laser.origin, laser.direction * boomForce, Color.red);
        if (Physics.Raycast(laser, out hit, 10000f) && Input.GetMouseButton(0)){
        	Debug.Log("you hit something lol with left mouse click");

        	if (hit.rigidbody){
        		Vector3 randomDirection = Random.insideUnitSphere;
        		hit.rigidbody.AddForce(randomDirection * boomForce);
        	}
        }


    }
}
