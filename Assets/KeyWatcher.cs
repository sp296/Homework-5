using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWatcher : MonoBehaviour {
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;

	float accumulatedTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		accumulatedTime += Time.deltaTime;

		if (Input.GetKeyDown("up")) {
			Debug.Log ("User pressed up.");
			CameraController ct = GetComponent<CameraController> ();
			ct.target = target1;
			ct.enabled = true; 
		}
		if (Input.GetKeyDown("left")) {
			Debug.Log ("User pressed left.");
			CameraController ct = GetComponent<CameraController> ();
			ct.target = target2;
			ct.enabled = true; 
		}
		if (Input.GetKeyDown("right")) {
			Debug.Log ("User pressed right.");
			CameraController ct = GetComponent<CameraController> ();
			ct.target = target3;
			ct.enabled = true; 
		}
	}
}
