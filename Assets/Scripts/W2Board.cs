using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2Board : MonoBehaviour
{
    public GameObject player;
    Vector3 initPos;
    public Transform[] hazard; //creates an array of transforms. we can specify the number of positions in the inspector and assign them
    
    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position; //store our players initial position at the very beginning
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.transform.position += new Vector3(0, -1, 0);
        }

        //use a loop to iterate through each position in the array, regardless of how many there are
        for (int i = 0; i < hazard.Length; i++) //.Length refers to the number of positions
        {
            if (hazard[i].position == player.transform.position) //if they are in the same position
            {
                player.transform.position = initPos; //reset the position
            }
        }
        
    }
}
