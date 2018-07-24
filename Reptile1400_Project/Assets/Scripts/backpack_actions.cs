using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpack_actions : MonoBehaviour {

	public bool backpack_open = false;


	// Use this for initialization
	void Start () {
		Debug.Log ("hii");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		if (backpack_open) {
			Debug.Log ("bye");
			GetComponent<Animation> ().Play ("down_backpack");
			backpack_open = false;

		} else {
			Debug.Log ("hi");
			GetComponent<Animation>().Play("up_backpack");
			backpack_open = true;

		}

	}
}
