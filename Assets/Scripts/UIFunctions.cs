using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make sure to include these directives
//otherwise, you won't be able to use UI or SceneManagement functions/properties/etc.
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Custom function to call when a button is pressed
    public void LoadScene(int sceneIndex){
    	SceneManager.LoadScene(sceneIndex);
    }

    //Custom function to call when a button is pressed
    public void QuitGame(){
    	Application.Quit();
    }
}
