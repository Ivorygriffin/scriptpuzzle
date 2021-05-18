﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Teleporter : MonoBehaviour {

	public GameObject teleportOutLocation;
	public GameObject teleportEntrance;
	public GameObject player;
	public Material colour;

	// Use this for initialization
	void Start ()
	{
	
		//Check if Teleport out location has been set.
		if (teleportOutLocation == null) {
			Debug.LogWarning("No Teleporter Out Location has been set for " + transform.name + ", Please set it and restart");
		}

		//Checks to see if you have set the collider on this object to a trigger 
		if (!GetComponent<Collider> ().isTrigger){
			Debug.LogWarning("Collider on " + transform.name + " is not set to \"Is Trigger\", please update and restart");
		}
		
	}


	// This function is called then any collider touches the collider on this object.
	void OnTriggerEnter(Collider collidedObject)
	{
		Debug.Log(player.GetComponent<Renderer>().material.name);
		Debug.Log(colour.name);
		//Teleport GameObject that was collided with to the teleportOutLocation


		if (collidedObject.gameObject.tag == "Player")
		{
			
		}
		if (player.GetComponent<Renderer>().material.name == colour.name + " (Instance)")
		{
			collidedObject.transform.position = teleportOutLocation.transform.position;
		}

	}

	//This section Draws a line from the teleporter in to the teleporter out within the editor
	void OnDrawGizmos()
	{
		Gizmos.DrawLine(transform.position,teleportOutLocation.transform.position);
	}
}
