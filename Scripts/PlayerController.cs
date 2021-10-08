using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 12f;
	private const float gravity = -9.8f;
	float y = 0f;
	public Camera cam;
	
	//the current focus of interactable items
	public Interactable focus;
	
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
		y = gravity;
		
		//moves locally based on player direction
		Vector3 move = (transform.right * x) + (transform.up * y) + (transform.forward * z);
		//execute the movement
		controller.Move(move * speed * Time.deltaTime);
		
		//handle player interaction
		if (Input.GetKeyDown(KeyCode.LeftShift)){
			//create ray towards mouse direction
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			//if the ray hits an object that is interactable
			if(Physics.Raycast(ray, out hit, 100)){
				Interactable interactable = hit.collider.GetComponent<Interactable>();
				if(interactable!=null)
					SetFocus(interactable);
			}
		}
    }
	
	//called when mouse ray cast hits interactable object
	void SetFocus(Interactable newFocus){
		//if the focus is different than the previous focus we set the new focus 
		//(after ensuring a null object is removed from focus)
		if(newFocus != focus){
			if(focus != null){
				focus.OnDefocused();
			}
			focus = newFocus;
		}
		//set the new interactable as the focus
		newFocus.OnFocused(transform);
	}
	//called when we are done focusing on that object
	void RemoveFocus(){
		//first stop the focus
		if(focus != null){
			focus.OnDefocused();
		}
		//now set to null, as nothinng should be a focus to the player at the moment
		focus = null;
	}
}
