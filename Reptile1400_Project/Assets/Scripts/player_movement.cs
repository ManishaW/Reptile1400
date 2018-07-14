using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
	

	Vector3 destinationPosition;
 	RaycastHit hitInfo = new RaycastHit();
    bool hit;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Mouse0)){  

		    hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			
			 if (hit) {
				if (hitInfo.transform.gameObject.tag == "Interactable"){
					Debug.Log ("DO SOMETHING!");
				}
			}
 			else{
				 destinationPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			 }
		}

		transform.position = Vector2.MoveTowards(transform.position, destinationPosition, Time.deltaTime * 5);
	      

	}
}
