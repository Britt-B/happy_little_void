using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
	bool moveUp = true;
    // Update is called once per frame
    void Update()
    {
		//move up/down
		if(moveUp){
			transform.Translate(Vector3.up * Time.deltaTime * .8f, Space.World);
			if(transform.position.y > 8)
				moveUp = false;
		}
			
		else{
			transform.Translate(Vector3.down * Time.deltaTime * .8f, Space.World);
			if(transform.position.y < 5)
				moveUp = true;
		}
		//rotate
		transform.RotateAround(transform.position, Vector3.up, 25f * Time.deltaTime);   
    }
}
