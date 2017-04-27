using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    bool mouseClick;
    public Transform centralObject;
    public float cameraRotateSpeed = 5.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseClick = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseClick = false;
        }

        if (mouseClick)
        {
            transform.RotateAround(centralObject.position, centralObject.up, Input.GetAxis("Mouse X") * cameraRotateSpeed);
            transform.RotateAround(centralObject.position, centralObject.right, Input.GetAxis("Mouse Y") * cameraRotateSpeed);
        }
    }
}
