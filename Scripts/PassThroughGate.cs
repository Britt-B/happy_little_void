using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughGate : MonoBehaviour
{
	
	//if the player is inside area, true
	private bool hasPassed;
	//the trial to reset
	[SerializeField]
	public GameObject trial;
	
	
    private void OnTriggerEnter(Collider other){
		//track status in/out
		hasPassed = !hasPassed;
		//if it switched to false, player left. Reset area
		if(!hasPassed)
			trial.GetComponent<Reset>().ResetStuff();
    }
}
