using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStuff : MonoBehaviour
{

	public void LoadNewScene(int sceneIndex){
		SceneManager.LoadScene(sceneIndex);
	}

	public void QuitGame(){
		Application.Quit();
	}

}
