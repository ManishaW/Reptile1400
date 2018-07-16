using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpack_actions : MonoBehaviour {

	public bool backpack_open = false;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		if (backpack_open) {
			Debug.Log ("bye");
			GetComponent<Animation> ().Play ("backpack_slider_down");
			backpack_open = false;

		} else {
			Debug.Log ("hi");
			GetComponent<Animation>().Play("backpack_slider_up");
			backpack_open = true;

		}

	}
}
