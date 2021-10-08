using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	//how quickly to turn
	public float mouseSensitivity = 100f;
	//what to change
	public Transform playerBody;
	//x rotation
	float xRotation = 0f;
	
    // Start is called before the first frame update
    void Start()
    {
        //hide cursor in center of screen and keep inside window
		Cursor.lockState = CursorLockMode.Locked;;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		
		//calculate change in rotation
		xRotation -= mouseY;
		//keeps player from rotating too far
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);
		
		//allows clamp step; basically Rotate()
		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		//moves on y axis
		playerBody.Rotate(Vector3.up * mouseX);
    }
}
