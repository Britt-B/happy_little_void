using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverText : MonoBehaviour 
{
	//showing message to this camera
	public Camera cam;
	//message to show
	public string message;
    //when the mouse is over this object
    void OnMouseOver(){
        //show the associated message
		cam.GetComponent<ShowText>().ShowMessage(message,1.0f);
    }
}
