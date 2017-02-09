using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeAnimation : MonoBehaviour {

	public float ShakeByX = 2;
	public float ShakeByY = 1;
	public float ShakeByZ = 3;
	public float delay = 1;
	public float time = 0;
	public string easeType = "easeInOutExpo";
	public string loopType = "pingPong";
	public bool includechildren = true;

	// Use this for initialization
	void Start () {


		iTween.ShakeScale (gameObject, iTween.Hash ("x", ShakeByX, "y", ShakeByY, "z", ShakeByZ, "delay", delay, "time", time, "includechildren", includechildren, "easeType", easeType, "loopType", loopType));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
