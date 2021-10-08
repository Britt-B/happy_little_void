using UnityEngine;

public class TeleportToSpawn : Interactable
{
	Vector3 spawn;
	CharacterController pc;
	
	void Start(){
		spawn = new Vector3(-31.1f, 6.25f, 1.5f);
	}
	
   //teleports player to fountain
   public override void Interact(){
	    //base interaction
		base.Interact();
		pc = player.GetComponent<CharacterController>();
		//disable char controller to teleport
		pc.enabled = false;
		//move player to beginning
		player.transform.localPosition = spawn;
		//enable char controller
		pc.enabled = true;
	}
}
