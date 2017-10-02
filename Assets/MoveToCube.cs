using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCube : MonoBehaviour {
	float elapsedTime=0.0f;
	Vector3 startPos=new Vector3(0,0,0);
	Vector3 initialPos = new Vector3 (0, 0, 0);
	Vector3 endPos =new Vector3(300,10,20);
	string tester1 = "none";
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("b")) {
			tester1 = "b";
		}
		if (tester1 == "b") {
			elapsedTime += Time.deltaTime;
			float percentComplete = elapsedTime / 3.0f; //go from 0.0 to 1.0
			transform.position = Vector3.Lerp (startPos, endPos, percentComplete);
			transform.rotation = Quaternion.Euler (10.0f, 30.0f, 0.0f);
		}
	}
}
