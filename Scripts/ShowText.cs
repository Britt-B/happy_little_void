using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
	//the text that should be shown on screen
	public string textValue;
	//the text object in game
	public Text textElement;
	
	//the vatiables to time text display
	private float start = 0.0f, current = 0.0f, wait = 5.0f;
	
	//should we check message display?
	bool check = false;
	
	public void Update(){
		//assign text value to text element
		textElement.text = textValue;
		
		//if the message has begun display period
		if(check){
			//if the time elapsed has exceeded wait time, hide message
			if(current - start >= wait)
				HideMessage();
			
			//set the current time
			current = Time.time;
		}
	}
	
    public void ShowMessage(string message, float waitTime){
		this.wait = waitTime;
		//assign the desired text
		textValue = message;
		//set timing condition to true
		check = true;
		//record time that message srarts display
		start = Time.time;
		//reset display time
	}
	
	public void HideMessage(){
		textValue = "";
		//set timing condition to false
		check = false;
	}
}
