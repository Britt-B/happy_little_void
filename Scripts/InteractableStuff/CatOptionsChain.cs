using UnityEngine;

public class CatOptionsChain : Options
{
	//the first one is lit got free
	public bool isFirst;
	
	//the previous option
	public GameObject previous;
	
	//showing message to this camera
	public Camera cam;
	
	
	//override the interact method
	public override void Interact(){
		//the cat trial needs to track the previous torch
		if(isFirst || (!isFirst && previous.GetComponent<Options>().isLit))
			//go ahead and light this one
			base.Interact();
		else
			//need to light previous, tell player
			cam.GetComponent<ShowText>().ShowMessage("The previous one must be lit first", 3.0f);
	}
}
