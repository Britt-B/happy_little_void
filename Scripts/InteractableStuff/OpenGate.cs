using UnityEngine;

public class OpenGate : Interactable{
	
	//if main gate, keys unlock, if not puzzles do
	public bool isMain;
	//check is gate is open
	bool isOpen = false;
	//showing message to this camera
	public Camera cam;
	
	//mesh color
	MeshFilter thisMesh;
	public Mesh blueMesh;
	public Mesh redMesh;
	
	//box collider to manage passage
	Collider bCollider;
	
	void Start(){
		//assign mesh and xollider components
		thisMesh = GetComponent<MeshFilter>();
		bCollider = GetComponent<Collider>();
	}
	
	//override the interact method
	public override void Interact(){
		base.Interact();
		//the main gate needs a key in inventory
		if(isMain){
			//make sure there is something in the inventory (only items for now are keys)
			if(!isOpen){
				if(Inventory.instance.items.Count > 0){
					Open();
					isOpen = true;
				}
				else{
				//display message; key is needed
				cam.GetComponent<ShowText>().ShowMessage("It appears something is needed here...", 5.0f);
				}
			}
		}
	}
	
	public override void Reset(){
		//close passage (except main door because key was already used)
		if(!isMain){
			bCollider.enabled = true;
			//mesh color will be red
			thisMesh.sharedMesh = redMesh;
			//reset open status to closed
			isOpen = false;
		}
	}
	public override void Finish(){
		//everything is open and blue when trial is finished
		if(!isMain){
			//no collider
			bCollider.enabled = false;
			//mesh color will be blue
			thisMesh.sharedMesh = blueMesh;
			//reset open status
			isOpen = true;
		}
	}
	
	public void Open(){
		//remove 1 key from inventory if main gate
		if(isMain)
			Inventory.instance.Remove(Inventory.instance.items[0]);
		//change to blue
		thisMesh.sharedMesh = blueMesh;
		//allow passage
		bCollider.enabled = false;
	}
}
