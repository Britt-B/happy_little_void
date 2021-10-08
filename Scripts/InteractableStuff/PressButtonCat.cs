using UnityEngine;

public class PressButtonCat : Interactable
{
	//showing message to this camera
	public Camera cam;
	//the final torch in the trial
	public GameObject lastOption;
	//the gate to the shrine
	public GameObject gate;
	
	public override void Interact(){
		base.Interact();
		if(lastOption.GetComponent<CatOptionsChain>().isLit)
			gate.GetComponent<OpenGate>().Open();
		else
			cam.GetComponent<ShowText>().ShowMessage("Light all the torches, in order.", 5.0f);
	}
}
