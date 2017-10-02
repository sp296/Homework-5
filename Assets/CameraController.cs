using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;

	float accumulatedTime = 0.0f;

	Vector3 startPos;
	Vector3 endPos;

	Quaternion startQuat;
	Quaternion endQuat;


	void onEnable() {
		startPos = this.transform.position;
		endPos = target.transform.position;
			
		startQuat = this.transform.rotation;
		endQuat = target.transform.rotation;

		accumulatedTime = 0.0f;

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		accumulatedTime = Time.deltaTime;
		float percentComplete = accumulatedTime / 3.0f; //go from 0.0 to 1.0
		float ClampedValue = Mathf.Clamp (percentComplete, 0.0f, 1.0f);
		this.transform.position = Vector3.Lerp (startPos, endPos, ClampedValue);
		this.transform.rotation = Quaternion.Slerp (startQuat, endQuat, ClampedValue);
	}
}
