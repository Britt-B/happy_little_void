using UnityEngine;

public class PanelRead : Interactable{
	
	//showing message to this camera
	public Camera cam;
	//message to display
	public string message;
	//the gate to open
	public GameObject nextGate;
	
	//see if interaction is first in area visit
	bool isRead = false;
	//the entarance panel
	public bool isMain;
	//the final panel
	public bool isFinal;
	
    //override the interact method
	public override void Interact(){
		//for instruction panels, show the associated dialogue
		base.Interact();
		cam.GetComponent<ShowText>().ShowMessage(message, 5.0f);
		if(!isRead){
			isRead = true;
			//open gate 1 if main
			if(isMain && nextGate != null)
				nextGate.GetComponent<OpenGate>().Open();
			if(isFinal){
				GetComponent<LiftVeil>().Lift();
			}
		}	
	}
	
	public override void Reset(){
		//reset read status to false
		isRead = false;
	}
	public override void Finish(){
		//read is true so objects (gates and veils) aren't accessed anymore
		isRead = true;
	}
}
