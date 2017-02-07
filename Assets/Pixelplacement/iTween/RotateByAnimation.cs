using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByAnimation : MonoBehaviour {

	public float RotateByX = 2;
	public float RotateByY = 2;
	public float RotateByZ = 2;
	public string easeType = "easeInOutBack";
	public string loopType = "pingPong";
	public float delay = 4;
	public float time = 1;
	public bool includechildren = true;


	void Start () {

		iTween.RotateBy(gameObject, iTween.Hash("x", RotateByX, "y", RotateByY, "z", RotateByZ, "easeType", easeType, "loopType", loopType, "delay", delay, "time", time, "includechildren", includechildren));

	}


}
