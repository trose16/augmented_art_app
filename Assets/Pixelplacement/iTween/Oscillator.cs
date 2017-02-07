using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

	public float timeCounter = 0;

	public float speed;
	public float width;
	public float height;

	// Use this for initialization
	void Start () {

		speed = 2;
		width = width;
		height = height;
		
	}
	
	// Update is called once per frame
	void Update () {

		timeCounter += Time.deltaTime*speed;

		float x = Mathf.Cos (timeCounter)*width;
		float y = Mathf.Sin (timeCounter)*height;
		float z = 1;

		transform.position = new Vector3 (x, y, z);


		
	}
}
