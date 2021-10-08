using UnityEngine;

public class BirdOptions : Options
{
	//to add number of options currently lit
	public GameObject ops;
	
	//override the interact method
	public override void Interact(){
		//use base to set isLit status first
		base.Interact();
		
		//the bird trial needs to track the number lit
		if(isLit)
			ops.GetComponent<BirdOptionsLit>().AddOption();
		else
			ops.GetComponent<BirdOptionsLit>().SubOption();
	}
}
