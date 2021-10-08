using UnityEngine;

public class Interactable : MonoBehaviour
{
	//how close player should be to interact with an object
    public float radius = 6f;
	//this interactable
	public Transform interactionTransform;
	//true if this item is the player's focus
	bool isFocus = false;
	//need to check if interaction happened so it doesn't loop on update
	bool hasInteracted = false;
	//Player object that is interacting
	protected Transform player;
	
	//functionality for each interactable implemented in class
	public virtual void Interact(){
		//override
	}
	public virtual void Reset(){
		//this resets objects when shrine is left too early
	}
	public virtual void Finish(){
		//this sets objects ro finished states
	}
	
	void Update(){
		//There is an object in focus and it is newly selected
		if(isFocus && !hasInteracted){
			//find the distance between the player and the object in focus
			float distance = Vector3.Distance(player.position, interactionTransform.position);
			//the player is within interaction radius of the object
			if(distance <= radius){
				Interact();
				
				hasInteracted = true;
			}
		}
	}
	
	//player focuses on an item
	public void OnFocused(Transform playerTransform){
		isFocus = true;
		player = playerTransform;
		//new object, reset interaction
		hasInteracted = false;
	}
	//player no longer focusing on item
	public void OnDefocused(){
		isFocus = false;
		player = null;
		//leaving object, reset interaction
		hasInteracted = false;
	}
	
	//callback to unity
	void OnDrawGizmosSelected(){
		
		//keep the null interactable set to current transform
		if(interactionTransform == null)
			interactionTransform = transform;
		
		Gizmos.color = Color.grey;
		Gizmos.DrawWireSphere(interactionTransform.position, radius);
	}
}
