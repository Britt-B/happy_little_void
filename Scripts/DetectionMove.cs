using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionMove : MonoBehaviour
{
	//the player that enters the field
	public GameObject player;
	
	//the number assigned to this sensor
	public int number;
	
	//in case of fail, reset trial
	public GameObject reset;
	
	//speed of movement
	float speed = 4f;
	//speed of rotation
	float rotateSpeed = 40f;
	
	//move texture speed
	float scrollSpeed = 0.5f;
	//the sensor's renderer
    Renderer rend;
	
	Vector3 spawn;
	
	void Start(){
		//load the renderer for texture mvmt
        rend = GetComponent<Renderer>();
		//set respawn for level
		spawn = new Vector3(-4.92f, 6.25f, -91f);
    }
	
	void Update(){
		//each sensor is coded by move type
		switch(number){
			case 1:
				//move the sensor back and forth
				transform.Translate(0, 0, speed * Time.deltaTime);
				break;
			
			case 2:
				//this one rotates in an arc
				transform.Translate(0, 0, speed * Time.deltaTime);
				transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
				break;
			case 3:
				//this one spins in a circle
				transform.Translate(0, 0, speed *0.5f * Time.deltaTime);
				transform.RotateAround(transform.position, Vector3.up, (rotateSpeed-10) * Time.deltaTime);
				break;
			case 4:
				//double speed case 1
				transform.Translate(0, 0, speed * 2 * Time.deltaTime);
				break;
			case 5:
				//double speed case 2
				transform.Translate(0, 0, speed * 2 * Time.deltaTime);
				transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
				break;
			default:
				//no movement
			break;
			
		}
		//animate texture
		float offset = Time.time * -scrollSpeed;
        rend.material.SetTextureOffset("_BaseMap", new Vector2(0,offset));
	}
	
	//collided with object
	 private void OnTriggerEnter(Collider other)
    {
		//the player was caught
		if(other == player.GetComponent<CharacterController>()){
			//if trial is not completed
			if(!reset.GetComponent<Reset>().GetIsCompleted()){
				//restet the torches etc
				reset.GetComponent<Reset>().ResetStuff();
				//disable char controller to teleport
				other.enabled = false;
				//move player to beginning
				player.transform.localPosition = spawn;
				//enable char controller
				other.enabled = true;
			}
		}
		else{
			//hit a wall, reverse speed to move in other direction
			speed = -speed;
			rotateSpeed = - rotateSpeed;
		}
    }
}
