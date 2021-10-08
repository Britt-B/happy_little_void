using UnityEngine;

public class Options : Interactable
{
	//is this torch selected?
	public bool isLit = false;
	//is the shrine complete?
	bool complete;
	
	//mesh color
	MeshFilter thisMesh;
	public Mesh blueMesh;
	public Mesh redMesh;
	
	void Start(){
		//assign mesh change
		thisMesh = GetComponent<MeshFilter>();
	}
	
	//override the interact method
	public override void Interact(){
		base.Interact();
		
		if(!isLit){
			//now its lit
			isLit = true;
			//change to blue
			thisMesh.sharedMesh = blueMesh;
		}
		//if not complete you can reset the light
		else if(complete == false){
			//now its not lit
			isLit = false;
			//change to red
			thisMesh.sharedMesh = redMesh;
		}
	}
	
	public override void Reset(){
		//reset the lit status to unlit
		isLit = false;
		//reset the mesh to red
		thisMesh.sharedMesh = redMesh;
	}
	
	public override void Finish(){
		//everything is lit
		isLit = true;
		//reset the mesh to red
		thisMesh.sharedMesh = blueMesh;
		//shrine is complete: disable turn off
		complete = true;
	}
}
