using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToAnimation : MonoBehaviour {

	public float alpha = 0;
	public float time = 3;
	public string easeType = "easeInSine";
	public bool includechildren = true;

	// Use this for initialization
	void Start () {

		iTween.FadeTo(gameObject, iTween.Hash("alpha", alpha, "time", time, "easeType", easeType, "includechildren", includechildren));

	}

	// Update is called once per frame
	void Update () {

	}
}
