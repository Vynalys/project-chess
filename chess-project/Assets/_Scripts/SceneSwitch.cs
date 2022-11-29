using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script is used on the canvis. A button can than call the functions of this script by adding the canvis
// to the buttons OnClick() properties.
public class SceneSwitch : MonoBehaviour
{
	// The Function uses the SceneManager from UE.SceneManagement to Load a scene by also using 
	// it to get the current scene and from there selecting and loading the GameScene.
	public void startGame(){
		// StartMenu has the index 0 (Starter Scene), second created was MainGame therefore has the index 1
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

		// Scenes can be added in File -> Build Settings. The index of the scene is there displayed.
	} 
}
