using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickBarPlacer : MonoBehaviour {

    public float distance = 5.0f;
    public float angle = 45.0f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Vector3 cameraFordwardWithoutX = Camera.main.transform.forward;

        transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance;// * (distance * (float)Math.Cos((angle) * Mathf.Deg2Rad));
        //transform.rotation = new Quaternion(0.0f, Camera.main.transform.rotation.y, 0.0f, Camera.main.transform.rotation.w);
        /*Vector3 newPosition = Camera.main.transform.position;
        newPosition.y += Camera.main.transform.forward.y * distance * (float)Math.Cos(angle);
        newPosition.x += Camera.main.transform.forward.x * distance * (float)Math.Sin(angle);
        transform.position = newPosition;*/
    }

    void OnDrawGizmos()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 500.0f, Color.red, 0);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Camera.main.transform.position, transform.position);
    }
}
