using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InProgress : MonoBehaviour
{
	
	//player to observe
	public Transform player;
	//has the shrine been completed?
	bool isCompleted;
	//is the stuff already reset? don't want to do it continuously
	bool isReset;
	
	public float doorMinX;
	public float doorMaxX;
	public float doorStop;
	
  
	//all the child objects
	Transform[] children;
  
  
	void Start(){
		children = GetComponentsInChildren<Transform>();
	}
	
    // Update is called once per frame
    void Update()
    {
		//the sgrine hasn't been solved, so reset if the player leaves the area
		if(!isCompleted){
			//if player is between doorway on the X plane
			if(player.position.x > doorMinX && player.position.x < doorMaxX){
				//if player passes door to the west, out
				if(player.position.z > doorStop && !isReset){
					//call reset script
					ResetStuff();
					isReset = true;
				}
				//if player passes door to the east, coming back in
				else if(player.position.z < -81 && isReset){
					//start working on trial again
					isReset = false;
				}
			}
		}
		
        
    }
	//acess every component in the trial that is interactable
	void ResetStuff(){
		
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
	
	public void SetIsCompleted(){
		this.isCompleted = true;
	}
}
