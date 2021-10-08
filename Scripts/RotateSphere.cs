using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    // Update is called once per frame
	Vector3 moveSphere;
	void Start(){
		//setting mvmt to 30 in x direction
		moveSphere = new Vector3(0,0,10);
	}
	
    void Update()
    {
        transform.Rotate(moveSphere * Time.deltaTime);
    }
}
