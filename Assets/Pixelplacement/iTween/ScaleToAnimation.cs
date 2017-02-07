using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleToAnimation : MonoBehaviour {

	public float ScaleToX = 2;
	public float ScaleToY = 1;
	public float ScaleToZ = 3;
	public float delay = 1;
	public float time = 2;
	public float speed = 2;
	public string easeType = "easeInOutExpo";
	public string loopType = "pingPong";
	public bool includechildren = true;

	// Use this for initialization
	void Start () {

		iTween.ScaleTo(gameObject, iTween.Hash("x", ScaleToX, "y", ScaleToY, "z", ScaleToZ, "easeType", easeType, "loopType", loopType, "delay", delay, "includechildren", includechildren, "time", time, "speed", speed));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
