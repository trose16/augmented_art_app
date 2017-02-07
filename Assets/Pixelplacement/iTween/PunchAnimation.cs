using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchAnimation : MonoBehaviour {

	public float PunchByX = 2;
	public float PunchByY = 1;
	public float PunchByZ = 3;
	public float delay = 1;
	public float time = 1;
	public string loopType = "pingPong";
	public bool includechildren = true;


	// Use this for initialization
	void Start () {

		iTween.PunchRotation(gameObject, iTween.Hash("x", PunchByX, "y", PunchByY, "z", PunchByZ, "delay", delay, "time", time, "looptype", loopType, "includechildren", includechildren));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
