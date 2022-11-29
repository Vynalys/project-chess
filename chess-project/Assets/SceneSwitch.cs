using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script is used on the canvis. A button can than call the functions of this script by adding the canvis
// to the buttons OnClick() properties.
public class SceneSwitcher : MonoBehaviour
{
	// The Function uses the SceneManager from UE.SceneManagement to Load a scene by also using 
	// it to get the current scene and from there selecting and loading the GameScene.
	public void StartGame(){
		// MainMenu was created as second Scene so it has index 1 and the main game has index 0
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}   
}
