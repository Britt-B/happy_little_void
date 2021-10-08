using UnityEngine;

public class ItemPickup : Interactable{
	//scriptable access
	public Item item;
	//override the interact method
	public override void Interact(){
		
		base.Interact();
		
		//add to inventory
		Inventory.instance.Add(item);
		//remove object from invironment
		Destroy(gameObject);
		}
}
