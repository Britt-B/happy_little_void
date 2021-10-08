using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
	//has the shrine been completed?
	bool isCompleted;
	//is the stuff already reset? don't want to do it continuously
	bool isReset;
	
	//all the child objects
	Transform[] children;
	
	void Start(){
		children = GetComponentsInChildren<Transform>();
	}
	
	//acess every component in the trial that is interactable
	public void ResetStuff(){
		//if it is completed, don't worry about resetting. All will be open/blue
		if(!isCompleted){
			foreach(Transform child in children){
				//find first level categories, then call associated scripts
		
				if(child.parent.name == "Panels")
					//reset panels
					child.GetComponent<PanelRead>().Reset();
					
				else if(child.parent.name == "Options")
					//reset options
					child.GetComponent<Options>().Reset();
					
				else if(child.parent.name == "Gates")
					//reset gates
					child.GetComponent<OpenGate>().Reset();
			}
		}
	}
	
	public void SetIsCompleted(){
		this.isCompleted = true;
	}
	public bool GetIsCompleted(){
		return isCompleted;
	}
	

}