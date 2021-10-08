using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	
    public void PlayGame(){
		//load into maze
		SceneManager.LoadScene(1);
	}
	
	public void QuitGame(){
		//close
		Application.Quit();
	}
}
