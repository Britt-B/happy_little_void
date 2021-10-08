using UnityEngine;

public class PressButtonDog : Interactable{
	
	//associated options - left to right
	public GameObject l;
	public GameObject r;
	
	//the gate to open
	public GameObject leftGate;	
	public GameObject rightGate;	
	
	
	//showing message to this camera
	public Camera cam;
	
	//is this button the last one?
	public bool isFinal;
	
	public override void Interact(){
		base.Interact();
		//the left gate option
		bool left = l.GetComponent<Options>().isLit;
		//the final gate
		if(isFinal){
			if(left)
				leftGate.GetComponent<OpenGate>().Open();
			else
				cam.GetComponent<ShowText>().ShowMessage("There should be something else here.", 5.0f);
		}
		
		else{
			//there is another gate (right) if not final passage
			bool right = r.GetComponent<Options>().isLit;
			
			//check which gate is lit
			if(left && !right){
				//open left
				leftGate.GetComponent<OpenGate>().Open();
				//close right
				rightGate.GetComponent<OpenGate>().Reset();
			}
			else if(right && !left){
				//open right
				rightGate.GetComponent<OpenGate>().Open();
				//close left
				leftGate.GetComponent<OpenGate>().Reset();
			}
			
			//if not, display suggestion message
			else
				cam.GetComponent<ShowText>().ShowMessage("Left or right? Only 1 choice...", 5.0f);
		}
	}
}
