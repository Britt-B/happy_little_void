using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftVeil : MonoBehaviour
{
	//the cover in front of the shrine
	public GameObject veil;
	
	//the parent object containing all the trial pieces
	public GameObject trialComplete;
	//all the child objects
	Transform[] children;
	
	//the glame at the fountain to light
	public GameObject flame;
  
	void Start(){
		children = trialComplete.GetComponentsInChildren<Transform>();
	}
	
    public void Lift(){
		//fade veil
		
		//destroy plane game object
		Destroy(veil);
		
		//mark trial as complete so it doesn't reset on exit
		trialComplete.GetComponent<Reset>().SetIsCompleted();
		
		//set all objects to finish state
		FinishStuff();
		
		//flame on main fountain is lit
		flame.GetComponent<SpriteRenderer>().color = new Color(48f,193f,255f,1f);
	}
	
		//acess every component in the trial that is interactable
	public void FinishStuff(){
		
		foreach(Transform child in children){
			//find first level categories, then call associated scripts
	
			if(child.parent.name == "Panels")
				//reset panels
				child.GetComponent<PanelRead>().Finish();
				
			else if(child.parent.name == "Options")
				//reset options
				child.GetComponent<Options>().Finish();
				
			else if(child.parent.name == "Gates")
				//reset gates
				child.GetComponent<OpenGate>().Finish();
		}
	}
}
