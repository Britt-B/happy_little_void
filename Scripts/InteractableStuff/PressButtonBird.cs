using UnityEngine;

public class PressButtonBird : Interactable
{
	//showing message to this camera
	public Camera cam;
	//the gate to the shrine
	public GameObject gate;
	//to get number of options currently lit
	public GameObject ops;
	
	public override void Interact(){
		base.Interact();
		//if all torches are lit, open gate
		if(ops.GetComponent<BirdOptionsLit>().GetOptionsLit() == 15)
			gate.GetComponent<OpenGate>().Open();
		else
			cam.GetComponent<ShowText>().ShowMessage("Light all the torches.", 5.0f);
	}
}
