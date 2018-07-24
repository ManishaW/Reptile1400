using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectOnMouse : MonoBehaviour
{

	Vector3 target;
	Vector3 start;
	Vector3 pos;
	bool flag = false;

	// Use this for initialization
	void Start ()
	{
		

		start = transform.position;
		pos = transform.position;
	
	}

	// Update is called once per frame
	void Update ()
	{
		if (flag) {
			pos = Input.mousePosition;
			pos.z = 45;
			pos = Camera.main.ScreenToWorldPoint (pos);
			transform.position = pos;
		}

	}

	void OnMouseDown(){
		Vector3 scale;
		Debug.Log ("clicked walkie talkie");
		if (flag) {
			flag = false;
			scale = transform.localScale /1.25f;
			transform.localScale = scale;
		} else {
			flag = true;
	
			scale = transform.localScale *1.25f;
			transform.localScale = scale;
		}
	}
}