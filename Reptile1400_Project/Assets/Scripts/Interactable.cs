using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void characterLines(string hitName){

		if(hitName.Equals("tweety")){
			Debug.Log ("TWEETY TALKING");
		}else if(hitName.Equals("stitch")){
			Debug.Log ("I HIT STITCH");
		}
	}
}
