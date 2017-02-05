using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour 
{

	public Transform target; 

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 targetPosition = transform.position; 
		targetPosition.x = target.position.x;

		transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime ); 

		//transform.position = new Vector3 (target.position.x, transform.position.y, transform.position.z); 
	}
}
	