using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey("escape")){
			//show cursor
			Cursor.lockState = CursorLockMode.None;;
			SceneManager.LoadScene(0, LoadSceneMode.Additive);
		}
    }
}
