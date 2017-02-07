using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeFromAnimation : MonoBehaviour {

	public float alpha = 0;
	public float time = 3;
	public string easeType = "easeInSine";
	public float delay = 3;
	public string loopType = "pingPong";
	public bool includechildren = true;

	// Use this for initialization
	void Start () {

		iTween.FadeFrom(gameObject, iTween.Hash("alpha", alpha, "time", time, "delay", delay, "loopType", loopType, "easeType", easeType, "includechildren", includechildren));

	}

	// Update is called once per frame
	void Update () {

	}
}
