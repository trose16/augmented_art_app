using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByAnimation : MonoBehaviour {

	public float MoveByX = 2;
	public float MoveByY = 1;
	public float MoveByZ = 3;
	public float delay = 1;
	public string easeType = "easeInOutExpo";
	public string loopType = "pingPong";
	public bool includechildren = true;


	void Start () {

		iTween.MoveBy(gameObject, iTween.Hash("x", MoveByX, "y", MoveByY, "z", MoveByZ, "easeType", easeType, "loopType", loopType, "delay", delay, "includechildren", includechildren));
	}

}