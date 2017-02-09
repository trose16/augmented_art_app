using System.Collections.Generic;
using UnityEngine;

public class ReverseOscillator : MonoBehaviour {

	public float timeCounter = 0;
	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float speed;
	public float width = 0;
	public float height = 0;

	// Use this for initialization
	void Start () {

		speed = 2;
		width = width;
		height = height;

	}

	// Update is called once per frame
	void Update () {

		timeCounter += Time.deltaTime*speed;

		y = Mathf.Sin (timeCounter)*width;
		x = Mathf.Cos (timeCounter)*height;

		transform.position = new Vector3 (x, y, z);		
	}
}

