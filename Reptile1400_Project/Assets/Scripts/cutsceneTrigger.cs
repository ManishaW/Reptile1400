using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneTrigger : MonoBehaviour {

	public GameObject cutsceneObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void trigger_cutscene(){

		cutsceneObject.SetActive(true);
	}
}
