using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuicBarPlacer : MonoBehaviour {

    public float distance = 5.0f;
    public float angle = 45.0f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 cameraFordwardWithoutX = Camera.main.transform.forward;

        transform.position = Camera.main.transform.position + cameraFordwardWithoutX *distance;// * (distance * (float)Math.Cos((angle) * Mathf.Deg2Rad));
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Camera.main.transform.position, transform.position);
        
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 500.0f, Color.red, 0);
    }
}
