using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdOptionsLit : MonoBehaviour
{
    int numLit = 0;
	
	public void AddOption(){
		numLit++;
	}
	public void SubOption(){
		numLit--;
	}
	
	public int GetOptionsLit(){
		return numLit;
	}
}
