using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour{
	
	#region Singleton
	//only one inventory is made in the game
	public static Inventory instance;
	void Awake(){
		//if another inventory was made something went wrong
		if(instance != null){
			Debug.LogWarning("More than one instance of inventory has been created");
		return;
		}
		instance = this;
	}
	#endregion
	
	//gor inventory menu altering
	public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;
	
	//list to hold inventory items
	public List<Item> items = new List<Item>();
	
	//add item to inventory list
	public void Add(Item item){
		//default items do not get picked up
		if(!item.isDefault){
			items.Add(item);
			if(onItemChangedCallback != null)
				//update inventory GUI
				onItemChangedCallback.Invoke();
		}
	}
	//remove from inventory list
	public void Remove(Item item){
		items.Remove(item);
	}
}
